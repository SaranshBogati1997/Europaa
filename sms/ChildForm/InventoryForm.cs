using Lib;
using Lib.Service;
using SMS.ChildForm.Popups;

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
    public partial class InventoryForm : Form
    {
        
        string moduleName = "INVENTORYFORM";
        IProductService _productService;
        public InventoryForm()
        {
            try
            {
                InitializeComponent();
                _productService = new ProductRepository();
                InitializeGrid();
                textBox1.GotFocus += TextBox1_GotFocus;
                HideForms(false);
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }



        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "Type here to search..")
            {
                textBox1.Text = "";
            }
        }
        private void HideForms(bool showItems)
        {
            productNameLabel.Visible = showItems;
            groupNameLabel.Visible = showItems;
            saveBtn.Visible = showItems;
            plusBtn.Visible = showItems;
            minusBtn.Visible = showItems;
            containerPanel.Visible = showItems;
            quantity.Visible = showItems;
            editBtn.Visible = showItems;
            productIdLabel.Visible = showItems;
            deleteBtn.Visible = showItems;
            if (showItems == false) emptyLabel.Visible = true;
            else emptyLabel.Visible = false;
        }

        private void InitializeGrid()
        {
            this.dataGridView1.DataSource = _productService.GetProductData();
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                HideForms(true);


                ProductDetailsModel product = new ProductDetailsModel()
                {
                    ProductId = Convert.ToInt32(row.Cells[0].Value),
                    ProductName = row.Cells[1].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells[3].Value),
                };
                productNameLabel.Text = product.ProductName;
                productIdLabel.Text = product.ProductId.ToString();
                quantityBox.Text = product.Quantity.ToString();

                RefreshData();
                HideForms(true);
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }



        }

        private void RefreshData()
        {

            this.dataGridView1.DataSource = _productService.GetProductData();


        }
        private void minusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number = 0;
                bool isNumber = int.TryParse(quantityBox.Text, out number);
                if (isNumber == false || number < 0)
                {
                    Helper.ShowInfo("Invalid quantity!! Only use numbers greater than 0");
                    return;
                }
                int subtractedNumber = number - 1;
                quantityBox.Text = subtractedNumber.ToString();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }



        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number = 0;
                bool isNumber = int.TryParse(quantityBox.Text, out number);
                if (isNumber == false)
                {
                    Helper.ShowInfo("Invalid quantity!! Only use numbers in quantity");
                    return;
                }
                int addedNo = number + 1;
                quantityBox.Text = addedNo.ToString();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number = 0;
                bool isNumber = int.TryParse(quantityBox.Text, out number);
                if (isNumber == false)
                {
                    Helper.ShowInfo("Invalid quantity!! Only use numbers in quantity");
                    return;
                };
                ProductDetailsModel product = new ProductDetailsModel()
                {
                    ProductId = Convert.ToInt32(productIdLabel.Text),
                    Quantity = number
                };
                bool isUpdated = _productService.UpdateProductQuantity(product);
                if (isUpdated == true)
                {
                    Helper.ShowInfo("Quantity updated successfully");
                }
                else
                {
                    Helper.ShowInfo("Failed to update quantity");
                }

                RefreshData();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool promptResponse = Helper.ShowPrompt("Are you sure you want to remove " + productNameLabel.Text);
                if (promptResponse == true)
                {

                    int productId = Convert.ToInt32(productIdLabel.Text);
                    bool isRemoved = _productService.DeleteProduct(productId);
                    if (isRemoved == true) Helper.ShowInfo(productNameLabel.Text + " removed successfully");
                    else Helper.ShowInfo("Failed to delete " + productNameLabel.Text + " from inventory");
                }
                RefreshData();
                HideForms(false);
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
                    if (isNumber == true) query3 = string.Format("OR CONVERT(Quantity, 'System.String') like '%{0}%'",
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

        private void editBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ProductDetailsModel product = _productService.GetSingleProduct(Convert.ToInt32(productIdLabel.Text));
                ProductPopup popup = new ProductPopup(product);
                var dr = new DialogResult();
                dr = popup.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    ProductDetailsModel editedProduct = popup.selectedProduct;
                    bool isUpdated = _productService.UpdateProduct(editedProduct);
                    if (isUpdated == true) Helper.ShowInfo("ProductDetailsModel updated successfully");
                    else Helper.ShowInfo("Failed to updated product");
                }
                else if (dr == DialogResult.No)
                {
                    bool result = Helper.ShowPrompt("Are you sure you want to delete " + product.ProductName + "?");

                    if (result == true)
                    {
                        bool isDeleted = _productService.DeleteProduct(product.ProductId);
                        if (isDeleted == true) Helper.ShowInfo(product.ProductName + " deleted successfully");
                        else Helper.ShowInfo("Failed to delete product ");
                    }
                }
                RefreshData();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }


        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

            try
            {
                ProductPopup popup = new ProductPopup();
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    ProductDetailsModel product = popup.selectedProduct;
                    bool isAdded = _productService.AddProduct(product);
                    if (isAdded == true) Helper.ShowInfo("ProductDetailsModel added successfully");
                    else Helper.ShowInfo("Failed to add product");
                }
                RefreshData();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }
        }

        private void productIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
