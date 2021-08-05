using Lib;
using SMS.Prompt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm.Popups
{
    public partial class UserPopup : Form
    {
        public UserModel selectedUser;
        string moduleName = "USERPOPUP";
        public UserPopup()
        {
            try
            {
                InitializeComponent();
                headerLabel.Text = "Add Users";
                InitializeButtons();
                selectedUser = new UserModel();
                // this.Size = new Size(570, 600);
                this.eyeBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                this.passwordBox.PasswordChar = '\0';
                this.eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                this.confirmPasswordBox.PasswordChar = '\0';

                nameBox.TabIndex = 0;
                passwordBox.TabIndex = 1;
                confirmPasswordBox.TabIndex = 2;
                addressBox.TabIndex = 3;
                mobileBox.TabIndex = 4;

                isAdminBox.Visible = false;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        public UserPopup(UserModel user)
        {
            try
            {
                InitializeComponent();
                //this.Size = new Size(570, 600);
                selectedUser = user;
                headerLabel.Text = "Manage Users";
                this.nameBox.Text = user.Username;
                this.addressBox.Text = user.Address;
                this.mobileBox.Text = user.MobileNo.ToString();
                string role = user.IsAdmin == true ? "Admin" : "User";
                this.isAdminBox.Text = role;
                passwordBox.Text = user.Password;
                confirmPasswordBox.Text = user.Password;
                this.isAdminBox.Enabled = false;
                if (user.IsAdmin == true)
                {
                    this.nameBox.Enabled = false;
                    this.addressBox.Enabled = false;
                    this.mobileBox.Enabled = false;
                    this.isAdminBox.Enabled = false;
                    addEditBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                }
                addEditBtn.Text = "Edit User";
                deleteBtn.Text = "Delete";
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text == string.Empty || addressBox.Text == string.Empty || mobileBox.Text == string.Empty || passwordBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Please fill all the filds to submit");
                    return;
                }
                else if(nameBox.Text.Contains("Enter") || addressBox.Text.Contains("Enter") || mobileBox.Text.Contains("Enter") || passwordBox.Text.Contains("Enter"))
                {
                    Helper.ShowInfo("Please fill all the filds to submit");
                    return;
                }
                bool isValid = ValidateInput();
                //if user is being added
                if (isValid == false)
                {
                    if (passwordBox.Text != confirmPasswordBox.Text)
                    {
                        Helper.ShowInfo("Passwords do not match");
                    }
                    else
                    {
                        Helper.ShowInfo("Invalid mobile number ! Cannot submit form");
                    }
                    return;
                }
                selectedUser.Username = this.nameBox.Text;
                selectedUser.Address = this.addressBox.Text;
                selectedUser.IsAdmin = false;
                selectedUser.MobileNo = Convert.ToInt64(mobileBox.Text);
                selectedUser.Password = passwordBox.Text;
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }


        private void InitializeButtons()
        {

            this.nameBox.Text = "Enter name here..";
            this.addressBox.Text = "Enter address here..";
            this.mobileBox.Text = "Enter mobile number here..";
            this.passwordBox.Text = "Enter password here..";
            this.confirmPasswordBox.Text = "Re-enter password..";

            passwordBox.ForeColor = Color.DimGray;
            confirmPasswordBox.ForeColor = Color.DimGray;

            this.nameBox.GotFocus += NameBox_GotFocus;
            this.addressBox.GotFocus += AddressBox_GotFocus;
            this.mobileBox.GotFocus += MobileBox_GotFocus;

            this.passwordBox.GotFocus += PasswordBox_GotFocus;
            this.passwordBox.LostFocus += PasswordBox_LostFocus;
            this.confirmPasswordBox.GotFocus += ConfirmPasswordBox_GotFocus;
            this.confirmPasswordBox.LostFocus += ConfirmPasswordBox_LostFocus;

            nameBox.LostFocus += NameBox_LostFocus;
            addressBox.LostFocus += AddressBox_LostFocus;
            mobileBox.LostFocus += MobileBox_LostFocus;

            addEditBtn.Text = "Add User";
            deleteBtn.Text = "Clear";
        }



        private void MobileBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mobileBox.Text))
            {
                mobileBox.Text = "Enter mobile number here..";
            }
        }

        private void AddressBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addressBox.Text))
            {
                addressBox.Text = "Enter address here..";
            }
        }

        private void NameBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                nameBox.Text = "Enter name here..";
            }
        }

        private void MobileBox_GotFocus(object sender, EventArgs e)
        {
            if (mobileBox.Text == "Enter mobile number here..")
                mobileBox.Text = "";
        }

        private void AddressBox_GotFocus(object sender, EventArgs e)
        {
            if (addressBox.Text == "Enter address here..")
                addressBox.Text = "";
        }

        private void NameBox_GotFocus(object sender, EventArgs e)
        {
            if (nameBox.Text == "Enter name here..")
                nameBox.Text = "";
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteBtn.Text == "Clear")
                {
                    nameBox.Text = "Enter name here..";
                    addressBox.Text = "Enter address here..";
                    mobileBox.Text = "Enter mobile number here..";
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PasswordBox_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(passwordBox.Text))
                {
                    passwordBox.Text = "Enter password here..";
                    eyeBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordBox.PasswordChar = '\0';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        private void PasswordBox_GotFocus(object sender, EventArgs e)
        {
            try
            {
                if (passwordBox.Text == "Enter password here..")
                {
                    passwordBox.Text = "";
                    eyeBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    passwordBox.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }
        private void ConfirmPasswordBox_GotFocus(object sender, EventArgs e)
        {
            try
            {
                if (confirmPasswordBox.Text == "Re-enter password..")
                {
                    confirmPasswordBox.Text = "";
                    eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    confirmPasswordBox.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }
        private void ConfirmPasswordBox_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(confirmPasswordBox.Text))
                {
                    confirmPasswordBox.Text = "Re-enter password..";
                    eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    confirmPasswordBox.PasswordChar = '\0';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }
        private bool ValidateInput()
        {
            bool isValid = false;
            try
            {
                var isNumber = double.TryParse(mobileBox.Text, out _);

                if (isNumber == true && (confirmPasswordBox.Text == passwordBox.Text))
                {
                    isValid = true;
                }
                return isValid;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void eyeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (eyeBtn.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    eyeBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    passwordBox.PasswordChar = '\0';
                }
                else
                {
                    eyeBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    passwordBox.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void eyeBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (eyeBtn2.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    confirmPasswordBox.PasswordChar = '\0';
                }
                else
                {
                    eyeBtn2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    confirmPasswordBox.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            namePanel =  Helper.HandleFocusEnter(namePanel);
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            namePanel = Helper.HandleFocusLeave(namePanel);
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            pwPanel = Helper.HandleFocusEnter(pwPanel);

        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            pwPanel = Helper.HandleFocusLeave(pwPanel);

        }

        private void confirmPasswordBox_Enter(object sender, EventArgs e)
        {
            confirmPwPanel = Helper.HandleFocusEnter(confirmPwPanel);

        }

        private void confirmPasswordBox_Leave(object sender, EventArgs e)
        {
            confirmPwPanel = Helper.HandleFocusLeave(confirmPwPanel);

        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            addressPanel = Helper.HandleFocusEnter(addressPanel);

        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            addressPanel = Helper.HandleFocusLeave(addressPanel);

        }

        private void mobileBox_Enter(object sender, EventArgs e)
        {
            mobilePanel = Helper.HandleFocusEnter(mobilePanel);

        }

        private void mobileBox_Leave(object sender, EventArgs e)
        {
            mobilePanel = Helper.HandleFocusLeave(mobilePanel);

        }

        private void isAdminBox_Enter(object sender, EventArgs e)
        {
            isAdminPanel = Helper.HandleFocusEnter(isAdminPanel);

        }

        private void isAdminBox_Leave(object sender, EventArgs e)
        {
            isAdminPanel = Helper.HandleFocusLeave(isAdminPanel);

        }
    }
}
