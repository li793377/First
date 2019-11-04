using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
   public class Image
    {
        #region 定义头像--数据结构
        private string photoid = "";
        private string photo = "";
        /// <summary>
        /// 编号
        /// </summary>
        public string PhotoID
        {
            get { return photoid; }
            set { photoid = value; }
        }
        /// <summary>
        /// 头像
        /// </summary>
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        #endregion
    }
}
