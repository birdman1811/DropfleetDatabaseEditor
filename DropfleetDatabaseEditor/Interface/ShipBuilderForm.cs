using DropfleetDatabaseEditor.Controllers;
using DropfleetDatabaseEditor.Datastore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropfleetDatabaseEditor.Interface
{
    public partial class ShipBuilderForm : Form
    {
        FactionController factionController = new FactionController();
        ShipController shipController = new ShipController();
        TonnageController tonnageController = new TonnageController();
        ShipRulesController ruleController = new ShipRulesController();

        List<Faction> factionList = new List<Faction>();
        List<Tonnage> tonnageList = new List<Tonnage>();
        List<ShipRule> shipRules = new List<ShipRule>();
        Ship newShip = new Ship();
        

        public ShipBuilderForm()
        {
            InitializeComponent();
            
            
            factionList = factionController.GetAllFactions();
            factionComboBox.DataSource = factionList;
            factionComboBox.DisplayMember = "name";
            tonnageList = tonnageController.GetAllTonnages();
            newShip.Launch = false;
            TonnageComboBox.DataSource = tonnageList;
            TonnageComboBox.DisplayMember = "tonnageName";
            shipRules = ruleController.GetAllRules();
            rulesCombo.DataSource = shipRules;
            rulesCombo.DisplayMember = "rule";
            ShipSpecialRulesBox.DataSource = newShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
        }
       

        private void ShipsMenuButton_Click(object sender, EventArgs e)
        {
            ShipControlForm newScreen = new ShipControlForm();
            newScreen.Show();
            Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            Close();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            newShip.Name = nameTextBox.Text;
        }

        private void ScanSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.Scan = (int)scanSelect.Value;
        }

        private void MinSigSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.SigMin = (int)minSigSelect.Value;
        }

        private void MaxSigSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.SigMax = (int)maxSigSelect.Value;
        }

        private void ThrustSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.Thrust = (int)thrustSelect.Value;
        }

        private void HullSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.Hull = (int)HullSelect.Value;
        }

        private void AMinSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.AMin = (int)AMinSelect.Value;
        }

        private void AMaxSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.AMax = (int)AMaxSelect.Value;
        }

        private void PdSeelct_ValueChanged(object sender, EventArgs e)
        {
            newShip.Pd = (int)PdSeelct.Value;
        }

        private void GroupMinSeelct_ValueChanged(object sender, EventArgs e)
        {
            newShip.GMin = (int)GroupMinSeelct.Value;
        }

        private void GroupMaxSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.GMax = (int)GroupMaxSelect.Value;
        }

        private void LaunchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newShip.Launch = launchCheckBox.Checked;
        }

        private void TonnageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newShip.Tonnage = (Tonnage)TonnageComboBox.SelectedItem;
        }

        private void PointsSelect_ValueChanged(object sender, EventArgs e)
        {
            newShip.Points = (int)PointsSelect.Value;
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            ShipRule newRule = (ShipRule)rulesCombo.SelectedItem;
            newRule.Amount = (int)ruleAmountSelect.Value;
            newShip.AddRule(newRule);
            ShipSpecialRulesBox.DataSource = null;
            ShipSpecialRulesBox.DataSource = newShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
            ruleAmountSelect.Value = 0;

        }

        private void DeleteRuleButton_Click(object sender, EventArgs e)
        {
            ShipRule deleteRule = (ShipRule)ShipSpecialRulesBox.SelectedItem;
            newShip.RemoveRule(deleteRule);
            ShipSpecialRulesBox.DataSource = null;
            ShipSpecialRulesBox.DataSource = newShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
            ruleAmountSelect.Value = 0;
        }

        private void AddWeaponsButton_Click(object sender, EventArgs e)
        {
            shipController.InsertShip(newShip);
            newShip.ShipID = shipController.GetShipID(newShip.Name, newShip.Points);
        }
    }
}
