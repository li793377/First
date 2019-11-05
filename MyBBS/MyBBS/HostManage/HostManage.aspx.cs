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
                    gvHostInfo.Rows[i].Cells[1].Text = ModuleManager.findModuleByModuleName(module).ModuleName;
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
            hostmanage.HostName = gvHostInfo.DataKeys[e.RowIndex].Value.ToString();
            hostmanage.DeleteHost(hostmanage);
            gvBind();
        }
        public void gvBind()
        {
            if (txtName.Text == string.Empty)
            {
                gvHostInfo.DataSource = hostmanage.GetAllHost("tb_Host").Tables[0];
                gvHostInfo.DataBind();
                for (int i = 0; i < hostmanage.GetAllHost("tb_Host").Tables[0].Rows.Count; i++)
                {
                    modulemanage.ModuleID = hostmanage.GetAllHost("tb_Host").Tables[0].Rows[i][1].ToString();
                    gvHostInfo.Rows[i].Cells[1].Text = modulemanage.FindModuleByName(modulemanage, "tb_Module").Tables[0].Rows[i][1].ToString();
                    gvHostInfo.Rows[i].Cells[3].Text = Convert.ToDateTime(hostmanage.GetAllHost("tb_Host").Tables[0].Rows[i][5].ToString()).ToLongDateString();
                }
            }
            else
            {
                hostmanage.HostName = txtName.Text;
                gvHostInfo.DataSource = hostmanage.FindHostByName(hostmanage, "tb_Host").Tables[0];
                gvHostInfo.DataBind();
                for (int i = 0; i < hostmanage.FindHostByName(hostmanage, "tb_Host").Tables[0].Rows.Count; i++)
                {
                    modulemanage.ModuleID = hostmanage.FindHostByName(hostmanage, "tb_Host").Tables[0].Rows[i][1].ToString();
                    gvHostInfo.Rows[i].Cells[1].Text = modulemanage.FindModuleByName(modulemanage, "tb_Module").Tables[0].Rows[i][1].ToString();
                    gvHostInfo.Rows[i].Cells[3].Text = Convert.ToDateTime(hostmanage.FindHostByName(hostmanage, "tb_Host").Tables[0].Rows[i][5].ToString()).ToLongDateString();
                }
            }
        }
    }
}