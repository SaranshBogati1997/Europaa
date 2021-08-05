using Lib;
using Lib.Service;
using SMS.ChildForm.Popups;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class LoginForm : Form
    {
        string moduleName = "LOGINFORM";
        private string myDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        IUserService _userService;
        public LoginForm()
        {
            try
            {
                InitializeComponent();
                InitializeButtons();
                _userService = new UserRepository();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void InitializeButtons()
        {
           
        }

        

        private void billBox_Enter(object sender, EventArgs e)
        {
            billPanel = Helper.HandleFocusEnter(billPanel);
        }

        private void billBox_Leave(object sender, EventArgs e)
        {
            billPanel = Helper.HandleFocusLeave(billPanel);
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                PerformLogin();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
        }

        public void PerformLogin()
        {
            UserModel user = new UserModel()
            {
                Username = UsernameInput.Text,
                Password = passwordInput.Text
            };
            bool userExists = _userService.CheckUserLogin(user);
            if (userExists == true)
            {
                CompanySelectorForm form = new CompanySelectorForm(user);
                form.Show();
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else
            {
                Helper.ShowInfo("Error!!The Username/ Password is wrong!! Please try again");
            }
        }
        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    PerformLogin();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
            
                
        }
    }

}
