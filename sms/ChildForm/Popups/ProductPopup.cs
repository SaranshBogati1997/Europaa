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

namespace SMS.ChildForm.Popups
{
    public partial class ProductPopup : Form
    {
        public ProductDetailsModel selectedProduct;
        string moduleName = "PRODUCTPOPUP";
        IProductService _productService;
        IUnitService _unitService;
        IGroupService _groupService;
        List<UnitModel> existingUnits;
        List<GroupModel> existingGroups;
        public ProductPopup()
        {
            try
            {
                InitializeComponent();
                headerLabel.Text = "Add Product";
                InitializeButtons();
                // this.Size = new Size(570, 600);
                this.addEditBtn.Text = "Add Product";
                deleteBtn.Text = "Clear";
                selectedProduct = new ProductDetailsModel();
                vatBox.ReadOnly = true;
                vatBox.Text = "0";
                _productService = new ProductRepository();
                _unitService = new UnitRepository();
                _groupService = new GroupRepository();
                existingUnits = _unitService.GetUnit();
                existingGroups = _groupService.GetGroup();

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }
        public ProductPopup(ProductDetailsModel product)
        {
            try
            {
                InitializeComponent();
                //this.Size = new Size(570, 600);
                headerLabel.Text = "Manage Product";
                deleteBtn.Text = "Delete";
                nameBox.Text = product.ProductName;
                // unitBox.Text = product.Unit;
                //PriceBox.Text = product.Price.ToString();
                
                selectedProduct = product;
                this.addEditBtn.Text = "Edit Product";

                existingUnits = _unitService.GetUnit();
                existingGroups = _groupService.GetGroup();

                existingGroups.ForEach(group => groupsDropdown.Items.Add(group.GroupName));
                existingUnits.ForEach(unit => unitDropDown.Items.Add(unit.UnitName));

                int groupIndex = groupsDropdown.Items.IndexOf(selectedProduct.ParentGroup);
                if(groupIndex >= 0 )groupsDropdown.SelectedIndex = groupIndex;

                int unitIndex = -1;
                existingUnits.ForEach(unit =>
                {
                    if (unit.UnitName == selectedProduct.Unit || unit.UnitShortName == selectedProduct.Unit)
                    {
                        unitIndex = unitDropDown.Items.IndexOf(unit.UnitName);
                    }

                });
                if (unitIndex >= 0 )unitDropDown.SelectedIndex = unitIndex;

                InitializeButtons();
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

        private void InitializeButtons()
        {
            addEditBtn.Text = "Add User";
            deleteBtn.Text = "Clear";
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text == string.Empty ||
                    //PriceBox.Text == string.Empty||
                    unitDropDown.Text == string.Empty)
                {
                    Helper.ShowInfo("Please fill all the filds to submit");
                    return;
                }
                bool isValid = ValidateInput();
                if (isValid == false)
                {
                    MessageBox.Show("Invalid Price! Cannot submit form");
                    return;
                }
                selectedProduct.ProductName = nameBox.Text;
                selectedProduct.Unit = unitDropDown.Text;
               // selectedProduct.Price = Convert.ToInt64(PriceBox.Text);
                ////selectedProduct.Price = Convert.ToInt64(PriceBox.Text);
               // selectedProduct.IsTaxable = enableVat.Checked;
                //selectedProduct.VatPercent = Convert.ToInt32(vatBox.Text);

                bool isAdded = _productService.AddProduct(selectedProduct);
                if (isAdded == true) this.DialogResult = DialogResult.OK;
                else DialogResult = DialogResult.No;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private bool ValidateInput()
        {
            bool isValid = false;
            //bool price = int.TryParse(PriceBox.Text, out _);
            //if (price == true)
            //{
            //    isValid = true;
            //}
            //else isValid = false;
            return isValid;
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteBtn.Text == "Clear")
                {
                    nameBox.Text = "";
                    groupsDropdown.SelectedIndex = 0;
                    unitDropDown.SelectedIndex = 0;
                    //PriceBox.Text = "";
                    //PriceBox.Text = "";
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.Control && e.KeyCode == Keys.Control) || (e.Control && e.KeyCode == Keys.N))
                {
                    GroupsPopup popup = new GroupsPopup();
                    DialogResult dr = new DialogResult();
                    dr = popup.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        Helper.ShowInfo("Group added");
                        RefreshComboBox();
                    }
                    else Helper.ShowInfo("Failed to add group");
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void RefreshComboBox()
        {
            unitDropDown.Items.Clear();
            groupsDropdown.Items.Clear();
            existingUnits = _unitService.GetUnit();
            foreach (var model in existingUnits)
            {
                unitDropDown.Items.Add(model.UnitName);
            }
            existingGroups =_groupService.GetGroup();
            foreach (var model in existingGroups)
            {
                groupsDropdown.Items.Add(model.GroupName);
            }

        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UnitPopup popup = new UnitPopup();
                DialogResult dr = new DialogResult();
                dr = popup.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    RefreshComboBox();
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void unitDropDown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.Control && e.KeyCode == Keys.Control) || (e.Control && e.KeyCode == Keys.N))
                {
                    UnitPopup popup = new UnitPopup();
                    DialogResult dr = new DialogResult();
                    dr = popup.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        Helper.ShowInfo("Unit added");
                        RefreshComboBox();
                    }
                    else Helper.ShowInfo("Failed to add unit");
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GroupsPopup popup = new GroupsPopup();
                DialogResult dr = new DialogResult();
                dr = popup.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Helper.ShowInfo("Group added");
                    RefreshComboBox();
                }
                else Helper.ShowInfo("Failed to add group");
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void enableVat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (enableVat.Checked == true)
                {
                    vatBox.ReadOnly = false;
                    vatBox.Text = "13";
                }
                else
                {
                    vatBox.ReadOnly = true;
                    vatBox.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
            }

        }

        private void ProductPopup_Load(object sender, EventArgs e)
        {

        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            namePanel = Helper.HandleFocusEnter(namePanel);
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            namePanel = Helper.HandleFocusLeave(namePanel);

        }

        private void descriptionBox_Enter(object sender, EventArgs e)
        {
            descriptionPanel = Helper.HandleFocusEnter(descriptionPanel);

        }

        private void descriptionBox_Leave(object sender, EventArgs e)
        {
            descriptionPanel = Helper.HandleFocusLeave(descriptionPanel);
        }

        private void PriceBox_Enter(object sender, EventArgs e)
        {
            costPanel = Helper.HandleFocusEnter(costPanel);

        }

        private void PriceBox_Leave(object sender, EventArgs e)
        {
            costPanel = Helper.HandleFocusLeave(costPanel);
        }

        //private void PriceBox_Enter(object sender, EventArgs e)
        //{
        //    salesPanel = Helper.HandleFocusEnter(salesPanel);

        //}

        //private void PriceBox_Leave(object sender, EventArgs e)
        //{
        //    salesPanel = Helper.HandleFocusLeave(salesPanel);
        //}

        private void vatBox_Enter(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusEnter(vatPanel);

        }

        private void vatBox_Leave(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusLeave(vatPanel);
        }
    }
}

public class ComboboxData
{
    public string Name { get; set; }
    public int Value { get; set; }
}
