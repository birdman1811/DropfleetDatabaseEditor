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
    public partial class BattlegroupForm : Form
    {
        BattlegroupController groupController = new BattlegroupController();
        BattleGroup newGroup = new BattleGroup();

        public BattlegroupForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu newScreen = new MainMenu();
            newScreen.Show();
            Close();
        }

        private void BackMenuButton_Click(object sender, EventArgs e)
        {
            MiscellaneousMenu newScreen = new MiscellaneousMenu();
            newScreen.Show();
            Close();
        }

        private void GroupNameText_TextChanged(object sender, EventArgs e)
        {
            newGroup.GroupName = groupNameText.Text;
        }

        private void ImageURLText_TextChanged(object sender, EventArgs e)
        {
            newGroup.GroupImage = imageURLText.Text;
        }

        private void MaxSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.Max = (int)maxSelect.Value;
        }

        private void MinLightSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MinLight = (int)minLightSelect.Value;
        }

        private void MaxLightSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MaxLight = (int)maxLightSelect.Value;
        }

        private void MinMediumSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MinMedium = (int)minMediumSelect.Value;
        }

        private void MaxMediumSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MaxMedium = (int)maxMediumSelect.Value;
        }

        private void MinHeavySelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MinHeavy = (int)minHeavySelect.Value;
        }

        private void MaxHeavySelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MaxHeavy = (int)maxHeavySelect.Value;
        }

        private void MinSuperHeavySelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MinSuperheavy = (int)minSuperHeavySelect.Value;
        }

        private void MaxSuperHeavySelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MaxSuperheavy = (int)maxSuperHeavySelect.Value;
        }

        private void minDreadnoughtSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MinDreadnought = (int)minDreadnoughtSelect.Value;
        }

        private void maxDreadnoughtSelect_ValueChanged(object sender, EventArgs e)
        {
            newGroup.MaxDreadnought = (int)maxDreadnoughtSelect.Value;
        }

        private void addBatllegroupButton_Click(object sender, EventArgs e)
        {
            groupController.InsertBattlegroup(newGroup);
            Thread successthread = new Thread(SuccessMessage);
            successthread.Start();
            BattlegroupForm newScreen = new BattlegroupForm();
            newScreen.Show();
            Close();
        }

        private void SuccessMessage()
        {
            MessageBox.Show("Group Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
