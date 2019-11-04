using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class ImageManager
    {
        public static int addPhoto(Image image)
        {
            return ImageSer.addPhoto(image);
        }
        public static string getMaxPhotoID()
        {
            return ImageSer.getMaxPhotoID();
        }
        public static int deletePhoto(Image image)
        {
            return ImageSer.deletePhoto(image);
        }
        public static Image findImageByPhotoID(Image image)
        {
            return ImageSer.findImageByPhotoID(image);
        }
        public static List<Image> getAllPhoto()
        {
            return ImageSer.getAllPhoto();
        }
    }
}
