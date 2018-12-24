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
    public partial class EditFactionForm : Form
    {
        FactionController factionControl = new FactionController();
        Faction selectedFaction;
        List<Faction> factionList;
        

        public EditFactionForm()
        {
            InitializeComponent();
            PopulateFactionList();
        }

        private void PopulateFactionList()
        {
            factionList = factionControl.GetAllFactions();
            factionCombo.DataSource = factionList;
            factionCombo.DisplayMember = "name";
        }

        private void SelctButton_Click(object sender, EventArgs e)
        {
            selectedFaction = (Faction)factionCombo.SelectedItem;
            editFactionPanel.Visible = true;
            nameTextBox.Text = selectedFaction.Name;
            IconTextBox.Text = selectedFaction.Icon;
            loreTextBox.Text = selectedFaction.Lore;
            gameplayTextBox.Text = selectedFaction.Gameplay;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FactionMenu newScreen = new FactionMenu();
            newScreen.Show();
            this.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            selectedFaction.Name = nameTextBox.Text;
            selectedFaction.Icon = IconTextBox.Text;
            selectedFaction.Lore = loreTextBox.Text;
            selectedFaction.Gameplay = gameplayTextBox.Text;
            factionControl.UpdateFaction(selectedFaction);
            nameTextBox.Clear();
            IconTextBox.Clear();
            loreTextBox.Clear();
            gameplayTextBox.Clear();
            editFactionPanel.Visible = false;
            factionList.Clear();
            PopulateFactionList();

        }
    }
}
