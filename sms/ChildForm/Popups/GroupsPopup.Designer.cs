namespace SMS.ChildForm.Popups
{
    partial class GroupsPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsPopup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.descripionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 278);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.descripionBox);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dragPanel);
            this.panel2.Controls.Add(this.addEditBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 278);
            this.panel2.TabIndex = 8;
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
            this.deleteBtn.Location = new System.Drawing.Point(243, 197);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(97, 39);
            this.deleteBtn.TabIndex = 83;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(104, 114);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 2);
            this.panel6.TabIndex = 49;
            // 
            // descripionBox
            // 
            this.descripionBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descripionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripionBox.ForeColor = System.Drawing.Color.DimGray;
            this.descripionBox.Location = new System.Drawing.Point(104, 140);
            this.descripionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descripionBox.Name = "descripionBox";
            this.descripionBox.Size = new System.Drawing.Size(250, 22);
            this.descripionBox.TabIndex = 0;
            this.descripionBox.Enter += new System.EventHandler(this.descripionBox_Enter);
            this.descripionBox.Leave += new System.EventHandler(this.descripionBox_Leave);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(104, 92);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(104, 162);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name";
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(417, 57);
            this.dragPanel.TabIndex = 24;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(28, 18);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(103, 24);
            this.headerLabel.TabIndex = 13;
            this.headerLabel.Text = "Add Group";
            // 
            // addEditBtn
            // 
            this.addEditBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEditBtn.FlatAppearance.BorderSize = 0;
            this.addEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addEditBtn.Location = new System.Drawing.Point(132, 197);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(107, 39);
            this.addEditBtn.TabIndex = 17;
            this.addEditBtn.Text = "Add";
            this.addEditBtn.UseVisualStyleBackColor = false;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // GroupsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 278);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "GroupsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripionBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton deleteBtn;
    }
}