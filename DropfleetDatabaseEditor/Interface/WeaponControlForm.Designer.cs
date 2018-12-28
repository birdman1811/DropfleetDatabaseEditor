namespace DropfleetDatabaseEditor.Interface
{
    partial class WeaponControlForm
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
            this.addWeapons = new System.Windows.Forms.Button();
            this.weaponRulesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.addWeapons);
            this.panel1.Controls.Add(this.weaponRulesButton);
            this.panel1.Location = new System.Drawing.Point(123, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 396);
            this.panel1.TabIndex = 0;
            // 
            // addWeapons
            // 
            this.addWeapons.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWeapons.Location = new System.Drawing.Point(256, 99);
            this.addWeapons.Name = "addWeapons";
            this.addWeapons.Size = new System.Drawing.Size(125, 70);
            this.addWeapons.TabIndex = 1;
            this.addWeapons.Text = "Add Weapons";
            this.addWeapons.UseVisualStyleBackColor = true;
            this.addWeapons.Click += new System.EventHandler(this.AddWeapons_Click);
            // 
            // weaponRulesButton
            // 
            this.weaponRulesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponRulesButton.Location = new System.Drawing.Point(81, 99);
            this.weaponRulesButton.Name = "weaponRulesButton";
            this.weaponRulesButton.Size = new System.Drawing.Size(125, 70);
            this.weaponRulesButton.TabIndex = 0;
            this.weaponRulesButton.Text = "Weapon Rules";
            this.weaponRulesButton.UseVisualStyleBackColor = true;
            this.weaponRulesButton.Click += new System.EventHandler(this.WeaponRulesButton_Click);
            // 
            // WeaponControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "WeaponControlForm";
            this.Text = "WeaponControlForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button weaponRulesButton;
        private System.Windows.Forms.Button addWeapons;
    }
}