using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
  public  class Module
    {
        #region 定义版块--数据结构
        private string moduleid = "";
        private string modulename = "";
        /// <summary>
        /// 版块编号
        /// </summary>
        public string ModuleID
        {
            get { return moduleid; }
            set { moduleid = value; }
        }
        /// <summary>
        /// 版块名称
        /// </summary>
        public string ModuleName
        {
            get { return modulename; }
            set { modulename = value; }
        }
        #endregion
    }
}
