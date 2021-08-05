using Lib.Models;
using Lib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lib
{
    public class ExportRepository : IExportService
    {
        IDataAccess _dataAccess;
        public ExportRepository()
        {
            _dataAccess = new DataAccess();
        }

        public int InsertInvoiceDetails(ReportDatabaseParametersModel parameters, int partyId)
        {
            using(var transaction  = new TransactionScope())
            {
                try
                {
                   string indexQuery  = "INSERT INTO tbl_mn_InvoiceIndex (FilePath, CreatedDate,CreatorId, InvoiceCategory, BillNo ) OUTPUT " +
                                        " INSERTED.InvoiceId " +
                                        " VALUES (@FilePath, GETDATE(), @CreatorId, @InvoiceCategory, @BillNo)";
                    int index = _dataAccess.Query<int>(indexQuery, parameters).FirstOrDefault();

                    var details = new InvoiceDetailsModel()
                    {
                        InvoiceId = index,
                        InvoiceDetails = parameters.InvoiceDetails,
                        InvoiceDate = DateTime.ParseExact(parameters.InvoiceDate, "yyyy-mm-dd hh:mm:ss.ffff", System.Globalization.CultureInfo.InvariantCulture),
                        PartyId = partyId
                    };
                   string detailsQuery = "INSERT INTO tbl_mn_InvoiceDetails ( InvoiceId, InvoiceDetails, InvoiceDate, PartyId)" +
                    " VALUES (@InvoiceId, @InvoiceDetails, @InvoiceDate, @PartyId)";
                    var obj = _dataAccess.Query<object>(detailsQuery, details);

                    transaction.Complete();

                    return index;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
