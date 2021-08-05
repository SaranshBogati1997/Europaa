namespace SMS.ChildForm
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.GridContainer = new System.Windows.Forms.Panel();
            this.paddingPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.addUserBtn = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 579);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1006, 30);
            this.bottomPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(40, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(928, 49);
            this.topPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(968, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(38, 579);
            this.rightPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(40, 579);
            this.leftPanel.TabIndex = 2;
            // 
            // GridContainer
            // 
            this.GridContainer.Controls.Add(this.dataGridView1);
            this.GridContainer.Controls.Add(this.paddingPanel);
            this.GridContainer.Controls.Add(this.panel1);
            this.GridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridContainer.Location = new System.Drawing.Point(40, 49);
            this.GridContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridContainer.Name = "GridContainer";
            this.GridContainer.Size = new System.Drawing.Size(928, 530);
            this.GridContainer.TabIndex = 3;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 33);
            this.paddingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(928, 32);
            this.paddingPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.searchIcon);
            this.panel1.Controls.Add(this.addUserBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 33);
            this.panel1.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(682, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(196, 33);
            this.panel10.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(14, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type here to search..";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(14, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(182, 8);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(14, 33);
            this.panel12.TabIndex = 1;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchIcon.ForeColor = System.Drawing.Color.DimGray;
            this.searchIcon.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.searchIcon.IconColor = System.Drawing.Color.DimGray;
            this.searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchIcon.IconSize = 33;
            this.searchIcon.Location = new System.Drawing.Point(878, 0);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(50, 33);
            this.searchIcon.TabIndex = 23;
            this.searchIcon.TabStop = false;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addUserBtn.IconColor = System.Drawing.Color.Black;
            this.addUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addUserBtn.IconSize = 16;
            this.addUserBtn.Location = new System.Drawing.Point(0, 0);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Rotation = 0D;
            this.addUserBtn.Size = new System.Drawing.Size(120, 33);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 465);
            this.dataGridView1.TabIndex = 10;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 609);
            this.Controls.Add(this.GridContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.GridContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel GridContainer;
        private FontAwesome.Sharp.IconButton addUserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paddingPanel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}