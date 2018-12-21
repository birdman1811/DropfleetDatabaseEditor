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
    public partial class EditUserForm : Form
    {

        UserController userController = new UserController();

        public EditUserForm()
        {
            InitializeComponent();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            User userToEdit = new User();
            bool userExists = userController.CheckUserName(userNameTextBox.Text);
            if (userExists == false)
            {
                Thread errorThread = new Thread(EmailNotValid);
                errorThread.Start();
            }
            else
            {
                userToEdit.Email = userNameTextBox.Text;
                CheckPasswords(userToEdit);
            }
        }

        private void EmailNotValid()
        {
            MessageBox.Show("Username not on System, check and try again.", "Username Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void CheckPasswords(User userToEdit)
        {
            bool passwordsSame = false;
            if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
            {
                passwordsSame = true;
            }

            if (passwordsSame == true)
            {
                userToEdit.Password = newPasswordTextBox.Text;
                GetExistingUser(userToEdit);
            }

            else
            {
                Thread errorThread = new Thread(PasswordsDontMatch);
            }
        }

        private void PasswordsDontMatch()
        {

        }

        private void GetExistingUser(User userToEdit)
        {

        }
    }
}
