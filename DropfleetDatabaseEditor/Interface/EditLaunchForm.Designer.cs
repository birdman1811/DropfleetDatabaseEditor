namespace DropfleetDatabaseEditor.Interface
{
    partial class EditLaunchForm
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
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.AddRule = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.removeAssetButton = new System.Windows.Forms.Button();
            this.addAssetButton = new System.Windows.Forms.Button();
            this.rulesQuantitySelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rulesCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantitySelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.assetsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assetListBox = new System.Windows.Forms.ListBox();
            this.shipNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesQuantitySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rulesListBox);
            this.panel1.Controls.Add(this.AddRule);
            this.panel1.Controls.Add(this.finishButton);
            this.panel1.Controls.Add(this.removeAssetButton);
            this.panel1.Controls.Add(this.addAssetButton);
            this.panel1.Controls.Add(this.rulesQuantitySelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rulesCombo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.quantitySelect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.assetsCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.assetListBox);
            this.panel1.Controls.Add(this.shipNameLabel);
            this.panel1.Location = new System.Drawing.Point(104, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 553);
            this.panel1.TabIndex = 1;
            // 
            // rulesListBox
            // 
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.Location = new System.Drawing.Point(231, 277);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(120, 95);
            this.rulesListBox.TabIndex = 14;
            // 
            // AddRule
            // 
            this.AddRule.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRule.Location = new System.Drawing.Point(48, 469);
            this.AddRule.Name = "AddRule";
            this.AddRule.Size = new System.Drawing.Size(120, 51);
            this.AddRule.TabIndex = 13;
            this.AddRule.Text = "Add Rule";
            this.AddRule.UseVisualStyleBackColor = true;
            this.AddRule.Click += new System.EventHandler(this.AddRule_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(563, 406);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(177, 102);
            this.finishButton.TabIndex = 12;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // removeAssetButton
            // 
            this.removeAssetButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAssetButton.Location = new System.Drawing.Point(614, 170);
            this.removeAssetButton.Name = "removeAssetButton";
            this.removeAssetButton.Size = new System.Drawing.Size(126, 69);
            this.removeAssetButton.TabIndex = 11;
            this.removeAssetButton.Text = "Remove Asset";
            this.removeAssetButton.UseVisualStyleBackColor = true;
            this.removeAssetButton.Click += new System.EventHandler(this.RemoveAssetButton_Click);
            // 
            // addAssetButton
            // 
            this.addAssetButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssetButton.Location = new System.Drawing.Point(216, 170);
            this.addAssetButton.Name = "addAssetButton";
            this.addAssetButton.Size = new System.Drawing.Size(126, 69);
            this.addAssetButton.TabIndex = 10;
            this.addAssetButton.Text = "Add Asset";
            this.addAssetButton.UseVisualStyleBackColor = true;
            this.addAssetButton.Click += new System.EventHandler(this.AddAssetButton_Click);
            // 
            // rulesQuantitySelect
            // 
            this.rulesQuantitySelect.Location = new System.Drawing.Point(48, 443);
            this.rulesQuantitySelect.Name = "rulesQuantitySelect";
            this.rulesQuantitySelect.Size = new System.Drawing.Size(120, 20);
            this.rulesQuantitySelect.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // rulesCombo
            // 
            this.rulesCombo.FormattingEnabled = true;
            this.rulesCombo.Location = new System.Drawing.Point(48, 351);
            this.rulesCombo.Name = "rulesCombo";
            this.rulesCombo.Size = new System.Drawing.Size(121, 21);
            this.rulesCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Special Rules";
            // 
            // quantitySelect
            // 
            this.quantitySelect.Location = new System.Drawing.Point(48, 262);
            this.quantitySelect.Name = "quantitySelect";
            this.quantitySelect.Size = new System.Drawing.Size(120, 20);
            this.quantitySelect.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // assetsCombo
            // 
            this.assetsCombo.FormattingEnabled = true;
            this.assetsCombo.Location = new System.Drawing.Point(48, 170);
            this.assetsCombo.Name = "assetsCombo";
            this.assetsCombo.Size = new System.Drawing.Size(121, 21);
            this.assetsCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Launch Asset";
            // 
            // assetListBox
            // 
            this.assetListBox.FormattingEnabled = true;
            this.assetListBox.Location = new System.Drawing.Point(379, 170);
            this.assetListBox.Name = "assetListBox";
            this.assetListBox.Size = new System.Drawing.Size(216, 160);
            this.assetListBox.TabIndex = 1;
            // 
            // shipNameLabel
            // 
            this.shipNameLabel.AutoSize = true;
            this.shipNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shipNameLabel.Location = new System.Drawing.Point(44, 38);
            this.shipNameLabel.Name = "shipNameLabel";
            this.shipNameLabel.Size = new System.Drawing.Size(102, 24);
            this.shipNameLabel.TabIndex = 0;
            this.shipNameLabel.Text = "shipname";
            // 
            // EditLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources.EVA_Battleship__Routine_Maintenance_3;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "EditLaunchForm";
            this.Text = "EditLaunchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesQuantitySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.Button AddRule;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button removeAssetButton;
        private System.Windows.Forms.Button addAssetButton;
        private System.Windows.Forms.NumericUpDown rulesQuantitySelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rulesCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantitySelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assetsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox assetListBox;
        private System.Windows.Forms.Label shipNameLabel;
    }
}