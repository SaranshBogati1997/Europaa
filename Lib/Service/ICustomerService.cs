using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface ICustomerService
    {
        bool UpdateCustomer(CustomerModel customer);
        DataTable GetData();
        bool AddCustomer(CustomerModel customer);
        List<CustomerModel> GetCustomer();
        bool DeleteCustomer(int id);
        bool UpdateDueBalance(double balance, int customerId);

    }
}
