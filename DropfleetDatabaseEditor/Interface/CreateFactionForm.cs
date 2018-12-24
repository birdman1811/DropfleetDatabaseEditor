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
    public partial class CreateFactionForm : Form
    {

        FactionController factionControl = new FactionController();

        public CreateFactionForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FactionMenu newScreen = new FactionMenu();
            newScreen.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Faction newFaction = new Faction
            {
                Name = nameTextBox.Text,
                Icon = IconTextBox.Text,
                Lore = loreTextBox.Text,
                Gameplay = gameplayTextBox.Text
            };


            factionControl.AddFaction(newFaction);

            nameTextBox.Clear();
            IconTextBox.Clear();
            loreTextBox.Clear();
            gameplayTextBox.Clear();

            Thread factionAdded = new Thread(FactionAddedMessage);
            factionAdded.Start();
        }

        private void FactionAddedMessage()
        {
            MessageBox.Show("Faction Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
