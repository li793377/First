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
    public partial class RevertCard : System.Web.UI.Page
    {
        Card card = new Card();
        Revert revert = new Revert();
        User user = new User();
        Host host = new Host();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Name"] == null)
                {
                    Response.Redirect("../Common/LimitPop.aspx");
                }
                else
                {
                    card.CardID = Page.Request.QueryString["CardID"].ToString();
                    labCName.Text = CardManager.FindCardByCardID(card).CardName;
                    string strName = Session["Name"].ToString();
                    if (Session["Pop"].ToString() == "用户")
                    {
                        user.UserName = strName;
                        user = UserManager.findUserByUserName(user);
                        labName.Text = strName;
                        labEmail.Text = user.Email;
                        labQQ.Text = user.QQ.ToString();
                        labIndex.Text = user.Index;
                        imgPhoto.ImageUrl = user.Photo;
                        return;
                    }
                    if (Session["Pop"].ToString() == "版主")
                    {
                        host.HostName = strName;
                        host = HostManager.FindHostByHostName(host);
                        labName.Text = strName;
                        labEmail.Text = host.Email;
                        labQQ.Text = host.QQ.ToString();
                        labIndex.Text = host.Index;
                        imgPhoto.ImageUrl = host.Photo;
                        return;
                    }
                    if (Session["Pop"].ToString() == "管理员")
                    {
                        labName.Text = strName;
                        labEmail.Text = "无";
                        labQQ.Text = "无";
                        labIndex.Text = "无";
                        imgPhoto.ImageUrl = "../Images/Admin.jpg";
                        return;
                    }
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('回帖主题不能为空！')</script>");
                return;
            }
            revert.RevertID = "HT" + (Convert.ToInt32(RevertManager.getMaxRevertID().Substring(2, 4)) + 1);
            revert.RevertName = txtName.Text;
            revert.CardID = Page.Request.QueryString["CardID"].ToString();
            revert.RevertContent = FreeTextBox1.Text;
            revert.RevertTime = DateTime.Now;
            revert.RevertPeople = Session["Name"].ToString();
            revert.Pop = Session["Pop"].ToString();
            RevertManager.addRevert(revert);
            Response.Redirect("CardInfo.aspx?CardID=" + Page.Request.QueryString["CardID"].ToString() + "");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = FreeTextBox1.Text = string.Empty;
        }
    }

}