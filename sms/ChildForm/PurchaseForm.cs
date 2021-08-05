using Lib;
using Lib.Models;
using Lib.Service;
using SMS.Prompt;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm
{
    public partial class PurchaseForm : Form
    {
        List<ProductDetailsModel> particularsList;
        
        List<ProductDetailsModel> existingProducts;
        List<SupplierModel> existingSuppliers;
        List<string> productNames;
        private bool isInvoiceCreated = false;
        string moduleName = "PURCAHSEFORM";
        JsonHandler handler = new JsonHandler();
        private string invoiceJsonString;
        private List<ProductDetailsModel> nonExisentList;
        SupplierModel selectedSupplier;
        private bool isInsertedToDatabase;
        string billNo = "";
        
        ISupplierService _supplierService;
        IProductService _productService;

        public PurchaseForm()
        {
            try
            {
                InitializeComponent();
                particularsList = new List<ProductDetailsModel>();
               
                this.dataGridView1.DataSource = LoadGrid();
                //StyleGrid(this.dataGridView1);
                _supplierService = new SupplierRepository();
                _productService = new ProductRepository();

                existingProducts = _productService.GetProduct();
                existingSuppliers = _supplierService.GetSupplier();
                foreach (SupplierModel model in existingSuppliers) supplierDropdown.Items.Add(model.SupplierName);
                panel6.Visible = false;
                creditCheckBox.Checked = false;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }


        }



        private System.Data.DataTable LoadGrid()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Sn", typeof(int));
            table.Columns.Add("Particulars", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Rate", typeof(double));
            table.Columns.Add("SubTotal", typeof(double));

            foreach (ProductDetailsModel product in particularsList)
            {
                table.Rows.Add(product.ProductId, product.ProductName, product.Quantity, product.Price, (product.Quantity * product.Price));
            }

            return table;
        }


        private void StyleGrid(DataGridView dv)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dv.AllowUserToAddRows = false;
            dv.AllowUserToDeleteRows = false;
            dv.AllowUserToResizeColumns = false;
            dv.AllowUserToResizeRows = false;
            dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dv.ColumnHeadersHeight = 40;
            dv.Dock = System.Windows.Forms.DockStyle.Fill;
            dv.EnableHeadersVisualStyles = false;
            dv.GridColor = System.Drawing.SystemColors.ButtonFace;
            dv.Location = new System.Drawing.Point(54, 58);
            dv.Name = "dataGridView1";
            dv.ReadOnly = true;
            dv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dv.RowHeadersWidth = 51;
            dv.RowTemplate.Height = 24;
            dv.Size = new System.Drawing.Size(909, 440);
            dv.TabIndex = 3;
            dv.ForeColor = Color.Black;
            dv.RowTemplate.Height = 40;
            dv.RowHeadersVisible = false;
            dv.DefaultCellStyle.SelectionBackColor = dv.DefaultCellStyle.BackColor;
            dv.DefaultCellStyle.SelectionForeColor = dv.DefaultCellStyle.ForeColor;
        }


        private void RefreshData()
        {
            this.dataGridView1.DataSource = LoadGrid();
            int netTotal = 0;
            int grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 4)
                    {
                        netTotal += Convert.ToInt32(cell.Value);
                        grandTotal = netTotal;
                    }
                }
            }
            netTotalBox.Text = netTotal.ToString();
            grandTotalBox.Text = netTotal.ToString();
        }

        private void quantityBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantityBox.Text == string.Empty || rateBox.Text == string.Empty)
                {
                    return;
                }
                int quantity = 0;
                int rate = 0;
                bool isQantityNumeric = int.TryParse(quantityBox.Text, out quantity);
                bool isRateNumeric = int.TryParse(rateBox.Text, out rate);

                if (isQantityNumeric == true && isRateNumeric == true)
                {
                    rowTotalBox.Text = (quantity * rate).ToString();
                }

                bool isDouble = double.TryParse(quantityBox.Text, out _);
                if (isDouble == false) quantityPanel.BackColor = Color.IndianRed;
                else quantityPanel = Helper.HandleFocusEnter(quantityPanel);

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }



        }

        private void rateBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantityBox.Text == string.Empty || rateBox.Text == string.Empty)
                {
                    return;
                }
                int quantity = 0;
                int rate = 0;
                bool isQantityNumeric = int.TryParse(quantityBox.Text, out quantity);
                bool isRateNumeric = int.TryParse(rateBox.Text, out rate);

                if (isQantityNumeric == true && isRateNumeric == true)
                {
                    rowTotalBox.Text = (quantity * rate).ToString();
                }
                bool isDouble = double.TryParse(rateBox.Text, out _);
                if (isDouble == false) ratePanel.BackColor = Color.IndianRed;
                else ratePanel = Helper.HandleFocusEnter(ratePanel);
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }


        private void ClearFields()
        {
            this.particularsBox.Text = string.Empty;
            this.quantityBox.Text = string.Empty;
            this.rateBox.Text = string.Empty;
            this.rowTotalBox.Text = string.Empty;

        }

        private void RatesForm_Load(object sender, EventArgs e)
        {
            try
            {
                productNames = new List<string>();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                foreach (ProductDetailsModel product in existingProducts)
                {
                    productNames.Add(product.ProductName.ToLower());
                    //collection.Add(product.ProductName);
                }


                //collection.AddRange(namesList.ToArray());
                var source = productNames.ToAutoCompleteStringCollection();
                particularsBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                particularsBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                particularsBox.AutoCompleteCustomSource = source;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private bool AddProducts(List<ProductDetailsModel> nonExisentList)
        {
            bool isAdded = _productService.UpdateInventory(nonExisentList,null);
            return isAdded;
        }

        private bool ShowYesNoPrompt(string message)
        {

            PromptForm form = new PromptForm(message, true);
            DialogResult dr = new DialogResult();
            dr = form.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void SubmitData()
        {
           

            isInsertedToDatabase = false;
            if (nonExisentList.Count != particularsList.Count)
            {
                 isInsertedToDatabase = _productService.UpdateInventory(particularsList, "PURCHASE");
            }

            HandleCredit();
            ExportInvoice();
            
        }

        private void HandleCredit()
        {
            bool isCredit = false;
            string paidAmount = "";
            string dueBalance = "";
            creditCheckBox.Invoke((MethodInvoker)(() => { isCredit = creditCheckBox.Checked; }));
            paidBox.Invoke((MethodInvoker)(() => { paidAmount = paidBox.Text; }));
            balanceBox.Invoke((MethodInvoker)(() => { dueBalance = balanceBox.Text; }));

            if(isCredit == true)
            {
                bool isUpdated = _supplierService.UpdateDueBalance(Convert.ToDouble(dueBalance), selectedSupplier.SupplierId);
            }
        }

        private List<ProductDetailsModel> CheckNonExistentParticulars()
        {

            List<ProductDetailsModel> nonExistingParticulars = new List<ProductDetailsModel>();
            foreach (ProductDetailsModel particular in particularsList)
            {
                if (!productNames.Contains(particular.ProductName.ToLower()))
                {
                    nonExistingParticulars.Add(particular);
                }
            }
            return nonExistingParticulars;
        }



        private void totalDiscountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (totalDiscountBox.Text == string.Empty)
                {
                    grandTotalBox.Text = netTotalBox.Text;
                }
                int discountAmount = 0;
                bool isNumeric = int.TryParse(totalDiscountBox.Text, out discountAmount);
                if (isNumeric == false) return;
                else
                {
                    int netTotal = Convert.ToInt32(netTotalBox.Text);
                    grandTotalBox.Text = (netTotal - discountAmount).ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void ExportInvoice()
        {
            double netTotal = 0;
            double grandTotal = 0;
            string date = "";
            double discount = 0;
            string billNumber = "";

            netTotalBox.Invoke((MethodInvoker)(() => { netTotal = Convert.ToDouble(netTotalBox.Text);  }));
            grandTotalBox.Invoke((MethodInvoker)(() => { grandTotal = Convert.ToDouble(grandTotalBox.Text);  }));
            dateBox.Invoke((MethodInvoker)(() => { date = dateBox.Value.ToString(); }));
            billBox.Invoke((MethodInvoker)(() => { billNumber = billBox.Text; }));
          
            if (totalDiscountBox.Text != string.Empty)
                totalDiscountBox.Invoke((MethodInvoker)(() => { discount = Convert.ToDouble(totalDiscountBox.Text); }));

            PurchaseReportModel reportParameters = new PurchaseReportModel()
            {
                ParticularsList = particularsList,
                NetTotal = netTotal.ToString(),
                GrandTotal = grandTotal.ToString(),
                SupplierVatNo = selectedSupplier.SupplierVatNo.ToString(),
                InvoiceDate = date
            };
           reportParameters.Discount = discount.ToString();

            ExportForm form = new ExportForm(reportParameters, invoiceJsonString, billNumber, selectedSupplier.SupplierId);
            form.Show();
            isInvoiceCreated = form.fileCreated;
        }
        public void ClearAllBoxes()
        {
            totalDiscountBox.Invoke((MethodInvoker)(() => { totalDiscountBox.Text = string.Empty; }));
            grandTotalBox.Invoke((MethodInvoker)(() => { grandTotalBox.Text = string.Empty; }));
            netTotalBox.Invoke((MethodInvoker)(() => { netTotalBox.Text = string.Empty; }));
            grandTotalBox.Invoke((MethodInvoker)(() => { grandTotalBox.Text = string.Empty; }));
            totalDiscountBox.Invoke((MethodInvoker)(() => { totalDiscountBox.Text = string.Empty; }));
            totalVatBox.Invoke((MethodInvoker)(() => { totalVatBox.Text = string.Empty; }));
            billBox.Invoke((MethodInvoker)(() => { billBox.Text = string.Empty; }));
            paidBox.Invoke((MethodInvoker)(() => { paidBox.Text = string.Empty; }));
            balanceBox.Invoke((MethodInvoker)(() => { balanceBox.Text = string.Empty; }));
            creditCheckBox.Invoke((MethodInvoker)(() => { creditCheckBox.Checked = false; }));
            particularsList.Clear();
        }

       

        private void particularsBox_Enter(object sender, EventArgs e)
        {
            particularPanel = Helper.HandleFocusEnter(particularPanel);

        }

        private void particularsBox_Leave(object sender, EventArgs e)
        {
            particularPanel = Helper.HandleFocusLeave(particularPanel);

        }

        private void rateBox_Enter(object sender, EventArgs e)
        {
            ratePanel = Helper.HandleFocusEnter(ratePanel);

        }

        private void rateBox_Leave(object sender, EventArgs e)
        {
            ratePanel = Helper.HandleFocusLeave(ratePanel);

        }

        private void quantityBox_Enter(object sender, EventArgs e)
        {
            quantityPanel = Helper.HandleFocusEnter(quantityPanel);

        }

        private void quantityBox_Leave(object sender, EventArgs e)
        {
            quantityPanel = Helper.HandleFocusLeave(quantityPanel);

        }

        private void rowTotalBox_Enter(object sender, EventArgs e)
        {
            totalPanel = Helper.HandleFocusEnter(totalPanel);

        }

        private void rowTotalBox_Leave(object sender, EventArgs e)
        {
            totalPanel = Helper.HandleFocusLeave(totalPanel);

        }

        private void netTotalBox_Enter_1(object sender, EventArgs e)
        {
            netTotalPanel = Helper.HandleFocusEnter(netTotalPanel);

        }

        private void netTotalBox_Leave_1(object sender, EventArgs e)
        {
            netTotalPanel = Helper.HandleFocusLeave(netTotalPanel);

        }

        private void totalDiscountBox_Enter_1(object sender, EventArgs e)
        {
            discountPanel = Helper.HandleFocusEnter(discountPanel);

        }

        private void totalDiscountBox_Leave_1(object sender, EventArgs e)
        {
            discountPanel = Helper.HandleFocusLeave(discountPanel);

        }

        private void totalVatBox_Enter_1(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusEnter(vatPanel);

        }

        private void totalVatBox_Leave_1(object sender, EventArgs e)
        {
            vatPanel = Helper.HandleFocusLeave(vatPanel);

        }

        private void grandTotalBox_Enter_1(object sender, EventArgs e)
        {
            grandTotalPanel = Helper.HandleFocusEnter(grandTotalPanel);

        }

        private void grandTotalBox_Leave_1(object sender, EventArgs e)
        {
            grandTotalPanel = Helper.HandleFocusLeave(grandTotalPanel);

        }

        private void addRowBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (particularsBox.Text == string.Empty || rateBox.Text == string.Empty || quantityBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Please fill all the filds to add to table");
                    return;
                }
                ProductDetailsModel product = new ProductDetailsModel()
                {
                    ProductId = particularsList.Count + 1,
                    ProductName = particularsBox.Text,
                    Quantity = Convert.ToInt32(quantityBox.Text),
                    Price = Convert.ToInt64(rateBox.Text)

                };
                product.Total = product.Quantity * product.Price;
                particularsList.Add(product);
                RefreshData();
                ClearFields();
                tabControl1.TabIndex = 1;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SupplierPopup popup = new SupplierPopup();
            DialogResult dr = popup.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Helper.ShowInfo("Supplier added");
                RefreshComboBox();
            }
            else if (dr == DialogResult.No)
            {
                Helper.ShowInfo("Failed to add Supplier");
            }
        }

        private void RefreshComboBox()
        {
            supplierDropdown.Items.Clear();
            existingSuppliers = _supplierService.GetSupplier();
            foreach (SupplierModel model in existingSuppliers) supplierDropdown.Items.Add(model.SupplierName);
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                isInvoiceCreated = false;
                if (particularsList.Count == 0 || supplierDropdown.Text == string.Empty || billBox.Text == string.Empty)
                {
                    if (supplierDropdown.Text == string.Empty)
                    {
                        Helper.ShowInfo("Supplier cannot be empty");
                        return;
                    }
                    else if (billBox.Text == string.Empty)
                    {
                        Helper.ShowInfo("Bill number cannot be empty");
                        return;
                    }
                    Helper.ShowInfo("Cannot export empty invoice");
                    return;
                }
                if(creditCheckBox.Checked == true)
                {
                    bool isValid = double.TryParse(paidBox.Text, out _);
                    if(isValid == false)
                    {
                        Helper.ShowInfo("Invalid Paid Amount");
                        return;
                    }
                }
                nonExisentList = CheckNonExistentParticulars();
                if (nonExisentList.Count != 0)
                {
                    string nonExistingStrings = "";
                    foreach (ProductDetailsModel nonExistingProduct in nonExisentList)
                    {
                        nonExistingStrings += nonExistingProduct.ProductName + ", ";
                    }
                    nonExistingStrings = nonExistingStrings.Trim().Substring(0, nonExistingStrings.Length - 2);
                    string message = "Items: " + nonExistingStrings + " do not exist in products. Do you want to" +
                        " auto add them?";
                    bool autoAdd = ShowYesNoPrompt(message);
                    if (autoAdd == true)
                    {
                        AddProducts(nonExisentList);
                    }
                }
                
                InvoiceJsonModel model = new InvoiceJsonModel()
                {
                    Particulars = particularsList,
                    NetTotal = netTotalBox.Text,
                    Discount = totalDiscountBox.Text,
                    Vat = totalVatBox.Text,
                    GrandTotal = grandTotalBox.Text,
                    Supplier = existingSuppliers.Find(sup => sup.SupplierName == supplierDropdown.Text),
                    InvoiceDate = dateBox.Text
                };
                if(creditCheckBox.Checked == true)
                {
                    model.IsCredit = true;
                    model.PaidAmount = paidBox.Text;
                    model.DueBalance = balanceBox.Text;
                }
                if (creditCheckBox.Checked == true)
                {
                    model.IsCredit = true;
                    model.PaidAmount = paidBox.Text;
                    model.DueBalance = balanceBox.Text;
                }
                else
                {
                    model.IsCredit = false;
                    model.PaidAmount = grandTotalBox.Text;
                }
                invoiceJsonString = handler.SerializeObject(model);
                using (WaitForm form = new WaitForm(SubmitData))
                {
                    form.ShowDialog(this);
                }
                ClearAllBoxes();
                if (isInvoiceCreated == true)
                {
                    Helper.ShowInfo("Inventory Updated");
                    RefreshData();

                }
                else Helper.ShowInfo("Failed to update inventory");
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void supplierDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedSupplier = existingSuppliers.Find(supp => supp.SupplierName == supplierDropdown.Text);
        }

       


        private void totalDiscountBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (netTotalBox.Text == string.Empty) { return; }
                SetGrandTotal();

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }
        }

        private void totalVatBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (netTotalBox.Text == string.Empty) { return; }
                SetGrandTotal();

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }
        }

        private void billBox_Enter(object sender, EventArgs e)
        {
            billPanel = Helper.HandleFocusEnter(billPanel);

        }

        private void billBox_Leave(object sender, EventArgs e)
        {
            billPanel = Helper.HandleFocusLeave(billPanel);

        }
        public void SetGrandTotal()
        {
            bool isDiscountPercentValid = float.TryParse(totalDiscountBox.Text, out float discountPercent);
            bool isVatValid = float.TryParse(totalVatBox.Text, out float vatPercent);
            double netTotal = Convert.ToDouble(netTotalBox.Text);

            if (isDiscountPercentValid == true && isVatValid == true)
            {
                double discountAmount = (discountPercent / 100) * netTotal;
                double totalWithDiscount = netTotal - discountAmount;
                double vatAmount = (vatPercent / 100) * totalWithDiscount;
                double grandTotal = totalWithDiscount + vatAmount;
                grandTotalBox.Text = grandTotal.ToString();
            }
            else if (isDiscountPercentValid == true && isVatValid == false)
            {
                double discountAmount = (discountPercent / 100) * netTotal;
                double totalWithDiscount = netTotal - discountAmount;
                grandTotalBox.Text = totalWithDiscount.ToString();
            }
            else if (isDiscountPercentValid == false && isVatValid == true)
            {
                double vatAmount = (vatPercent / 100) * netTotal;
                double grandTotal = netTotal + vatAmount;
                grandTotalBox.Text = grandTotal.ToString();

            }
            else
            {
                grandTotalBox.Text = netTotal.ToString();
            }
        }

        private void totalVatBox_KeyDown(object sender, KeyEventArgs e)
        {
            totalVatBox.ReadOnly = false;
            if (totalVatBox.TextLength == 2)
            {
                if (e.KeyCode == Keys.Back)
                {
                    totalVatBox.ReadOnly = false;
                }
                else if (totalVatBox.Text == "10" && e.KeyCode == Keys.NumPad0)
                {
                    totalVatBox.ReadOnly = false;
                }
                else totalVatBox.ReadOnly = true;
            }
        }

        private void totalDiscountBox_KeyDown(object sender, KeyEventArgs e)
        {
            totalDiscountBox.ReadOnly = false;
            if (totalDiscountBox.TextLength == 2)
            {
                if (e.KeyCode == Keys.Back)
                {
                    totalDiscountBox.ReadOnly = false;
                }
                else if (totalDiscountBox.Text == "10" && e.KeyCode == Keys.NumPad0)
                {
                    totalDiscountBox.ReadOnly = false;
                }
                else totalDiscountBox.ReadOnly = true;
            }
        }

        private void paidBox_TextChanged(object sender, EventArgs e)
        {
            bool isDouble = double.TryParse(paidBox.Text, out double paidAmount);
            if (isDouble == false)
            {

                paidPanel.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                paidPanel = Helper.HandleFocusEnter(paidPanel);
                double grandTotal = (double)float.Parse(grandTotalBox.Text);
                double balance = grandTotal - paidAmount;
                balanceBox.Text = balance.ToString();
            }
        }

        private void paidPanel_Enter(object sender, EventArgs e)
        {
            paidPanel = Helper.HandleFocusEnter(paidPanel);

        }

        private void paidPanel_Leave(object sender, EventArgs e)
        {
            paidPanel = Helper.HandleFocusLeave(paidPanel);

        }

        private void balanceBox_Enter(object sender, EventArgs e)
        {
            balancePanel = Helper.HandleFocusEnter(balancePanel);

        }

        private void balanceBox_Leave(object sender, EventArgs e)
        {
            balancePanel = Helper.HandleFocusLeave(balancePanel);

        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            ClearAllBoxes();
            particularsList.Clear();
            RefreshData();
        }

        private void creditCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (creditCheckBox.Checked == true) panel6.Visible = true;
            else panel6.Visible = false;
        }

        private void paidBox_Enter(object sender, EventArgs e)
        {
            paidPanel = Helper.HandleFocusEnter(paidPanel);
        }

        private void paidBox_Leave(object sender, EventArgs e)
        {
            paidPanel = Helper.HandleFocusLeave(paidPanel);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }    
    }
}
public static class EnumerableExtensionsEx
{
    public static AutoCompleteStringCollection ToAutoCompleteStringCollection(
        this IEnumerable<string> enumerable)
    {
        if (enumerable == null) throw new ArgumentNullException("enumerable");
        var autoComplete = new AutoCompleteStringCollection();
        foreach (var item in enumerable) autoComplete.Add(item);
        return autoComplete;
    }
}
