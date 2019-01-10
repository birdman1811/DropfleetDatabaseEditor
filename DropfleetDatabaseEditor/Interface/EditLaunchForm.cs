using DropfleetDatabaseEditor.Datastore;
using DropfleetDatabaseEditor.Controllers;
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
    public partial class EditLaunchForm : Form
    {
        WeaponController weaponControl = new WeaponController();
        ShipController shipControl = new ShipController();
        LaunchAssetsController assetControl = new LaunchAssetsController();
        List<LaunchAsset> assetList = new List<LaunchAsset>();
        List<WeaponRule> rulesList = new List<WeaponRule>();
        Ship editShip;
        

        public EditLaunchForm(Ship ship)
        {
            InitializeComponent();
            editShip = ship;
        }
    }
}
