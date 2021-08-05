namespace SMS
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.buttonGroupPanel = new System.Windows.Forms.Panel();
            this.reportBtn = new FontAwesome.Sharp.IconButton();
            this.manageBtn = new FontAwesome.Sharp.IconButton();
            this.financeBtn = new FontAwesome.Sharp.IconButton();
            this.salesBtn = new FontAwesome.Sharp.IconButton();
            this.purchaseBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.activeUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedButtonIcon = new FontAwesome.Sharp.IconPictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.buttonGroupPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedButtonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.buttonGroupPanel);
            this.panel1.Controls.Add(this.logoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 599);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 28;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 557);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.logoutBtn.Rotation = 0D;
            this.logoutBtn.Size = new System.Drawing.Size(211, 42);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // buttonGroupPanel
            // 
            this.buttonGroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.buttonGroupPanel.Controls.Add(this.reportBtn);
            this.buttonGroupPanel.Controls.Add(this.manageBtn);
            this.buttonGroupPanel.Controls.Add(this.financeBtn);
            this.buttonGroupPanel.Controls.Add(this.salesBtn);
            this.buttonGroupPanel.Controls.Add(this.purchaseBtn);
            this.buttonGroupPanel.Controls.Add(this.dashboardBtn);
            this.buttonGroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroupPanel.Location = new System.Drawing.Point(0, 119);
            this.buttonGroupPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGroupPanel.Name = "buttonGroupPanel";
            this.buttonGroupPanel.Size = new System.Drawing.Size(211, 413);
            this.buttonGroupPanel.TabIndex = 8;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportBtn.Enabled = false;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.reportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.reportBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.reportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportBtn.IconSize = 28;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(0, 210);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.reportBtn.Rotation = 0D;
            this.reportBtn.Size = new System.Drawing.Size(211, 42);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // manageBtn
            // 
            this.manageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.manageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.manageBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manageBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.manageBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.manageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageBtn.IconSize = 28;
            this.manageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBtn.Location = new System.Drawing.Point(0, 168);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.manageBtn.Rotation = 0D;
            this.manageBtn.Size = new System.Drawing.Size(211, 42);
            this.manageBtn.TabIndex = 15;
            this.manageBtn.Text = "Manage";
            this.manageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBtn.UseVisualStyleBackColor = false;
            this.manageBtn.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // financeBtn
            // 
            this.financeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.financeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.financeBtn.FlatAppearance.BorderSize = 0;
            this.financeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.financeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.financeBtn.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.financeBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.financeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.financeBtn.IconSize = 28;
            this.financeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeBtn.Location = new System.Drawing.Point(0, 126);
            this.financeBtn.Name = "financeBtn";
            this.financeBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.financeBtn.Rotation = 0D;
            this.financeBtn.Size = new System.Drawing.Size(211, 42);
            this.financeBtn.TabIndex = 14;
            this.financeBtn.Text = "Finance";
            this.financeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.financeBtn.UseVisualStyleBackColor = false;
            this.financeBtn.Click += new System.EventHandler(this.financeBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesBtn.FlatAppearance.BorderSize = 0;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.salesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salesBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.salesBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.salesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesBtn.IconSize = 28;
            this.salesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesBtn.Location = new System.Drawing.Point(0, 84);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.salesBtn.Rotation = 0D;
            this.salesBtn.Size = new System.Drawing.Size(211, 42);
            this.salesBtn.TabIndex = 12;
            this.salesBtn.Text = "Sales Billing";
            this.salesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesBtn.UseVisualStyleBackColor = false;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.purchaseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchaseBtn.FlatAppearance.BorderSize = 0;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.purchaseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.purchaseBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.purchaseBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.purchaseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.purchaseBtn.IconSize = 28;
            this.purchaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseBtn.Location = new System.Drawing.Point(0, 42);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.purchaseBtn.Rotation = 0D;
            this.purchaseBtn.Size = new System.Drawing.Size(211, 42);
            this.purchaseBtn.TabIndex = 11;
            this.purchaseBtn.Text = "Purchase Billing";
            this.purchaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchaseBtn.UseVisualStyleBackColor = false;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.dashboardBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 28;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.dashboardBtn.Rotation = 0D;
            this.dashboardBtn.Size = new System.Drawing.Size(211, 42);
            this.dashboardBtn.TabIndex = 10;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.panel5);
            this.logoPanel.Controls.Add(this.panel3);
            this.logoPanel.Controls.Add(this.iconPictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(211, 119);
            this.logoPanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Location = new System.Drawing.Point(46, 18);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 82);
            this.panel5.TabIndex = 4;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 82;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(115, 82);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(185, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 119);
            this.panel3.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 119);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.titlePanel.Controls.Add(this.panel4);
            this.titlePanel.Controls.Add(this.selectedButtonIcon);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(211, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(885, 47);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.activeUser);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(657, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 47);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.activeUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activeUser.Location = new System.Drawing.Point(104, 10);
            this.activeUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(54, 17);
            this.activeUser.TabIndex = 3;
            this.activeUser.Text = "Saransh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "logged in as: ";
            // 
            // selectedButtonIcon
            // 
            this.selectedButtonIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.selectedButtonIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.selectedButtonIcon.IconColor = System.Drawing.Color.White;
            this.selectedButtonIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.selectedButtonIcon.Location = new System.Drawing.Point(16, 10);
            this.selectedButtonIcon.Margin = new System.Windows.Forms.Padding(2);
            this.selectedButtonIcon.Name = "selectedButtonIcon";
            this.selectedButtonIcon.Size = new System.Drawing.Size(42, 32);
            this.selectedButtonIcon.TabIndex = 1;
            this.selectedButtonIcon.TabStop = false;
            this.selectedButtonIcon.Click += new System.EventHandler(this.selectedButtonIcon_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(211, 47);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(885, 552);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(211, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 2);
            this.panel2.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1096, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.buttonGroupPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedButtonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel logoPanel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton reportBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel buttonGroupPanel;
        private FontAwesome.Sharp.IconPictureBox selectedButtonIcon;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private System.Windows.Forms.Label activeUser;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton salesBtn;
        private FontAwesome.Sharp.IconButton purchaseBtn;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton financeBtn;
        private FontAwesome.Sharp.IconButton manageBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}