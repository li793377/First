using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;

namespace MyBBS.AdminManage
{
    public partial class updateAdmin : System.Web.UI.Page
    {
        Admin admin = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                admin = AdminManager.getAdmin();
                txtName.Text = admin.AdminName;
                txtPwd.Text = admin.AdminPwd;
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('管理员姓名不能为空！')</script>");
                return;
            }
            else if (txtPwd.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('管理员密码不能为空！')</script>");
                return;
            }
            else
            {
                admin.AdminName = txtName.Text;
                admin.AdminPwd = txtPwd.Text;
                AdminManager.updateAdmin(admin);
                Response.Write("<script language=javascript>alert('管理员信息修改成功！')</script>");
            }
        }
    }
}
