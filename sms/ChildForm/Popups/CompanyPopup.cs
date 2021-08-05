using Lib;
using Lib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm.Popups
{
    public partial class CompanyPopup : Form
    {
        string imagePath = "";
        List<Label> warningLabels;
        UserModel activeUser;
        ICompanyService _companyService;
        public CompanyPopup(UserModel user)
        {
            try
            {
                activeUser = user;
                InitializeComponent();
                warningLabels = new List<Label>();
                _companyService = new CompanyRepository();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    logoBox.Text = imagePath;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        private void CompanyPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CompanySelectorForm form = new CompanySelectorForm(activeUser);
            form.Show();
            this.ShowInTaskbar = false;
            this.Hide();

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Label label in warningLabels)
                {
                    if (label.Visible == true)
                    {
                        return;
                    }
                }
                bool isMobileValid = double.TryParse(mobileBox.Text, out double mobileNumber);
                bool isPhoneValid = double.TryParse(phoneBox.Text, out double phoneNumber);
                bool isPanValid = double.TryParse(panBox.Text, out double panNumber);
                if ((mobileBox.Text != string.Empty && isMobileValid == false) || isPhoneValid == false)
                {

                    Helper.ShowInfo("Invalid mobile or phone number");
                    return;
                }
                if (isPanValid == false || panNumber.ToString().Length != 9)
                {
                    Helper.ShowInfo("Invalid PAN number");
                    return;
                }
                CompanyModel company = new CompanyModel()
                {
                    CompanyName = nameBox.Text,
                    City = cityBox.Text,
                    State = stateBox.Text,
                    Country = countryBox.Text,
                    Logo = logoBox.Text,
                    MobileNumber = Convert.ToInt32(mobileNumber),
                    PhoneNumber = Convert.ToInt32(phoneNumber),
                    PAN = Convert.ToInt32(panNumber),
                    StartDate = dateTimePicker1.Text
                };
                bool isAdded = _companyService.InsertCompany(company);
                if (isAdded == true)
                {
                    Helper.ShowInfo("Company " + company.CompanyName + " created successfully");
                    CompanySelectorForm form = new CompanySelectorForm(activeUser);
                    form.Show();
                    this.ShowInTaskbar = false;
                    this.Hide();

                }
                else
                {
                    Helper.ShowInfo("Failed to create company");
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                
            }

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}
