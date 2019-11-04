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
        public static User findUserByUserName(User user)
        {
            return UserSer.findUserByUserName(user);
        }
    }
}
