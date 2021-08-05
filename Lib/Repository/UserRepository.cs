using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Lib.Service;

namespace Lib
{
    public class UserRepository : IUserService
    {
        IDataAccess _dataAccess;
        public UserRepository()
        {
            _dataAccess = new DataAccess();
        }
        public bool UpdateUser(UserModel user)
        {
            try
            {
               string query = "Update tbl_mn_User set Username = @Username, Password = @Password," +
                       "MobileNo = @MobileNo, Address =@Address where UserId = @UserId";
                return _dataAccess.Query<UserModel>(query, user) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool AddUser(UserModel user)
        {
            try
            {
                string query = "INSERT INTO  tbl_mn_User (Username , Password ," +
                        "MobileNo, Address ) VALUES (@Username,@Password,@MobileNo,@Address)";
                return _dataAccess.Query<UserModel>(query, user) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool DeleteUser(int userId)
        {
            try
            {
                string query = "DELETE FROM tbl_mn_User WHERE UserId = @userId";
                return _dataAccess.Query<object>(query, userId) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<UserModel> GetUser()
        {
            try
            {
                string query = "SELECT *  FROM tbl_mn_User ";
                return _dataAccess.Query<UserModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string GetUserPassword(int id)
        {
            try
            {
                var users = GetUser();
                return users.Find(x => x.UserId == id).Password;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool CheckUserLogin(UserModel user)
        {
            try
            {
                var users = GetUser();
                return users.Find(x => x.Username == user.Username && x.Password == user.Password) != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetUserData()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("MobileNo", typeof(double));
                table.Columns.Add("Role", typeof(string));

                List<UserModel> userList = GetUser();
                foreach (UserModel user in userList)
                {
                    string role = user.IsAdmin == true ? "Admin" : "User";
                    table.Rows.Add(user.UserId, user.Username, user.Address, user.MobileNo, role);
                };
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
