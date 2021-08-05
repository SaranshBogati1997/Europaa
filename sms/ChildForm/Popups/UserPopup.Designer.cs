namespace SMS.ChildForm.Popups
{
    partial class UserPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPopup));
            this.addEditBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eyeBtn2 = new FontAwesome.Sharp.IconButton();
            this.eyeBtn = new FontAwesome.Sharp.IconButton();
            this.isAdminPanel = new System.Windows.Forms.Panel();
            this.isAdminBox = new System.Windows.Forms.TextBox();
            this.mobilePanel = new System.Windows.Forms.Panel();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.confirmPwPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.pwPanel = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEditBtn
            // 
            this.addEditBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addEditBtn.FlatAppearance.BorderSize = 0;
            this.addEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEditBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addEditBtn.Location = new System.Drawing.Point(164, 412);
            this.addEditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(76, 39);
            this.addEditBtn.TabIndex = 6;
            this.addEditBtn.Text = "Add/ Edit";
            this.addEditBtn.UseVisualStyleBackColor = false;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(244, 412);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Rotation = 0D;
            this.deleteBtn.Size = new System.Drawing.Size(72, 39);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eyeBtn2);
            this.panel1.Controls.Add(this.eyeBtn);
            this.panel1.Controls.Add(this.isAdminPanel);
            this.panel1.Controls.Add(this.isAdminBox);
            this.panel1.Controls.Add(this.mobilePanel);
            this.panel1.Controls.Add(this.mobileBox);
            this.panel1.Controls.Add(this.addressPanel);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.confirmPwPanel);
            this.panel1.Controls.Add(this.confirmPasswordBox);
            this.panel1.Controls.Add(this.pwPanel);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.namePanel);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.dragPanel);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addEditBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 479);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "User rights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Confirm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Password";
            // 
            // eyeBtn2
            // 
            this.eyeBtn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eyeBtn2.FlatAppearance.BorderSize = 0;
            this.eyeBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeBtn2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.eyeBtn2.IconColor = System.Drawing.Color.Black;
            this.eyeBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eyeBtn2.IconSize = 20;
            this.eyeBtn2.Location = new System.Drawing.Point(295, 196);
            this.eyeBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.eyeBtn2.Name = "eyeBtn2";
            this.eyeBtn2.Rotation = 0D;
            this.eyeBtn2.Size = new System.Drawing.Size(22, 27);
            this.eyeBtn2.TabIndex = 20;
            this.eyeBtn2.TabStop = false;
            this.eyeBtn2.UseVisualStyleBackColor = false;
            this.eyeBtn2.Click += new System.EventHandler(this.eyeBtn2_Click);
            // 
            // eyeBtn
            // 
            this.eyeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eyeBtn.FlatAppearance.BorderSize = 0;
            this.eyeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.eyeBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.eyeBtn.IconColor = System.Drawing.Color.Black;
            this.eyeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.eyeBtn.IconSize = 20;
            this.eyeBtn.Location = new System.Drawing.Point(295, 142);
            this.eyeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eyeBtn.Name = "eyeBtn";
            this.eyeBtn.Rotation = 0D;
            this.eyeBtn.Size = new System.Drawing.Size(22, 27);
            this.eyeBtn.TabIndex = 20;
            this.eyeBtn.TabStop = false;
            this.eyeBtn.UseVisualStyleBackColor = false;
            this.eyeBtn.Click += new System.EventHandler(this.eyeBtn_Click);
            // 
            // isAdminPanel
            // 
            this.isAdminPanel.BackColor = System.Drawing.Color.DarkGray;
            this.isAdminPanel.Location = new System.Drawing.Point(137, 380);
            this.isAdminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isAdminPanel.Name = "isAdminPanel";
            this.isAdminPanel.Size = new System.Drawing.Size(180, 2);
            this.isAdminPanel.TabIndex = 53;
            // 
            // isAdminBox
            // 
            this.isAdminBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.isAdminBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isAdminBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminBox.ForeColor = System.Drawing.Color.DimGray;
            this.isAdminBox.Location = new System.Drawing.Point(137, 360);
            this.isAdminBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(180, 18);
            this.isAdminBox.TabIndex = 52;
            this.isAdminBox.Enter += new System.EventHandler(this.isAdminBox_Enter);
            this.isAdminBox.Leave += new System.EventHandler(this.isAdminBox_Leave);
            // 
            // mobilePanel
            // 
            this.mobilePanel.BackColor = System.Drawing.Color.DarkGray;
            this.mobilePanel.Location = new System.Drawing.Point(137, 327);
            this.mobilePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobilePanel.Name = "mobilePanel";
            this.mobilePanel.Size = new System.Drawing.Size(180, 2);
            this.mobilePanel.TabIndex = 53;
            // 
            // mobileBox
            // 
            this.mobileBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mobileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileBox.ForeColor = System.Drawing.Color.DimGray;
            this.mobileBox.Location = new System.Drawing.Point(137, 309);
            this.mobileBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(180, 18);
            this.mobileBox.TabIndex = 52;
            this.mobileBox.Enter += new System.EventHandler(this.mobileBox_Enter);
            this.mobileBox.Leave += new System.EventHandler(this.mobileBox_Leave);
            // 
            // addressPanel
            // 
            this.addressPanel.BackColor = System.Drawing.Color.DarkGray;
            this.addressPanel.Location = new System.Drawing.Point(137, 277);
            this.addressPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(180, 2);
            this.addressPanel.TabIndex = 53;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.ForeColor = System.Drawing.Color.DimGray;
            this.addressBox.Location = new System.Drawing.Point(136, 259);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(180, 18);
            this.addressBox.TabIndex = 52;
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // confirmPwPanel
            // 
            this.confirmPwPanel.BackColor = System.Drawing.Color.DarkGray;
            this.confirmPwPanel.Location = new System.Drawing.Point(137, 228);
            this.confirmPwPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPwPanel.Name = "confirmPwPanel";
            this.confirmPwPanel.Size = new System.Drawing.Size(180, 2);
            this.confirmPwPanel.TabIndex = 53;
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.confirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordBox.ForeColor = System.Drawing.Color.DimGray;
            this.confirmPasswordBox.Location = new System.Drawing.Point(137, 208);
            this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(137, 18);
            this.confirmPasswordBox.TabIndex = 52;
            this.confirmPasswordBox.Enter += new System.EventHandler(this.confirmPasswordBox_Enter);
            this.confirmPasswordBox.Leave += new System.EventHandler(this.confirmPasswordBox_Leave);
            // 
            // pwPanel
            // 
            this.pwPanel.BackColor = System.Drawing.Color.DarkGray;
            this.pwPanel.Location = new System.Drawing.Point(137, 173);
            this.pwPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwPanel.Name = "pwPanel";
            this.pwPanel.Size = new System.Drawing.Size(180, 2);
            this.pwPanel.TabIndex = 53;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordBox.Location = new System.Drawing.Point(136, 156);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(137, 18);
            this.passwordBox.TabIndex = 52;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.DarkGray;
            this.namePanel.Location = new System.Drawing.Point(137, 115);
            this.namePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(180, 2);
            this.namePanel.TabIndex = 51;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.Location = new System.Drawing.Point(136, 97);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 18);
            this.nameBox.TabIndex = 50;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dragPanel.Controls.Add(this.headerLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(365, 66);
            this.dragPanel.TabIndex = 16;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(32, 20);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(103, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Add User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Password";
            // 
            // UserPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(365, 479);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UserPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPopup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addEditBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel dragPanel;
        private FontAwesome.Sharp.IconButton eyeBtn2;
        private FontAwesome.Sharp.IconButton eyeBtn;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel isAdminPanel;
        private System.Windows.Forms.TextBox isAdminBox;
        private System.Windows.Forms.Panel mobilePanel;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Panel confirmPwPanel;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Panel pwPanel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}