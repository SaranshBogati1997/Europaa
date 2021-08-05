using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface IDataAccess
    {
        List<T> Query<T>(string query, object parameters = null, bool isStoredProcedure = false);
        IDbConnection GetNewConnection();
    }
}
