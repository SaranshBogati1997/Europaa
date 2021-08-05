using Lib.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class CustomerRepository : ICustomerService
    {
        IDataAccess _dataAccess;
        public CustomerRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool UpdateCustomer(CustomerModel customer)
        {
            try
            {
                string query = "Update tbl_mn_Customer set CustomerName = @CustomerName " +
                        ",CustomerMobileNo = @CustomerMobileNo, CustomerAddress=@CustoemrAddress," +
                        "CustomerVatNo = @CustoemrVatNo where CustomerId = @CustomerId";
                var obj = _dataAccess.Query<object>(query, customer);
                return obj != null;               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("MobileNo", typeof(double));
                table.Columns.Add("VatNo", typeof(double));
                List<CustomerModel> customerList = GetCustomer();
                foreach (CustomerModel customer in customerList)
                {

                    table.Rows.Add(customer.CustomerId, customer.CustomerName, customer.CustomerAddress, customer.CustomerMobileNo, customer.CustomerVatNo);
                };
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool AddCustomer(CustomerModel customer)
        {
            try
            {
                string query = "INSERT ITNO tbl_mn_Customer " +
                        "(CustomerName, CustomerAddress, CustomerMobileNo, CustomerVatNo)" +
                        " VALUES " +
                        "(@CustomerName, @CustomerAddress,@CustomerMobileNo,@CustomerVatNo)";
                var obj = _dataAccess.Query<object>(query, customer);
                return obj != null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<CustomerModel> GetCustomer()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_Customer";
                return _dataAccess.Query<CustomerModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteCustomer(int id)
        {
            try
            {
                string query = "DELETE  FROM tbl_mn_Customer WHERE CustomerId = @Id";
                var obj =  _dataAccess.Query<object>(query, new { Id = id});
                return obj != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool UpdateDueBalance(double balance, int customerId)
        {
            try
            {
                string currentAmountQuery = "SELECT DueAmount FROM tbl_mn_Customer WHERE CustomerId = @CustomerId";
                double currentAmount = _dataAccess.Query<double>(currentAmountQuery).FirstOrDefault();
                double updatedAmount = currentAmount + balance;
                string query = "Update tbl_mn_Customer set DueAmount = @DueAmount " +
                       " where CustomerId = @CustomerId";
                var obj = _dataAccess.Query<object>(query, new { DueAmount = currentAmount, CustomerId = customerId});
                return obj != null;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            
           

        }
    }
}
