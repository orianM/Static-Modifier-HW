using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_modifier_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*Static - is a modifier that makes a variable/function/class not dependent on an instance.*/

            #endregion

            #region question 2

            /*Static can be used to manage a function/field which has a global value,
              in other words a value that remains "static" and shouldn't be changed  by every instance*/

            #endregion

            #region question 3

            /*The functions/field we'll declare as static are ones that don't need an instance.
              For example: If we create a class called "Names", and a function called "GetName(class)",
                           we would declare "GetName()" as static since it does not have to rely on an instance.*/

            #endregion

            #region question 4

            Person per1 = new Person(05325346, "Bee");
            Person per2 = new Person(75634534, "Fee");
            Person per3 = new Person(82903456, "Cee");
            Person per4 = new Person(02987343, "Qee");
            Person per5 = new Person(24839613, "Gee");
            Person per6 = new Person(79082353, "Hee");
            Person per7 = new Person(93624545, "Mee");
            Person per8 = new Person(09237458, "Zee");
            Person per9 = new Person(34768556, "Lee");
            Person per10 = new Person(09178239, "Key");

            #endregion

            #region question 5

            User user1 = new User()
            {
                password = "1",
                userName = "One",
                isLogin = false,
                permission = Permission.User
            };

            User user2 = new User()
            {
                password = "2",
                userName = "Two",
                isLogin = false,
                permission = Permission.User
            };

            User user3 = new User()
            {
                password = "3",
                userName = "Three",
                isLogin = true,
                permission = Permission.Admin
            };

            User user4 = new User()
            {
                password = "4",
                userName = "Four",
                isLogin = false,
                permission = Permission.User
            };

            User user5 = new User()
            {
                password = "5",
                userName = "Five",
                isLogin = true,
                permission = Permission.Admin
            };

            #endregion
        }
    }
}
