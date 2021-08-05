namespace SMS.ChildForm.Popups
{
    partial class CompanyPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyPopup));
            this.dragPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cityBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stateBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.countryBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mobileBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.submitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nameBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logoBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.faxBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dragPanel.Controls.Add(this.pictureBox1);
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(786, 85);
            this.dragPanel.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(83, 26);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(131, 25);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Add Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(42, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(31, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(31, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "State";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cityBox);
            this.panel3.Controls.Add(this.stateBox);
            this.panel3.Controls.Add(this.countryBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(430, 218);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 178);
            this.panel3.TabIndex = 50;
            // 
            // cityBox
            // 
            this.cityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cityBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cityBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityBox.HintForeColor = System.Drawing.Color.Empty;
            this.cityBox.HintText = "";
            this.cityBox.isPassword = false;
            this.cityBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.cityBox.LineIdleColor = System.Drawing.Color.Gray;
            this.cityBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.cityBox.LineThickness = 2;
            this.cityBox.Location = new System.Drawing.Point(75, 102);
            this.cityBox.MaxLength = 32767;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(224, 35);
            this.cityBox.TabIndex = 7;
            this.cityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stateBox
            // 
            this.stateBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.stateBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.stateBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.stateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stateBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stateBox.HintForeColor = System.Drawing.Color.Empty;
            this.stateBox.HintText = "";
            this.stateBox.isPassword = false;
            this.stateBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.stateBox.LineIdleColor = System.Drawing.Color.Gray;
            this.stateBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.stateBox.LineThickness = 2;
            this.stateBox.Location = new System.Drawing.Point(77, 62);
            this.stateBox.MaxLength = 32767;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(224, 34);
            this.stateBox.TabIndex = 6;
            this.stateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // countryBox
            // 
            this.countryBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.countryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.countryBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.countryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countryBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.countryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countryBox.HintForeColor = System.Drawing.Color.Empty;
            this.countryBox.HintText = "";
            this.countryBox.isPassword = false;
            this.countryBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.countryBox.LineIdleColor = System.Drawing.Color.Gray;
            this.countryBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.countryBox.LineThickness = 2;
            this.countryBox.Location = new System.Drawing.Point(77, 21);
            this.countryBox.MaxLength = 32767;
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(224, 35);
            this.countryBox.TabIndex = 5;
            this.countryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mobileBox);
            this.panel5.Controls.Add(this.phoneBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(26, 210);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 113);
            this.panel5.TabIndex = 10;
            // 
            // mobileBox
            // 
            this.mobileBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mobileBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mobileBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mobileBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobileBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mobileBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mobileBox.HintForeColor = System.Drawing.Color.Empty;
            this.mobileBox.HintText = "";
            this.mobileBox.isPassword = false;
            this.mobileBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.mobileBox.LineIdleColor = System.Drawing.Color.Gray;
            this.mobileBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.mobileBox.LineThickness = 2;
            this.mobileBox.Location = new System.Drawing.Point(132, 62);
            this.mobileBox.MaxLength = 32767;
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(224, 32);
            this.mobileBox.TabIndex = 4;
            this.mobileBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneBox
            // 
            this.phoneBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.phoneBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.phoneBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.phoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneBox.HintForeColor = System.Drawing.Color.Empty;
            this.phoneBox.HintText = "";
            this.phoneBox.isPassword = false;
            this.phoneBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.phoneBox.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.phoneBox.LineThickness = 2;
            this.phoneBox.Location = new System.Drawing.Point(132, 21);
            this.phoneBox.MaxLength = 32767;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(224, 35);
            this.phoneBox.TabIndex = 3;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(51, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mobile No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(46, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phone No.";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dateTimePicker1);
            this.panel14.Controls.Add(this.panBox);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Location = new System.Drawing.Point(22, 346);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(390, 122);
            this.panel14.TabIndex = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 31);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 25, 20, 19, 24, 928);
            // 
            // panBox
            // 
            this.panBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.panBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.panBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.panBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.panBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panBox.HintForeColor = System.Drawing.Color.Empty;
            this.panBox.HintText = "";
            this.panBox.isPassword = false;
            this.panBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.panBox.LineIdleColor = System.Drawing.Color.Gray;
            this.panBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.panBox.LineThickness = 2;
            this.panBox.Location = new System.Drawing.Point(132, 17);
            this.panBox.MaxLength = 32767;
            this.panBox.Name = "panBox";
            this.panBox.Size = new System.Drawing.Size(224, 32);
            this.panBox.TabIndex = 8;
            this.panBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(46, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(86, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "PAN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(104, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Logo";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(383, 159);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(32, 25);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Active = false;
            this.submitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitBtn.BorderRadius = 0;
            this.submitBtn.ButtonText = "CREATE";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.submitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.submitBtn.Iconimage = null;
            this.submitBtn.Iconimage_right = null;
            this.submitBtn.Iconimage_right_Selected = null;
            this.submitBtn.Iconimage_Selected = null;
            this.submitBtn.IconMarginLeft = 0;
            this.submitBtn.IconMarginRight = 0;
            this.submitBtn.IconRightVisible = false;
            this.submitBtn.IconRightZoom = 0D;
            this.submitBtn.IconVisible = false;
            this.submitBtn.IconZoom = 0D;
            this.submitBtn.IsTab = false;
            this.submitBtn.Location = new System.Drawing.Point(595, 433);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.submitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(199)))), ((int)(((byte)(99)))));
            this.submitBtn.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.selected = false;
            this.submitBtn.Size = new System.Drawing.Size(80, 34);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "CREATE";
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.Textcolor = System.Drawing.Color.White;
            this.submitBtn.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameBox.HintForeColor = System.Drawing.Color.Empty;
            this.nameBox.HintText = "";
            this.nameBox.isPassword = false;
            this.nameBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.nameBox.LineIdleColor = System.Drawing.Color.Gray;
            this.nameBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.nameBox.LineThickness = 2;
            this.nameBox.Location = new System.Drawing.Point(154, 106);
            this.nameBox.MaxLength = 32767;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(224, 30);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // logoBox
            // 
            this.logoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.logoBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.logoBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logoBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.logoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoBox.HintForeColor = System.Drawing.Color.Empty;
            this.logoBox.HintText = "";
            this.logoBox.isPassword = false;
            this.logoBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.logoBox.LineIdleColor = System.Drawing.Color.Gray;
            this.logoBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.logoBox.LineThickness = 2;
            this.logoBox.Location = new System.Drawing.Point(154, 142);
            this.logoBox.MaxLength = 32767;
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(224, 35);
            this.logoBox.TabIndex = 2;
            this.logoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Active = false;
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(173)))), ((int)(((byte)(84)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "BACK";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = null;
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = false;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = false;
            this.button1.IconZoom = 0D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(679, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.OnHovercolor = System.Drawing.Color.Gray;
            this.button1.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 184);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(742, 34);
            this.bunifuSeparator1.TabIndex = 81;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(26, 320);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(387, 20);
            this.bunifuSeparator2.TabIndex = 82;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(430, 408);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(335, 20);
            this.bunifuSeparator3.TabIndex = 82;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.faxBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(430, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 88);
            this.panel1.TabIndex = 10;
            // 
            // faxBox
            // 
            this.faxBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.faxBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.faxBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.faxBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.faxBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.faxBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.faxBox.HintForeColor = System.Drawing.Color.Empty;
            this.faxBox.HintText = "";
            this.faxBox.isPassword = false;
            this.faxBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.faxBox.LineIdleColor = System.Drawing.Color.Gray;
            this.faxBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.faxBox.LineThickness = 2;
            this.faxBox.Location = new System.Drawing.Point(77, 49);
            this.faxBox.MaxLength = 32767;
            this.faxBox.Name = "faxBox";
            this.faxBox.Size = new System.Drawing.Size(224, 32);
            this.faxBox.TabIndex = 4;
            this.faxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailBox
            // 
            this.emailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.emailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.emailBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailBox.HintForeColor = System.Drawing.Color.Empty;
            this.emailBox.HintText = "";
            this.emailBox.isPassword = false;
            this.emailBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.emailBox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailBox.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.emailBox.LineThickness = 2;
            this.emailBox.Location = new System.Drawing.Point(75, 3);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(224, 35);
            this.emailBox.TabIndex = 3;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(35, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // CompanyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(786, 506);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CompanyPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyPopup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyPopup_FormClosed);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Bunifu.Framework.UI.BunifuFlatButton submitBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cityBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stateBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox countryBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mobileBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneBox;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox panBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox logoBox;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox faxBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}