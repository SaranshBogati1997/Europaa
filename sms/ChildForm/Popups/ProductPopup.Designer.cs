namespace SMS.ChildForm.Popups
{
    partial class ProductPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPopup));
            this.dragPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.salesPanel = new System.Windows.Forms.Panel();
            this.costPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.vatPanel = new System.Windows.Forms.Panel();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.enableVat = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.addGroupBtn = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupsDropdown = new System.Windows.Forms.ComboBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.unitDropDown = new System.Windows.Forms.ComboBox();
            this.addUnitBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.dragPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(806, 66);
            this.dragPanel.TabIndex = 25;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown_1);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(20, 18);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(134, 30);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Add Product";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(122, 112);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 25);
            this.nameBox.TabIndex = 0;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 16;
            this.deleteBtn.Location = new System.Drawing.Point(661, 377);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(112, 39);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addEditBtn
            // 
            this.addEditBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEditBtn.FlatAppearance.BorderSize = 0;
            this.addEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addEditBtn.Location = new System.Drawing.Point(529, 377);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(128, 39);
            this.addEditBtn.TabIndex = 26;
            this.addEditBtn.Text = "Add/ Edit";
            this.addEditBtn.UseVisualStyleBackColor = false;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cost Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(217, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sales Price";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.salesPanel);
            this.panel5.Controls.Add(this.costPanel);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(24, 265);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(422, 68);
            this.panel5.TabIndex = 40;
            // 
            // salesPanel
            // 
            this.salesPanel.BackColor = System.Drawing.Color.DarkGray;
            this.salesPanel.Location = new System.Drawing.Point(294, 50);
            this.salesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(103, 2);
            this.salesPanel.TabIndex = 49;
            // 
            // costPanel
            // 
            this.costPanel.BackColor = System.Drawing.Color.DarkGray;
            this.costPanel.Location = new System.Drawing.Point(89, 50);
            this.costPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.costPanel.Name = "costPanel";
            this.costPanel.Size = new System.Drawing.Size(103, 2);
            this.costPanel.TabIndex = 48;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.vatPanel);
            this.panel7.Controls.Add(this.vatBox);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.enableVat);
            this.panel7.Location = new System.Drawing.Point(456, 265);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 71);
            this.panel7.TabIndex = 41;
            // 
            // vatPanel
            // 
            this.vatPanel.BackColor = System.Drawing.Color.DarkGray;
            this.vatPanel.Location = new System.Drawing.Point(147, 50);
            this.vatPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vatPanel.Name = "vatPanel";
            this.vatPanel.Size = new System.Drawing.Size(103, 2);
            this.vatPanel.TabIndex = 49;
            // 
            // vatBox
            // 
            this.vatBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vatBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatBox.ForeColor = System.Drawing.Color.DimGray;
            this.vatBox.Location = new System.Drawing.Point(147, 24);
            this.vatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vatBox.Name = "vatBox";
            this.vatBox.Size = new System.Drawing.Size(103, 25);
            this.vatBox.TabIndex = 1;
            this.vatBox.Enter += new System.EventHandler(this.vatBox_Enter);
            this.vatBox.Leave += new System.EventHandler(this.vatBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(92, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "VAT(%)";
            // 
            // enableVat
            // 
            this.enableVat.AutoSize = true;
            this.enableVat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enableVat.Location = new System.Drawing.Point(18, 24);
            this.enableVat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enableVat.Name = "enableVat";
            this.enableVat.Size = new System.Drawing.Size(55, 25);
            this.enableVat.TabIndex = 0;
            this.enableVat.Text = "VAT";
            this.enableVat.UseVisualStyleBackColor = true;
            this.enableVat.CheckedChanged += new System.EventHandler(this.enableVat_CheckedChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel11.Location = new System.Drawing.Point(0, 153);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1046, 2);
            this.panel11.TabIndex = 42;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.addGroupBtn);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Controls.Add(this.groupsDropdown);
            this.panel13.Location = new System.Drawing.Point(24, 183);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(422, 65);
            this.panel13.TabIndex = 43;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addGroupBtn.FlatAppearance.BorderSize = 0;
            this.addGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addGroupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addGroupBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addGroupBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addGroupBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addGroupBtn.IconSize = 30;
            this.addGroupBtn.Location = new System.Drawing.Point(358, 20);
            this.addGroupBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Rotation = 0D;
            this.addGroupBtn.Size = new System.Drawing.Size(29, 29);
            this.addGroupBtn.TabIndex = 47;
            this.addGroupBtn.UseVisualStyleBackColor = false;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(30, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Group";
            // 
            // groupsDropdown
            // 
            this.groupsDropdown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsDropdown.ForeColor = System.Drawing.Color.DimGray;
            this.groupsDropdown.FormattingEnabled = true;
            this.groupsDropdown.Location = new System.Drawing.Point(81, 20);
            this.groupsDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsDropdown.Name = "groupsDropdown";
            this.groupsDropdown.Size = new System.Drawing.Size(273, 29);
            this.groupsDropdown.TabIndex = 39;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.unitDropDown);
            this.panel18.Controls.Add(this.addUnitBtn);
            this.panel18.Controls.Add(this.label7);
            this.panel18.Location = new System.Drawing.Point(454, 183);
            this.panel18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(317, 65);
            this.panel18.TabIndex = 44;
            // 
            // unitDropDown
            // 
            this.unitDropDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unitDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitDropDown.ForeColor = System.Drawing.Color.DimGray;
            this.unitDropDown.FormattingEnabled = true;
            this.unitDropDown.Location = new System.Drawing.Point(49, 19);
            this.unitDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitDropDown.Name = "unitDropDown";
            this.unitDropDown.Size = new System.Drawing.Size(139, 29);
            this.unitDropDown.TabIndex = 38;
            this.unitDropDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unitDropDown_KeyDown);
            // 
            // addUnitBtn
            // 
            this.addUnitBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addUnitBtn.FlatAppearance.BorderSize = 0;
            this.addUnitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUnitBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addUnitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addUnitBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addUnitBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(115)))), ((int)(((byte)(77)))));
            this.addUnitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addUnitBtn.IconSize = 30;
            this.addUnitBtn.Location = new System.Drawing.Point(192, 20);
            this.addUnitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUnitBtn.Name = "addUnitBtn";
            this.addUnitBtn.Rotation = 0D;
            this.addUnitBtn.Size = new System.Drawing.Size(22, 29);
            this.addUnitBtn.TabIndex = 48;
            this.addUnitBtn.UseVisualStyleBackColor = false;
            this.addUnitBtn.Click += new System.EventHandler(this.addUnitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(406, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Description";
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.DarkGray;
            this.namePanel.Location = new System.Drawing.Point(122, 137);
            this.namePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(250, 2);
            this.namePanel.TabIndex = 47;
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionBox.Location = new System.Drawing.Point(488, 112);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(250, 25);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.DarkGray;
            this.descriptionPanel.Location = new System.Drawing.Point(488, 138);
            this.descriptionPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(250, 2);
            this.descriptionPanel.TabIndex = 48;
            // 
            // ProductPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 437);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.dragPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ProductPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetailsModel";
            this.Load += new System.EventHandler(this.ProductPopup_Load);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox nameBox;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox enableVat;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton addGroupBtn;
        private System.Windows.Forms.ComboBox unitDropDown;
        private FontAwesome.Sharp.IconButton addUnitBtn;
        private System.Windows.Forms.ComboBox groupsDropdown;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Panel costPanel;
        private System.Windows.Forms.TextBox PriceBox;
        //private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Panel vatPanel;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Panel descriptionPanel;
    }
}