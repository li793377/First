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
    public static class RevertSer
    {
        public static int addRevert(Revert revert)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("revertid",revert.RevertID),
                new SqlParameter("revertname",revert.RevertName),
                new SqlParameter("cardid",revert.CardID),
                new SqlParameter("revertcontent",revert.RevertContent),
                new SqlParameter("reverttime",revert.RevertTime),
                new SqlParameter("revertpeople",revert.RevertPeople),
                new SqlParameter("pop",revert.Pop),
        };
            string sql = "insert into tb_card values( @revertid,@revertname,@cardid,@revertcontent,@reverttime,@revertpeople,@pop)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static string getMaxRevertID()
        {
            string sql = "select top 1 回帖编号 from tb_revert order by 回帖编号 Desc";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getOfRevertbyDataReader(dr).RevertID;
        }
        public static int DeleteRevertRevertID(Revert revert)
        {
            SqlParameter[] sp = {
                 new SqlParameter("@revertid", revert.RevertID),
            };
            string sql = "delete from tb_Revert where 回帖编号=@revertid";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static Revert FindRevertByRevertID(Revert revert)
        {
            SqlParameter[] sp = {
                new SqlParameter("@revertid", revert.RevertID),
            };
            string sql = "select * from tb_Revert where 回帖编号 like @revertid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfRevertbyDataReader(dr);
        }
        public static List<Revert> FindRevertByCardID(Revert revert)
        {
            SqlParameter[] sp = {
                new SqlParameter("@cardid", revert.CardID),
            };
            string sql = "select * from tb_Revert where 帖子编号 like @cardid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getListOfRevertbyDataReader(dr);
        }

        static List<Revert> getListOfRevertbyDataReader(SqlDataReader dr)
        {
            List<Revert> listOfStudentInfo = new List<Revert>();
            while (dr.Read())
            {
                Revert revert = new Revert();
                int revertID = dr.GetOrdinal("回帖编号");
                if (!dr.IsDBNull(revertID))
                {
                    revert.RevertID = dr.GetString(revertID);
                }
                int revertName = dr.GetOrdinal("回帖主题");
                if (!dr.IsDBNull(revertName))
                {
                    revert.RevertName = dr.GetString(revertName);
                }
                int cardID = dr.GetOrdinal("帖子编号");
                if (!dr.IsDBNull(cardID))
                {
                    revert.CardID = dr.GetString(cardID);
                }
                int revertContent = dr.GetOrdinal("回帖内容");
                if (dr.IsDBNull(revertContent))
                {
                    revert.RevertContent = dr.GetString(revertContent);
                }
                int revertTime = dr.GetOrdinal("回帖时间");
                if (!dr.IsDBNull(revertTime))
                {
                    revert.RevertTime = dr.GetDateTime(revertTime);
                }
                int revertPeople = dr.GetOrdinal("回帖人");
                if (!dr.IsDBNull(revertPeople))
                {
                    revert.RevertPeople = dr.GetString(revertPeople);
                }
                int pop = dr.GetOrdinal("角色");
                if (!dr.IsDBNull(pop))
                {
                    revert.Pop = dr.GetString(pop);
                }

                listOfStudentInfo.Add(revert);

            }
            return listOfStudentInfo;
        }
        static Revert getOfRevertbyDataReader(SqlDataReader dr)
        {
            Revert revert = new Revert();
            while (dr.Read())
            {
                
                int revertID = dr.GetOrdinal("回帖编号");
                if (!dr.IsDBNull(revertID))
                {
                    revert.RevertID = dr.GetString(revertID);
                }
                int revertName = dr.GetOrdinal("回帖主题");
                if (!dr.IsDBNull(revertName))
                {
                    revert.RevertName = dr.GetString(revertName);
                }
                int cardID = dr.GetOrdinal("帖子编号");
                if (!dr.IsDBNull(cardID))
                {
                    revert.CardID = dr.GetString(cardID);
                }
                int revertContent = dr.GetOrdinal("回帖内容");
                if (dr.IsDBNull(revertContent))
                {
                    revert.RevertContent = dr.GetString(revertContent);
                }
                int revertTime = dr.GetOrdinal("回帖时间");
                if (!dr.IsDBNull(revertTime))
                {
                    revert.RevertTime = dr.GetDateTime(revertTime);
                }
                int revertPeople = dr.GetOrdinal("回帖人");
                if (!dr.IsDBNull(revertPeople))
                {
                    revert.RevertPeople = dr.GetString(revertPeople);
                }
                int pop = dr.GetOrdinal("角色");
                if (!dr.IsDBNull(pop))
                {
                    revert.Pop = dr.GetString(pop);
                }
            }
            return revert;
        }
    }
}
