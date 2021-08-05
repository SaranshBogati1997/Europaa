using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IReportService
    {
        Dictionary<string, string> GetPurchaseData();
        Dictionary<string, string> GetSalesData();
    }
}
