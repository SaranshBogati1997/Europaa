using System;

namespace Lib
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long MobileNo { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool isActive { get; set; }
    }
}
