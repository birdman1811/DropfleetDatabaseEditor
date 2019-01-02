using DropfleetDatabaseEditor.Controllers;
using DropfleetDatabaseEditor.Datastore;
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
    public partial class TonnageForm : Form
    {
        Tonnage newTonnage = new Tonnage();
        Tonnage editTonnage = new Tonnage();
        
        List<TonnageClass> tonnageClasses = new List<TonnageClass>();
        TonnageController tonnageControl = new TonnageController();
        List<Tonnage> tonnageList;

        public TonnageForm()
        {
            editTonnage.TonnageClass = new TonnageClass();
            InitializeComponent();
            
        }

        private void ShipsMenuButton_Click(object sender, EventArgs e)
        {
            ShipControlForm newScreen = new ShipControlForm();
            newScreen.Show();
            Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            Close();
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            createPanel.Visible = true;
            tonnageClasses = tonnageControl.GetTonnageClasses();
            tonnageClassCombo.DataSource = tonnageClasses;
            tonnageClassCombo.DisplayMember = "ClassName";
            newTonnage.TonnageClass = (TonnageClass)tonnageClassCombo.SelectedItem;
            
        }

        private void TonnageTextBox_TextChanged(object sender, EventArgs e)
        {
            newTonnage.TonnageName = tonnageTextBox.Text;
        }

        private void ValueSelect_ValueChanged(object sender, EventArgs e)
        {
            newTonnage.Value = (int)valueSelect.Value;
        }

        private void TonnageClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newTonnage.TonnageClass = (TonnageClass)tonnageClassCombo.SelectedItem;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tonnageControl.InsertTonnage(newTonnage);
            Thread successThread = new Thread(SuccessMessage);
            successThread.Start();
            createPanel.Visible = false;
            tonnageTextBox.Clear();
            valueSelect.Value = 0;
            tonnageList.Add(newTonnage);
        }

        private void SuccessMessage()
        {
            MessageBox.Show("Item Added or Updated Succesfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditExistingButton_Click(object sender, EventArgs e)
        {            
            editPanel.Visible = true;
            tonnageList = tonnageControl.GetAllTonnages();
            tonnageCombo.DataSource = null;
            tonnageCombo.DataSource = tonnageList;
            tonnageCombo.DisplayMember = "TonnageName";
            editTonnage = (Tonnage)tonnageCombo.SelectedItem;
            tonnageClasses = tonnageControl.GetTonnageClasses();
            editTonnageClassCombo.DataSource = null;
            editTonnageClassCombo.DataSource = tonnageClasses;
            editTonnageClassCombo.DisplayMember = "ClassName";
            

        }

        private void TonnageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            editTonnage = (Tonnage)tonnageCombo.SelectedItem;             
            editTonnageTextBox.Text = editTonnage.TonnageName;
            editTonnageValueSelect.Value = (int)editTonnage.Value;        

        }
    }
}
