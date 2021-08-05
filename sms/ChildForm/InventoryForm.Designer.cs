namespace SMS.ChildForm
{
    partial class InventoryForm
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.gridContainer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.formPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textboxContainer = new System.Windows.Forms.Panel();
            this.plusBtn = new FontAwesome.Sharp.IconButton();
            this.minusBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quantity = new System.Windows.Forms.Label();
            this.padPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.paddingPanel = new System.Windows.Forms.Panel();
            this.buttonContainer = new System.Windows.Forms.Panel();
            this.addProductBtn = new FontAwesome.Sharp.IconButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.gridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.formPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.padPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 499);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(919, 30);
            this.bottomPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(40, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(841, 47);
            this.topPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(881, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(38, 499);
            this.rightPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(40, 499);
            this.leftPanel.TabIndex = 2;
            // 
            // gridContainer
            // 
            this.gridContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridContainer.Controls.Add(this.dataGridView1);
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(40, 112);
            this.gridContainer.Margin = new System.Windows.Forms.Padding(2);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.Size = new System.Drawing.Size(500, 387);
            this.gridContainer.TabIndex = 7;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 387);
            this.dataGridView1.TabIndex = 3;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formPanel.Controls.Add(this.panel1);
            this.formPanel.Controls.Add(this.padPanel);
            this.formPanel.Controls.Add(this.groupNameLabel);
            this.formPanel.Controls.Add(this.productNameLabel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formPanel.Location = new System.Drawing.Point(562, 112);
            this.formPanel.Margin = new System.Windows.Forms.Padding(2);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(319, 387);
            this.formPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 308);
            this.panel1.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveBtn.IconColor = System.Drawing.Color.Black;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.IconSize = 16;
            this.saveBtn.Location = new System.Drawing.Point(11, 111);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Rotation = 0D;
            this.saveBtn.Size = new System.Drawing.Size(53, 32);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(109)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 16;
            this.deleteBtn.Location = new System.Drawing.Point(174, 111);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(143, 33);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete from Inventory";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DimGray;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editBtn.IconColor = System.Drawing.Color.Black;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 16;
            this.editBtn.Location = new System.Drawing.Point(73, 111);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Rotation = 0D;
            this.editBtn.Size = new System.Drawing.Size(91, 32);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Edit Product";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 84);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 23);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.containerPanel);
            this.panel3.Controls.Add(this.plusBtn);
            this.panel3.Controls.Add(this.minusBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 41);
            this.panel3.TabIndex = 8;
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.containerPanel.Controls.Add(this.quantityBox);
            this.containerPanel.Controls.Add(this.panel10);
            this.containerPanel.Controls.Add(this.textboxContainer);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(48, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(221, 41);
            this.containerPanel.TabIndex = 20;
            // 
            // quantityBox
            // 
            this.quantityBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.quantityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.ForeColor = System.Drawing.Color.DimGray;
            this.quantityBox.Location = new System.Drawing.Point(16, 11);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityBox.Multiline = true;
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(205, 30);
            this.quantityBox.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(16, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(205, 11);
            this.panel10.TabIndex = 2;
            // 
            // textboxContainer
            // 
            this.textboxContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textboxContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.textboxContainer.Location = new System.Drawing.Point(0, 0);
            this.textboxContainer.Margin = new System.Windows.Forms.Padding(2);
            this.textboxContainer.Name = "textboxContainer";
            this.textboxContainer.Size = new System.Drawing.Size(16, 41);
            this.textboxContainer.TabIndex = 1;
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.plusBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.DimGray;
            this.plusBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plusBtn.IconColor = System.Drawing.Color.Black;
            this.plusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.plusBtn.IconSize = 16;
            this.plusBtn.Location = new System.Drawing.Point(269, 0);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Rotation = 0D;
            this.plusBtn.Size = new System.Drawing.Size(50, 41);
            this.plusBtn.TabIndex = 5;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minusBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.DimGray;
            this.minusBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.minusBtn.IconColor = System.Drawing.Color.Black;
            this.minusBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minusBtn.IconSize = 16;
            this.minusBtn.Location = new System.Drawing.Point(0, 0);
            this.minusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Rotation = 0D;
            this.minusBtn.Size = new System.Drawing.Size(48, 41);
            this.minusBtn.TabIndex = 4;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 26);
            this.panel2.TabIndex = 7;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantity.Location = new System.Drawing.Point(0, 0);
            this.quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(56, 17);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "Quantity";
            // 
            // padPanel
            // 
            this.padPanel.Controls.Add(this.panel8);
            this.padPanel.Controls.Add(this.emptyLabel);
            this.padPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.padPanel.Location = new System.Drawing.Point(0, 42);
            this.padPanel.Margin = new System.Windows.Forms.Padding(2);
            this.padPanel.Name = "padPanel";
            this.padPanel.Size = new System.Drawing.Size(319, 37);
            this.padPanel.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.productIdLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(250, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(69, 37);
            this.panel8.TabIndex = 12;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.Location = new System.Drawing.Point(4, 9);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(15, 17);
            this.productIdLabel.TabIndex = 9;
            this.productIdLabel.Text = "1";
            this.productIdLabel.Click += new System.EventHandler(this.productIdLabel_Click);
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLabel.Location = new System.Drawing.Point(4, 9);
            this.emptyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(225, 17);
            this.emptyLabel.TabIndex = 0;
            this.emptyLabel.Text = "Click on product to edit their quantity";
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupNameLabel.Location = new System.Drawing.Point(0, 25);
            this.groupNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(37, 17);
            this.groupNameLabel.TabIndex = 1;
            this.groupNameLabel.Text = "Book";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.productNameLabel.Location = new System.Drawing.Point(0, 0);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(99, 25);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Ramayana";
            // 
            // paddingPanel
            // 
            this.paddingPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(40, 80);
            this.paddingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(841, 32);
            this.paddingPanel.TabIndex = 11;
            // 
            // buttonContainer
            // 
            this.buttonContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonContainer.Controls.Add(this.addProductBtn);
            this.buttonContainer.Controls.Add(this.panel15);
            this.buttonContainer.Controls.Add(this.searchIcon);
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContainer.Location = new System.Drawing.Point(40, 47);
            this.buttonContainer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(841, 33);
            this.buttonContainer.TabIndex = 10;
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addProductBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addProductBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addProductBtn.IconColor = System.Drawing.Color.Black;
            this.addProductBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addProductBtn.IconSize = 16;
            this.addProductBtn.Location = new System.Drawing.Point(0, 0);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(22, 2, 2, 2);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.addProductBtn.Rotation = 0D;
            this.addProductBtn.Size = new System.Drawing.Size(158, 33);
            this.addProductBtn.TabIndex = 25;
            this.addProductBtn.Text = "+ New Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox1);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(595, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(196, 33);
            this.panel15.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(14, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type here to search..";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(14, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(182, 8);
            this.panel16.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(14, 33);
            this.panel17.TabIndex = 1;
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
            this.searchIcon.Location = new System.Drawing.Point(791, 0);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(2);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Padding = new System.Windows.Forms.Padding(2);
            this.searchIcon.Size = new System.Drawing.Size(50, 33);
            this.searchIcon.TabIndex = 23;
            this.searchIcon.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(540, 112);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(22, 387);
            this.panel9.TabIndex = 12;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 529);
            this.Controls.Add(this.gridContainer);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.gridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.padPanel.ResumeLayout(false);
            this.padPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.buttonContainer.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel gridContainer;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel paddingPanel;
        private System.Windows.Forms.Panel buttonContainer;
        private FontAwesome.Sharp.IconButton minusBtn;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label productNameLabel;
        private FontAwesome.Sharp.IconButton plusBtn;
        private System.Windows.Forms.Panel padPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton saveBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel textboxContainer;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton addProductBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}