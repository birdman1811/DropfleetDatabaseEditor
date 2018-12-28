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
    public partial class AddWeaponForm : Form
    {

        WeaponController weaponControl = new WeaponController();
        List<Faction> factionList;
        FactionController factionControl = new FactionController();
        Weapon newWeapon = new Weapon();
        
        List<WeaponRule> weaponRules;

        public AddWeaponForm()
        {
            InitializeComponent();
            factionList = factionControl.GetAllFactions();
            factionComboBox.DataSource = factionList;
            factionComboBox.DisplayMember = "name";
            weaponRules = weaponControl.GetWeaponRules();
            weaponRuleComboBox.DataSource = weaponRules;
            weaponRuleComboBox.DisplayMember = "rule";
            specialRulesListBox.DataSource = newWeapon.Rules;
            specialRulesListBox.DisplayMember = "rule " + "(" + "amount" + ")";
            newWeapon.Faction = (Faction)factionComboBox.SelectedItem;
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

        private void AddWeaponButton_Click(object sender, EventArgs e)
        {
            weaponControl.AddWeapon(newWeapon);
            Thread addedMessageThread = new Thread(AddedMessage);
            addedMessageThread.Start();
            AddWeaponForm newScreen = new AddWeaponForm();
            newScreen.Show();
            this.Close();
        }

        private void AddedMessage()
        {
            MessageBox.Show("Weapon Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            newWeapon.Name = nameTextBox.Text;
        }

        private void FactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newWeapon.Faction = (Faction)factionComboBox.SelectedItem;
        }

        private void LockValueSelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.LockValue = (int)lockValueSelect.Value;
        }

        

        private void DamageSelect_ValueChanged(object sender, EventArgs e)
        {
            newWeapon.Damage = (int)damageSelect.Value;
        }

        private void addRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance newRuleInstance = new WeaponRuleInstance();
            newRuleInstance.Amount = (int)ruleAmountSelect.Value;
            WeaponRule selectedRule = (WeaponRule)weaponRuleComboBox.SelectedItem;
            newRuleInstance.RuleID = selectedRule.RuleID;
            newRuleInstance.Rule = selectedRule.Rule;
            newWeapon.AddRule(newRuleInstance);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = newWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            ruleAmountSelect.Value = 0;
        }

        private void updateRuleAmountButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance editRuleInstance = (WeaponRuleInstance)specialRulesListBox.SelectedItem;
            newWeapon.RemoveRule((WeaponRuleInstance)specialRulesListBox.SelectedItem);
            editRuleInstance.Amount = (int)editRuleAmountSelector.Value;
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = newWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
            newWeapon.AddRule(editRuleInstance);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = newWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
        }

        private void deleteRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRuleInstance DeletedRule = (WeaponRuleInstance)specialRulesListBox.SelectedItem;
            newWeapon.RemoveRule(DeletedRule);
            specialRulesListBox.DataSource = null;
            specialRulesListBox.DataSource = newWeapon.Rules;
            specialRulesListBox.DisplayMember = "fullString";
        }

        private void AttackTextBox_TextChanged(object sender, EventArgs e)
        {
            newWeapon.Attack = AttackTextBox.Text;
        }
    }
}
