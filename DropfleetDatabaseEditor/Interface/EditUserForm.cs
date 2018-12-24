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
        UserAccessController accessControl = new UserAccessController();

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
                userNameTextBox.Clear();
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
                errorThread.Start();
                newPasswordTextBox.Clear();
                confirmNewPasswordTextBox.Clear();
            }
        }

        private void PasswordsDontMatch()
        {
            MessageBox.Show("Passwords Don't match, please try again.", "New Passwords Don't Match", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void GetExistingUser(User userToEdit)
        {
            User oldDetails = userController.GetUser(userToEdit.Email);
            oldDetails.Email = userToEdit.Email;
            bool userValidated = accessControl.GrantAccess(oldDetails, existingPasswordTextBox.Text);
            if (userValidated == false)
            {
                Thread errorThread = new Thread(WrongPassword);
                errorThread.Start();
            }

            else
            {
                ChangePassword(oldDetails);
            }
        }

        private void WrongPassword()
        {
            MessageBox.Show("Wrong User Password, please re-enter password.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void ChangePassword(User userToEdit) 
        {
            accessControl.EditUser(userToEdit, newPasswordTextBox.Text);
            userNameTextBox.Clear();
            existingPasswordTextBox.Clear();
            newPasswordTextBox.Clear();
            confirmNewPasswordTextBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UsersMenu newScreen = new UsersMenu();
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
