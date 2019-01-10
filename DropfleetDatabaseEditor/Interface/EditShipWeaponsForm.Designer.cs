namespace DropfleetDatabaseEditor.Interface
{
    partial class EditShipWeaponsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.FacingsCheckBox = new System.Windows.Forms.GroupBox();
            this.SLBox = new System.Windows.Forms.CheckBox();
            this.SRBox = new System.Windows.Forms.CheckBox();
            this.FNBox = new System.Windows.Forms.CheckBox();
            this.RBox = new System.Windows.Forms.CheckBox();
            this.SBox = new System.Windows.Forms.CheckBox();
            this.FBox = new System.Windows.Forms.CheckBox();
            this.AddWeaponsButton = new System.Windows.Forms.Button();
            this.RemoveWeaponButton = new System.Windows.Forms.Button();
            this.AddWeaponButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponComboBox = new System.Windows.Forms.ComboBox();
            this.ShipName = new System.Windows.Forms.Label();
            this.WeaponListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.FacingsCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.FacingsCheckBox);
            this.panel1.Controls.Add(this.AddWeaponsButton);
            this.panel1.Controls.Add(this.RemoveWeaponButton);
            this.panel1.Controls.Add(this.AddWeaponButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weaponComboBox);
            this.panel1.Controls.Add(this.ShipName);
            this.panel1.Controls.Add(this.WeaponListBox);
            this.panel1.Location = new System.Drawing.Point(72, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 528);
            this.panel1.TabIndex = 1;
            // 
            // FacingsCheckBox
            // 
            this.FacingsCheckBox.Controls.Add(this.SLBox);
            this.FacingsCheckBox.Controls.Add(this.SRBox);
            this.FacingsCheckBox.Controls.Add(this.FNBox);
            this.FacingsCheckBox.Controls.Add(this.RBox);
            this.FacingsCheckBox.Controls.Add(this.SBox);
            this.FacingsCheckBox.Controls.Add(this.FBox);
            this.FacingsCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacingsCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FacingsCheckBox.Location = new System.Drawing.Point(24, 155);
            this.FacingsCheckBox.Name = "FacingsCheckBox";
            this.FacingsCheckBox.Size = new System.Drawing.Size(185, 224);
            this.FacingsCheckBox.TabIndex = 10;
            this.FacingsCheckBox.TabStop = false;
            this.FacingsCheckBox.Text = "Facings";
            // 
            // SLBox
            // 
            this.SLBox.AutoSize = true;
            this.SLBox.Location = new System.Drawing.Point(11, 176);
            this.SLBox.Name = "SLBox";
            this.SLBox.Size = new System.Drawing.Size(61, 24);
            this.SLBox.TabIndex = 5;
            this.SLBox.Text = "S(L)";
            this.SLBox.UseVisualStyleBackColor = true;
            // 
            // SRBox
            // 
            this.SRBox.AutoSize = true;
            this.SRBox.Location = new System.Drawing.Point(11, 146);
            this.SRBox.Name = "SRBox";
            this.SRBox.Size = new System.Drawing.Size(63, 24);
            this.SRBox.TabIndex = 4;
            this.SRBox.Text = "S(R)";
            this.SRBox.UseVisualStyleBackColor = true;
            // 
            // FNBox
            // 
            this.FNBox.AutoSize = true;
            this.FNBox.Location = new System.Drawing.Point(11, 116);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(63, 24);
            this.FNBox.TabIndex = 3;
            this.FNBox.Text = "F(N)";
            this.FNBox.UseVisualStyleBackColor = true;
            // 
            // RBox
            // 
            this.RBox.AutoSize = true;
            this.RBox.Location = new System.Drawing.Point(11, 86);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(39, 24);
            this.RBox.TabIndex = 2;
            this.RBox.Text = "R";
            this.RBox.UseVisualStyleBackColor = true;
            // 
            // SBox
            // 
            this.SBox.AutoSize = true;
            this.SBox.Location = new System.Drawing.Point(11, 56);
            this.SBox.Name = "SBox";
            this.SBox.Size = new System.Drawing.Size(38, 24);
            this.SBox.TabIndex = 1;
            this.SBox.Text = "S";
            this.SBox.UseVisualStyleBackColor = true;
            // 
            // FBox
            // 
            this.FBox.AutoSize = true;
            this.FBox.Location = new System.Drawing.Point(11, 26);
            this.FBox.Name = "FBox";
            this.FBox.Size = new System.Drawing.Size(37, 24);
            this.FBox.TabIndex = 0;
            this.FBox.Text = "F";
            this.FBox.UseVisualStyleBackColor = true;
            // 
            // AddWeaponsButton
            // 
            this.AddWeaponsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWeaponsButton.Location = new System.Drawing.Point(531, 357);
            this.AddWeaponsButton.Name = "AddWeaponsButton";
            this.AddWeaponsButton.Size = new System.Drawing.Size(138, 109);
            this.AddWeaponsButton.TabIndex = 9;
            this.AddWeaponsButton.Text = "Finish";
            this.AddWeaponsButton.UseVisualStyleBackColor = true;
            this.AddWeaponsButton.Click += new System.EventHandler(this.AddWeaponsButton_Click);
            // 
            // RemoveWeaponButton
            // 
            this.RemoveWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveWeaponButton.Location = new System.Drawing.Point(519, 208);
            this.RemoveWeaponButton.Name = "RemoveWeaponButton";
            this.RemoveWeaponButton.Size = new System.Drawing.Size(121, 49);
            this.RemoveWeaponButton.TabIndex = 5;
            this.RemoveWeaponButton.Text = "Delete Weapon";
            this.RemoveWeaponButton.UseVisualStyleBackColor = true;
            this.RemoveWeaponButton.Click += new System.EventHandler(this.RemoveWeaponButton_Click);
            // 
            // AddWeaponButton
            // 
            this.AddWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWeaponButton.Location = new System.Drawing.Point(35, 419);
            this.AddWeaponButton.Name = "AddWeaponButton";
            this.AddWeaponButton.Size = new System.Drawing.Size(121, 47);
            this.AddWeaponButton.TabIndex = 4;
            this.AddWeaponButton.Text = "Add Weapon";
            this.AddWeaponButton.UseVisualStyleBackColor = true;
            this.AddWeaponButton.Click += new System.EventHandler(this.AddWeaponButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Weapon";
            // 
            // weaponComboBox
            // 
            this.weaponComboBox.FormattingEnabled = true;
            this.weaponComboBox.Location = new System.Drawing.Point(45, 119);
            this.weaponComboBox.Name = "weaponComboBox";
            this.weaponComboBox.Size = new System.Drawing.Size(317, 21);
            this.weaponComboBox.TabIndex = 2;
            // 
            // ShipName
            // 
            this.ShipName.AutoSize = true;
            this.ShipName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShipName.Location = new System.Drawing.Point(55, 32);
            this.ShipName.Name = "ShipName";
            this.ShipName.Size = new System.Drawing.Size(174, 26);
            this.ShipName.TabIndex = 1;
            this.ShipName.Text = "shipNameLabel";
            // 
            // WeaponListBox
            // 
            this.WeaponListBox.FormattingEnabled = true;
            this.WeaponListBox.Location = new System.Drawing.Point(218, 155);
            this.WeaponListBox.Name = "WeaponListBox";
            this.WeaponListBox.Size = new System.Drawing.Size(275, 225);
            this.WeaponListBox.TabIndex = 0;
            // 
            // EditShipWeaponsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.EVA_Battleship__Routine_Maintenance_3;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "EditShipWeaponsForm";
            this.Text = "EditShipWeaponsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FacingsCheckBox.ResumeLayout(false);
            this.FacingsCheckBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox FacingsCheckBox;
        private System.Windows.Forms.CheckBox SLBox;
        private System.Windows.Forms.CheckBox SRBox;
        private System.Windows.Forms.CheckBox FNBox;
        private System.Windows.Forms.CheckBox RBox;
        private System.Windows.Forms.CheckBox SBox;
        private System.Windows.Forms.CheckBox FBox;
        private System.Windows.Forms.Button AddWeaponsButton;
        private System.Windows.Forms.Button RemoveWeaponButton;
        private System.Windows.Forms.Button AddWeaponButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox weaponComboBox;
        private System.Windows.Forms.Label ShipName;
        private System.Windows.Forms.ListBox WeaponListBox;
    }
}