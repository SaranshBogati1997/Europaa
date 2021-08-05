using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SMS.ChildForm;
using Lib;

namespace SMS
{
    public partial class mainForm : Form
    {
        public static UserModel currentUser;
        public static CompanyModel currentCompany;
        string moduleName = "MAINFORM";
        public mainForm(UserModel activeUser, CompanyModel company)
        {
            try
            {
                InitializeComponent();
                currentCompany = company;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.DoubleBuffered = true;
                currentUser = activeUser;
                this.activeUser.Text = currentUser.Username;
                ToggleActivePanel("dashboard");
                OpenChildForm(new DashboardForm());

                iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                if (!string.IsNullOrEmpty(company.Logo))
                {
                Image img = Image.FromFile(company.Logo);
                iconPictureBox2.Image = (Image)img;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        private Form currentChildForm;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleActivePanel("dashboard");
                OpenChildForm(new DashboardForm());
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        private void ToggleActivePanel(string buttonName)
        {
            try
            {
                List<FontAwesome.Sharp.IconButton> btnList = new List<FontAwesome.Sharp.IconButton>()
            {
                dashboardBtn,
                financeBtn,
                reportBtn,
                purchaseBtn,
                salesBtn,
                //ledgerBtn,
                manageBtn
            };
                foreach (var btn in btnList)
                {
                    btn.BackColor = Color.FromArgb(34, 40, 49);
                    btn.ForeColor = Color.WhiteSmoke;
                    btn.IconColor = Color.WhiteSmoke;
                    if (btn.Name.ToString().Trim().Substring(0, btn.Name.Length - 3) == buttonName)
                    {
                        btn.BackColor = Color.FromArgb(0,173,181);
                        btn.ForeColor = Color.White;
                        btn.IconColor = Color.White;
                        selectedButtonIcon.IconChar = btn.IconChar;
                        selectedButtonIcon.IconColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }
        private void OpenChildForm(Form childForm)
        {
            try
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                childForm.BackColor = Color.WhiteSmoke;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(childForm);
                currentChildForm.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }


        }
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleActivePanel("inventory");
                OpenChildForm(new InventoryForm());
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleActivePanel("report");
                OpenChildForm(new ReportForm());

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }


        private void minimizeBtn_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
                else
                    WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                ToggleActivePanel("");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new SupplierForm());
                ToggleActivePanel("supplier");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }     

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm form = new LoginForm();
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new PurchaseForm());
                ToggleActivePanel("purchase");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new SalesForm());
                ToggleActivePanel("sales");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ledgerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenChildForm(new LedgerForm());
                ToggleActivePanel("ledger");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void financeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new FinanceForm());
                ToggleActivePanel("finance");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ManageForm());
                ToggleActivePanel("manage");
            }
            catch(Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }
        }

        private void selectedButtonIcon_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
