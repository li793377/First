using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stu.DBHelper;
using MyBBS.Model;
using System.Data;
using System.Data.SqlClient;


namespace MyBBS.DAL
{
    public static class AdminSer
    {
        public static Admin Login(Admin admin)
        {
            SqlParameter[] sp =
            {
                        new SqlParameter("@adminname",admin.AdminName),
                        new SqlParameter("@adminpwd",admin.AdminPwd),
            };
            string sql = "SELECT * FROM tb_Admin WHERE (管理员姓名 = @adminname) AND (管理员密码 = @adminpwd)";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfAdminbyDataReader(dr);
        }
        public static Admin getAdmin()
        {
            string sql = "select * from tb_Admin";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getOfAdminbyDataReader(dr);
        }
        public static int updateAdmin(Admin admin)
        {
            SqlParameter[] sp = new SqlParameter[]
          {
                new SqlParameter("adminname",admin.AdminName),
                new SqlParameter("adminpwd"  ,admin.AdminPwd),
         };
            string sql = "update tb_Admin set 管理员姓名=@adminname,管理员密码=@adminpwd";
            return sqlHelp.ExecuteNonQuery(sql,sp);
        }
        static List<Admin> getListOfAdminbyDataReader(SqlDataReader dr)
        {
            List<Admin> listOfStudentInfo = new List<Admin>();
            while (dr.Read())
            {
                Admin admin = new Admin();
                int adminName = dr.GetOrdinal("管理员姓名");
                if (!dr.IsDBNull(adminName))
                {
                    admin.AdminName = dr.GetString(adminName);
                }
                int adminPwd = dr.GetOrdinal("管理员密码");
                if (!dr.IsDBNull(adminPwd))
                {
                    admin.AdminPwd = dr.GetString(adminPwd);
                }
                int adminRole = dr.GetOrdinal("管理员权限");
                if (!dr.IsDBNull(adminRole))
                {
                    admin.AdminPwd = dr.GetString(adminRole);
                }

                listOfStudentInfo.Add(admin);

            }
            return listOfStudentInfo;
        }
        static Admin getOfAdminbyDataReader(SqlDataReader dr)
        {
            Admin admin = new Admin();
            while (dr.Read())
            {
              
                int adminName = dr.GetOrdinal("管理员姓名");
                if (!dr.IsDBNull(adminName))
                {
                    admin.AdminName = dr.GetString(adminName);
                }
                int adminPwd = dr.GetOrdinal("管理员密码");
                if (!dr.IsDBNull(adminPwd))
                {
                    admin.AdminPwd = dr.GetString(adminPwd);
                }
                int adminRole = dr.GetOrdinal("管理员权限");
                if (!dr.IsDBNull(adminRole))
                {
                    admin.AdminPwd = dr.GetString(adminRole);
                }
            }
            return admin;

        }
    }
}
