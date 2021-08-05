namespace SMS.ChildForm
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.addSupplierBtn = new FontAwesome.Sharp.IconButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.paddingPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(49, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(911, 60);
            this.topPanel.TabIndex = 2;
            // 
            // addSupplierBtn
            // 
            this.addSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addSupplierBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addSupplierBtn.FlatAppearance.BorderSize = 0;
            this.addSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSupplierBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addSupplierBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSupplierBtn.ForeColor = System.Drawing.Color.Ivory;
            this.addSupplierBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addSupplierBtn.IconColor = System.Drawing.Color.Black;
            this.addSupplierBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addSupplierBtn.IconSize = 16;
            this.addSupplierBtn.Location = new System.Drawing.Point(0, 0);
            this.addSupplierBtn.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.addSupplierBtn.Name = "addSupplierBtn";
            this.addSupplierBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.addSupplierBtn.Rotation = 0D;
            this.addSupplierBtn.Size = new System.Drawing.Size(125, 41);
            this.addSupplierBtn.TabIndex = 3;
            this.addSupplierBtn.Text = "Add Supplier";
            this.addSupplierBtn.UseVisualStyleBackColor = false;
            this.addSupplierBtn.Click += new System.EventHandler(this.addSupplierBtn_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(960, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(41, 552);
            this.rightPanel.TabIndex = 5;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPanel.Controls.Add(this.panel10);
            this.buttonPanel.Controls.Add(this.searchIcon);
            this.buttonPanel.Controls.Add(this.addSupplierBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(49, 60);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(911, 41);
            this.buttonPanel.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(584, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 41);
            this.panel10.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(18, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type here to search..";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(18, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(243, 10);
            this.panel11.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(18, 41);
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
            this.searchIcon.IconSize = 41;
            this.searchIcon.Location = new System.Drawing.Point(845, 0);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(66, 41);
            this.searchIcon.TabIndex = 5;
            this.searchIcon.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(49, 552);
            this.leftPanel.TabIndex = 6;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(49, 523);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(911, 29);
            this.bottomPanel.TabIndex = 7;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(49, 101);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(911, 40);
            this.paddingPanel.TabIndex = 8;
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
            this.dataGridView1.Location = new System.Drawing.Point(49, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 382);
            this.dataGridView1.TabIndex = 9;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1001, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.Text = "Supplier";
            this.buttonPanel.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private FontAwesome.Sharp.IconButton addSupplierBtn;
        private System.Windows.Forms.Panel rightPanel;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel paddingPanel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}