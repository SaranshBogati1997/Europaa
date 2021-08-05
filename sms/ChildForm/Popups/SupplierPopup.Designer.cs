namespace SMS.ChildForm
{
    partial class SupplierPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierPopup));
            this.dragPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vatPanel = new System.Windows.Forms.Panel();
            this.vatBox = new System.Windows.Forms.TextBox();
            this.mobilePanel = new System.Windows.Forms.Panel();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dragPanel.Controls.Add(this.panel1);
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(406, 66);
            this.dragPanel.TabIndex = 24;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown_1);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.headerLabel.Location = new System.Drawing.Point(196, 25);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(139, 30);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Add Supplier";
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
            this.deleteBtn.Location = new System.Drawing.Point(288, 308);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(66, 38);
            this.deleteBtn.TabIndex = 18;
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
            this.addEditBtn.Location = new System.Drawing.Point(179, 308);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(97, 38);
            this.addEditBtn.TabIndex = 17;
            this.addEditBtn.Text = "Add/ Edit";
            this.addEditBtn.UseVisualStyleBackColor = false;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Vat No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Name";
            // 
            // vatPanel
            // 
            this.vatPanel.BackColor = System.Drawing.Color.DarkGray;
            this.vatPanel.Location = new System.Drawing.Point(109, 276);
            this.vatPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vatPanel.Name = "vatPanel";
            this.vatPanel.Size = new System.Drawing.Size(245, 2);
            this.vatPanel.TabIndex = 73;
            // 
            // vatBox
            // 
            this.vatBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vatBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatBox.ForeColor = System.Drawing.Color.DimGray;
            this.vatBox.Location = new System.Drawing.Point(111, 257);
            this.vatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vatBox.Name = "vatBox";
            this.vatBox.Size = new System.Drawing.Size(245, 18);
            this.vatBox.TabIndex = 68;
            this.vatBox.TextChanged += new System.EventHandler(this.vatBox_TextChanged);
            this.vatBox.Enter += new System.EventHandler(this.vatBox_Enter);
            this.vatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vatBox_KeyDown);
            this.vatBox.Leave += new System.EventHandler(this.vatBox_Leave);
            // 
            // mobilePanel
            // 
            this.mobilePanel.BackColor = System.Drawing.Color.DarkGray;
            this.mobilePanel.Location = new System.Drawing.Point(109, 222);
            this.mobilePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobilePanel.Name = "mobilePanel";
            this.mobilePanel.Size = new System.Drawing.Size(245, 2);
            this.mobilePanel.TabIndex = 69;
            // 
            // mobileBox
            // 
            this.mobileBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mobileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileBox.ForeColor = System.Drawing.Color.DimGray;
            this.mobileBox.Location = new System.Drawing.Point(111, 203);
            this.mobileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(245, 18);
            this.mobileBox.TabIndex = 67;
            this.mobileBox.TextChanged += new System.EventHandler(this.mobileBox_TextChanged);
            this.mobileBox.Enter += new System.EventHandler(this.mobileBox_Enter);
            this.mobileBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mobileBox_KeyDown);
            this.mobileBox.Leave += new System.EventHandler(this.mobileBox_Leave);
            // 
            // addressPanel
            // 
            this.addressPanel.BackColor = System.Drawing.Color.DarkGray;
            this.addressPanel.Location = new System.Drawing.Point(109, 172);
            this.addressPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(245, 2);
            this.addressPanel.TabIndex = 70;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.DimGray;
            this.addressBox.Location = new System.Drawing.Point(111, 154);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(245, 18);
            this.addressBox.TabIndex = 66;
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.DarkGray;
            this.namePanel.Location = new System.Drawing.Point(109, 120);
            this.namePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(245, 2);
            this.namePanel.TabIndex = 63;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(111, 102);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(245, 18);
            this.nameBox.TabIndex = 62;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 66);
            this.panel1.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Supplier";
            // 
            // SupplierPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 386);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vatPanel);
            this.Controls.Add(this.vatBox);
            this.Controls.Add(this.mobilePanel);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addEditBtn);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SupplierPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierPopup";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label headerLabel;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel vatPanel;
        private System.Windows.Forms.TextBox vatBox;
        private System.Windows.Forms.Panel mobilePanel;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}