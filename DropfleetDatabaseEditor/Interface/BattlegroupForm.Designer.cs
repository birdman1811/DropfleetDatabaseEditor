namespace DropfleetDatabaseEditor.Interface
{
    partial class BattlegroupForm
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
            this.backMenuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBatllegroupButton = new System.Windows.Forms.Button();
            this.dreadnoughtGroup = new System.Windows.Forms.GroupBox();
            this.maxDreadnoughtSelect = new System.Windows.Forms.NumericUpDown();
            this.minDreadnoughtSelect = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.superHeavyGroup = new System.Windows.Forms.GroupBox();
            this.maxSuperHeavySelect = new System.Windows.Forms.NumericUpDown();
            this.minSuperHeavySelect = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.heavyGroup = new System.Windows.Forms.GroupBox();
            this.maxHeavySelect = new System.Windows.Forms.NumericUpDown();
            this.minHeavySelect = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mediumGroup = new System.Windows.Forms.GroupBox();
            this.maxMediumSelect = new System.Windows.Forms.NumericUpDown();
            this.minMediumSelect = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lightBox = new System.Windows.Forms.GroupBox();
            this.maxLightSelect = new System.Windows.Forms.NumericUpDown();
            this.minLightSelect = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxSelect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.imageURLText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dreadnoughtGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDreadnoughtSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDreadnoughtSelect)).BeginInit();
            this.superHeavyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSuperHeavySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSuperHeavySelect)).BeginInit();
            this.heavyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeavySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeavySelect)).BeginInit();
            this.mediumGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMediumSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMediumSelect)).BeginInit();
            this.lightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLightSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLightSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mainMenuButton);
            this.panel2.Controls.Add(this.backMenuButton);
            this.panel2.Location = new System.Drawing.Point(681, 517);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 132);
            this.panel2.TabIndex = 6;
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
            // backMenuButton
            // 
            this.backMenuButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuButton.Location = new System.Drawing.Point(18, 19);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(114, 90);
            this.backMenuButton.TabIndex = 0;
            this.backMenuButton.Text = "Back to Previous Menu";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.BackMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.addBatllegroupButton);
            this.panel1.Controls.Add(this.dreadnoughtGroup);
            this.panel1.Controls.Add(this.superHeavyGroup);
            this.panel1.Controls.Add(this.heavyGroup);
            this.panel1.Controls.Add(this.mediumGroup);
            this.panel1.Controls.Add(this.lightBox);
            this.panel1.Controls.Add(this.maxSelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.imageURLText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupNameText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 449);
            this.panel1.TabIndex = 7;
            // 
            // addBatllegroupButton
            // 
            this.addBatllegroupButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBatllegroupButton.Location = new System.Drawing.Point(579, 317);
            this.addBatllegroupButton.Name = "addBatllegroupButton";
            this.addBatllegroupButton.Size = new System.Drawing.Size(150, 90);
            this.addBatllegroupButton.TabIndex = 11;
            this.addBatllegroupButton.Text = "Add Battle Group";
            this.addBatllegroupButton.UseVisualStyleBackColor = true;
            this.addBatllegroupButton.Click += new System.EventHandler(this.addBatllegroupButton_Click);
            // 
            // dreadnoughtGroup
            // 
            this.dreadnoughtGroup.Controls.Add(this.maxDreadnoughtSelect);
            this.dreadnoughtGroup.Controls.Add(this.minDreadnoughtSelect);
            this.dreadnoughtGroup.Controls.Add(this.label12);
            this.dreadnoughtGroup.Controls.Add(this.label13);
            this.dreadnoughtGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreadnoughtGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dreadnoughtGroup.Location = new System.Drawing.Point(579, 168);
            this.dreadnoughtGroup.Name = "dreadnoughtGroup";
            this.dreadnoughtGroup.Size = new System.Drawing.Size(150, 103);
            this.dreadnoughtGroup.TabIndex = 10;
            this.dreadnoughtGroup.TabStop = false;
            this.dreadnoughtGroup.Text = "Dreadnought";
            // 
            // maxDreadnoughtSelect
            // 
            this.maxDreadnoughtSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDreadnoughtSelect.Location = new System.Drawing.Point(81, 66);
            this.maxDreadnoughtSelect.Name = "maxDreadnoughtSelect";
            this.maxDreadnoughtSelect.Size = new System.Drawing.Size(40, 23);
            this.maxDreadnoughtSelect.TabIndex = 4;
            this.maxDreadnoughtSelect.ValueChanged += new System.EventHandler(this.maxDreadnoughtSelect_ValueChanged);
            // 
            // minDreadnoughtSelect
            // 
            this.minDreadnoughtSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minDreadnoughtSelect.Location = new System.Drawing.Point(10, 66);
            this.minDreadnoughtSelect.Name = "minDreadnoughtSelect";
            this.minDreadnoughtSelect.Size = new System.Drawing.Size(40, 23);
            this.minDreadnoughtSelect.TabIndex = 3;
            this.minDreadnoughtSelect.ValueChanged += new System.EventHandler(this.minDreadnoughtSelect_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(77, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Max";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 24);
            this.label13.TabIndex = 1;
            this.label13.Text = "Min";
            // 
            // superHeavyGroup
            // 
            this.superHeavyGroup.Controls.Add(this.maxSuperHeavySelect);
            this.superHeavyGroup.Controls.Add(this.minSuperHeavySelect);
            this.superHeavyGroup.Controls.Add(this.label10);
            this.superHeavyGroup.Controls.Add(this.label11);
            this.superHeavyGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superHeavyGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.superHeavyGroup.Location = new System.Drawing.Point(579, 42);
            this.superHeavyGroup.Name = "superHeavyGroup";
            this.superHeavyGroup.Size = new System.Drawing.Size(150, 103);
            this.superHeavyGroup.TabIndex = 9;
            this.superHeavyGroup.TabStop = false;
            this.superHeavyGroup.Text = "SuperHeavy";
            // 
            // maxSuperHeavySelect
            // 
            this.maxSuperHeavySelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSuperHeavySelect.Location = new System.Drawing.Point(81, 66);
            this.maxSuperHeavySelect.Name = "maxSuperHeavySelect";
            this.maxSuperHeavySelect.Size = new System.Drawing.Size(40, 23);
            this.maxSuperHeavySelect.TabIndex = 4;
            this.maxSuperHeavySelect.ValueChanged += new System.EventHandler(this.MaxSuperHeavySelect_ValueChanged);
            // 
            // minSuperHeavySelect
            // 
            this.minSuperHeavySelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minSuperHeavySelect.Location = new System.Drawing.Point(10, 66);
            this.minSuperHeavySelect.Name = "minSuperHeavySelect";
            this.minSuperHeavySelect.Size = new System.Drawing.Size(40, 23);
            this.minSuperHeavySelect.TabIndex = 3;
            this.minSuperHeavySelect.ValueChanged += new System.EventHandler(this.MinSuperHeavySelect_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(77, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Min";
            // 
            // heavyGroup
            // 
            this.heavyGroup.Controls.Add(this.maxHeavySelect);
            this.heavyGroup.Controls.Add(this.minHeavySelect);
            this.heavyGroup.Controls.Add(this.label8);
            this.heavyGroup.Controls.Add(this.label9);
            this.heavyGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heavyGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heavyGroup.Location = new System.Drawing.Point(380, 304);
            this.heavyGroup.Name = "heavyGroup";
            this.heavyGroup.Size = new System.Drawing.Size(136, 103);
            this.heavyGroup.TabIndex = 8;
            this.heavyGroup.TabStop = false;
            this.heavyGroup.Text = "Heavy";
            // 
            // maxHeavySelect
            // 
            this.maxHeavySelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHeavySelect.Location = new System.Drawing.Point(81, 66);
            this.maxHeavySelect.Name = "maxHeavySelect";
            this.maxHeavySelect.Size = new System.Drawing.Size(40, 23);
            this.maxHeavySelect.TabIndex = 4;
            this.maxHeavySelect.ValueChanged += new System.EventHandler(this.MaxHeavySelect_ValueChanged);
            // 
            // minHeavySelect
            // 
            this.minHeavySelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minHeavySelect.Location = new System.Drawing.Point(10, 66);
            this.minHeavySelect.Name = "minHeavySelect";
            this.minHeavySelect.Size = new System.Drawing.Size(40, 23);
            this.minHeavySelect.TabIndex = 3;
            this.minHeavySelect.ValueChanged += new System.EventHandler(this.MinHeavySelect_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(77, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Min";
            // 
            // mediumGroup
            // 
            this.mediumGroup.Controls.Add(this.maxMediumSelect);
            this.mediumGroup.Controls.Add(this.minMediumSelect);
            this.mediumGroup.Controls.Add(this.label6);
            this.mediumGroup.Controls.Add(this.label7);
            this.mediumGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumGroup.Location = new System.Drawing.Point(380, 168);
            this.mediumGroup.Name = "mediumGroup";
            this.mediumGroup.Size = new System.Drawing.Size(136, 103);
            this.mediumGroup.TabIndex = 7;
            this.mediumGroup.TabStop = false;
            this.mediumGroup.Text = "Medium";
            // 
            // maxMediumSelect
            // 
            this.maxMediumSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMediumSelect.Location = new System.Drawing.Point(81, 66);
            this.maxMediumSelect.Name = "maxMediumSelect";
            this.maxMediumSelect.Size = new System.Drawing.Size(40, 23);
            this.maxMediumSelect.TabIndex = 4;
            this.maxMediumSelect.ValueChanged += new System.EventHandler(this.MaxMediumSelect_ValueChanged);
            // 
            // minMediumSelect
            // 
            this.minMediumSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minMediumSelect.Location = new System.Drawing.Point(10, 66);
            this.minMediumSelect.Name = "minMediumSelect";
            this.minMediumSelect.Size = new System.Drawing.Size(40, 23);
            this.minMediumSelect.TabIndex = 3;
            this.minMediumSelect.ValueChanged += new System.EventHandler(this.MinMediumSelect_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(77, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Min";
            // 
            // lightBox
            // 
            this.lightBox.Controls.Add(this.maxLightSelect);
            this.lightBox.Controls.Add(this.minLightSelect);
            this.lightBox.Controls.Add(this.label5);
            this.lightBox.Controls.Add(this.label4);
            this.lightBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightBox.Location = new System.Drawing.Point(380, 41);
            this.lightBox.Name = "lightBox";
            this.lightBox.Size = new System.Drawing.Size(136, 103);
            this.lightBox.TabIndex = 6;
            this.lightBox.TabStop = false;
            this.lightBox.Text = "Light";
            // 
            // maxLightSelect
            // 
            this.maxLightSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLightSelect.Location = new System.Drawing.Point(81, 66);
            this.maxLightSelect.Name = "maxLightSelect";
            this.maxLightSelect.Size = new System.Drawing.Size(40, 23);
            this.maxLightSelect.TabIndex = 4;
            this.maxLightSelect.ValueChanged += new System.EventHandler(this.MaxLightSelect_ValueChanged);
            // 
            // minLightSelect
            // 
            this.minLightSelect.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLightSelect.Location = new System.Drawing.Point(10, 66);
            this.minLightSelect.Name = "minLightSelect";
            this.minLightSelect.Size = new System.Drawing.Size(40, 23);
            this.minLightSelect.TabIndex = 3;
            this.minLightSelect.ValueChanged += new System.EventHandler(this.MinLightSelect_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(77, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Min";
            // 
            // maxSelect
            // 
            this.maxSelect.Location = new System.Drawing.Point(36, 251);
            this.maxSelect.Name = "maxSelect";
            this.maxSelect.Size = new System.Drawing.Size(120, 20);
            this.maxSelect.TabIndex = 5;
            this.maxSelect.ValueChanged += new System.EventHandler(this.MaxSelect_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Number of Ship Groups";
            // 
            // imageURLText
            // 
            this.imageURLText.Location = new System.Drawing.Point(36, 160);
            this.imageURLText.Name = "imageURLText";
            this.imageURLText.Size = new System.Drawing.Size(177, 20);
            this.imageURLText.TabIndex = 3;
            this.imageURLText.TextChanged += new System.EventHandler(this.ImageURLText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Image URL";
            // 
            // groupNameText
            // 
            this.groupNameText.Location = new System.Drawing.Point(36, 78);
            this.groupNameText.Name = "groupNameText";
            this.groupNameText.Size = new System.Drawing.Size(126, 20);
            this.groupNameText.TabIndex = 1;
            this.groupNameText.TextChanged += new System.EventHandler(this.GroupNameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // BattlegroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DropfleetDatabaseEditor.Properties.Resources._10__The_Space_Jump__All_finished;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BattlegroupForm";
            this.Text = "BattlegroupForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dreadnoughtGroup.ResumeLayout(false);
            this.dreadnoughtGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDreadnoughtSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDreadnoughtSelect)).EndInit();
            this.superHeavyGroup.ResumeLayout(false);
            this.superHeavyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSuperHeavySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSuperHeavySelect)).EndInit();
            this.heavyGroup.ResumeLayout(false);
            this.heavyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHeavySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHeavySelect)).EndInit();
            this.mediumGroup.ResumeLayout(false);
            this.mediumGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMediumSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minMediumSelect)).EndInit();
            this.lightBox.ResumeLayout(false);
            this.lightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLightSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLightSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBatllegroupButton;
        private System.Windows.Forms.GroupBox dreadnoughtGroup;
        private System.Windows.Forms.NumericUpDown maxDreadnoughtSelect;
        private System.Windows.Forms.NumericUpDown minDreadnoughtSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox superHeavyGroup;
        private System.Windows.Forms.NumericUpDown maxSuperHeavySelect;
        private System.Windows.Forms.NumericUpDown minSuperHeavySelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox heavyGroup;
        private System.Windows.Forms.NumericUpDown maxHeavySelect;
        private System.Windows.Forms.NumericUpDown minHeavySelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox mediumGroup;
        private System.Windows.Forms.NumericUpDown maxMediumSelect;
        private System.Windows.Forms.NumericUpDown minMediumSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox lightBox;
        private System.Windows.Forms.NumericUpDown maxLightSelect;
        private System.Windows.Forms.NumericUpDown minLightSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imageURLText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupNameText;
        private System.Windows.Forms.Label label1;
    }
}