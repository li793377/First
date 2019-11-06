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
    public partial class AddModule : System.Web.UI.Page
    {
        Module module = new Module();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtID.Text = "M" + (Convert.ToInt32(ModuleManager.getMaxModuleID().Substring(1, 4)) + 1);
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('版块名称不能为空！')</script>");
                return;
            }
            else
            {
                module.ModuleName = txtName.Text;
                if (ModuleManager.findModuleByModuleName(module).ModuleName == null)
                {
                    Response.Write("<script language=javascript>alert('该版块名已经存在！')</script>");
                    txtName.Text = string.Empty;
                    txtName.Focus();
                    return;
                }
                else
                {
                    module.ModuleID = txtID.Text;
                    module.ModuleName = txtName.Text;
                    ModuleManager.addModule(module);
                    Response.Redirect("ModuleManage.aspx");
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }
    }
}