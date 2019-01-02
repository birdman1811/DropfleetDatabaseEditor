namespace DropfleetDatabaseEditor.Interface
{
    partial class AddWeaponForm
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.weaponScreenButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttackTextBox = new System.Windows.Forms.TextBox();
            this.addWeaponButton = new System.Windows.Forms.Button();
            this.deleteRuleButton = new System.Windows.Forms.Button();
            this.updateRuleAmountButton = new System.Windows.Forms.Button();
            this.editRuleAmountSelector = new System.Windows.Forms.NumericUpDown();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.ruleAmountSelect = new System.Windows.Forms.NumericUpDown();
            this.weaponRuleComboBox = new System.Windows.Forms.ComboBox();
            this.specialRulesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.damageSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lockValueSelect = new System.Windows.Forms.NumericUpDown();
            this.factionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRuleAmountSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAmountSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockValueSelect)).BeginInit();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.weaponScreenButton);
            this.panel2.Location = new System.Drawing.Point(598, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 132);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.AttackTextBox);
            this.panel1.Controls.Add(this.addWeaponButton);
            this.panel1.Controls.Add(this.deleteRuleButton);
            this.panel1.Controls.Add(this.updateRuleAmountButton);
            this.panel1.Controls.Add(this.editRuleAmountSelector);
            this.panel1.Controls.Add(this.addRuleButton);
            this.panel1.Controls.Add(this.ruleAmountSelect);
            this.panel1.Controls.Add(this.weaponRuleComboBox);
            this.panel1.Controls.Add(this.specialRulesListBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.damageSelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lockValueSelect);
            this.panel1.Controls.Add(this.factionComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(77, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 370);
            this.panel1.TabIndex = 5;
            // 
            // AttackTextBox
            // 
            this.AttackTextBox.Location = new System.Drawing.Point(319, 124);
            this.AttackTextBox.Name = "AttackTextBox";
            this.AttackTextBox.Size = new System.Drawing.Size(121, 20);
            this.AttackTextBox.TabIndex = 18;
            this.AttackTextBox.TextChanged += new System.EventHandler(this.AttackTextBox_TextChanged);
            // 
            // addWeaponButton
            // 
            this.addWeaponButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWeaponButton.Location = new System.Drawing.Point(433, 272);
            this.addWeaponButton.Name = "addWeaponButton";
            this.addWeaponButton.Size = new System.Drawing.Size(252, 68);
            this.addWeaponButton.TabIndex = 17;
            this.addWeaponButton.Text = "Add Weapon";
            this.addWeaponButton.UseVisualStyleBackColor = true;
            this.addWeaponButton.Click += new System.EventHandler(this.AddWeaponButton_Click);
            // 
            // deleteRuleButton
            // 
            this.deleteRuleButton.Location = new System.Drawing.Point(564, 196);
            this.deleteRuleButton.Name = "deleteRuleButton";
            this.deleteRuleButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRuleButton.TabIndex = 16;
            this.deleteRuleButton.Text = "Delete Rule";
            this.deleteRuleButton.UseVisualStyleBackColor = true;
            this.deleteRuleButton.Click += new System.EventHandler(this.DeleteRuleButton_Click);
            // 
            // updateRuleAmountButton
            // 
            this.updateRuleAmountButton.Location = new System.Drawing.Point(522, 150);
            this.updateRuleAmountButton.Name = "updateRuleAmountButton";
            this.updateRuleAmountButton.Size = new System.Drawing.Size(117, 23);
            this.updateRuleAmountButton.TabIndex = 15;
            this.updateRuleAmountButton.Text = "Update Rule Amount";
            this.updateRuleAmountButton.UseVisualStyleBackColor = true;
            this.updateRuleAmountButton.Click += new System.EventHandler(this.UpdateRuleAmountButton_Click);
            // 
            // editRuleAmountSelector
            // 
            this.editRuleAmountSelector.Location = new System.Drawing.Point(590, 124);
            this.editRuleAmountSelector.Name = "editRuleAmountSelector";
            this.editRuleAmountSelector.Size = new System.Drawing.Size(49, 20);
            this.editRuleAmountSelector.TabIndex = 14;
            this.editRuleAmountSelector.ValueChanged += new System.EventHandler(this.editRuleAmountSelector_ValueChanged);
            // 
            // addRuleButton
            // 
            this.addRuleButton.Location = new System.Drawing.Point(650, 85);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(75, 23);
            this.addRuleButton.TabIndex = 13;
            this.addRuleButton.Text = "Add Rule";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // ruleAmountSelect
            // 
            this.ruleAmountSelect.Location = new System.Drawing.Point(701, 52);
            this.ruleAmountSelect.Name = "ruleAmountSelect";
            this.ruleAmountSelect.Size = new System.Drawing.Size(49, 20);
            this.ruleAmountSelect.TabIndex = 12;
            this.ruleAmountSelect.ValueChanged += new System.EventHandler(this.ruleAmountSelect_ValueChanged);
            // 
            // weaponRuleComboBox
            // 
            this.weaponRuleComboBox.FormattingEnabled = true;
            this.weaponRuleComboBox.Location = new System.Drawing.Point(564, 52);
            this.weaponRuleComboBox.Name = "weaponRuleComboBox";
            this.weaponRuleComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponRuleComboBox.TabIndex = 11;
            this.weaponRuleComboBox.SelectedIndexChanged += new System.EventHandler(this.weaponRuleComboBox_SelectedIndexChanged);
            // 
            // specialRulesListBox
            // 
            this.specialRulesListBox.FormattingEnabled = true;
            this.specialRulesListBox.Location = new System.Drawing.Point(660, 124);
            this.specialRulesListBox.Name = "specialRulesListBox";
            this.specialRulesListBox.Size = new System.Drawing.Size(120, 95);
            this.specialRulesListBox.TabIndex = 10;
            this.specialRulesListBox.SelectedIndexChanged += new System.EventHandler(this.specialRulesListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(315, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(315, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Damage";
            // 
            // damageSelect
            // 
            this.damageSelect.Location = new System.Drawing.Point(320, 206);
            this.damageSelect.Name = "damageSelect";
            this.damageSelect.Size = new System.Drawing.Size(120, 20);
            this.damageSelect.TabIndex = 6;
            this.damageSelect.ValueChanged += new System.EventHandler(this.DamageSelect_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(315, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lock Value";
            // 
            // lockValueSelect
            // 
            this.lockValueSelect.Location = new System.Drawing.Point(319, 63);
            this.lockValueSelect.Name = "lockValueSelect";
            this.lockValueSelect.Size = new System.Drawing.Size(120, 20);
            this.lockValueSelect.TabIndex = 4;
            this.lockValueSelect.ValueChanged += new System.EventHandler(this.LockValueSelect_ValueChanged);
            // 
            // factionComboBox
            // 
            this.factionComboBox.FormattingEnabled = true;
            this.factionComboBox.Location = new System.Drawing.Point(32, 146);
            this.factionComboBox.Name = "factionComboBox";
            this.factionComboBox.Size = new System.Drawing.Size(121, 21);
            this.factionComboBox.TabIndex = 3;
            this.factionComboBox.SelectedIndexChanged += new System.EventHandler(this.FactionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weapon Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(32, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AddWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddWeaponForm";
            this.Text = "AddWeaponForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editRuleAmountSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleAmountSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockValueSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button weaponScreenButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lockValueSelect;
        private System.Windows.Forms.ComboBox factionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addWeaponButton;
        private System.Windows.Forms.Button deleteRuleButton;
        private System.Windows.Forms.Button updateRuleAmountButton;
        private System.Windows.Forms.NumericUpDown editRuleAmountSelector;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.NumericUpDown ruleAmountSelect;
        private System.Windows.Forms.ComboBox weaponRuleComboBox;
        private System.Windows.Forms.ListBox specialRulesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown damageSelect;
        private System.Windows.Forms.TextBox AttackTextBox;
    }
}