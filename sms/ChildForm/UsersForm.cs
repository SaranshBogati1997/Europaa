using Lib;
using Lib.Service;
using SMS.ChildForm.Popups;
using SMS.Prompt;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm
{
    public partial class UsersForm : Form
    {

        string moduleName = "USERFROM";
        Mode currentMode;
        Form popupToShowOnAdd;
        IUserService _userService;
        ICustomerService _customerService;
        ISupplierService _supplierService;
        IProductService _productService;
        IUnitService _unitService;
        IGroupService _groupService;
        public UsersForm(Mode mode)
        {
            try
            {
                InitializeComponent();
                currentMode = mode;
                _userService = new UserRepository();
                _customerService = new CustomerRepository();
                _supplierService = new SupplierRepository();
                _productService = new ProductRepository();
                _unitService = new UnitRepository();
                _groupService = new GroupRepository();
                ActivateMode(mode);
                textBox1.GotFocus += TextBox1_GotFocus;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }
        }

        private void ActivateMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.USER:
                    addUserBtn.Text = "Add User";
                    InitializeGrid(_userService.GetUserData());
                    popupToShowOnAdd = new UserPopup();
                    break;
                case Mode.CUSTOMER:
                    addUserBtn.Text = "Add Customer";
                    InitializeGrid(_customerService.GetData());
                    popupToShowOnAdd = new CustomerPopup();
                    break;
                case Mode.SUPPLIER:
                    addUserBtn.Text = "Add Supplier";
                    InitializeGrid(_supplierService.GetData());
                    popupToShowOnAdd = new SupplierPopup();
                    break;
                case Mode.PRODUCT:
                    addUserBtn.Text = "Add Product";
                    InitializeGrid(_productService.GetProductData());
                    popupToShowOnAdd = new ProductPopup();
                    break;
                case Mode.UNIT:
                    addUserBtn.Text = "Add Unit";
                    InitializeGrid(_unitService.GetUnitData());
                    popupToShowOnAdd = new UnitPopup();
                    break;
                case Mode.GROUP:
                    addUserBtn.Text = "Add Group";
                    InitializeGrid(_groupService.GetGroupData());
                    popupToShowOnAdd = new GroupsPopup();
                    break;
                default:
                    break;
            }
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "Type here to search..")
            {
                textBox1.Text = "";
            }
        }

        private void InitializeGrid(DataTable table)
        {
            this.dataGridView1.DataSource = table;
            //StyleGrid();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }
        private void StyleGrid()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(54, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 440);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;



            DataGridViewButtonColumn button = new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "Actions",
                Text = "Action",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true
            };
            button.DefaultCellStyle.BackColor = Color.FromArgb(55, 126, 161);
            button.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataGridView1.Columns.Add(button);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool addSuccess = false;
                string textToAppend = "";
                //Edit
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    if (e.RowIndex == -1) return;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr;
                    switch (currentMode)
                    {
                        case Mode.USER:
                            var userId = Convert.ToInt32(row.Cells[1].Value);
                            string password = _userService.GetUserPassword(userId);
                            UserModel user = new UserModel()
                            {
                                UserId = Convert.ToInt32(row.Cells[1].Value),
                                Username = row.Cells[2].Value.ToString(),
                                Address = row.Cells[3].Value.ToString(),
                                MobileNo = Convert.ToInt64(row.Cells[4].Value),
                                Password = password
                            };
                            UserPopup userPopup = new UserPopup(user);
                            dr = userPopup.ShowDialog();
                            if (dr == DialogResult.OK)
                            {
                                UserModel editedUser = userPopup.selectedUser;
                                addSuccess = _userService.UpdateUser(editedUser);
                                textToAppend = "User";
                            }
                            else if (dr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + user.Username + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _userService.DeleteUser(user.UserId);
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(user.Username + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete user");
                                    }
                                }

                            }
                            this.dataGridView1.DataSource = _userService.GetUserData();
                            break;
                        case Mode.CUSTOMER:
                            CustomerModel CustomerModel = new CustomerModel()
                            {
                                CustomerId = Convert.ToInt32(row.Cells[1].Value),
                                CustomerName = row.Cells[2].Value.ToString(),
                                CustomerAddress = row.Cells[3].Value.ToString(),
                                CustomerMobileNo = Convert.ToInt64(row.Cells[4].Value),
                                CustomerVatNo = Convert.ToInt64(row.Cells[5].Value)

                            };
                            CustomerPopup customerPopup = new CustomerPopup(CustomerModel);
                            DialogResult customerDr = customerPopup.ShowDialog();
                            if (customerDr == DialogResult.OK)
                            {
                                CustomerModel editedCustomer = customerPopup.selectedCustomer;
                                addSuccess = _customerService.UpdateCustomer(editedCustomer);
                                textToAppend = "Customer";
                            }
                            else if (customerDr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + CustomerModel.CustomerName + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _customerService.DeleteCustomer(CustomerModel.CustomerId);
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(CustomerModel.CustomerName + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete customer");
                                    }
                                }

                            }
                            this.dataGridView1.DataSource = _customerService.GetData();
                            break;
                        case Mode.SUPPLIER:
                            SupplierModel supplier = new SupplierModel()
                            {
                                SupplierId = Convert.ToInt32(row.Cells[1].Value),
                                SupplierName = row.Cells[2].Value.ToString(),
                                SupplierAddress = row.Cells[3].Value.ToString(),
                                SupplierMobileNo = Convert.ToInt64(row.Cells[4].Value),
                                SupplierVatNo = Convert.ToInt64(row.Cells[5].Value),
                            };
                            SupplierPopup supplierPopup = new SupplierPopup(supplier);
                            DialogResult supplierDr = supplierPopup.ShowDialog();
                            if (supplierDr == DialogResult.OK)
                            {
                                SupplierModel editedSupplier = supplierPopup.selectedSupplier;
                                addSuccess = _supplierService.UpdateSupplier(editedSupplier);
                                textToAppend = "Supplier";
                            }
                            else if (supplierDr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + supplier.SupplierName + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _supplierService.DeleteSupplier(supplier.SupplierId);
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(supplier.SupplierName + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete supplier");
                                    }
                                }

                            }
                            this.dataGridView1.DataSource = _supplierService.GetData();
                            break;
                        case Mode.PRODUCT:
                            ProductDetailsModel product = new ProductDetailsModel()
                            {
                                ProductId = Convert.ToInt32(row.Cells[1].Value),
                                ProductName = row.Cells[2].Value.ToString(),
                                Unit = row.Cells[3].Value.ToString(),
                                Price = Convert.ToInt64(row.Cells[4].Value),
                                Quantity = Convert.ToInt32(row.Cells[5].Value)
                            };
                            ProductPopup productPopup = new ProductPopup(product);
                            DialogResult productDr = productPopup.ShowDialog();
                            if (productDr == DialogResult.OK)
                            {
                                ProductDetailsModel editedProduct = productPopup.selectedProduct;
                                addSuccess = _productService.UpdateProduct(editedProduct);
                                textToAppend = "Product";
                            }
                            else if (productDr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + product.ProductName + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _productService.DeleteProduct(product.ProductId);
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(product.ProductName + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete product");
                                    }
                                }

                            }
                            this.dataGridView1.DataSource = _productService.GetProductData();
                            break;
                        case Mode.UNIT:
                            var unit = new UnitModel()
                            {
                                UnitId = Convert.ToInt32(row.Cells[1].Value),
                                UnitName = row.Cells[2].Value.ToString(),
                                UnitShortName = row.Cells[3].Value.ToString()
                            };
                            UnitPopup unitPopup = new UnitPopup(unit);
                            DialogResult unitDr = unitPopup.ShowDialog();

                            if (unitDr == DialogResult.OK)
                            {
                                var editedModel = unitPopup.selectedUnit;
                                addSuccess = _unitService.UpdateUnit(editedModel);
                                textToAppend = "User";
                            }
                            else if (unitDr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + unit.UnitName + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _unitService.DeleteUnit(Convert.ToInt32(unit.UnitId));
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(unit.UnitName + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete unit");
                                    }
                                }
                            }
                            this.dataGridView1.DataSource = _unitService.GetUnitData();
                            break;
                        case Mode.GROUP:
                            var group = new GroupModel()
                            {
                                GroupId = Convert.ToInt32(row.Cells[1].Value),
                                GroupName = row.Cells[2].Value.ToString(),
                                GroupDescription = row.Cells[3].Value.ToString()
                            };
                            GroupsPopup groupPopup = new GroupsPopup(group);
                            DialogResult groupDr = groupPopup.ShowDialog();
                            if (groupDr == DialogResult.OK)
                            {
                                GroupModel editedGroup = groupPopup.selectedGroup;
                                addSuccess = _groupService.UpdateGroup(editedGroup);
                                textToAppend = "Group";
                            }
                            else if (groupDr == DialogResult.No)
                            {
                                bool result = Helper.ShowPrompt("Are you sure you want to delete " + group.GroupName + "?");
                                if (result == true)
                                {
                                    bool isSuccess = _groupService.DeleteGroup((int)group.GroupId);
                                    if (isSuccess == true)
                                    {
                                        Helper.ShowInfo(group.GroupName + " deleted successfully");
                                    }
                                    else
                                    {
                                        Helper.ShowInfo("Failed to delete group");
                                    }
                                }

                            }
                            this.dataGridView1.DataSource = _groupService.GetGroupData();
                            break;
                        default:
                            break;
                    }


                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }


        }

        private void RefreshData()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Helper.ShowInfo("Error encounetered. Error details: " + ex.Message);
            }

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool addSuccess = false;
                string textToAppend = "";
                switch (currentMode)
                {
                    case Mode.USER:
                        UserPopup popup = new UserPopup();
                        if (popup.ShowDialog() == DialogResult.OK)
                        {
                            UserModel user = popup.selectedUser;
                            addSuccess = _userService.AddUser(user);
                            textToAppend = "User";
                        }
                        break;
                    case Mode.CUSTOMER:
                        CustomerPopup customerPopup = new CustomerPopup();
                        if (customerPopup.ShowDialog() == DialogResult.OK)
                        {
                            CustomerModel customer = customerPopup.selectedCustomer;
                            addSuccess = _customerService.AddCustomer(customer);
                            textToAppend = "Customer";
                        }
                        break;
                    case Mode.SUPPLIER:
                        SupplierPopup supplierPopup = new SupplierPopup();
                        if (supplierPopup.ShowDialog() == DialogResult.OK)
                        {
                            SupplierModel supplier = supplierPopup.selectedSupplier;
                            addSuccess = _supplierService.AddSupplier(supplier);
                            textToAppend = "Supplier";
                        }
                        break;
                    case Mode.PRODUCT:
                        ProductPopup productPopup = new ProductPopup();
                        if (productPopup.ShowDialog() == DialogResult.OK)
                        {
                            ProductDetailsModel product = productPopup.selectedProduct;
                            addSuccess = _productService.AddProduct(product);
                            textToAppend = "Product";
                        }
                        break;
                    case Mode.UNIT:
                        UnitPopup unitPopup = new UnitPopup();
                        if (unitPopup.ShowDialog() == DialogResult.OK)
                        {
                            var unit = unitPopup.selectedUnit;
                            addSuccess = _unitService.AddUnit(unit);
                            textToAppend = "Unit";
                        }
                        break;
                    case Mode.GROUP:
                        GroupsPopup groupPopup = new GroupsPopup();
                        if (groupPopup.ShowDialog() == DialogResult.OK)
                        {
                            GroupModel group = groupPopup.selectedGroup;
                            addSuccess = _groupService.AddGroup(group);
                            textToAppend = "Group";
                        }
                        break;
                    default:
                        break;
                }
                if (addSuccess == true)
                {
                    Helper.ShowInfo(textToAppend + " added Successfully");

                }

                RefreshData();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void HandleDatagridClick()
        {
            switch (currentMode)
            {
                case Mode.USER:
                    addUserBtn.Text = "Add User";
                    InitializeGrid(_userService.GetUserData());
                    break;
                case Mode.CUSTOMER:
                    addUserBtn.Text = "Add Customer";
                    InitializeGrid(_customerService.GetData());
                    break;
                case Mode.SUPPLIER:
                    addUserBtn.Text = "Add Supplier";
                    InitializeGrid(_supplierService.GetData());
                    break;
                case Mode.PRODUCT:
                    addUserBtn.Text = "Add Product";
                    InitializeGrid(_productService.GetProductData());
                    break;
                case Mode.UNIT:
                    addUserBtn.Text = "Add Unit";
                    InitializeGrid(_unitService.GetUnitData());
                    break;
                case Mode.GROUP:
                    addUserBtn.Text = "Add Group";
                    InitializeGrid(_groupService.GetGroupData());
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                string query1 = "";
                string query2 = "Name LIKE '%" + textBox1.Text + "%'";
                string query3 = "";
                if (textBox1.Text == string.Empty)
                {
                    query1 = "";
                    query3 = "";
                }
                else
                {
                    bool isId = int.TryParse(textBox1.Text, out _);
                    bool isNumber = long.TryParse(textBox1.Text, out _);
                    if (isId == true) query1 = " OR Id = " + Convert.ToInt32(textBox1.Text);
                    //if(isNumeric == true) query3 = " OR  MobileNo lIKE '%" + textBox1.Text + "%'";
                    if (isNumber == true) query3 = string.Format("OR CONVERT(MobileNo, 'System.String') like '%{0}%'",
                                      textBox1.Text);
                }
                bs.Filter = query2 + query1 + query3;
                //"Id LIKE '%" + textBox1.Text + "%'";


                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }
    }
}
