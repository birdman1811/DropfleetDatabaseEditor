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
    public partial class WeaponControlForm : Form
    {
        public WeaponControlForm()
        {
            InitializeComponent();
        }

        private void WeaponRulesButton_Click(object sender, EventArgs e)
        {
            WeaponRulesForm newScreen = new WeaponRulesForm();
            newScreen.Show();
            this.Close();
        }

        private void AddWeapons_Click(object sender, EventArgs e)
        {
            AddWeaponForm newScreen = new AddWeaponForm();
            newScreen.Show();
            this.Close();
        }

        private void editWeaponsButton_Click(object sender, EventArgs e)
        {
            EditWeaponForm newScreen = new EditWeaponForm();
            newScreen.Show();
            this.Close();
        }
    }
}
