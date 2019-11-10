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
        public static int addPhoto(Image image)
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
        public static int deletePhoto(Image image)
        {
            SqlParameter[] sp = new SqlParameter[]
         {
                new SqlParameter("photoid",image.PhotoID),
         };
            string sql = "delete from tb_Image where 编号=@photoid";
            return sqlHelp.ExecuteNonQuery(sql, sp);
        }
        public static List<Image> getAllPhoto()
        {
            string sql = "select * from tb_Image ORDER BY 编号";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql);
            return getListOfImageFromDataReader(dr);
        }
        public static Image findImageByPhotoID(Image image)
        {
            SqlParameter[] sp = {
                new SqlParameter("@photoid", image.PhotoID),
            };
            string sql = "select * from tb_Image where 编号 like @photoid";
            SqlDataReader dr = sqlHelp.ExecuteReader(sql, sp);
            return getImagebyDataReader(dr);
        }
        static List<Image> getListOfImageFromDataReader(SqlDataReader dr)
        {
            List<Image> listOfStudentInfo = new List<Image>();
            while (dr.Read())
            {
                Image image = new Image();
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

                listOfStudentInfo.Add(image);

            }
            return listOfStudentInfo;
        }
        static Image getImagebyDataReader(SqlDataReader dr)
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
