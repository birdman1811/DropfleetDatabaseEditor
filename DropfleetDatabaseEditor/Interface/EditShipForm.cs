﻿using DropfleetDatabaseEditor.Controllers;
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
    public partial class EditShipForm : Form
    {
        FactionController factionControl = new FactionController();
        ShipController shipControl = new ShipController();
        ShipRulesController rulesControl = new ShipRulesController();
        List<Faction> factionList = new List<Faction>();
        List<Ship> shipList = new List<Ship>();
        List<ShipRule> ruleList = new List<ShipRule>();
        Faction selectedFaction = new Faction();
        Ship selectedShip = new Ship();
        TonnageController tonnageControl = new TonnageController();
        List<Tonnage> tonnageList = new List<Tonnage>();
        static Ship editShip = new Ship();

        public EditShipForm()
        {
            InitializeComponent();
            factionList = factionControl.GetAllFactions();
            selectFactionComboBox.DataSource = factionList;
            selectFactionComboBox.DisplayMember = "name";
            selectedFaction = (Faction)selectFactionComboBox.SelectedItem;
            shipList = shipControl.GetAllShipsOfFaction(selectedFaction);
            selectShipCombo.DataSource = null;
            selectShipCombo.DataSource = shipList;
            selectShipCombo.DisplayMember = "name";
            editShip = (Ship)selectShipCombo.SelectedItem;
            tonnageList = tonnageControl.GetAllTonnages();
            ruleList = rulesControl.GetAllRules();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            Close();
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            ShipControlForm newScreen = new ShipControlForm();
            newScreen.Show();
            Close();
        }

        private void SelectFactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFaction = (Faction)selectFactionComboBox.SelectedItem;
            shipList.Clear();
            shipList = shipControl.GetAllShipsOfFaction(selectedFaction);
            selectShipCombo.DataSource = null;
            selectShipCombo.DataSource = shipList;
            selectShipCombo.DisplayMember = "name";
        }

        private void SelectShipCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editShip = (Ship)selectShipCombo.SelectedItem;
            
        }

        private void SelectShipButton_Click(object sender, EventArgs e)
        {
            
            shipStatsPanel.Visible = true;
            specrulesPanel.Visible = true;
            panel1.Visible = false;
            nameTextBox.Text = editShip.Name;
            factionComboBox.DataSource = factionList;
            factionComboBox.DisplayMember = "name";
            scanSelect.Value = editShip.Scan;
            minSigSelect.Value = editShip.SigMin;
            maxSigSelect.Value = editShip.SigMax;
            thrustSelect.Value = editShip.Thrust;
            HullSelect.Value = editShip.Hull;
            PdSeelct.Value = editShip.Pd;
            AMinSelect.Value = editShip.AMin;
            AMaxSelect.Value = editShip.AMax;
            launchCheckBox.Checked = editShip.Launch;
            TonnageComboBox.DataSource = tonnageList;
            TonnageComboBox.DisplayMember = "tonnageName";
            int index = 0;
            foreach (Tonnage t in tonnageList)
            {
                if (t.TonnageName == editShip.Tonnage.TonnageName)
                {
                    index = tonnageList.IndexOf(t);
                }
            }
            TonnageComboBox.SelectedIndex = index;
            PointsSelect.Value = editShip.Points;
            GroupMinSeelct.Value = editShip.GMin;
            GroupMaxSelect.Value = editShip.GMax;

            ShipSpecialRulesBox.DataSource = editShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
            rulesCombo.DataSource = ruleList;
            rulesCombo.DisplayMember = "rule";
            Console.WriteLine(editShip.ShipID);
        }

        private void DeleteRuleButton_Click(object sender, EventArgs e)
        {
            
            ShipRule ruleToDelete = (ShipRule)ShipSpecialRulesBox.SelectedItem;
            editShip.RemoveRule(ruleToDelete);
            rulesControl.DeleteRuleInstance(ruleToDelete, editShip.ShipID);
            ShipSpecialRulesBox.DataSource = null;
            ShipSpecialRulesBox.DataSource = editShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            ShipRule ruleToAdd = (ShipRule)rulesCombo.SelectedItem;
            ruleToAdd.Amount = (int)ruleAmountSelect.Value;
            editShip.AddRule(ruleToAdd);
            Console.WriteLine(editShip.ShipID);
            rulesControl.InsertRuleInstance(ruleToAdd, editShip.ShipID);
            ShipSpecialRulesBox.DataSource = null;
            ShipSpecialRulesBox.DataSource = editShip.Special;
            ShipSpecialRulesBox.DisplayMember = "fullString";
        }

        private void EditWeaponsButton_Click(object sender, EventArgs e)
        {
            EditShipWeaponsForm newScreen = new EditShipWeaponsForm(editShip);
            newScreen.Show();
            Close();
        }
    }
}
