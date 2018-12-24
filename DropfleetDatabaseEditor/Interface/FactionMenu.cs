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
    public partial class FactionMenu : Form
    {
        public FactionMenu()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            this.Close();
        }

        private void CreateFactionButton_Click(object sender, EventArgs e)
        {
            CreateFactionForm newScreen = new CreateFactionForm();
            newScreen.Show();
            this.Close();
        }

        private void EditFactionButton_Click(object sender, EventArgs e)
        {
            EditFactionForm newScreen = new EditFactionForm();
            newScreen.Show();
            this.Close();
        }
    }
}
