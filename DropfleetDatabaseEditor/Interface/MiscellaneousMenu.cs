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
    public partial class MiscellaneousMenu : Form
    {
        public MiscellaneousMenu()
        {
            InitializeComponent();
        }

        private void BattlegroupsForm_Click(object sender, EventArgs e)
        {
            BattlegroupForm newScreen = new BattlegroupForm();
            newScreen.Show();
            Close();

        }
    }
}
