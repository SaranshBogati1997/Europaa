using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Service
{
    public interface IUserService
    {
        bool UpdateUser(UserModel user);
        bool AddUser(UserModel user);
        bool DeleteUser(int userId);
        List<UserModel> GetUser();
        string GetUserPassword(int id);
        bool CheckUserLogin(UserModel user);
        DataTable GetUserData();
    }
}
