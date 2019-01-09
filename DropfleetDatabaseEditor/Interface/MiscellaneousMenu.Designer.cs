namespace DropfleetDatabaseEditor.Interface
{
    partial class MiscellaneousMenu
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
            this.battlegroupsForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.battlegroupsForm);
            this.panel1.Location = new System.Drawing.Point(139, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 438);
            this.panel1.TabIndex = 0;
            // 
            // battlegroupsForm
            // 
            this.battlegroupsForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battlegroupsForm.Location = new System.Drawing.Point(97, 73);
            this.battlegroupsForm.Name = "battlegroupsForm";
            this.battlegroupsForm.Size = new System.Drawing.Size(139, 95);
            this.battlegroupsForm.TabIndex = 0;
            this.battlegroupsForm.Text = "Battlegroups";
            this.battlegroupsForm.UseVisualStyleBackColor = true;
            this.battlegroupsForm.Click += new System.EventHandler(this.BattlegroupsForm_Click);
            // 
            // MiscellaneousMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources._10__The_Space_Jump__All_finished;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Name = "MiscellaneousMenu";
            this.Text = "MiscellaneousMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button battlegroupsForm;
    }
}