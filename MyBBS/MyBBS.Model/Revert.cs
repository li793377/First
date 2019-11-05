using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
   public class Revert
    {
        #region 定义回帖--数据结构
        private string revertid = "";
        private string revertname = "";
        private string cardid = "";
        private string revertcontent = "";
        private DateTime reverttime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        private string revertpeople = "";
        private string pop = "";
        /// <summary>
        /// 回帖编号
        /// </summary>
        public string RevertID
        {
            get { return revertid; }
            set { revertid = value; }
        }
        /// <summary>
        /// 回帖主题
        /// </summary>
        public string RevertName
        {
            get { return revertname; }
            set { revertname = value; }
        }
        /// <summary>
        /// 帖子编号
        /// </summary>
        public string CardID
        {
            get { return cardid; }
            set { cardid = value; }
        }
        /// <summary>
        /// 回帖内容
        /// </summary>
        public string RevertContent
        {
            get { return revertcontent; }
            set { revertcontent = value; }
        }
        /// <summary>
        /// 回帖时间
        /// </summary>
        public DateTime RevertTime
        {
            get { return reverttime; }
            set { reverttime = value; }
        }
        /// <summary>
        /// 回帖人
        /// </summary>
        public string RevertPeople
        {
            get { return revertpeople; }
            set { revertpeople = value; }
        }
        /// <summary>
        /// 角色
        /// </summary>
        public string Pop
        {
            get { return pop; }
            set { pop = value; }
        }
        #endregion
    }
}
