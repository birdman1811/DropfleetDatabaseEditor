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
    public partial class WeaponiseShipForm : Form
    {
        WeaponController weaponControl = new WeaponController();
        List<Weapon> weaponList = new List<Weapon>();
        Ship shipToWeaponise;
        List<Facings> facingsList = new List<Facings>();
        List<int> listNumbers = new List<int>();
        
        public WeaponiseShipForm(Ship NewShip)
        {
            InitializeComponent();
            ShipName.Text = "Add Weapons to " + NewShip.Name;
            weaponList = weaponControl.GetWeaponsByFaction(NewShip.Faction);
            weaponComboBox.DataSource = weaponList;
            weaponComboBox.DisplayMember = "name";
            WeaponListBox.DataSource = NewShip.Weapons;
            WeaponListBox.DisplayMember = "fullString";
            shipToWeaponise = NewShip;
            facingsList = weaponControl.GetAllFacings();            
            listNumbers = weaponControl.GetListNumbers();
            
        }

        private void AddWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponFacing newWeapon = new WeaponFacing();
            newWeapon.Weapon = (Weapon)weaponComboBox.SelectedItem;
            if (FBox.Checked == true)
            {
                Facings newFacing = new Facings(1,"F");
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
            shipToWeaponise.AddWeapon(newWeapon);
            WeaponListBox.DataSource = null;
            WeaponListBox.DataSource = shipToWeaponise.Weapons;
            WeaponListBox.DisplayMember = "fullString";
        }

        private void RemoveWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponFacing deleteWeapon = (WeaponFacing)WeaponListBox.SelectedItem;
            shipToWeaponise.RemoveWeapon(deleteWeapon);
            WeaponListBox.DataSource = null;
            WeaponListBox.DataSource = shipToWeaponise.Weapons;
            WeaponListBox.DisplayMember = "fullString";
        }

       

        private void AddWeaponsButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            foreach (WeaponFacing weapon in shipToWeaponise.Weapons)
            {
                Boolean cleanNumber = false;

                while (cleanNumber == false)
                {
                    int listNumber = rnd.Next(1, 30000);
                    if (listNumbers.Contains(listNumber) == false)
                    {
                        weapon.ListNumber = listNumber;
                        cleanNumber = true;
                    }
                }

                weaponControl.InsertWeaponInstance(weapon, shipToWeaponise.ShipID);
                foreach(Facings facing in weapon.Facings)
                {
                    weaponControl.InsertFacingInstance(facing, weapon.ListNumber);
                }
                
            }

            ShipBuilderForm newScreen = new ShipBuilderForm();
            newScreen.Show();
            Close();

        }

        
    }
}
