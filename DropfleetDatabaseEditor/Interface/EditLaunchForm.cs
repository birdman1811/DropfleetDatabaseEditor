using DropfleetDatabaseEditor.Datastore;
using DropfleetDatabaseEditor.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropfleetDatabaseEditor.Interface
{
    public partial class EditLaunchForm : Form
    {
        WeaponController weaponControl = new WeaponController();
        ShipController shipControl = new ShipController();
        LaunchAssetsController assetControl = new LaunchAssetsController();
        List<LaunchAsset> assetList = new List<LaunchAsset>();
        List<WeaponRule> rulesList = new List<WeaponRule>();
        Ship editShip;
        LaunchAsset newAsset = new LaunchAsset();

        public EditLaunchForm(Ship ship)
        {
            InitializeComponent();
            editShip = ship;
            assetList = assetControl.GetAllLaunchAssets();
            rulesList = weaponControl.GetWeaponRules();
            editShip.LaunchAssets = shipControl.GetShipsLaunchAssets(editShip.ShipID);
            rulesCombo.DataSource = rulesList;
            rulesCombo.DisplayMember = "rule";
            assetsCombo.DataSource = assetList;
            assetsCombo.DisplayMember = "asset";
            assetListBox.DataSource = editShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
            rulesListBox.DataSource = newAsset.Rules;
            rulesListBox.DisplayMember = "fullString";
        }

        private void AddRule_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance newRule = new WeaponRuleInstance();
            WeaponRule rule = (WeaponRule)rulesCombo.SelectedItem;
            newRule.RuleID = rule.RuleID;
            newRule.Rule = rule.Rule;
            newRule.Amount = (int)rulesQuantitySelect.Value;
            newAsset.AddRuleInstance(newRule);
            rulesQuantitySelect.Value = 0;
            rulesListBox.DataSource = null;
            rulesListBox.DataSource = newAsset.Rules;
            rulesListBox.DisplayMember = "fullString";
        }

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            newAsset = (LaunchAsset)assetsCombo.SelectedItem;
            newAsset.Amount = (int)quantitySelect.Value;
            editShip.AddAsset(newAsset);
            assetListBox.DataSource = null;
            assetListBox.DataSource = editShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
            assetControl.InsertLaunchAssetInstance(newAsset, editShip.ShipID);
            foreach (WeaponRuleInstance r in newAsset.Rules)
            {
                assetControl.InsertAssetSpecialRuleInstance(newAsset, r, editShip.ShipID);
            }
        }

        private void RemoveAssetButton_Click(object sender, EventArgs e)
        {
            LaunchAsset deleteAsset = (LaunchAsset)assetListBox.SelectedItem;
            editShip.DeleteAsset(deleteAsset);
            assetListBox.DataSource = null;
            assetListBox.DataSource = editShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
            assetControl.DeleteLaunchAssetInstance(deleteAsset, editShip.ShipID);
            foreach (WeaponRuleInstance r in deleteAsset.Rules)
            {
                assetControl.DeleteAssetSpecialRuleInstance(deleteAsset, r, editShip.ShipID);
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            EditShipForm newScreen = new EditShipForm();
            newScreen.Show();
            Close();
        }
    }
}
