﻿using System;
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
        public static int UpdateHost(Host host)
        {
            SqlParameter[] sp =
            {
                    new SqlParameter("@hostname",host.HostName),
                    new SqlParameter("@hostpwd",host.HostPwd),
                    new SqlParameter("@tname",host.TName),
                    new SqlParameter("@sex",host.Sex),
                    new SqlParameter("@birthday",host.Birthday),
                    new SqlParameter("@tel",host.Tel),
                    new SqlParameter("@mobile", host.Mobile),
                    new SqlParameter("@qq",host.QQ),
                    new SqlParameter("@photo",host.Photo),
                    new SqlParameter("@email", host.Email),
                    new SqlParameter("@faddress", host.FAddress),
                    new SqlParameter("@raddress",host.RAddress),
                    new SqlParameter("@index",host.Index),
            };
            string sql = "update tb_Host set 密码=@hostpwd,真实姓名=@tname,性别=@sex,出生日期=@birthday,联系电话=@tel,手机=@mobile,"
                + "QQ号=@qq,头像=@photo,Email=@email,家庭住址=@faddress,联系地址=@raddress,个人首页=@index where 版主=@hostname";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static Host Login(Host host)
        {
            SqlParameter[] sp =
            {
                        new SqlParameter("@hostname",host.HostName),
                        new SqlParameter("@hostpwd",host.HostPwd),
            };
            string sql = "SELECT * FROM tb_Host WHERE (版主 = @hostname) AND (密码 = @hostpwd)";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfHostbyDataReader(dr);
        }
        public static int addHost(Host host)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("@hostname",host.HostName),
                new SqlParameter("@moduleid",host.ModuleID),
                new SqlParameter("@hostpwd",host.HostPwd),
                new SqlParameter("@tname",host.TName),
                new SqlParameter("@sex",host.Sex),
                new SqlParameter("@birthday",host.Birthday),
                new SqlParameter("@tel",host.Tel),
                new SqlParameter("@mobile",host.Mobile),
                new SqlParameter("@qq",host.QQ),
                new SqlParameter("@photo",host.Photo),
                new SqlParameter("@email",host.Email),
                new SqlParameter("@faddress",host.FAddress),
                new SqlParameter("@raddress",host.RAddress),
                new SqlParameter("@index",host.Index),
                new SqlParameter("@hostpop",host.HostPop),
        };
            string sql = "insert into tb_hosthostues( @hostname,@moduleid,@hostpwd,@tname,@sex,@birthday,@tel,@mobile,@qq,@photo,@email,@faddress,@raddress,@index,@hostpop)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static List<Host> getAllHost()
        {
            string sql = "selsct * from tb_host";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getListOfHostbyDataReader(dr);
        }
        public static int deleteHost(Host host)
        {
            SqlParameter[] sp =
                {
                       new SqlParameter("@hostname",host.HostName),
                };
            string sql = "delete from tb_Host where 版主=@hostname";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static List<Host> FindHostByMID(Host host)
        {
            SqlParameter[] sp = {
                new SqlParameter("@moduleid", host.ModuleID),
            };
            string sql = "select * from tb_Host where 版块编号 like @moduleid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getListOfHostbyDataReader(dr);
        }
        public static Host FindHostByModuleID(Host host)
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

