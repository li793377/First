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
    public static class ImageSer
    {
        public static int addRevert(Image image)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("photoid",image.PhotoID),
                new SqlParameter("photo",image.Photo),
        };
            string sql = "insert into tb_card values(@photoid,@photo)";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static string getMaxPhotoID()
        {
            string sql = "select top 1 编号 from tb_image order by 编号 Desc";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            string MaxID = "IMG1001";
            while (dr.Read())
            {
                int photoID = dr.GetOrdinal("编号");
                if (!dr.IsDBNull(photoID))
                {
                    MaxID = dr.GetString(photoID);
                }
            }
            return MaxID;
        }
        public static List<Image> FindHostByMID(Image image)
        {
            SqlParameter[] sp = {
                new SqlParameter("@photoid", image.PhotoID),
            };
            string sql = "select * from tb_Image where 头像 like @photoid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getListOfImagebyDataReader(dr);
        }
         static List<Image> getListOfImagebyDataReader(SqlDataReader dr)
        {
            List<Image> listOfStudentInfo = new List<Image>();
            while (dr.Read())
            {
                Image image = new Image();
                int photoID = dr.GetOrdinal("编号");
                if (!dr.IsDBNull(photoID)) 
                {
                    image.PhotoID= dr.GetString(photoID);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    image.Photo = dr.GetString(photo);
                }

                listOfStudentInfo.Add(image);

            }
            return listOfStudentInfo;
        }
         static Image getOfImagebyDataReader(SqlDataReader dr)
        {
           Image image = new Image();
            while (dr.Read())
            {         
                int photoID = dr.GetOrdinal("编号");
                if (!dr.IsDBNull(photoID))
                {
                    image.PhotoID = dr.GetString(photoID);
                }
                int photo = dr.GetOrdinal("头像");
                if (!dr.IsDBNull(photo))
                {
                    image.Photo = dr.GetString(photo);
                }
            }
            return image;
        }
    }
}
