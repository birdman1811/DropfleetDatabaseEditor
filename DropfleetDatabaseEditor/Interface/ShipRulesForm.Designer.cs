namespace DropfleetDatabaseEditor.Interface
{
    partial class ShipRulesForm
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
            this.shipScreenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editExistingButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.createNewPanel = new System.Windows.Forms.Panel();
            this.saveNewRuleBUtton = new System.Windows.Forms.Button();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ruleComboBox = new System.Windows.Forms.ComboBox();
            this.SaveEditedRuleButton = new System.Windows.Forms.Button();
            this.editRuleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.createNewPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.shipScreenButton);
            this.panel2.Location = new System.Drawing.Point(670, 506);
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
            // shipScreenButton
            // 
            this.shipScreenButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipScreenButton.Location = new System.Drawing.Point(18, 19);
            this.shipScreenButton.Name = "shipScreenButton";
            this.shipScreenButton.Size = new System.Drawing.Size(114, 90);
            this.shipScreenButton.TabIndex = 0;
            this.shipScreenButton.Text = "Back to Ships Screen";
            this.shipScreenButton.UseVisualStyleBackColor = true;
            this.shipScreenButton.Click += new System.EventHandler(this.ShipScreenButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.editExistingButton);
            this.panel1.Controls.Add(this.createNewButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 120);
            this.panel1.TabIndex = 7;
            // 
            // editExistingButton
            // 
            this.editExistingButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editExistingButton.Location = new System.Drawing.Point(12, 60);
            this.editExistingButton.Name = "editExistingButton";
            this.editExistingButton.Size = new System.Drawing.Size(103, 38);
            this.editExistingButton.TabIndex = 1;
            this.editExistingButton.Text = "Edit";
            this.editExistingButton.UseVisualStyleBackColor = true;
            this.editExistingButton.Click += new System.EventHandler(this.EditExistingButton_Click);
            // 
            // createNewButton
            // 
            this.createNewButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewButton.Location = new System.Drawing.Point(12, 15);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(103, 39);
            this.createNewButton.TabIndex = 0;
            this.createNewButton.Text = "Create";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // createNewPanel
            // 
            this.createNewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createNewPanel.Controls.Add(this.saveNewRuleBUtton);
            this.createNewPanel.Controls.Add(this.ruleTextBox);
            this.createNewPanel.Controls.Add(this.label1);
            this.createNewPanel.Location = new System.Drawing.Point(91, 168);
            this.createNewPanel.Name = "createNewPanel";
            this.createNewPanel.Size = new System.Drawing.Size(262, 306);
            this.createNewPanel.TabIndex = 8;
            this.createNewPanel.Visible = false;
            // 
            // saveNewRuleBUtton
            // 
            this.saveNewRuleBUtton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewRuleBUtton.Location = new System.Drawing.Point(58, 171);
            this.saveNewRuleBUtton.Name = "saveNewRuleBUtton";
            this.saveNewRuleBUtton.Size = new System.Drawing.Size(165, 69);
            this.saveNewRuleBUtton.TabIndex = 2;
            this.saveNewRuleBUtton.Text = "Save New Rule";
            this.saveNewRuleBUtton.UseVisualStyleBackColor = true;
            this.saveNewRuleBUtton.Click += new System.EventHandler(this.SaveNewRuleBUtton_Click);
            // 
            // ruleTextBox
            // 
            this.ruleTextBox.Location = new System.Drawing.Point(58, 94);
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.Size = new System.Drawing.Size(165, 20);
            this.ruleTextBox.TabIndex = 1;
            this.ruleTextBox.TextChanged += new System.EventHandler(this.RuleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ship Rule Text";
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.ruleComboBox);
            this.editPanel.Controls.Add(this.SaveEditedRuleButton);
            this.editPanel.Controls.Add(this.editRuleTextBox);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Location = new System.Drawing.Point(475, 86);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(262, 402);
            this.editPanel.TabIndex = 9;
            this.editPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(47, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Rule";
            // 
            // ruleComboBox
            // 
            this.ruleComboBox.FormattingEnabled = true;
            this.ruleComboBox.Location = new System.Drawing.Point(51, 82);
            this.ruleComboBox.Name = "ruleComboBox";
            this.ruleComboBox.Size = new System.Drawing.Size(165, 21);
            this.ruleComboBox.TabIndex = 6;
            this.ruleComboBox.SelectedIndexChanged += new System.EventHandler(this.RuleComboBox_SelectedIndexChanged);
            // 
            // SaveEditedRuleButton
            // 
            this.SaveEditedRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEditedRuleButton.Location = new System.Drawing.Point(51, 285);
            this.SaveEditedRuleButton.Name = "SaveEditedRuleButton";
            this.SaveEditedRuleButton.Size = new System.Drawing.Size(165, 69);
            this.SaveEditedRuleButton.TabIndex = 5;
            this.SaveEditedRuleButton.Text = "Edit Rule";
            this.SaveEditedRuleButton.UseVisualStyleBackColor = true;
            this.SaveEditedRuleButton.Click += new System.EventHandler(this.SaveEditedRuleButton_Click);
            // 
            // editRuleTextBox
            // 
            this.editRuleTextBox.Location = new System.Drawing.Point(51, 208);
            this.editRuleTextBox.Name = "editRuleTextBox";
            this.editRuleTextBox.Size = new System.Drawing.Size(165, 20);
            this.editRuleTextBox.TabIndex = 4;
            this.editRuleTextBox.TextChanged += new System.EventHandler(this.EditRuleTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ship Rule Text";
            // 
            // ShipRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.createNewPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ShipRulesForm";
            this.Text = "ShipRulesForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.createNewPanel.ResumeLayout(false);
            this.createNewPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button shipScreenButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editExistingButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Panel createNewPanel;
        private System.Windows.Forms.Button saveNewRuleBUtton;
        private System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ruleComboBox;
        private System.Windows.Forms.Button SaveEditedRuleButton;
        private System.Windows.Forms.TextBox editRuleTextBox;
        private System.Windows.Forms.Label label2;
    }
}