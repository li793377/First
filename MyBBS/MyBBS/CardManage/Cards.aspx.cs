using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.BLL;
using MyBBS.Model;

namespace MyBBS.CardManage
{
    public partial class Cards : System.Web.UI.Page
    {
        Card card = new Card();
        Module module = new Module();
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
            card.ModuleID = Page.Request.QueryString["ModuleID"].ToString();
            card.ModuleID = "M1001";
            ps.DataSource = CardManager.FindCardByMouduleID(card);
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 3; //显示的数量
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
            dlInfo.DataKeyField = "CardID";
            dlInfo.DataBind();
        }
        public string getModule()
        {
           // module.ModuleID = Page.Request.QueryString["ModuleID"].ToString();
            module.ModuleID = "M1001";
            module = ModuleManager.FindModuleByID(module);
            if (module!=null)
            {
                return module.ModuleName;
            }
            else
                return null;
        }
        protected void dlInfo_EditCommand(object source, DataListCommandEventArgs e)
        {
            string cardid = dlInfo.DataKeys[e.Item.ItemIndex].ToString();
            Page.Response.Redirect("RevertCard.aspx?CardID=" + cardid + "");
        }
    }
}