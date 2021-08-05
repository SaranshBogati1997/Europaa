namespace SMS.ChildForm
{
    partial class ManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.productsBtn = new FontAwesome.Sharp.IconButton();
            this.userBtn = new FontAwesome.Sharp.IconButton();
            this.groupsBtn = new FontAwesome.Sharp.IconButton();
            this.customerBtn = new FontAwesome.Sharp.IconButton();
            this.unitBtn = new FontAwesome.Sharp.IconButton();
            this.supplierBtn = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.productsBtn);
            this.bunifuGradientPanel1.Controls.Add(this.userBtn);
            this.bunifuGradientPanel1.Controls.Add(this.groupsBtn);
            this.bunifuGradientPanel1.Controls.Add(this.customerBtn);
            this.bunifuGradientPanel1.Controls.Add(this.unitBtn);
            this.bunifuGradientPanel1.Controls.Add(this.supplierBtn);
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1464, 788);
            this.bunifuGradientPanel1.TabIndex = 8;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.productsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.productsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.productsBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.productsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.productsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productsBtn.IconSize = 80;
            this.productsBtn.Location = new System.Drawing.Point(621, 219);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Rotation = 0D;
            this.productsBtn.Size = new System.Drawing.Size(219, 134);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Manage Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.SystemColors.Control;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.userBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.userBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.userBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userBtn.IconSize = 80;
            this.userBtn.Location = new System.Drawing.Point(43, 39);
            this.userBtn.Name = "userBtn";
            this.userBtn.Rotation = 0D;
            this.userBtn.Size = new System.Drawing.Size(219, 134);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Manage User";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // groupsBtn
            // 
            this.groupsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.groupsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupsBtn.FlatAppearance.BorderSize = 0;
            this.groupsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.groupsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.groupsBtn.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.groupsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.groupsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.groupsBtn.IconSize = 80;
            this.groupsBtn.Location = new System.Drawing.Point(621, 39);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Rotation = 0D;
            this.groupsBtn.Size = new System.Drawing.Size(219, 134);
            this.groupsBtn.TabIndex = 0;
            this.groupsBtn.Text = "Manage Groups";
            this.groupsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.groupsBtn.UseVisualStyleBackColor = false;
            this.groupsBtn.Click += new System.EventHandler(this.groupsBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.customerBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.customerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.customerBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.customerBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.customerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customerBtn.IconSize = 80;
            this.customerBtn.Location = new System.Drawing.Point(332, 39);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Rotation = 0D;
            this.customerBtn.Size = new System.Drawing.Size(219, 134);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Manage Customer";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // unitBtn
            // 
            this.unitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.unitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.unitBtn.FlatAppearance.BorderSize = 0;
            this.unitBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.unitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.unitBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.unitBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.unitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.unitBtn.IconSize = 80;
            this.unitBtn.Location = new System.Drawing.Point(329, 219);
            this.unitBtn.Name = "unitBtn";
            this.unitBtn.Rotation = 0D;
            this.unitBtn.Size = new System.Drawing.Size(222, 134);
            this.unitBtn.TabIndex = 0;
            this.unitBtn.Text = "Manage Units";
            this.unitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.unitBtn.UseVisualStyleBackColor = false;
            this.unitBtn.Click += new System.EventHandler(this.unitBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.SystemColors.Control;
            this.supplierBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierBtn.FlatAppearance.BorderSize = 0;
            this.supplierBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.supplierBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.supplierBtn.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.supplierBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.supplierBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.supplierBtn.IconSize = 80;
            this.supplierBtn.Location = new System.Drawing.Point(40, 219);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Rotation = 0D;
            this.supplierBtn.Size = new System.Drawing.Size(222, 134);
            this.supplierBtn.TabIndex = 0;
            this.supplierBtn.Text = "Manage Supplier";
            this.supplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 609);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage ";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private FontAwesome.Sharp.IconButton productsBtn;
        private FontAwesome.Sharp.IconButton userBtn;
        private FontAwesome.Sharp.IconButton groupsBtn;
        private FontAwesome.Sharp.IconButton customerBtn;
        private FontAwesome.Sharp.IconButton unitBtn;
        private FontAwesome.Sharp.IconButton supplierBtn;
    }
}