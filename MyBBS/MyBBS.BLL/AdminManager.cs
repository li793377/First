using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class AdminManager
    {
        public static Admin Login(Admin admin)
        {
            return AdminSer.Login(admin);
        }
        public static Admin getAdmin()
        {
            return AdminSer.getAdmin();
        }
        public static int updateAdmin(Admin admin)
        {

            return AdminSer.updateAdmin(admin);
        }
    }
}
