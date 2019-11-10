using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;
namespace MyBBS.HostManage
{
    public partial class HostManage : System.Web.UI.Page
    {
        Host host = new Host();
        Module module = new Module();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvHostInfo.DataSource = HostManager.getAllHost();
                gvHostInfo.DataKeyNames = new string[] { "版主" };
                gvHostInfo.DataBind();
                List<Host> listOfHost = HostManager.getAllHost();
                for (int i = 0; i < listOfHost.Count; i++)
                {
                    module.ModuleID = listOfHost[i].ModuleID;
                    gvHostInfo.Rows[i].Cells[1].Text = ModuleManager.findModuleByName(module).ModuleName;
                    gvHostInfo.Rows[i].Cells[3].Text = listOfHost[i].Birthday.ToLongDateString();
                }
            }
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            gvBind();
        }
        protected void gvHostInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvHostInfo.PageIndex = e.NewPageIndex;
            gvBind();
        }
        protected void gvHostInfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                Session["Name"] = gvHostInfo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Session["Pop"] = "版主";
                Response.Redirect("../Common/ModifyInfo.aspx");
            }
        }
        protected void gvHostInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)(e.Row.Cells[7].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
            }
        }
        protected void gvHostInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            host.HostName = gvHostInfo.DataKeys[e.RowIndex].Value.ToString();
            if (HostManager.deleteHost(host) != 0)
                Response.Write("<script language=javascript>alert('删除成功！')</script>");
            else
                Response.Write("<script language=javascript>alert('删除失败！')</script>");
            gvBind();
        }
        public void gvBind()
        {
            if (txtName.Text == string.Empty)
            {
                List<Host> listOfHost = HostManager.getAllHost();
                gvHostInfo.DataSource = listOfHost;
                gvHostInfo.DataBind();
                for (int i = 0; i < listOfHost.Count; i++)
                {
                    module.ModuleID = listOfHost[i].ModuleID.ToString();
                    gvHostInfo.Rows[i].Cells[1].Text = ModuleManager.FindModuleByID(module).ModuleName;
                    gvHostInfo.Rows[i].Cells[3].Text = listOfHost[i].Birthday.ToLongDateString();
                }
            }
            else
            {
                host.HostName = txtName.Text;
                host=HostManager.FindHostByHostName(host);
                gvHostInfo.DataSource = host;
                gvHostInfo.DataBind();
                module.ModuleID = host.ModuleID;
                gvHostInfo.Rows[0].Cells[1].Text = ModuleManager.FindModuleByID(module).ModuleName;
                gvHostInfo.Rows[0].Cells[3].Text = host.Birthday.ToLongDateString();

            }
        }
    }
}