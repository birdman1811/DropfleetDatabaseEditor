namespace DropfleetDatabaseEditor.Interface
{
    partial class MainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.factionControlButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.shipsButton = new System.Windows.Forms.Button();
            this.miscellaneousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.DFC_logo_colour_whiteBG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // factionControlButton
            // 
            this.factionControlButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factionControlButton.Location = new System.Drawing.Point(158, 178);
            this.factionControlButton.Name = "factionControlButton";
            this.factionControlButton.Size = new System.Drawing.Size(143, 71);
            this.factionControlButton.TabIndex = 1;
            this.factionControlButton.Text = "Factions";
            this.factionControlButton.UseVisualStyleBackColor = true;
            // 
            // usersButton
            // 
            this.usersButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Location = new System.Drawing.Point(158, 284);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(143, 71);
            this.usersButton.TabIndex = 2;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            // 
            // shipsButton
            // 
            this.shipsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipsButton.Location = new System.Drawing.Point(692, 178);
            this.shipsButton.Name = "shipsButton";
            this.shipsButton.Size = new System.Drawing.Size(143, 71);
            this.shipsButton.TabIndex = 3;
            this.shipsButton.Text = "Ships";
            this.shipsButton.UseVisualStyleBackColor = true;
            // 
            // miscellaneousButton
            // 
            this.miscellaneousButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellaneousButton.Location = new System.Drawing.Point(692, 284);
            this.miscellaneousButton.Name = "miscellaneousButton";
            this.miscellaneousButton.Size = new System.Drawing.Size(143, 71);
            this.miscellaneousButton.TabIndex = 4;
            this.miscellaneousButton.Text = "Misscelaneous";
            this.miscellaneousButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.BOX_Cover_DROPFLEET_Commander_Final;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.miscellaneousButton);
            this.Controls.Add(this.shipsButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.factionControlButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button factionControlButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button shipsButton;
        private System.Windows.Forms.Button miscellaneousButton;
    }
}