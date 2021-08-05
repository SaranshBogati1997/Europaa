using Lib.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class CompanyRepository : ICompanyService
    {
        IDataAccess _dataAccess;
        public CompanyRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool InsertCompany(CompanyModel company)
        {
            try
            {
                string query = "INSERT INTO tbl_mn_Company " +
                        "(CompanyName, City, State, Country, Logo, MobileNumber, PhoneNumber, PAN, StartDate)" +
                        "VALUES " +
                        "(@CompanyName, @City, @State, @Country, @Logo, @MobileNo, @PhoneNo,@PAN, @StartDate)";
                var obj = _dataAccess.Query<object>(query, company);
                if (obj != null)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<CompanyModel> GetCompany()
        {
            try
            {
                string query = "SELECT * FROM tbl_mn_Company";
                return _dataAccess.Query<CompanyModel>(query);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
