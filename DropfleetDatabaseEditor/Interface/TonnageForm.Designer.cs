namespace DropfleetDatabaseEditor.Interface
{
    partial class TonnageForm
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
            this.shipsMenuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editExistingButton = new System.Windows.Forms.Button();
            this.createNewButton = new System.Windows.Forms.Button();
            this.createPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tonnageClassCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valueSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tonnageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.tonnageCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveEditedButton = new System.Windows.Forms.Button();
            this.editTonnageClassCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editTonnageValueSelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.editTonnageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSelect)).BeginInit();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTonnageValueSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.shipsMenuButton);
            this.panel2.Location = new System.Drawing.Point(660, 517);
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
            // shipsMenuButton
            // 
            this.shipsMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipsMenuButton.Location = new System.Drawing.Point(18, 19);
            this.shipsMenuButton.Name = "shipsMenuButton";
            this.shipsMenuButton.Size = new System.Drawing.Size(114, 90);
            this.shipsMenuButton.TabIndex = 0;
            this.shipsMenuButton.Text = "Back to Ships Menu";
            this.shipsMenuButton.UseVisualStyleBackColor = true;
            this.shipsMenuButton.Click += new System.EventHandler(this.ShipsMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.editExistingButton);
            this.panel1.Controls.Add(this.createNewButton);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 120);
            this.panel1.TabIndex = 6;
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
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPanel.Controls.Add(this.saveButton);
            this.createPanel.Controls.Add(this.tonnageClassCombo);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.valueSelect);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.tonnageTextBox);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Location = new System.Drawing.Point(162, 29);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(371, 474);
            this.createPanel.TabIndex = 7;
            this.createPanel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(35, 332);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(161, 87);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Tonnage";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tonnageClassCombo
            // 
            this.tonnageClassCombo.FormattingEnabled = true;
            this.tonnageClassCombo.Location = new System.Drawing.Point(35, 270);
            this.tonnageClassCombo.Name = "tonnageClassCombo";
            this.tonnageClassCombo.Size = new System.Drawing.Size(121, 21);
            this.tonnageClassCombo.TabIndex = 5;
            this.tonnageClassCombo.SelectedIndexChanged += new System.EventHandler(this.TonnageClassCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tonnage Class";
            // 
            // valueSelect
            // 
            this.valueSelect.Location = new System.Drawing.Point(35, 167);
            this.valueSelect.Name = "valueSelect";
            this.valueSelect.Size = new System.Drawing.Size(67, 20);
            this.valueSelect.TabIndex = 3;
            this.valueSelect.ValueChanged += new System.EventHandler(this.ValueSelect_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tonnage Value";
            // 
            // tonnageTextBox
            // 
            this.tonnageTextBox.Location = new System.Drawing.Point(35, 60);
            this.tonnageTextBox.Name = "tonnageTextBox";
            this.tonnageTextBox.Size = new System.Drawing.Size(67, 20);
            this.tonnageTextBox.TabIndex = 1;
            this.tonnageTextBox.TextChanged += new System.EventHandler(this.TonnageTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tonnage Designation";
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editPanel.Controls.Add(this.tonnageCombo);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.saveEditedButton);
            this.editPanel.Controls.Add(this.editTonnageClassCombo);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.editTonnageValueSelect);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.editTonnageTextBox);
            this.editPanel.Controls.Add(this.label6);
            this.editPanel.Location = new System.Drawing.Point(580, 29);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(371, 474);
            this.editPanel.TabIndex = 8;
            this.editPanel.Visible = false;
            // 
            // tonnageCombo
            // 
            this.tonnageCombo.FormattingEnabled = true;
            this.tonnageCombo.Location = new System.Drawing.Point(24, 59);
            this.tonnageCombo.Name = "tonnageCombo";
            this.tonnageCombo.Size = new System.Drawing.Size(121, 21);
            this.tonnageCombo.TabIndex = 15;
            this.tonnageCombo.SelectedIndexChanged += new System.EventHandler(this.TonnageCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tonnage To Edit";
            // 
            // saveEditedButton
            // 
            this.saveEditedButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditedButton.Location = new System.Drawing.Point(24, 370);
            this.saveEditedButton.Name = "saveEditedButton";
            this.saveEditedButton.Size = new System.Drawing.Size(161, 87);
            this.saveEditedButton.TabIndex = 13;
            this.saveEditedButton.Text = "Save Tonnage";
            this.saveEditedButton.UseVisualStyleBackColor = true;
            this.saveEditedButton.Click += new System.EventHandler(this.SaveEditedButton_Click);
            // 
            // editTonnageClassCombo
            // 
            this.editTonnageClassCombo.FormattingEnabled = true;
            this.editTonnageClassCombo.Location = new System.Drawing.Point(24, 337);
            this.editTonnageClassCombo.Name = "editTonnageClassCombo";
            this.editTonnageClassCombo.Size = new System.Drawing.Size(121, 21);
            this.editTonnageClassCombo.TabIndex = 12;
            this.editTonnageClassCombo.SelectedIndexChanged += new System.EventHandler(this.EditTonnageClassCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tonnage Class";
            // 
            // editTonnageValueSelect
            // 
            this.editTonnageValueSelect.Location = new System.Drawing.Point(24, 255);
            this.editTonnageValueSelect.Name = "editTonnageValueSelect";
            this.editTonnageValueSelect.Size = new System.Drawing.Size(67, 20);
            this.editTonnageValueSelect.TabIndex = 10;
            this.editTonnageValueSelect.ValueChanged += new System.EventHandler(this.EditTonnageValueSelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tonnage Value";
            // 
            // editTonnageTextBox
            // 
            this.editTonnageTextBox.Location = new System.Drawing.Point(24, 164);
            this.editTonnageTextBox.Name = "editTonnageTextBox";
            this.editTonnageTextBox.Size = new System.Drawing.Size(67, 20);
            this.editTonnageTextBox.TabIndex = 8;
            this.editTonnageTextBox.TextChanged += new System.EventHandler(this.EditTonnageTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tonnage Designation";
            // 
            // TonnageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.Battle_of_Vega_BG_Wip_9__chromatic____Copy;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TonnageForm";
            this.Text = "TonnageForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSelect)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editTonnageValueSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button shipsMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editExistingButton;
        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.ComboBox tonnageClassCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown valueSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tonnageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveEditedButton;
        private System.Windows.Forms.ComboBox editTonnageClassCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown editTonnageValueSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editTonnageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tonnageCombo;
    }
}