using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;
namespace MyBBS.UserManage
{
    public partial class UserManage : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<User> listOfUser = UserManager.getAllUser();
                gvUserInfo.DataSource = listOfUser;
                gvUserInfo.DataKeyNames = new string[] { "用户名" };
                gvUserInfo.DataBind();
                for (int i = 0; i < listOfUser.Count; i++)
                {
                    gvUserInfo.Rows[i].Cells[2].Text = UserManager.getAllUser()[i].Birthday.ToLongDateString();
                }
            }
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            gvBind();
        }
        protected void gvUserInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUserInfo.PageIndex = e.NewPageIndex;
            gvBind();
        }
        protected void gvUserInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)(e.Row.Cells[6].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
            }
        }
        protected void gvUserInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            user.UserName = gvUserInfo.DataKeys[e.RowIndex].Value.ToString();
            UserManager.deleteUser(user);
            gvBind();
        }
        protected void gvUserInfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                Session["Name"] = gvUserInfo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Session["Pop"] = "用户";
                Response.Redirect("../Common/ModifyInfo.aspx");
            }
        }
        public void gvBind()
        {
            if (txtName.Text == string.Empty)
            {
                List<User> listOfUser = UserManager.getAllUser();
                gvUserInfo.DataSource = listOfUser;
                gvUserInfo.DataBind();
                for (int i = 0; i < listOfUser.Count; i++)
                {
                    gvUserInfo.Rows[i].Cells[2].Text = listOfUser[i].Birthday.ToLongDateString();
                }
            }
            else
            {
                user.UserName = txtName.Text;
                user = UserManager.findUserByUserName(user);
                gvUserInfo.DataSource = user;
                gvUserInfo.DataBind();
                gvUserInfo.Rows[0].Cells[2].Text = user.Birthday.ToLongDateString();
            }
        }
    }

}