using DropfleetDatabaseEditor.Controllers;
using DropfleetDatabaseEditor.Datastore;
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
    public partial class AddLaunchForm : Form
    {
        WeaponController weaponControl = new WeaponController();
        ShipController shipControl = new ShipController();
        LaunchAssetsController launchController = new LaunchAssetsController();
        Ship launchShip;
        List<LaunchAsset> launchAssets = new List<LaunchAsset>();
        List<WeaponRuleInstance> weaponRules = new List<WeaponRuleInstance>();
        LaunchAsset newAsset = new LaunchAsset();
        


        public AddLaunchForm(Ship newShip)
        {
            InitializeComponent();
            shipNameLabel.Text = "Add Launch Assets to " + newShip.Name;
            launchShip = newShip;
            launchAssets = launchController.GetAllLaunchAssets();
            List<WeaponRule> weaponRulesa = weaponControl.GetWeaponRules();
            assetsCombo.DataSource = launchAssets;
            assetsCombo.DisplayMember = "asset";
            rulesCombo.DataSource = weaponRulesa;
            rulesCombo.DisplayMember = "rule";
            assetListBox.DataSource = launchShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
            rulesListBox.DataSource = newAsset.Rules;
            rulesListBox.DisplayMember = "fullString";
        }

        private void AssetsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaunchAsset selectedAsset = (LaunchAsset)assetsCombo.SelectedItem;
            newAsset.AssetID = selectedAsset.AssetID;
            newAsset.Asset = selectedAsset.Asset;
        }

        private void QuantitySelect_ValueChanged(object sender, EventArgs e)
        {
            newAsset.Amount = (int)quantitySelect.Value;
        }       

        

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            
            launchShip.LaunchAssets.Add(newAsset);
            newAsset = new LaunchAsset();            
            assetListBox.DataSource = null;
            assetListBox.DataSource = launchShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
            quantitySelect.Value = 0;
            rulesQuantitySelect.Value = 0;
            rulesListBox.DataSource = null;
            rulesListBox.DataSource = newAsset.Rules;
            rulesListBox.DisplayMember = "fullString";
        }

        private void RemoveAssetButton_Click(object sender, EventArgs e)
        {
            launchShip.LaunchAssets.Remove((LaunchAsset)assetListBox.SelectedItem);
            assetListBox.DataSource = null;
            assetListBox.DataSource = launchShip.LaunchAssets;
            assetListBox.DisplayMember = "fullString";
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            foreach (LaunchAsset asset in launchShip.LaunchAssets)
            {
                launchController.InsertLaunchAssetInstance(asset, launchShip.ShipID);
                foreach (WeaponRuleInstance rule in asset.Rules)
                {
                    launchController.InsertAssetSpecialRuleInstance(asset, rule, launchShip.ShipID);
                }
            }
            ShipBuilderForm newScreen = new ShipBuilderForm();
            newScreen.Show();
            Close();
        }

        private void AddRule_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance newRule = new WeaponRuleInstance();
            WeaponRule selectedRule = (WeaponRule)rulesCombo.SelectedItem;
            newRule.Rule = selectedRule.Rule;
            newRule.RuleID = selectedRule.RuleID;
            newRule.Amount = (int) rulesQuantitySelect.Value;
            newAsset.AddRuleInstance(newRule);
            rulesQuantitySelect.Value = 0;
            rulesListBox.DataSource = null;
            rulesListBox.DataSource = newAsset.Rules;
            rulesListBox.DisplayMember = "fullString";
        }
    }
}
