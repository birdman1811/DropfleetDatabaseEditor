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
    public partial class WeaponRulesForm : Form
    {
        WeaponController weaponControl = new WeaponController();
        List<WeaponRule> weaponRules = new List<WeaponRule>();
        WeaponRule selectedRule;

        public WeaponRulesForm()
        {
            InitializeComponent();
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            createNewPanel.Visible = true;
            editExistinPanel.Visible = false;
        }

        private void AddRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRule newRule = new WeaponRule
            {
                Rule = newRuleText.Text
            };
            weaponControl.InsertWeaponRule(newRule);
            newRuleText.Clear();
            Thread addedToDBThread = new Thread(AddedMessage);
            addedToDBThread.Start();
        }

        private void AddedMessage()
        {
            MessageBox.Show("Item Succesfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditExistingButton_Click(object sender, EventArgs e)
        {
            createNewPanel.Visible = false;
            editExistinPanel.Visible = true;
            weaponRules = weaponControl.GetWeaponRules();
            ruleComboBox.DataSource = weaponRules;
            ruleComboBox.DisplayMember = "Rule";
        }

        private void RuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRule = (WeaponRule)ruleComboBox.SelectedItem;
            editRuleTextBox.Text = selectedRule.Rule;
        }

        private void EditRuleButton_Click(object sender, EventArgs e)
        {
            WeaponRule editRule = selectedRule;
            editRule.Rule = editRuleTextBox.Text;
            weaponControl.UpdateRule(editRule);
            weaponRules.Clear();
            weaponRules = weaponControl.GetWeaponRules();
            Thread updatedThread = new Thread(UpdateMessage);
            updatedThread.Start();            
            ruleComboBox.DataSource = weaponRules;
            ruleComboBox.DisplayMember = "Rule";
        }

        private void UpdateMessage()
        {
            MessageBox.Show("Item Succesfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
