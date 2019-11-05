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
    public static class UserSer
    {
        public static User findUserByUserName(User user)
        {
            SqlParameter[] sp = {
                new SqlParameter("@username", user.UserName),
            };
            string sql = "select * from tb_User where 用户名 like @username";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfUserbyDataReader(dr);
        }
        static List<User> getListOfUserbyDataReader(SqlDataReader dr)
        {
            List<User> listOfStudentInfo = new List<User>();
            while (dr.Read())
            {
                User user = new User();
                int userName = dr.GetOrdinal("用户名");
                if (!dr.IsDBNull(userName))
                {
                    user.UserName = dr.GetString(userName);
                }
                int userPwd = dr.GetOrdinal("用户密码");
                if (!dr.IsDBNull(userPwd))
                {
                    user.UserPwd = dr.GetString(userPwd);
                }
                int tName = dr.GetOrdinal("真实姓名");
                if (!dr.IsDBNull(tName))
                {
                    user.TName = dr.GetString(tName);
                }
                int sex = dr.GetOrdinal("性别");
                if (dr.IsDBNull(sex))
                {
                    user.Sex = dr.GetBoolean(sex);
                }
                int birthday = dr.GetOrdinal("出生日期");
                if (!dr.IsDBNull(birthday))
                {
                    user.Birthday = dr.GetDateTime(birthday);
                }
                int tel = dr.GetOrdinal("联系电话");
                if (!dr.IsDBNull(tel))
                {
                    user.Tel = dr.GetString(tel);
                }
                int mobile = dr.GetOrdinal("手机");
                if (!dr.IsDBNull(mobile))
                {
                    user.Mobile = dr.GetString(mobile);
                }
                int qQ = dr.GetOrdinal("QQ号");
                if (!dr.IsDBNull(qQ))
                {
                    user.QQ = dr.GetInt64(qQ);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    user.Photo = dr.GetString(photo);
                }
                int email = dr.GetOrdinal("Email");
                if (!dr.IsDBNull(photo))
                {
                    user.Email = dr.GetString(email);
                }
                int fAddress = dr.GetOrdinal("家庭");
                if (!dr.IsDBNull(fAddress))
                {
                    user.FAddress = dr.GetString(fAddress);
                }
                int rAddress = dr.GetOrdinal("联系地址");
                if (!dr.IsDBNull(rAddress))
                {
                    user.FAddress = dr.GetString(rAddress);
                }
                int index = dr.GetOrdinal("个人首页");
                if (!dr.IsDBNull(index))
                {
                    user.Index = dr.GetString(index);

                }
                int userPop = dr.GetOrdinal("用户权限");
                if (!dr.IsDBNull(userPop))
                {
                    user.UserPop = dr.GetString(userPop);
                }

                listOfStudentInfo.Add(user);

            }
            return listOfStudentInfo;
        }
        static User getOfUserbyDataReader(SqlDataReader dr)
        {
             User user = new User();
            while (dr.Read())
            {
                int userName = dr.GetOrdinal("用户名");
                if (!dr.IsDBNull(userName))
                {
                    user.UserName = dr.GetString(userName);
                }
                int userPwd = dr.GetOrdinal("用户密码");
                if (!dr.IsDBNull(userPwd))
                {
                    user.UserPwd = dr.GetString(userPwd);
                }
                int tName = dr.GetOrdinal("真实姓名");
                if (!dr.IsDBNull(tName))
                {
                    user.TName = dr.GetString(tName);
                }
                int sex = dr.GetOrdinal("性别");
                if (dr.IsDBNull(sex))
                {
                    user.Sex = dr.GetBoolean(sex);
                }
                int birthday = dr.GetOrdinal("出生日期");
                if (!dr.IsDBNull(birthday))
                {
                    user.Birthday = dr.GetDateTime(birthday);
                }
                int tel = dr.GetOrdinal("联系电话");
                if (!dr.IsDBNull(tel))
                {
                    user.Tel = dr.GetString(tel);
                }
                int mobile = dr.GetOrdinal("手机");
                if (!dr.IsDBNull(mobile))
                {
                    user.Mobile = dr.GetString(mobile);
                }
                int qQ = dr.GetOrdinal("QQ号");
                if (!dr.IsDBNull(qQ))
                {
                    user.QQ = dr.GetInt64(qQ);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    user.Photo = dr.GetString(photo);
                }
                int email = dr.GetOrdinal("Email");
                if (!dr.IsDBNull(photo))
                {
                    user.Email = dr.GetString(email);
                }
                int fAddress = dr.GetOrdinal("家庭住址");
                if (!dr.IsDBNull(fAddress))
                {
                    user.FAddress = dr.GetString(fAddress);
                }
                int rAddress = dr.GetOrdinal("联系地址");
                if (!dr.IsDBNull(rAddress))
                {
                    user.FAddress = dr.GetString(rAddress);
                }
                int index = dr.GetOrdinal("个人首页");
                if (!dr.IsDBNull(index))
                {
                    user.Index = dr.GetString(index);

                }
                int userPop = dr.GetOrdinal("用户权限");
                if (!dr.IsDBNull(userPop))
                {
                    user.UserPop = dr.GetString(userPop);
                }
            }
            return user;
        }

    }
}
