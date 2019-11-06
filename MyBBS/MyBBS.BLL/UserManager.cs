using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class UserManager
    {
        public static User Login(User user)
        {
            return UserSer.Login(user);
        }
        public static List<User> getAllUser()
        {
            return UserSer.getAllUser();
        }
        public static int addUser(User user)
        {
            return UserSer.addUser(user);
        }
        public static int deleteUser(User user)
        {
            return UserSer.deleteUser(user);
        }
        public static User findUserByUserName(User user)
        {
            return UserSer.findUserByUserName(user);
        }
    }
}
