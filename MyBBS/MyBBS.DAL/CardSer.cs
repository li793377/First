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
    public static class CardSer
    {
        public static int addCard(Card card)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("cardid",card.CardID),
                new SqlParameter("cardname",card.CardName),
                new SqlParameter("moduleid",card.ModuleID),
                new SqlParameter("cardcontent",card.CardContent),
                new SqlParameter("cardtime",card.CardTime),
                new SqlParameter("cardpeople",card.CardPeople),
                new SqlParameter("pop",card.Pop),
        };
            string sql = "insert into tb_card values( @cardid,@cardname,@moduleid,@cardcontent,@cardtime,@cardpeople,@pop)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static string getMaxCardID()
        {
            string sql = "select top 1 帖子编号 from tb_card order by 帖子编号 Desc";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            string MaxID="T1001";
            while (dr.Read())
            {
                int cardID = dr.GetOrdinal("帖子编号");
                if (!dr.IsDBNull(cardID))
                {
                    MaxID = dr.GetString(cardID);
                }
            }
            return MaxID;
        }
        public static int deleteCard(Card card)
        {
            SqlParameter[] sp = new SqlParameter[]
          {
                new SqlParameter("cardid",card.CardID),

         };
            string sql = "delete from tb_Card where 帖子编号 = @cardid";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static Card FindCardByCardID(Card card)
        {
            SqlParameter[] sp = {
                new SqlParameter("@cardid", card.CardID),
            };
            string sql = "select * from tb_card where 帖子编号 like @cardid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getOfCardFromDataReader(dr);
        }
        
        public static List<Card> FindCardByMouduleID(Card card)
        {
            {
                SqlParameter[] sp = {
                        new SqlParameter("@moduleID", card.ModuleID),
                      };
                string sql = "select * from tb_card where 模块编号 like @cardid";
                SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
                return getListOfCardFromDataReader(dr);
            }
        }
        public static List<Card> FindCardByCardName(Card card)
        {
            {
                SqlParameter[] sp = {
                        new SqlParameter("@cardName", card.CardName),
                      };
                string sql = "select * from tb_card where 帖子名称 like @cardName";
                SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
                return getListOfCardFromDataReader(dr);
            }
        }
        public static List<Card> getAllCard()
        {
            string sql = "select * from tb_card ORDER BY 发表时间";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getListOfCardFromDataReader(dr);

        }
        static List<Card> getListOfCardFromDataReader(SqlDataReader dr)
        {
            List<Card> listOfCard = new List<Card>();
            while (dr.Read())
            {
                Card card = new Card();
                int cardID = dr.GetOrdinal("帖子编号");
                if (!dr.IsDBNull(cardID))
                {
                    card.CardID = dr.GetString(cardID);
                }
                int cardName = dr.GetOrdinal("帖子名称");
                if (!dr.IsDBNull(cardName))
                {
                    card.CardName = dr.GetString(cardName);
                }
                int moduleid = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleid))
                {
                    card.ModuleID = dr.GetString(moduleid);
                }

                int cardContent = dr.GetOrdinal("帖子内容");
                if (!dr.IsDBNull(cardContent))
                {
                    card.CardContent = dr.GetString(cardContent);
                }
                int time = dr.GetOrdinal("发表时间");
                if (!dr.IsDBNull(time))
                {
                    card.CardTime = dr.GetDateTime(time);
                }
                int peo = dr.GetOrdinal("发帖人");
                if (!dr.IsDBNull(peo))
                {
                    card.CardPeople = dr.GetString(peo);
                }
                int pop = dr.GetOrdinal("角色");
                if (!dr.IsDBNull(pop))
                {
                    card.Pop = dr.GetString(pop);
                }
                listOfCard.Add(card);
            }
            return listOfCard;
        }
        static Card getOfCardFromDataReader(SqlDataReader dr)
        {
            Card card = new Card();
            while (dr.Read())
            {
                int cardID = dr.GetOrdinal("帖子编号");
                if (!dr.IsDBNull(cardID))
                {
                    card.CardID = dr.GetString(cardID);
                }
                int cardName = dr.GetOrdinal("帖子名称");
                if (!dr.IsDBNull(cardName))
                {
                    card.CardName = dr.GetString(cardName);
                }
                int moduleid = dr.GetOrdinal("版块编号");
                if (!dr.IsDBNull(moduleid))
                {
                    card.ModuleID = dr.GetString(moduleid);
                }

                int cardContent = dr.GetOrdinal("帖子内容");
                if (!dr.IsDBNull(cardContent))
                {
                    card.CardContent = dr.GetString(cardContent);
                }
                int time = dr.GetOrdinal("发表时间");
                if (!dr.IsDBNull(time))
                {
                    card.CardTime = dr.GetDateTime(time);
                }
                int peo = dr.GetOrdinal("发帖人");
                if (!dr.IsDBNull(peo))
                {
                    card.CardPeople = dr.GetString(peo);
                }
                int pop = dr.GetOrdinal("角色");
                if (!dr.IsDBNull(pop))
                {
                    card.Pop = dr.GetString(pop);
                }

            }
            return card;
        }
    }
}
