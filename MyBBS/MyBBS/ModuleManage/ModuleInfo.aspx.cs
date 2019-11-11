using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.BLL;
using MyBBS.Model;
namespace MyBBS.ModuleManage
{
    public partial class ModuleInfo : System.Web.UI.Page
    {
        Module module = new Module();
        Host host = new Host();
        protected void Page_Load(object sender, EventArgs e)
        {
            dlBind();
        }
        protected void lnkbtnOne_Click(object sender, EventArgs e)
        {
            labPage.Text = "1";
            dlBind();
        }
        protected void lnkbtnUp_Click(object sender, EventArgs e)
        {
            labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
            dlBind();
        }
        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
            dlBind();
        }
        protected void lnkbtnBack_Click(object sender, EventArgs e)
        {
            labPage.Text = labBackPage.Text;
            dlBind();
        }
        public void dlBind()
        {
            int curpage = Convert.ToInt32(labPage.Text);
            PagedDataSource ps = new PagedDataSource();
            ps.DataSource = ModuleManager.getAllModule();
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 8; //显示的数量
            ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
            lnkbtnUp.Enabled = true;
            lnkbtnNext.Enabled = true;
            lnkbtnBack.Enabled = true;
            lnkbtnOne.Enabled = true;
            if (curpage == 1)
            {
                lnkbtnOne.Enabled = false;//不显示第一页按钮
                lnkbtnUp.Enabled = false;//不显示上一页按钮
            }
            if (curpage == ps.PageCount)
            {
                lnkbtnNext.Enabled = false;//不显示下一页
                lnkbtnBack.Enabled = false;//不显示最后一页
            }
            this.labBackPage.Text = Convert.ToString(ps.PageCount);
            dlInfo.DataSource = ps;
            dlInfo.DataKeyField ="ModuleID";
            dlInfo.DataBind();
        }
        public string getHost(string str)
        {
            host.ModuleID = str;
            if (HostManager.FindHostByModuleID(host)!=null)
            {
                string hostname = HostManager.FindHostByModuleID(host).HostName;
                return hostname;
            }
            else
                return null;
        }
    }
}