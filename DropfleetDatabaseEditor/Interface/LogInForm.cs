using DropfleetDatabaseEditor.Controllers;
using DropfleetDatabaseEditor.Datastore;
using DropfleetDatabaseEditor.Interface;
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

namespace DropfleetDatabaseEditor
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            User userToValidate = new User();
            UserController userController = new UserController();
            UserAccessController accessController = new UserAccessController();
            bool isCorrectEmail = userController.CheckUserName(usernameTextBox.Text);
            if (isCorrectEmail == true){
                Console.WriteLine("Email or Username valid.");
                userToValidate = userController.GetUser(usernameTextBox.Text);
                bool isverified = accessController.GrantAccess(userToValidate, passwordTextBox.Text);
                if (isverified == true)
                {
                    Console.WriteLine("Access Granted");
                    Interface.MainMenu newScreen = new Interface.MainMenu();
                    newScreen.Show();                    
                }
                else
                {
                    Thread messageThread = new Thread(AccessDeniedMessage);
                    messageThread.Start();
                }
            }
            else
            {
                Thread messageThread = new Thread(AccessDeniedMessage);
                messageThread.Start();
            }
            

        }

        

        private void AccessDeniedMessage()
        {
            MessageBox.Show("Access Denied, Please Try Again", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUserForm newScreen = new CreateUserForm();
            newScreen.Show();
        }
    }
}
