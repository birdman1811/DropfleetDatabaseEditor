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
    public partial class ShipControlForm : Form
    {
        public ShipControlForm()
        {
            InitializeComponent();
        }

        private void weaponsControlButton_Click(object sender, EventArgs e)
        {
            WeaponControlForm newScreen = new WeaponControlForm();
            newScreen.Show();
            this.Close();
        }
    }
}
