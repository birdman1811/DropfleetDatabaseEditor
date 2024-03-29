﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersMenu newScreen = new UsersMenu();
            newScreen.Show();
            this.Close();
        }

        private void FactionControlButton_Click(object sender, EventArgs e)
        {
            FactionMenu newScreen = new FactionMenu();
            newScreen.Show();
            this.Close();
        }

        private void ShipsButton_Click(object sender, EventArgs e)
        {
            ShipControlForm newScreen = new ShipControlForm();
            newScreen.Show();
            this.Close();
        }

        private void MiscellaneousButton_Click(object sender, EventArgs e)
        {
            MiscellaneousMenu newScreen = new MiscellaneousMenu();
            newScreen.Show();
            Close();
        }
    }
}
