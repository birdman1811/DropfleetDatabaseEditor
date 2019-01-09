namespace DropfleetDatabaseEditor.Interface
{
    partial class ShipControlForm
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
            this.ShipBuilderButton = new System.Windows.Forms.Button();
            this.ShipRulesButton = new System.Windows.Forms.Button();
            this.tonnageButton = new System.Windows.Forms.Button();
            this.weaponsControlButton = new System.Windows.Forms.Button();
            this.EditShipButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.EditShipButton);
            this.panel1.Controls.Add(this.ShipBuilderButton);
            this.panel1.Controls.Add(this.ShipRulesButton);
            this.panel1.Controls.Add(this.tonnageButton);
            this.panel1.Controls.Add(this.weaponsControlButton);
            this.panel1.Location = new System.Drawing.Point(162, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 400);
            this.panel1.TabIndex = 0;
            // 
            // ShipBuilderButton
            // 
            this.ShipBuilderButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipBuilderButton.Location = new System.Drawing.Point(139, 224);
            this.ShipBuilderButton.Name = "ShipBuilderButton";
            this.ShipBuilderButton.Size = new System.Drawing.Size(112, 60);
            this.ShipBuilderButton.TabIndex = 3;
            this.ShipBuilderButton.Text = "Build a Ship";
            this.ShipBuilderButton.UseVisualStyleBackColor = true;
            this.ShipBuilderButton.Click += new System.EventHandler(this.ShipBuilderButton_Click);
            // 
            // ShipRulesButton
            // 
            this.ShipRulesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipRulesButton.Location = new System.Drawing.Point(398, 134);
            this.ShipRulesButton.Name = "ShipRulesButton";
            this.ShipRulesButton.Size = new System.Drawing.Size(112, 60);
            this.ShipRulesButton.TabIndex = 2;
            this.ShipRulesButton.Text = "Ship Rules";
            this.ShipRulesButton.UseVisualStyleBackColor = true;
            this.ShipRulesButton.Click += new System.EventHandler(this.ShipRulesButton_Click);
            // 
            // tonnageButton
            // 
            this.tonnageButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonnageButton.Location = new System.Drawing.Point(271, 134);
            this.tonnageButton.Name = "tonnageButton";
            this.tonnageButton.Size = new System.Drawing.Size(112, 60);
            this.tonnageButton.TabIndex = 1;
            this.tonnageButton.Text = "Tonnage";
            this.tonnageButton.UseVisualStyleBackColor = true;
            this.tonnageButton.Click += new System.EventHandler(this.TonnageButton_Click);
            // 
            // weaponsControlButton
            // 
            this.weaponsControlButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponsControlButton.Location = new System.Drawing.Point(139, 134);
            this.weaponsControlButton.Name = "weaponsControlButton";
            this.weaponsControlButton.Size = new System.Drawing.Size(112, 60);
            this.weaponsControlButton.TabIndex = 0;
            this.weaponsControlButton.Text = "Weapons";
            this.weaponsControlButton.UseVisualStyleBackColor = true;
            this.weaponsControlButton.Click += new System.EventHandler(this.WeaponsControlButton_Click);
            // 
            // EditShipButton
            // 
            this.EditShipButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShipButton.Location = new System.Drawing.Point(271, 224);
            this.EditShipButton.Name = "EditShipButton";
            this.EditShipButton.Size = new System.Drawing.Size(112, 60);
            this.EditShipButton.TabIndex = 4;
            this.EditShipButton.Text = "Edit a Ship";
            this.EditShipButton.UseVisualStyleBackColor = true;
            this.EditShipButton.Click += new System.EventHandler(this.EditShipButton_Click);
            // 
            // ShipControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "ShipControlForm";
            this.Text = "ShipControlForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button weaponsControlButton;
        private System.Windows.Forms.Button tonnageButton;
        private System.Windows.Forms.Button ShipRulesButton;
        private System.Windows.Forms.Button ShipBuilderButton;
        private System.Windows.Forms.Button EditShipButton;
    }
}