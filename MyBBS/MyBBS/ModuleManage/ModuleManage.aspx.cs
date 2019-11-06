using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;
namespace MyBBS.ModuleManage
{
    public partial class ModuleManage : System.Web.UI.Page
    {
        Module module = new Module();
        Host host = new Host();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            gvBind();
        }
        protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvInfo.PageIndex = e.NewPageIndex;
            gvBind();
        }
        protected void gvInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            module.ModuleID = gvInfo.DataKeys[e.RowIndex].Value.ToString();
            if(ModuleManager.deleteModule(module)!=0)
                Response.Write("<script>alert('版块信息删除成功')</script>");
            gvBind();
        }
        protected void gvInfo_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvInfo.EditIndex = e.NewEditIndex;
            gvBind();
        }
        protected void gvInfo_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            module.ModuleID = gvInfo.DataKeys[e.RowIndex].Value.ToString();
            module.ModuleName = ((TextBox)(gvInfo.Rows[e.RowIndex].Cells[1].Controls[0])).Text;
            ModuleManager.updateModule(module);
            gvInfo.EditIndex = -1;
            gvBind();
        }
        protected void gvInfo_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvInfo.EditIndex = -1;
            gvBind();
        }
        public void gvBind()
        {
            if (txtName.Text == string.Empty)
            {
                if (Session["Pop"].ToString().Trim() == "版主")
                {
                    HyperLink1.Visible = false;
                    host.HostName = Session["Name"].ToString();
                    module.ModuleID = HostManager.FindHostByHostName(host).ModuleID;
                    gvInfo.DataSource = ModuleManager.FindModuleByID(module);
                    gvInfo.DataKeyNames = new string[] { "版块编号" };
                    gvInfo.DataBind();
                    return;
                }
                if (Session["Pop"].ToString().Trim() == "管理员")
                {
                    gvInfo.DataSource = ModuleManager.getAllModule();
                    gvInfo.DataKeyNames = new string[] { "版块编号" };
                    gvInfo.DataBind();
                    return;
                }
            }
            else
            {
                if (Session["Pop"].ToString().Trim() == "管理员")
                {
                    module.ModuleName = txtName.Text;
                    gvInfo.DataSource = ModuleManager.findModuleByName(module);
                    gvInfo.DataKeyNames = new string[] { "版块编号" };
                    gvInfo.DataBind();
                    return;
                }
            }
        }
    }
}