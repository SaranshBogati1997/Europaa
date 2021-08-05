using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class DataAccess:IDataAccess
    {
        public string ConnectionString { get; set; }
        
        public DataAccess()
        {
            ConnectionString = GetConnectionString();
        }
        public IDbConnection GetNewConnection()
        {
            IDbConnection conn = new SqliteConnection(ConnectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }
        public List<T> Query<T>(string query, object parameters = null, bool isStoredProcedure = false)
        {
            using(IDbConnection conn = new SqliteConnection(ConnectionString))
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }                
                if (isStoredProcedure)
                {
                    var storedExecution = conn.Query<T>(query, parameters, commandType: CommandType.StoredProcedure);
                    return storedExecution.AsList();
                }
                var dt = conn.Query<T>(query,parameters);
                return dt.AsList();

            }
        }
    }
}
