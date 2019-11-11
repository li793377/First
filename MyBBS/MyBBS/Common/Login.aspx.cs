using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;
namespace MyBBS.Common
{
    public partial class Login : System.Web.UI.Page
    {
        User user = new User();
        Host host = new Host();
        Admin admin = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == "0")
            {
                Label1.Text = "〖用户登录〗";
            }
            if (Request.QueryString["id"] == "1")
            {
                Label1.Text = "〖版主登录〗";
            }
            if (Request.QueryString["id"] == "2")
            {
                Label1.Text = "〖管理员登录〗";
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('登录名不能为空！')</script>");
                return;
            }
            else
            {
                if (Request.QueryString["id"] == "0")
                {
                    Session["ID"] = "0";
                    user.UserName = txtName.Text;
                    user.UserPwd = txtPwd.Text;
                    user = UserManager.Login(user);
                    if (user.TName != null && txtCode.Text == Request.Cookies["CheckCode"].Value)
                    {
                        Session["Name"] = txtName.Text;
                        Session["Pop"] = "用户";
                        Response.Write("<script language=javascript>opener.location.reload();window.close();</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('用户名称或密码不正确！')</script>");
                    }
                }
                if (Request.QueryString["id"] == "1")
                {
                    Session["ID"] = "1";
                    host.HostName = txtName.Text;
                    host.HostPwd = txtPwd.Text;
                    host = HostManager.Login(host);
                    if (host.TName != null && txtCode.Text == Request.Cookies["CheckCode"].Value)
                    {
                        Session["Name"] = txtName.Text;
                        Session["Pop"] = "版主";
                        Response.Write("<script language=javascript>opener.location.reload();window.close();</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('版主名称或密码不正确！')</script>");
                    }
                }
                if (Request.QueryString["id"] == "2")
                {
                    Session["ID"] = "2";
                    admin.AdminName = txtName.Text;
                    admin.AdminPwd = txtPwd.Text;
                    admin = AdminManager.Login(admin);
                    if (admin.AdminRole != null && txtCode.Text == Request.Cookies["CheckCode"].Value)
                    {
                        Session["Name"] = txtName.Text;
                        Session["Pop"] = "管理员";
                        Response.Write("<script language=javascript>opener.location.reload();window.close();</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('管理员名称或密码不正确！')</script>");
                    }
                }
            }
        }
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>window.close();</script>");
        }
    }

}