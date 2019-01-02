namespace DropfleetDatabaseEditor.Interface
{
    partial class EditWeaponForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.weaponScreenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectWeaponButton = new System.Windows.Forms.Button();
            this.weaponComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.factionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponStatsPanel = new System.Windows.Forms.Panel();
            this.editRulesButton = new System.Windows.Forms.Button();
            this.weaponFactionComboBox = new System.Windows.Forms.ComboBox();
            this.saveWeaponButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AttackTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.damageSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lockValueSelect = new System.Windows.Forms.NumericUpDown();
            this.weaponRulesPanel = new System.Windows.Forms.Panel();
            this.deleteRuleButton = new System.Windows.Forms.Button();
            this.updateRuleAmountButton = new System.Windows.Forms.Button();
            this.editRuleAmountSelector = new System.Windows.Forms.NumericUpDown();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.ruleAmountSelect = new System.Windows.Forms.NumericUpDown();
            this.weaponRuleComboBox = new System.Windows.Forms.ComboBox();
            this.specialRulesListBox = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.weaponStatsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockValueSelect)).BeginInit();
            this.weaponRulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRuleAmountSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAmountSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.weaponScreenButton);
            this.panel2.Location = new System.Drawing.Point(681, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 132);
            this.panel2.TabIndex = 5;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(157, 19);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(114, 90);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "Back to Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // weaponScreenButton
            // 
            this.weaponScreenButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponScreenButton.Location = new System.Drawing.Point(18, 19);
            this.weaponScreenButton.Name = "weaponScreenButton";
            this.weaponScreenButton.Size = new System.Drawing.Size(114, 90);
            this.weaponScreenButton.TabIndex = 0;
            this.weaponScreenButton.Text = "Back to Weapons Screen";
            this.weaponScreenButton.UseVisualStyleBackColor = true;
            this.weaponScreenButton.Click += new System.EventHandler(this.WeaponScreenButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.selectWeaponButton);
            this.panel1.Controls.Add(this.weaponComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.factionComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 269);
            this.panel1.TabIndex = 6;
            // 
            // selectWeaponButton
            // 
            this.selectWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectWeaponButton.Location = new System.Drawing.Point(22, 193);
            this.selectWeaponButton.Name = "selectWeaponButton";
            this.selectWeaponButton.Size = new System.Drawing.Size(121, 62);
            this.selectWeaponButton.TabIndex = 4;
            this.selectWeaponButton.Text = "Select Weapon";
            this.selectWeaponButton.UseVisualStyleBackColor = true;
            this.selectWeaponButton.Click += new System.EventHandler(this.SelectWeaponButton_Click);
            // 
            // weaponComboBox
            // 
            this.weaponComboBox.FormattingEnabled = true;
            this.weaponComboBox.Location = new System.Drawing.Point(23, 153);
            this.weaponComboBox.Name = "weaponComboBox";
            this.weaponComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponComboBox.TabIndex = 3;
            this.weaponComboBox.SelectedIndexChanged += new System.EventHandler(this.WeaponComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weapon";
            // 
            // factionComboBox
            // 
            this.factionComboBox.FormattingEnabled = true;
            this.factionComboBox.Location = new System.Drawing.Point(22, 66);
            this.factionComboBox.Name = "factionComboBox";
            this.factionComboBox.Size = new System.Drawing.Size(121, 21);
            this.factionComboBox.TabIndex = 1;
            this.factionComboBox.SelectedIndexChanged += new System.EventHandler(this.FactionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faction";
            // 
            // weaponStatsPanel
            // 
            this.weaponStatsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.weaponStatsPanel.Controls.Add(this.editRulesButton);
            this.weaponStatsPanel.Controls.Add(this.weaponFactionComboBox);
            this.weaponStatsPanel.Controls.Add(this.saveWeaponButton);
            this.weaponStatsPanel.Controls.Add(this.label7);
            this.weaponStatsPanel.Controls.Add(this.label6);
            this.weaponStatsPanel.Controls.Add(this.AttackTextBox);
            this.weaponStatsPanel.Controls.Add(this.nameTextBox);
            this.weaponStatsPanel.Controls.Add(this.label5);
            this.weaponStatsPanel.Controls.Add(this.label4);
            this.weaponStatsPanel.Controls.Add(this.damageSelect);
            this.weaponStatsPanel.Controls.Add(this.label3);
            this.weaponStatsPanel.Controls.Add(this.lockValueSelect);
            this.weaponStatsPanel.Location = new System.Drawing.Point(173, 31);
            this.weaponStatsPanel.Name = "weaponStatsPanel";
            this.weaponStatsPanel.Size = new System.Drawing.Size(345, 491);
            this.weaponStatsPanel.TabIndex = 7;
            this.weaponStatsPanel.Visible = false;
            // 
            // editRulesButton
            // 
            this.editRulesButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRulesButton.Location = new System.Drawing.Point(173, 378);
            this.editRulesButton.Name = "editRulesButton";
            this.editRulesButton.Size = new System.Drawing.Size(119, 92);
            this.editRulesButton.TabIndex = 30;
            this.editRulesButton.Text = "Save Stats and Edit Weapon Rules";
            this.editRulesButton.UseVisualStyleBackColor = true;
            this.editRulesButton.Click += new System.EventHandler(this.EditRulesButton_Click);
            // 
            // weaponFactionComboBox
            // 
            this.weaponFactionComboBox.FormattingEnabled = true;
            this.weaponFactionComboBox.Location = new System.Drawing.Point(24, 134);
            this.weaponFactionComboBox.Name = "weaponFactionComboBox";
            this.weaponFactionComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponFactionComboBox.TabIndex = 29;
            this.weaponFactionComboBox.SelectedIndexChanged += new System.EventHandler(this.WeaponFactionComboBox_SelectedIndexChanged);
            // 
            // saveWeaponButton
            // 
            this.saveWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWeaponButton.Location = new System.Drawing.Point(24, 378);
            this.saveWeaponButton.Name = "saveWeaponButton";
            this.saveWeaponButton.Size = new System.Drawing.Size(120, 92);
            this.saveWeaponButton.TabIndex = 25;
            this.saveWeaponButton.Text = "Save Weapon Stats, keep Rules";
            this.saveWeaponButton.UseVisualStyleBackColor = true;
            this.saveWeaponButton.Click += new System.EventHandler(this.SaveWeaponButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Weapon Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Faction";
            // 
            // AttackTextBox
            // 
            this.AttackTextBox.Location = new System.Drawing.Point(24, 270);
            this.AttackTextBox.Name = "AttackTextBox";
            this.AttackTextBox.Size = new System.Drawing.Size(121, 20);
            this.AttackTextBox.TabIndex = 24;
            this.AttackTextBox.TextChanged += new System.EventHandler(this.AttackTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(24, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 26;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Attack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Damage";
            // 
            // damageSelect
            // 
            this.damageSelect.Location = new System.Drawing.Point(25, 352);
            this.damageSelect.Name = "damageSelect";
            this.damageSelect.Size = new System.Drawing.Size(120, 20);
            this.damageSelect.TabIndex = 21;
            this.damageSelect.ValueChanged += new System.EventHandler(this.DamageSelect_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lock Value";
            // 
            // lockValueSelect
            // 
            this.lockValueSelect.Location = new System.Drawing.Point(24, 209);
            this.lockValueSelect.Name = "lockValueSelect";
            this.lockValueSelect.Size = new System.Drawing.Size(120, 20);
            this.lockValueSelect.TabIndex = 19;
            this.lockValueSelect.ValueChanged += new System.EventHandler(this.LockValueSelect_ValueChanged);
            // 
            // weaponRulesPanel
            // 
            this.weaponRulesPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.weaponRulesPanel.Controls.Add(this.deleteRuleButton);
            this.weaponRulesPanel.Controls.Add(this.updateRuleAmountButton);
            this.weaponRulesPanel.Controls.Add(this.editRuleAmountSelector);
            this.weaponRulesPanel.Controls.Add(this.addRuleButton);
            this.weaponRulesPanel.Controls.Add(this.ruleAmountSelect);
            this.weaponRulesPanel.Controls.Add(this.weaponRuleComboBox);
            this.weaponRulesPanel.Controls.Add(this.specialRulesListBox);
            this.weaponRulesPanel.Location = new System.Drawing.Point(549, 31);
            this.weaponRulesPanel.Name = "weaponRulesPanel";
            this.weaponRulesPanel.Size = new System.Drawing.Size(423, 491);
            this.weaponRulesPanel.TabIndex = 8;
            this.weaponRulesPanel.Visible = false;
            // 
            // deleteRuleButton
            // 
            this.deleteRuleButton.Location = new System.Drawing.Point(104, 225);
            this.deleteRuleButton.Name = "deleteRuleButton";
            this.deleteRuleButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRuleButton.TabIndex = 23;
            this.deleteRuleButton.Text = "Delete Rule";
            this.deleteRuleButton.UseVisualStyleBackColor = true;
            // 
            // updateRuleAmountButton
            // 
            this.updateRuleAmountButton.Location = new System.Drawing.Point(62, 179);
            this.updateRuleAmountButton.Name = "updateRuleAmountButton";
            this.updateRuleAmountButton.Size = new System.Drawing.Size(117, 23);
            this.updateRuleAmountButton.TabIndex = 22;
            this.updateRuleAmountButton.Text = "Update Rule Amount";
            this.updateRuleAmountButton.UseVisualStyleBackColor = true;
            // 
            // editRuleAmountSelector
            // 
            this.editRuleAmountSelector.Location = new System.Drawing.Point(130, 153);
            this.editRuleAmountSelector.Name = "editRuleAmountSelector";
            this.editRuleAmountSelector.Size = new System.Drawing.Size(49, 20);
            this.editRuleAmountSelector.TabIndex = 21;
            // 
            // addRuleButton
            // 
            this.addRuleButton.Location = new System.Drawing.Point(190, 114);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(75, 23);
            this.addRuleButton.TabIndex = 20;
            this.addRuleButton.Text = "Add Rule";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // ruleAmountSelect
            // 
            this.ruleAmountSelect.Location = new System.Drawing.Point(241, 81);
            this.ruleAmountSelect.Name = "ruleAmountSelect";
            this.ruleAmountSelect.Size = new System.Drawing.Size(49, 20);
            this.ruleAmountSelect.TabIndex = 19;
            // 
            // weaponRuleComboBox
            // 
            this.weaponRuleComboBox.FormattingEnabled = true;
            this.weaponRuleComboBox.Location = new System.Drawing.Point(104, 81);
            this.weaponRuleComboBox.Name = "weaponRuleComboBox";
            this.weaponRuleComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponRuleComboBox.TabIndex = 18;
            // 
            // specialRulesListBox
            // 
            this.specialRulesListBox.FormattingEnabled = true;
            this.specialRulesListBox.Location = new System.Drawing.Point(200, 153);
            this.specialRulesListBox.Name = "specialRulesListBox";
            this.specialRulesListBox.Size = new System.Drawing.Size(120, 95);
            this.specialRulesListBox.TabIndex = 17;
            // 
            // EditWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.weaponRulesPanel);
            this.Controls.Add(this.weaponStatsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditWeaponForm";
            this.Text = "EditWeaponForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.weaponStatsPanel.ResumeLayout(false);
            this.weaponStatsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockValueSelect)).EndInit();
            this.weaponRulesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editRuleAmountSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAmountSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button weaponScreenButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectWeaponButton;
        private System.Windows.Forms.ComboBox weaponComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox factionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel weaponStatsPanel;
        private System.Windows.Forms.Panel weaponRulesPanel;
        private System.Windows.Forms.Button saveWeaponButton;
        private System.Windows.Forms.TextBox AttackTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown damageSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lockValueSelect;
        private System.Windows.Forms.ComboBox weaponFactionComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button editRulesButton;
        private System.Windows.Forms.Button deleteRuleButton;
        private System.Windows.Forms.Button updateRuleAmountButton;
        private System.Windows.Forms.NumericUpDown editRuleAmountSelector;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.NumericUpDown ruleAmountSelect;
        private System.Windows.Forms.ComboBox weaponRuleComboBox;
        private System.Windows.Forms.ListBox specialRulesListBox;
    }
}