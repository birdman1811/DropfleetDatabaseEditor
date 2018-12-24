namespace DropfleetDatabaseEditor.Interface
{
    partial class FactionMenu
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.editFactionButton = new System.Windows.Forms.Button();
            this.createFactionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mainMenuButton);
            this.panel1.Controls.Add(this.editFactionButton);
            this.panel1.Controls.Add(this.createFactionButton);
            this.panel1.Location = new System.Drawing.Point(393, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 429);
            this.panel1.TabIndex = 0;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(55, 255);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(182, 71);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // editFactionButton
            // 
            this.editFactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFactionButton.Location = new System.Drawing.Point(55, 145);
            this.editFactionButton.Name = "editFactionButton";
            this.editFactionButton.Size = new System.Drawing.Size(182, 71);
            this.editFactionButton.TabIndex = 1;
            this.editFactionButton.Text = "Edit Faction";
            this.editFactionButton.UseVisualStyleBackColor = true;
            this.editFactionButton.Click += new System.EventHandler(this.EditFactionButton_Click);
            // 
            // createFactionButton
            // 
            this.createFactionButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFactionButton.Location = new System.Drawing.Point(55, 53);
            this.createFactionButton.Name = "createFactionButton";
            this.createFactionButton.Size = new System.Drawing.Size(182, 71);
            this.createFactionButton.TabIndex = 0;
            this.createFactionButton.Text = "Create Faction";
            this.createFactionButton.UseVisualStyleBackColor = true;
            this.createFactionButton.Click += new System.EventHandler(this.CreateFactionButton_Click);
            // 
            // FactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.BOX_Cover_DROPFLEET_Commander_Final;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "FactionMenu";
            this.Text = "FactionMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button editFactionButton;
        private System.Windows.Forms.Button createFactionButton;
    }
}