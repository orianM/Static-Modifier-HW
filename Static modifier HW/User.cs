using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_modifier_HW
{
    class User
    {
        public string password;
        public string userName;
        public bool isLogin;
        public Permission permission;
        public static User[] users = new User[5];

        public User()
        {

        }

        public User(string password, string userName, bool isLogin, Permission permission)
        {
            this.password = password;
            this.userName = userName;
            this.isLogin = isLogin;
            this.permission = permission
        }

        public static Permission Login(string password, string userName)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (userName.ToLower() == users[i].userName.ToLower() && password.ToLower() == users[i].password.ToLower())
                {
                    users[i].isLogin = true;
                    return users[i].permission;
                }
            }

            return Permission.None;
        }

        public static void Logout(User user)
        {
            user.isLogin = false;
        }
    }
}
