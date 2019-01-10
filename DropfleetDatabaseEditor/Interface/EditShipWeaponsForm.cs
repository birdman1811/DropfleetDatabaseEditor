using DropfleetDatabaseEditor.Controllers;
using DropfleetDatabaseEditor.Datastore;
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
    public partial class EditShipWeaponsForm : Form
    {
        Ship editShip;
        WeaponController weaponController = new WeaponController();
        List<Weapon> weaponList = new List<Weapon>();
        ShipController shipControl = new ShipController();
        List<int> listNumbers = new List<int>();

        public EditShipWeaponsForm(Ship Ship)
        {
            InitializeComponent();
            editShip = Ship;
            List<WeaponFacing> shipsWeapons = shipControl.GetShipWeapons(editShip.ShipID);
            foreach (WeaponFacing w in shipsWeapons)
            {
                editShip.AddWeapon(w);
            }
            weaponList = weaponController.GetWeaponsByFaction(editShip.Faction);
            WeaponListBox.DataSource = editShip.Weapons;
            WeaponListBox.DisplayMember = "fullString";
            weaponComboBox.DataSource = weaponList;
            weaponComboBox.DisplayMember = "name";
            listNumbers = weaponController.GetListNumbers();
            ShipName.Text = "Edit Weapons for " + editShip.Name;
            if (editShip.Launch == true)
            {
                AddWeaponsButton.Text = "Edit Launch Assets";
            }
        }

        private void RemoveWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponFacing deleteWeapon = (WeaponFacing)WeaponListBox.SelectedItem;
            weaponController.DeleteWeaponInstance(deleteWeapon);
            editShip.RemoveWeapon(deleteWeapon);
            WeaponListBox.DataSource = null;
            WeaponListBox.DataSource = editShip.Weapons;
            WeaponListBox.DisplayMember = "fullString";
        }

        private void AddWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponFacing newWeapon = new WeaponFacing
            {
                Weapon = (Weapon)weaponComboBox.SelectedItem
            };
            if (FBox.Checked == true)
            {
                Facings newFacing = new Facings(1, "F");
                newWeapon.AddFacing(newFacing);
            }
            if (SBox.Checked == true)
            {
                Facings newFacing = new Facings(2, "S");
                newWeapon.AddFacing(newFacing);
            }
            if (RBox.Checked == true)
            {
                Facings newFacing = new Facings(3, "R");
                newWeapon.AddFacing(newFacing);
            }
            if (FNBox.Checked == true)
            {
                Facings newFacing = new Facings(5, "F(N)");
                newWeapon.AddFacing(newFacing);
            }
            if (SRBox.Checked == true)
            {
                Facings newFacing = new Facings(6, "S(R)");
                newWeapon.AddFacing(newFacing);
            }
            if (SLBox.Checked == true)
            {
                Facings newFacing = new Facings(7, "S(L)");
                newWeapon.AddFacing(newFacing);
            }
            editShip.AddWeapon(newWeapon);
            WeaponListBox.DataSource = null;
            WeaponListBox.DataSource = editShip.Weapons;
            WeaponListBox.DisplayMember = "fullString";
            Random rnd = new Random();

            
                Boolean cleanNumber = false;

                while (cleanNumber == false)
                {
                    int listNumber = rnd.Next(1, 30000);
                    if (listNumbers.Contains(listNumber) == false)
                    {
                        newWeapon.ListNumber = listNumber;
                        cleanNumber = true;
                    }
                }

                weaponController.InsertWeaponInstance(newWeapon, editShip.ShipID);
                foreach (Facings facing in newWeapon.Facings)
                {
                    weaponController.InsertFacingInstance(facing, newWeapon.ListNumber);
                }

            
        }

        private void AddWeaponsButton_Click(object sender, EventArgs e)
        {
            if (editShip.Launch == false)
            {

                EditShipForm newScreen = new EditShipForm();
                newScreen.Show();
                Close();
            }

            else
            {
                EditLaunchForm newScreen = new EditLaunchForm(editShip);
                newScreen.Show();
                Close();
            }
        }
    }
}
