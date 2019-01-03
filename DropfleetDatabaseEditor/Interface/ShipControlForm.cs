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

        private void WeaponsControlButton_Click(object sender, EventArgs e)
        {
            WeaponControlForm newScreen = new WeaponControlForm();
            newScreen.Show();
            this.Close();
        }

        private void TonnageButton_Click(object sender, EventArgs e)
        {
            TonnageForm newScreen = new TonnageForm();
            newScreen.Show();
            Close();
        }

        private void ShipRulesButton_Click(object sender, EventArgs e)
        {
            ShipRulesForm newScreen = new ShipRulesForm();
            newScreen.Show();
            Close();
        }

        private void ShipBuilderButton_Click(object sender, EventArgs e)
        {
            ShipBuilderForm newScreen = new ShipBuilderForm();
            newScreen.Show();
            Close();
        }
    }
}
