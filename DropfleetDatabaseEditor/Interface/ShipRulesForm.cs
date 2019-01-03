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
    public partial class ShipRulesForm : Form
    {
        ShipRulesController ruleController = new ShipRulesController();
        ShipRule rule = new ShipRule();
        List<ShipRule> rulesList;

        public ShipRulesForm()
        {
            InitializeComponent();
            rulesList = ruleController.GetAllRules();
        }

        private void ShipScreenButton_Click(object sender, EventArgs e)
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

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            createNewPanel.Visible = true;

        }

        private void RuleTextBox_TextChanged(object sender, EventArgs e)
        {
            rule.Rule = ruleTextBox.Text;
        }

        private void SaveNewRuleBUtton_Click(object sender, EventArgs e)
        {
            ruleController.InsertRule(rule);
            Thread successMessageThread = new Thread(SuccessMessage);
            successMessageThread.Start();
            ruleTextBox.Clear();
            createNewPanel.Visible = false;
            rulesList.Clear();
            rulesList = ruleController.GetAllRules();

        }

        private void SuccessMessage()
        {
            MessageBox.Show("Database Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditExistingButton_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            ruleComboBox.DataSource = rulesList;
            ruleComboBox.DisplayMember = "rule";
        }

        private void RuleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rule = (ShipRule)ruleComboBox.SelectedItem;
            editRuleTextBox.Text = rule.Rule;
        }

        private void EditRuleTextBox_TextChanged(object sender, EventArgs e)
        {
            rule.Rule = editRuleTextBox.Text;
        }

        private void SaveEditedRuleButton_Click(object sender, EventArgs e)
        {
            ruleController.UpdateRule(rule);
            Thread successMessageThread = new Thread(SuccessMessage);
            successMessageThread.Start();
            editPanel.Visible = false;
            rulesList.Clear();
            rulesList = ruleController.GetAllRules();
        }
    }
}
