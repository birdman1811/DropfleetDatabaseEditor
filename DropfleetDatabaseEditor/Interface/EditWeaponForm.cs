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
    public partial class EditWeaponForm : Form
    {
        FactionController factionControl = new FactionController();
        WeaponController weaponControl = new WeaponController();
        Weapon editWeapon = new Weapon();
        Faction selectedFaction = new Faction();
        List<Faction> factionList = new List<Faction>();
        List<WeaponRule> rulesList = new List<WeaponRule>();
        List<Weapon> weaponList = new List<Weapon>();

        public EditWeaponForm()
        {
            InitializeComponent();
            SetFactionCombo();
            SetWeaponCombo();
        }

        private void SetFactionCombo()
        {
            factionList = factionControl.GetAllFactions();            
            factionComboBox.DataSource = factionList;
            factionComboBox.DisplayMember = "name";
            selectedFaction = (Faction)factionComboBox.SelectedItem;
            
        }

        private void SetWeaponCombo()
        {
            weaponList = weaponControl.GetWeaponsByFaction(selectedFaction);            
            weaponComboBox.DataSource = null;
            weaponComboBox.DataSource = weaponList;
            weaponComboBox.DisplayMember = "name";
            editWeapon = (Weapon)weaponComboBox.SelectedItem;
        }

        private void WeaponScreenButton_Click(object sender, EventArgs e)
        {
            WeaponControlForm newScreen = new WeaponControlForm();
            newScreen.Show();
            this.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            this.Close();
        }

        private void SelectWeaponButton_Click(object sender, EventArgs e)
        {
            editWeapon = (Weapon)weaponComboBox.SelectedItem;
            weaponStatsPanel.Visible = true;
            PopulateStatsPanel();
        }

        private void PopulateStatsPanel()
        {
            nameTextBox.Text = editWeapon.Name;
            weaponFactionComboBox.DataSource = factionList;
            weaponFactionComboBox.DisplayMember = "name";
            weaponFactionComboBox.SelectedItem = editWeapon.Faction;
            lockValueSelect.Value = editWeapon.LockValue;
            AttackTextBox.Text = editWeapon.Attack;
            damageSelect.Value = editWeapon.Damage;
            
        }

        private void FactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFaction = (Faction)factionComboBox.SelectedItem;
            SetWeaponCombo();
        }

        private void WeaponComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editWeapon = (Weapon)weaponComboBox.SelectedItem;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            editWeapon.Name = nameTextBox.Text;
        }

        private void WeaponFactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editWeapon.Faction = (Faction)weaponFactionComboBox.SelectedItem;
        }

        private void LockValueSelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.LockValue = (int)lockValueSelect.Value;
        }

        private void AttackTextBox_TextChanged(object sender, EventArgs e)
        {
            editWeapon.Attack = AttackTextBox.Text;
        }

        private void DamageSelect_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Damage = (int)damageSelect.Value;
        }

        private void SaveWeaponButton_Click(object sender, EventArgs e)
        {
            
            weaponControl.UpdateWeapon(editWeapon);
            weaponStatsPanel.Visible = false;
            Thread updatedMessageThread = new Thread(WeaponUpdatedMessage);
            updatedMessageThread.Start();
        }

        private void WeaponUpdatedMessage()
        {
            MessageBox.Show("Weapon Stats Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditRulesButton_Click(object sender, EventArgs e)
        {
            weaponControl.UpdateWeapon(editWeapon);
            weaponStatsPanel.Visible = false;
            Thread updatedMessageThread = new Thread(WeaponUpdatedMessage);
            updatedMessageThread.Start();
            weaponRulesPanel.Visible = true;
            rulesList = weaponControl.GetWeaponRules();
            weaponRuleComboBox.DataSource = rulesList;
            weaponRuleComboBox.DisplayMember = "rule";
            specialRulesListBox.DataSource = editWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance newRuleInstance = new WeaponRuleInstance
            {
                Amount = (int)ruleAmountSelect.Value
            };
            WeaponRule selectedRule = (WeaponRule)weaponRuleComboBox.SelectedItem;
            newRuleInstance.RuleID = selectedRule.RuleID;
            newRuleInstance.Rule = selectedRule.Rule;
            editWeapon.AddRule(newRuleInstance);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = editWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            ruleAmountSelect.Value = 0;
            weaponControl.InsertWeaponRuleInstance(editWeapon.WeaponID, newRuleInstance);

        }

        private void updateRuleAmountButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance editRuleInstance = (WeaponRuleInstance)specialRulesListBox.SelectedItem;
            editWeapon.RemoveRule((WeaponRuleInstance)specialRulesListBox.SelectedItem);
            editRuleInstance.Amount = (int)editRuleAmountSelector.Value;
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = editWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            editWeapon.AddRule(editRuleInstance);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = editWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            weaponControl.UpdateWeaponRuleInstance(editRuleInstance, editWeapon.WeaponID);
        }

        private void deleteRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance DeletedRule = (WeaponRuleInstance)specialRulesListBox.SelectedItem;
            editWeapon.RemoveRule(DeletedRule);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = editWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            weaponControl.DeleteWeaponRuleInstance(DeletedRule, editWeapon.WeaponID);
        }

        private void editCompleteButton_Click(object sender, EventArgs e)
        {
            Thread updatedMessageThread = new Thread(WeaponUpdatedMessage);
            updatedMessageThread.Start();
            weaponRulesPanel.Visible = false;
        }
    }
}
