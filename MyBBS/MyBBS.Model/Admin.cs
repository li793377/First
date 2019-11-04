using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
    public class Admin
    {

        #region 定义管理员--数据结构
        private string adminname = "";
        private string adminpwd = "";
        private string adminrole;
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AdminName
        {
            get { return adminname; }
            set { adminname = value; }
        }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPwd
        {
            get { return adminpwd; }
            set { adminpwd = value; }
        }
        public string AdminRole
        {
            get { return adminrole; }
            set { adminrole = value; }
        }
        #endregion
    }
}
