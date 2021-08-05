namespace SMS.ChildForm.Popups
{
    partial class UnitPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitPopup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shortNameBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Unit Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(26, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Short Name";
            // 
            // addEditBtn
            // 
            this.addEditBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEditBtn.FlatAppearance.BorderSize = 0;
            this.addEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addEditBtn.Location = new System.Drawing.Point(158, 198);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(78, 35);
            this.addEditBtn.TabIndex = 36;
            this.addEditBtn.Text = "Add";
            this.addEditBtn.UseVisualStyleBackColor = false;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(122, 112);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 2);
            this.panel6.TabIndex = 51;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(122, 92);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(194, 18);
            this.nameBox.TabIndex = 50;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(122, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 2);
            this.panel1.TabIndex = 53;
            // 
            // shortNameBox
            // 
            this.shortNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.shortNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shortNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortNameBox.ForeColor = System.Drawing.Color.DimGray;
            this.shortNameBox.Location = new System.Drawing.Point(122, 144);
            this.shortNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shortNameBox.Name = "shortNameBox";
            this.shortNameBox.Size = new System.Drawing.Size(194, 18);
            this.shortNameBox.TabIndex = 52;
            this.shortNameBox.Enter += new System.EventHandler(this.shortNameBox_Enter);
            this.shortNameBox.Leave += new System.EventHandler(this.shortNameBox_Leave);
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
            this.deleteBtn.Location = new System.Drawing.Point(250, 198);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(66, 35);
            this.deleteBtn.TabIndex = 82;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(371, 66);
            this.dragPanel.TabIndex = 83;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(32, 27);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(86, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add Unit";
            // 
            // UnitPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(371, 256);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shortNameBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UnitPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox shortNameBox;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label headerLabel;
    }
}