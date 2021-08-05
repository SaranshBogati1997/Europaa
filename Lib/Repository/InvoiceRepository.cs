using Lib.Models;
using Lib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib { 

    public class InvoiceRepository:IInvoiceService
    {
        IDataAccess _dataAccess;
        public InvoiceRepository()
        {
            _dataAccess = new DataAccess();
        }
        public string GetBillJson(string billNumber)
        {
            try
            {
                string query = "select * from tbl_mn_InvoiceDetails d inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId where BillNo = @billNo ";
                string invoiceDetails = _dataAccess.Query<InvoiceDetailsModel>(query, new { billNo = billNumber }).FirstOrDefault().InvoiceDetails;
                return invoiceDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetAllBills()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_InvoiceDetails";
                var bills = new List<string>();
                var invoiceDetails = _dataAccess.Query<InvoiceDetailsModel>(query);
                invoiceDetails.ForEach(x => bills.Add(x.InvoiceDetails));
                return bills;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public List<double> GetTotalIncomeExpense()
        {
            List<double> incomeExpenseList = new List<double>();
            double totalIcome = 0;
            double totalExpense = 0;
            List<string> billsList = GetAllBills();
            JsonHandler handler = new JsonHandler();
            billsList.ForEach(bill =>
            {
                InvoiceJsonModel jsonBill = handler.Deserialize<InvoiceJsonModel>(bill);
                if (jsonBill.Customer != null)
                {
                    if (string.IsNullOrEmpty(jsonBill.PaidAmount)) totalIcome += 0;
                    else totalIcome += Convert.ToDouble(jsonBill.PaidAmount);
                }
                else
                {
                    if (string.IsNullOrEmpty(jsonBill.PaidAmount)) totalExpense += 0;
                    else totalExpense += Convert.ToDouble(jsonBill.PaidAmount);
                }

            });
            incomeExpenseList.Add(totalIcome);
            incomeExpenseList.Add(totalExpense);

            return incomeExpenseList;
        }
        public List<string> GetBillForSupplier(int supplierId)
        {
            try
            {
                string query = "select i.BillNo from tbl_mn_InvoiceDetails d inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId where InvoiceCategory = 'PURCHASE' and PartyId = @id ";
                var bills = _dataAccess.Query<int>(query, new { id = supplierId });
                return bills.Select(x => x.ToString()).ToList();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetBillForCustomer(int customerId)
        {
            try
            {
                string query = "select * from tbl_mn_InvoiceDetails d inner join tbl_mn_InvoiceIndex i on d.InvoiceId = i.InvoiceId where InvoiceCategory = 'SALES' and PartyId = @id ";
                var bills = _dataAccess.Query<int>(query, new { id = customerId });
                return bills.Select(x => x.ToString()).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

    }
}
