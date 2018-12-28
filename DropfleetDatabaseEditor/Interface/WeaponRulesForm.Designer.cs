namespace DropfleetDatabaseEditor.Interface
{
    partial class WeaponRulesForm
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
            this.editExistingButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.createNewPanel = new System.Windows.Forms.Panel();
            this.addRuleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newRuleText = new System.Windows.Forms.TextBox();
            this.editExistinPanel = new System.Windows.Forms.Panel();
            this.ruleComboBox = new System.Windows.Forms.ComboBox();
            this.editRuleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editRuleTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.weaponScreenButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.createNewPanel.SuspendLayout();
            this.editExistinPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.editExistingButton);
            this.panel1.Controls.Add(this.createNewButton);
            this.panel1.Location = new System.Drawing.Point(49, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 120);
            this.panel1.TabIndex = 0;
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
            this.editExistingButton.Click += new System.EventHandler(this.editExistingButton_Click);
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
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // createNewPanel
            // 
            this.createNewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createNewPanel.Controls.Add(this.addRuleButton);
            this.createNewPanel.Controls.Add(this.label1);
            this.createNewPanel.Controls.Add(this.newRuleText);
            this.createNewPanel.Location = new System.Drawing.Point(91, 216);
            this.createNewPanel.Name = "createNewPanel";
            this.createNewPanel.Size = new System.Drawing.Size(330, 256);
            this.createNewPanel.TabIndex = 1;
            this.createNewPanel.Visible = false;
            // 
            // addRuleButton
            // 
            this.addRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRuleButton.Location = new System.Drawing.Point(27, 126);
            this.addRuleButton.Name = "addRuleButton";
            this.addRuleButton.Size = new System.Drawing.Size(183, 53);
            this.addRuleButton.TabIndex = 2;
            this.addRuleButton.Text = "Add New Rule";
            this.addRuleButton.UseVisualStyleBackColor = true;
            this.addRuleButton.Click += new System.EventHandler(this.addRuleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rule";
            // 
            // newRuleText
            // 
            this.newRuleText.Location = new System.Drawing.Point(27, 65);
            this.newRuleText.Name = "newRuleText";
            this.newRuleText.Size = new System.Drawing.Size(252, 20);
            this.newRuleText.TabIndex = 0;
            // 
            // editExistinPanel
            // 
            this.editExistinPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editExistinPanel.Controls.Add(this.editRuleButton);
            this.editExistinPanel.Controls.Add(this.label2);
            this.editExistinPanel.Controls.Add(this.editRuleTextBox);
            this.editExistinPanel.Controls.Add(this.ruleComboBox);
            this.editExistinPanel.Location = new System.Drawing.Point(537, 216);
            this.editExistinPanel.Name = "editExistinPanel";
            this.editExistinPanel.Size = new System.Drawing.Size(330, 256);
            this.editExistinPanel.TabIndex = 2;
            this.editExistinPanel.Visible = false;
            // 
            // ruleComboBox
            // 
            this.ruleComboBox.FormattingEnabled = true;
            this.ruleComboBox.Location = new System.Drawing.Point(28, 31);
            this.ruleComboBox.Name = "ruleComboBox";
            this.ruleComboBox.Size = new System.Drawing.Size(172, 21);
            this.ruleComboBox.TabIndex = 0;
            this.ruleComboBox.SelectedIndexChanged += new System.EventHandler(this.ruleComboBox_SelectedIndexChanged);
            // 
            // editRuleButton
            // 
            this.editRuleButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRuleButton.Location = new System.Drawing.Point(28, 168);
            this.editRuleButton.Name = "editRuleButton";
            this.editRuleButton.Size = new System.Drawing.Size(183, 53);
            this.editRuleButton.TabIndex = 5;
            this.editRuleButton.Text = "Edit Rule";
            this.editRuleButton.UseVisualStyleBackColor = true;
            this.editRuleButton.Click += new System.EventHandler(this.editRuleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rule";
            // 
            // editRuleTextBox
            // 
            this.editRuleTextBox.Location = new System.Drawing.Point(28, 107);
            this.editRuleTextBox.Name = "editRuleTextBox";
            this.editRuleTextBox.Size = new System.Drawing.Size(252, 20);
            this.editRuleTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.weaponScreenButton);
            this.panel2.Location = new System.Drawing.Point(118, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 132);
            this.panel2.TabIndex = 3;
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
            this.weaponScreenButton.Click += new System.EventHandler(this.weaponScreenButton_Click);
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
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // WeaponRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editExistinPanel);
            this.Controls.Add(this.createNewPanel);
            this.Controls.Add(this.panel1);
            this.Name = "WeaponRulesForm";
            this.Text = "WeaponRulesForm";
            this.panel1.ResumeLayout(false);
            this.createNewPanel.ResumeLayout(false);
            this.createNewPanel.PerformLayout();
            this.editExistinPanel.ResumeLayout(false);
            this.editExistinPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editExistingButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Panel createNewPanel;
        private System.Windows.Forms.Button addRuleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newRuleText;
        private System.Windows.Forms.Panel editExistinPanel;
        private System.Windows.Forms.Button editRuleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editRuleTextBox;
        private System.Windows.Forms.ComboBox ruleComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button weaponScreenButton;
    }
}