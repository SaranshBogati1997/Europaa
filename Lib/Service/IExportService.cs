using Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IExportService
    {
        int InsertInvoiceDetails(ReportDatabaseParametersModel parameters, int partyId);
    }
}
