using DropfleetDatabaseEditor.Controllers;
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
    public partial class CreateUserForm : Form
    {
        UserController userController = new UserController();
        UserAccessController accessController = new UserAccessController();

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
           bool passwordsMatch = CheckPasswordMatch();
           if (passwordsMatch == false)
            {
                Thread messageThread = new Thread(BadPasswords);
                messageThread.Start();
            }

           if (passwordsMatch == true)
            {
                bool userNameTaken = CheckUserNameTaken();
                if (userNameTaken == true)
                {
                    Thread messageThread = new Thread(UserNameTaken);
                    messageThread.Start();
                }
                else
                {
                    accessController.CreateUser(emailTextBox.Text, passwordTextBox.Text);
                    this.Close();
                }
            }

        }

        private void UserNameTaken()
        {
            MessageBox.Show("Username or Email already Exists.", "User already Exists", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private bool CheckUserNameTaken()
        {
            bool userNameAvailable = userController.CheckUserName(emailTextBox.Text);

            return userNameAvailable;
        }

        private void BadPasswords()
        {
            MessageBox.Show("Passwords Do Not Match, Please Try Again.", "Passwords Don't Match", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private bool CheckPasswordMatch()
        {
            bool passwordsMatch = false;

            if (passwordTextBox.Text == PasswordCheckTextBox.Text)
            {
                passwordsMatch = true;
            }

            return passwordsMatch;
        }

    }
}
