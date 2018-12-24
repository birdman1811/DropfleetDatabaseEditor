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
    public partial class UsersMenu : Form
    {
        public UsersMenu()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            CreateUserForm newScreen = new CreateUserForm();
            newScreen.Show();
            this.Close();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm newScreen = new EditUserForm();
            newScreen.Show();
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            this.Close();
        }
    }
}
