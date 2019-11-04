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
        public static int addRevert(Image image)
        {
            return ImageSer.addRevert(image);
        }
        public static string getMaxPhotoID()
        {
            return ImageSer.getMaxPhotoID();
        }
    }
}
