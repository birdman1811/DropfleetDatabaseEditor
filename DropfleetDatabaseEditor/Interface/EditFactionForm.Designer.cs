namespace DropfleetDatabaseEditor.Interface
{
    partial class EditFactionForm
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
            this.factionCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selctButton = new System.Windows.Forms.Button();
            this.editFactionPanel = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.gameplayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IconTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.editFactionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.selctButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.factionCombo);
            this.panel1.Location = new System.Drawing.Point(44, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 289);
            this.panel1.TabIndex = 0;
            // 
            // factionCombo
            // 
            this.factionCombo.FormattingEnabled = true;
            this.factionCombo.Location = new System.Drawing.Point(19, 83);
            this.factionCombo.Name = "factionCombo";
            this.factionCombo.Size = new System.Drawing.Size(121, 21);
            this.factionCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Faction";
            // 
            // selctButton
            // 
            this.selctButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctButton.Location = new System.Drawing.Point(20, 137);
            this.selctButton.Name = "selctButton";
            this.selctButton.Size = new System.Drawing.Size(120, 71);
            this.selctButton.TabIndex = 2;
            this.selctButton.Text = "Edit Faction";
            this.selctButton.UseVisualStyleBackColor = true;
            this.selctButton.Click += new System.EventHandler(this.SelctButton_Click);
            // 
            // editFactionPanel
            // 
            this.editFactionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editFactionPanel.Controls.Add(this.saveButton);
            this.editFactionPanel.Controls.Add(this.gameplayTextBox);
            this.editFactionPanel.Controls.Add(this.label4);
            this.editFactionPanel.Controls.Add(this.loreTextBox);
            this.editFactionPanel.Controls.Add(this.label3);
            this.editFactionPanel.Controls.Add(this.IconTextBox);
            this.editFactionPanel.Controls.Add(this.label2);
            this.editFactionPanel.Controls.Add(this.nameTextBox);
            this.editFactionPanel.Controls.Add(this.label5);
            this.editFactionPanel.Location = new System.Drawing.Point(228, 42);
            this.editFactionPanel.Name = "editFactionPanel";
            this.editFactionPanel.Size = new System.Drawing.Size(732, 593);
            this.editFactionPanel.TabIndex = 1;
            this.editFactionPanel.Visible = false;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(8, 114);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(192, 87);
            this.mainMenuButton.TabIndex = 10;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(8, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 87);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Faction Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(516, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 87);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Faction";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // gameplayTextBox
            // 
            this.gameplayTextBox.Location = new System.Drawing.Point(41, 429);
            this.gameplayTextBox.Multiline = true;
            this.gameplayTextBox.Name = "gameplayTextBox";
            this.gameplayTextBox.Size = new System.Drawing.Size(453, 123);
            this.gameplayTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Faction Gameplay";
            // 
            // loreTextBox
            // 
            this.loreTextBox.Location = new System.Drawing.Point(41, 264);
            this.loreTextBox.Multiline = true;
            this.loreTextBox.Name = "loreTextBox";
            this.loreTextBox.Size = new System.Drawing.Size(453, 120);
            this.loreTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Faction Lore";
            // 
            // IconTextBox
            // 
            this.IconTextBox.Location = new System.Drawing.Point(41, 179);
            this.IconTextBox.Name = "IconTextBox";
            this.IconTextBox.Size = new System.Drawing.Size(453, 20);
            this.IconTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faction Icon URL";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(41, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(129, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(42, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Faction Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(12, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 224);
            this.panel2.TabIndex = 2;
            // 
            // EditFactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.spaceships_abandonned_space_station_ultimate_finale;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editFactionPanel);
            this.Controls.Add(this.panel1);
            this.Name = "EditFactionForm";
            this.Text = "EditFactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editFactionPanel.ResumeLayout(false);
            this.editFactionPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selctButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox factionCombo;
        private System.Windows.Forms.Panel editFactionPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox gameplayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IconTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
    }
}