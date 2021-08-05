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
    public class SupplierRepository:ISupplierService
    {
        IDataAccess _dataAccess;
        public SupplierRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool UpdateSupplier(SupplierModel supplier)
        {
            try
            {
                string query = "Update tbl_mn_Supplier set SupplierName = @name " +
                        ",SupplierMobileNo = @SupplierMobileNo, SupplierAddress =@SupplierAddress,SupplierVatNo = @SupplierVatNo where SupplierId = @SupplierId";
                return _dataAccess.Query<object>(query, supplier) != null;
               
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
                List<SupplierModel> supplierList = GetSupplier();
                foreach (SupplierModel supplier in supplierList)
                {

                    table.Rows.Add(supplier.SupplierId, supplier.SupplierName, supplier.SupplierAddress, supplier.SupplierMobileNo, supplier.SupplierVatNo);
                };
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddSupplier(SupplierModel supplier)
        {
            try
            {
                string query = "INSERT INTO tbl_mn_Supplier ( SupplierName,SupplierMobileNo, SupplierAddress,SupplierVatNo, DueAmount ) VALUES " +
                    "(@SupplierName,@SupplierMobileNo,@SupplierAddress,@SupplierVatNo, @DueAmount)";
                return _dataAccess.Query<object>(query, supplier) != null;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<SupplierModel> GetSupplier()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_Supplier";
                return _dataAccess.Query<SupplierModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteSupplier(int id)
        {
            try
            {
                string query = "DELETE FROM tbl_mn_Supplier WHERE SupplierId = @id";
                return _dataAccess.Query<SupplierModel>(query, id) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool UpdateDueBalance(double balance, int supplierId)
        {
            try
            {
                string querySel = "SELECT * FROM tbl_mn_Supplier  WHERE SupplierId = @id";
                double current = _dataAccess.Query<double>(querySel, supplierId).FirstOrDefault();

                string query = "UPDATE tbl_mn_Supplier SET DueAmount = @balance WHERE SupplierId = @id";
                var parameter = new
                {
                    balance = current + balance,
                    id = supplierId
                };
                return _dataAccess.Query<SupplierModel>(query, parameter) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
