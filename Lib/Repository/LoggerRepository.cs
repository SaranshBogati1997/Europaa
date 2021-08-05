using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class Logger
    {
        
        public static void Log(string module, string type, string message, string details)
        {
            try
            {
                IDataAccess _dataAccess = new DataAccess();
                string query = "INSERT INTO tbl_lg_DetailLog (Module, LogType, LogMessage, LogDetails) VALUES " +
                    "(@Module, @LogType, @LogMessage, @LogDetails)";
                _dataAccess.Query<object>(query, new { Module = module, LogType = type, LogMessage = message, LogDetails = details });

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
