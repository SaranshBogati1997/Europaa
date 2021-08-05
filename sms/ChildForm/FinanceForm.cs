using Lib;
using Lib.Models;
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

namespace SMS.ChildForm
{
    public partial class FinanceForm : Form
    {
        List<SupplierModel> existingSupplier;
        List<CustomerModel> existingCustomer;
        InvoiceJsonModel billModel;
        ISupplierService _supplierService;
        ICustomerService _customerService;
        IInvoiceService _invoiceService;
        JsonHandler handler;
        public FinanceForm()
        {
            InitializeComponent();
            //StyleGrid(this.dataGridView1);
            //StyleGrid(this.dataGridView2);
            _supplierService = new SupplierRepository();
            _customerService = new CustomerRepository();
            _invoiceService = new InvoiceRepository();
            financeDropdown.Items.Add("Payable");
            financeDropdown.Items.Add("Recievable");
            handler = new JsonHandler();
            bottomContainerPanel.Visible = false;
            topContainerPanel.Visible = false;
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
            dv.GridColor = System.Drawing.SystemColors.Control;
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

        public void LoadData(TableType type)
        {
            dataGridView1.Columns.Clear();
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Amount", typeof(double));
           
            if (type == TableType.SUPPLIER)
            {
                foreach (var model in existingSupplier)
                {
                    table.Rows.Add(model.SupplierName, model.DueAmount);
                }

            }
            else if (type == TableType.CUSTOMER)
            {
                foreach (var model in existingCustomer)
                {
                    table.Rows.Add(model.CustomerName, model.DueAmount);
                }
            }
            this.dataGridView1.DataSource = table;


            DataGridViewButtonColumn button = new DataGridViewButtonColumn()
            {
                Name = "ViewBill",
                HeaderText = "Bills",
                Text = "View bills",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true
            };
            button.DefaultCellStyle.BackColor = Color.FromArgb(55, 126, 161);
            button.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataGridView1.Columns.Add(button);


        }

        private void financeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (financeDropdown.Text == "Payable")
            {
                existingSupplier = _supplierService.GetSupplier();

                LoadData(TableType.SUPPLIER);
            }
            else if (financeDropdown.Text == "Recievable")
            {
                existingCustomer = _customerService.GetCustomer();

                LoadData(TableType.CUSTOMER);
            }
            rightContainerPanel.Visible = false;
        }

        

        private void LoadBillGrid(List<ProductDetailsModel> particulars)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sn");
            table.Columns.Add("Particular");
            table.Columns.Add("Quantity");
            table.Columns.Add("Rate");
            table.Columns.Add("Total");
            int i = 1;
            particulars.ForEach(el =>
            {
                table.Rows.Add(i, el.ProductName, el.Quantity, el.Price, el.Total);
                i++;
            });
            dataGridView2.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Edit
                if (e.ColumnIndex == dataGridView1.Columns["ViewBill"].Index)
                {
                    rightContainerPanel.Visible = true;
                    topContainerPanel.Visible = true;
                    bottomContainerPanel.Visible = false;
                    customerDropdown.Items.Clear();
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    List<string> billDropDownList = new List<string>();
                    if (financeDropdown.Text == "Payable")
                    {
                        var selectedSup = existingSupplier.Find(el => el.SupplierName == row.Cells[0].Value.ToString());
                        nameLabel.Text = selectedSup.SupplierName;
                        vatLabel.Text = selectedSup.SupplierVatNo.ToString();
                        mobileLabel.Text = selectedSup.SupplierMobileNo.ToString();
                        addressLabel.Text = selectedSup.SupplierAddress.ToString();
                        billDropDownList = _invoiceService.GetBillForSupplier(selectedSup.SupplierId);
                    }
                    else
                    {
                        var selectedCust = existingCustomer.Find(el => el.CustomerName == row.Cells[0].Value.ToString());
                        vatLabel.Text = selectedCust.CustomerVatNo.ToString();
                        mobileLabel.Text = selectedCust.CustomerMobileNo.ToString();
                        addressLabel.Text = selectedCust.CustomerAddress.ToString();
                        billDropDownList = _invoiceService.GetBillForCustomer(selectedCust.CustomerId);
                    }
                    billDropDownList.ForEach(value =>
                    {
                        customerDropdown.Items.Add(value);
                    });
                }
            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
            }
        }

        private void customerDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            bottomContainerPanel.Visible = true;

            billNoLabel.Text = customerDropdown.Text;
            string jsonInvoice = _invoiceService.GetBillJson(customerDropdown.Text);
            billModel = handler.Deserialize<InvoiceJsonModel>(jsonInvoice);
            LoadBillGrid(billModel.Particulars);



            netTotalLabel.Text = billModel.NetTotal;
            discountLabel.Text = billModel.Discount;
            vatPercentLabel.Text = billModel.Vat;
            grandTotalLabel.Text = billModel.GrandTotal;
            paidLabel.Text = billModel.PaidAmount;
            balanceLabel.Text = billModel.DueBalance;
        }
    }
}
public enum TableType
{
    CUSTOMER,
    SUPPLIER
}
