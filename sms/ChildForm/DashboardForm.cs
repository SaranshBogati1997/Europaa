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
using System.Windows.Forms.DataVisualization.Charting;

namespace SMS.ChildForm
{
    public partial class DashboardForm : Form
    {
        private List<ProductDetailsModel> inventoryList;
        string moduleName = "DASHBOARDFORM";
        List<ProductDetailsModel> productList;
        IProductService _productService;
        IUserService _userService;
        ICustomerService _customerService;
        ISupplierService _supplierService;
        IInvoiceService _invoiceService;
        public DashboardForm()
        {
            try
            {
                _productService = new ProductRepository();
                _userService = new UserRepository();
                _customerService = new CustomerRepository();
                _supplierService = new SupplierRepository();
                _invoiceService = new InvoiceRepository();

                productList = _productService.GetProduct();
                InitializeComponent();
                LoadCount();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);

                Helper.ShowInfo("Error encounetered. Error details: " + ex.Message);
            }

        }

        private void LoadCount()
        {
            try
            {
                List<UserModel> userList =_userService.GetUser();
                List<CustomerModel> customerList = _customerService.GetCustomer();
                List<SupplierModel> supplierList = _supplierService.GetSupplier();
                inventoryList = _productService.GetProduct();
                CompanyModel currentCompany = mainForm.currentCompany;

                double totalPayableAmount = 0;
                double totalRecievableAmount = 0;
                customerList.ForEach(customer =>
                {
                    totalRecievableAmount += Convert.ToDouble(customer.DueAmount);
                });
                supplierList.ForEach(supplier =>
                {
                    totalPayableAmount += Convert.ToDouble(supplier.DueAmount);
                });
                List<double> incomeExpenseList = _invoiceService.GetTotalIncomeExpense();

                //set all the label
                activeCustomerCount.Text = customerList.Count().ToString();
                activeSuppliersCount.Text = supplierList.Count().ToString();
                companyLabel.Text = currentCompany.CompanyName;

                companyLogo.SizeMode = PictureBoxSizeMode.Zoom;
                if (currentCompany.Logo != null && !string.IsNullOrEmpty(currentCompany.Logo))
                {
                    Image img = Image.FromFile(currentCompany.Logo);
                    companyLogo.Image = (Image)img;
                }


                recievableLabel.Text = totalRecievableAmount.ToString();
                payableLabel.Text = totalPayableAmount.ToString();
                incomeLabel.Text = incomeExpenseList[0].ToString();
                expenseLabel.Text = incomeExpenseList[1].ToString();

            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);

                Helper.ShowInfo("Error encounetered. Error details: " + ex.Message);
            }

        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }




    }
}
