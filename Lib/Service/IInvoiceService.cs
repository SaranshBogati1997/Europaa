using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IInvoiceService
    {
        string GetBillJson(string billNumber);
        List<string> GetAllBills();
        List<double> GetTotalIncomeExpense();
        List<string> GetBillForSupplier(int supplierId);
        List<string> GetBillForCustomer(int customerId);
    }
}
