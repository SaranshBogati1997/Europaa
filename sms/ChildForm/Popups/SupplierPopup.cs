using Lib;
using Lib.Service;
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

namespace SMS.ChildForm
{
    public partial class SupplierPopup : Form
    {
        public SupplierModel selectedSupplier;
        string moduleName = "SUPPLIERPOPUP";
        ISupplierService _supplierService;

        public SupplierPopup()
        {
            try
            {   
                InitializeComponent();
                headerLabel.Text = "Add Supplier";
                InitializeButtons();
                this.addEditBtn.Text = "Add Supplier";
                selectedSupplier = new SupplierModel();
                deleteBtn.Text = "Clear";
                _supplierService = new SupplierRepository();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        public SupplierPopup(string vatNumber)
        {
            try
            {
                InitializeComponent();
                headerLabel.Text = "Add Supplier";
                InitializeButtons();
                this.addEditBtn.Text = "Add Supplier";
                selectedSupplier = new SupplierModel()
                {
                    SupplierVatNo = Convert.ToInt64(vatNumber)
                };
                vatBox.Text = vatNumber;
                vatBox.ReadOnly = true;
                deleteBtn.Text = "Clear";
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        public SupplierPopup(SupplierModel supplier)
        {
            try
            {
                InitializeComponent();
                //this.Size = new Size(570, 600);

                selectedSupplier = supplier;
                headerLabel.Text = "Manage Supplier";
                this.nameBox.Text = supplier.SupplierName;
                this.addressBox.Text = supplier.SupplierAddress;
                this.mobileBox.Text = supplier.SupplierMobileNo.ToString();
                vatBox.Text = supplier.SupplierVatNo.ToString();
                this.addEditBtn.Text = "Edit Supplier";
                deleteBtn.Text = "Delete";
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void dragPanel_MouseDown_1(object sender, MouseEventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InitializeButtons()
        {

            addEditBtn.Text = "Add User";
            deleteBtn.Text = "Clear";
        }

     
        private bool ValidateInput()
        {
            bool isValid = false;
            try
            {
                var isNumber = double.TryParse(mobileBox.Text, out _);
                if (isNumber == true)
                {
                    isValid = true;
                }
                return isValid;

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                throw ex;
            }

        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = ValidateInput();
                if (nameBox.Text == string.Empty || addressBox.Text == string.Empty || mobileBox.Text == string.Empty || vatBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Please fill all the filds to submit");
                    return;
                }
                if (isValid == false)
                {
                    MessageBox.Show("Invalid mobile number ! Cannot submit form");
                    return;
                }
                selectedSupplier.SupplierName = nameBox.Text;
                selectedSupplier.SupplierAddress= addressBox.Text;
                selectedSupplier.SupplierMobileNo= Convert.ToInt64(mobileBox.Text);
                selectedSupplier.SupplierVatNo= Convert.ToInt64(vatBox.Text);
                bool isAdded = _supplierService.AddSupplier(selectedSupplier);
                if(isAdded == true) this.DialogResult = DialogResult.OK;
                else this.DialogResult = DialogResult.No;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

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
                    vatBox.Text = "Enter vat number here..";

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
        private void vatBox_TextChanged(object sender, EventArgs e)
        {
            bool isDouble = double.TryParse(vatBox.Text, out _);
            if (isDouble == false) vatPanel.BackColor = Color.IndianRed;
            else vatPanel = Helper.HandleFocusEnter(vatPanel);

        }
    }
}
