using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface ISupplierService
    {
        bool UpdateSupplier(SupplierModel supplier);
        DataTable GetData();
        bool AddSupplier(SupplierModel supplier);
        List<SupplierModel> GetSupplier();
        bool DeleteSupplier(int id);
        bool UpdateDueBalance(double balance, int supplierId);
    }
}
