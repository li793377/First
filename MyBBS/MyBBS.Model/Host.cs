using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
   public class Host
    {
        #region 定义版主--数据结构
        private string hostname = "";
        private string moduleid = "";
        private string hostpwd = "";
        private string tname = "";
        private bool sex = false;
        private DateTime birthday = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        private string tel = "";
        private string mobile = "";
        private Int64 qq = 0;
        private string photo = "";
        private string email = "";
        private string faddress = "";
        private string raddress = "";
        private string index = "";
        private string hostpop = "版主";
        /// <summary>
        /// 版主名
        /// </summary>
        public string HostName
        {
            get { return hostname; }
            set { hostname = value; }
        }
        /// <summary>
        /// 版块编号
        /// </summary>
        public string ModuleID
        {
            get { return moduleid; }
            set { moduleid = value; }
        }
        /// <summary>
        /// 版主密码
        /// </summary>
        public string HostPwd
        {
            get { return hostpwd; }
            set { hostpwd = value; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TName
        {
            get { return tname; }
            set { tname = value; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        /// <summary>
        /// QQ号
        /// </summary>
        public Int64 QQ
        {
            get { return qq; }
            set { qq = value; }
        }
        /// <summary>
        /// 头像
        /// </summary>
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        /// <summary>
        /// Email
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string FAddress
        {
            get { return faddress; }
            set { faddress = value; }
        }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string RAddress
        {
            get { return raddress; }
            set { raddress = value; }
        }
        /// <summary>
        /// 个人首页
        /// </summary>
        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        /// <summary>
        /// 版主权限
        /// </summary>
        public string HostPop
        {
            get { return hostpop; }
            set { hostpop = value; }
        }
        #endregion
    }
}
