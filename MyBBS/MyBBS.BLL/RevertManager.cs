using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBBS.DAL;
using MyBBS.Model;
namespace MyBBS.BLL
{
    public static class RevertManager
    {
        public static int addRevert(Revert revert)
        {
            return RevertSer.addRevert(revert);
        }
        public static string getMaxRevertID()
        {
            return RevertSer.getMaxRevertID();
        }
        public static Revert FindRevertByRevertID(Revert revert)
        {
            return RevertSer.FindRevertByRevertID(revert);
        }
        public static List<Revert> FindRevertByCardID(Revert revert)
        {
            return RevertSer.FindRevertByCardID(revert);
        }
        public static int DeleteRevertByRevertID(Revert revert)
        {
            return RevertSer.DeleteRevertRevertID(revert);
        }
    }
}
