using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBBS.Model
{
   public class Card
    {
        #region 定义帖子--数据结构
        private string cardid = "";
        private string cardname = "";
        private string moduleid = "";
        private string cardcontent = "";
        private DateTime cardtime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        private string cardpeople = "";
        private string pop = "";
        /// <summary>
        /// 帖子编号
        /// </summary>
        public string CardID
        {
            get { return cardid; }
            set { cardid = value; }
        }
        /// <summary>
        /// 帖子名称
        /// </summary>
        public string CardName
        {
            get { return cardname; }
            set { cardname = value; }
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
        /// 帖子内容
        /// </summary>
        public string CardContent
        {
            get { return cardcontent; }
            set { cardcontent = value; }
        }
        /// <summary>
        /// 发表日期
        /// </summary>
        public DateTime CardTime
        {
            get { return cardtime; }
            set { cardtime = value; }
        }
        /// <summary>
        /// 发帖人
        /// </summary>
        public string CardPeople
        {
            get { return cardpeople; }
            set { cardpeople = value; }
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
