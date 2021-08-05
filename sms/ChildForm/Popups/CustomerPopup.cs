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
    public partial class CustomerPopup : Form
    {
        public CustomerModel selectedCustomer { get; set; }
        string moduleName = "CUSTOMERPOPUP";
        bool isValid = false;
        ICustomerService _customerService;
        public CustomerPopup()
        {
            selectedCustomer = new CustomerModel();
            _customerService = new CustomerRepository();
            InitializeComponent();
            
            addEditBtn.Text = "Add";
            deleteBtn.Text = "Clear";
        }
        public CustomerPopup(CustomerModel customer)
        {
            selectedCustomer = customer;
            InitializeComponent();
            nameBox.Text = customer.CustomerName;
            addressBox.Text = customer.CustomerAddress;
            mobileBox.Text = customer.CustomerMobileNo.ToString();
            vatBox.Text = customer.CustomerVatNo.ToString();

            addEditBtn.Text = "Edit";
            deleteBtn.Text = "Delete";
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = ValidateInput();
                if (nameBox.Text == string.Empty || addressBox.Text == string.Empty || mobileBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Please fill all the filds to submit");
                    return;
                }
                if (isValid == false)
                {
                    MessageBox.Show("Invalid mobile number ! Cannot submit form");
                    return;
                }

                selectedCustomer.CustomerName = nameBox.Text;
                selectedCustomer.CustomerAddress= addressBox.Text;
                selectedCustomer.CustomerMobileNo= Convert.ToInt64(mobileBox.Text);
                if (vatBox.Text != string.Empty) selectedCustomer.CustomerVatNo= Convert.ToInt64(vatBox.Text);
                bool isAdded = _customerService.AddCustomer(selectedCustomer);

                if (isAdded == true) this.DialogResult = DialogResult.OK;
                else this.DialogResult = DialogResult.No;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private bool ValidateInput()
        {
            var isNumber = double.TryParse(mobileBox.Text, out _);
            if (isNumber == true)
            {
                isValid = true;
            }
            return isValid;

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            namePanel = Helper.HandleFocusEnter(namePanel);
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            namePanel = Helper.HandleFocusLeave(namePanel);

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

        private void vatBox_Enter(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusEnter(vatPanel);

        }

        private void vatBox_Leave(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusLeave(vatPanel);

        }

        private void vatBox_TextChanged(object sender, EventArgs e)
        {

            bool isDouble = double.TryParse(vatBox.Text, out _);
            if (isDouble == false) vatPanel.BackColor = Color.IndianRed;
            else vatPanel = Helper.HandleFocusEnter(vatPanel);

        }

        private void vatBox_KeyDown(object sender, KeyEventArgs e)
        {
            vatBox.ReadOnly = false;
            if (vatBox.TextLength == 9)
            {
                if (e.KeyCode == Keys.Back)
                {
                    vatBox.ReadOnly = false;
                }
                else vatBox.ReadOnly = true;
            }

        }

        private void mobileBox_KeyDown(object sender, KeyEventArgs e)
        {
            mobileBox.ReadOnly = false;
            if (mobileBox.TextLength == 10)
            {
                if (e.KeyCode == Keys.Back)
                {
                    mobileBox.ReadOnly = false;
                }
                else mobileBox.ReadOnly = true;
            }
        }

        private void mobileBox_TextChanged(object sender, EventArgs e)
        {
            bool isDouble = double.TryParse(mobileBox.Text, out _);
            if (isDouble == false) mobilePanel.BackColor = Color.IndianRed;
            else mobilePanel = Helper.HandleFocusEnter(mobilePanel);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteBtn.Text == "Clear")
                {
                    nameBox.Text = "";
                    addressBox.Text = "";
                    mobileBox.Text = "";
                    vatBox.Text = "";

                }
                else
                {
                    //.DeleteUnit(selectedCustomer.CustomerId);
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("CUSTOMER", "ERROR", ex.Message, ex.StackTrace);
            }
        }
    }
}
