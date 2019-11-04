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
    public static class HostSer
    {
        public static List<Host> FindHostByMID(Host host)
        {
            SqlParameter[] sp = {
                new SqlParameter("@moduleid", host.ModuleID),
            };
            string sql = "select * from tb_Host where 版块编号 like @moduleid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getListOfHostbyDataReader(dr);
        }
        public static Host FindHostByMouduleID(Host host)
        {
            SqlParameter[] sp = {
                new SqlParameter("@moduleid", host.ModuleID),
            };
            string sql = "select * from tb_Host where 版块编号 like @moduleid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfHostbyDataReader(dr);
        }
        public static Host FindHostByHostName(Host host)
        {
            SqlParameter[] sp = {
                new SqlParameter("@hostName", host.HostName),
            };
            string sql = "select * from tb_Host where 版主 like @hostname";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfHostbyDataReader(dr);
        }
        static List<Host> getListOfHostbyDataReader(SqlDataReader dr)
        {
            List<Host> listOfStudentInfo = new List<Host>();
            while (dr.Read())
            {
                Host host = new Host();
                int hostName = dr.GetOrdinal("版主");
                if (!dr.IsDBNull(hostName))
                {
                    host.HostName = dr.GetString(hostName);
                }
                int moduleID = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleID))
                {
                    host.ModuleID = dr.GetString(moduleID);
                }
                int hostPwd = dr.GetOrdinal("密码");
                if (!dr.IsDBNull(hostPwd))
                {
                    host.HostPwd = dr.GetString(hostPwd);
                }
                int tName = dr.GetOrdinal("真实姓名");
                if (!dr.IsDBNull(tName))
                {
                    host.TName = dr.GetString(tName);
                }
                int sex = dr.GetOrdinal("性别");
                if (!dr.IsDBNull(sex))
                {
                    host.Sex = dr.GetBoolean(sex);
                }
                int birthday = dr.GetOrdinal("出生日期");
                if (!dr.IsDBNull(birthday))
                {
                    host.Birthday = dr.GetDateTime(birthday);
                }
                int tel = dr.GetOrdinal("联系电话");
                if (!dr.IsDBNull(tel))
                {
                    host.Tel = dr.GetString(tel);
                }
                int mobile = dr.GetOrdinal("手机");
                if (!dr.IsDBNull(mobile))
                {
                    host.Mobile = dr.GetString(mobile);
                }
                int qQ = dr.GetOrdinal("QQ号");
                if (!dr.IsDBNull(qQ))
                {
                    host.QQ = dr.GetInt64(qQ);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    host.Photo = dr.GetString(photo);
                }
                int email = dr.GetOrdinal("Email");
                if (!dr.IsDBNull(photo))
                {
                    host.Email = dr.GetString(email);
                }
                int fAddress = dr.GetOrdinal("家庭住址");
                if (!dr.IsDBNull(fAddress))
                {
                    host.FAddress = dr.GetString(fAddress);
                }
                int rAddress = dr.GetOrdinal("联系地址");
                if (!dr.IsDBNull(rAddress))
                {
                    host.FAddress = dr.GetString(rAddress);
                }
                int index = dr.GetOrdinal("个人首页");
                if (!dr.IsDBNull(index))
                {
                    host.Index = dr.GetString(index);

                }
                int hostPop = dr.GetOrdinal("版主权限");
                if (!dr.IsDBNull(hostPop))
                {
                    host.HostPop = dr.GetString(hostPop);
                }
                listOfStudentInfo.Add(host);

            }
            return listOfStudentInfo;
        }
        static Host getOfHostbyDataReader(SqlDataReader dr)
        {
            Host host = new Host();
            while (dr.Read())
            {
                int hostName = dr.GetOrdinal("版主");
                if (!dr.IsDBNull(hostName))
                {
                    host.HostName = dr.GetString(hostName);
                }
                int moduleID = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleID))
                {
                    host.ModuleID = dr.GetString(moduleID);
                }
                int hostPwd = dr.GetOrdinal("密码");
                if (!dr.IsDBNull(hostPwd))
                {
                    host.HostPwd = dr.GetString(hostPwd);
                }
                int tName = dr.GetOrdinal("真实姓名");
                if (!dr.IsDBNull(tName))
                {
                    host.TName = dr.GetString(tName);
                }
                int sex = dr.GetOrdinal("性别");
                if (!dr.IsDBNull(sex))
                {
                    host.Sex = dr.GetBoolean(sex);
                }
                int birthday = dr.GetOrdinal("出生日期");
                if (!dr.IsDBNull(birthday))
                {
                    host.Birthday = dr.GetDateTime(birthday);
                }
                int tel = dr.GetOrdinal("联系电话");
                if (!dr.IsDBNull(tel))
                {
                    host.Tel = dr.GetString(tel);
                }
                int mobile = dr.GetOrdinal("手机");
                if (!dr.IsDBNull(mobile))
                {
                    host.Mobile = dr.GetString(mobile);
                }
                int qQ = dr.GetOrdinal("QQ号");
                if (!dr.IsDBNull(qQ))
                {
                    host.QQ = dr.GetInt64(qQ);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    host.Photo = dr.GetString(photo);
                }
                int email = dr.GetOrdinal("Email");
                if (!dr.IsDBNull(photo))
                {
                    host.Email = dr.GetString(email);
                }
                int fAddress = dr.GetOrdinal("家庭住址");
                if (!dr.IsDBNull(fAddress))
                {
                    host.FAddress = dr.GetString(fAddress);
                }
                int rAddress = dr.GetOrdinal("联系地址");
                if (!dr.IsDBNull(rAddress))
                {
                    host.FAddress = dr.GetString(rAddress);
                }
                int index = dr.GetOrdinal("个人首页");
                if (!dr.IsDBNull(index))
                {
                    host.Index = dr.GetString(index);

                }
                int hostPop = dr.GetOrdinal("版主权限");
                if (!dr.IsDBNull(hostPop))
                {
                    host.HostPop = dr.GetString(hostPop);
                }
                

            }
            return host;
        }
    }
}

