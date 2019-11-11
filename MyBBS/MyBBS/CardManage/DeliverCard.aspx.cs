using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.BLL;
using MyBBS.Model;
using System.Data;

namespace MyBBS.CardManage
{
    public partial class DeliverCard : System.Web.UI.Page
    {
        Card card = new Card();
        Module module = new Module();
        User user = new User();
        Host host = new Host();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMName.DataSource = ModuleManager.getAllModule();
                ddlMName.DataTextField = "ModuleName";
                ddlMName.DataBind();
            }
            string strName = "";
            if (Session["Name"] == null)
            {
                strName = "匿名";
                labName.Text = strName;
                labEmail.Text = "无";
                labQQ.Text = "无";
                labIndex.Text = "无";
                imgPhoto.ImageUrl = "../Images/Visiter.jpg";
            }
            else
            {
                strName = Session["Name"].ToString();
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strName = "";
            string strPop = "";
            if (txtCName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('帖子名称不能为空！')</script>");
                return;
            }
            if (Session["Name"] == null)
            {
                strName = "匿名";
                strPop = "游客";
            }
            else
            {
                strName = Session["Name"].ToString();
                strPop = Session["Pop"].ToString();
            }
            card.CardID = "T" + (Convert.ToInt32(CardManager.getMaxCardID().Substring(1, 4)) + 1);
            card.CardName = txtCName.Text;
            try
            {
                module.ModuleName = ddlMName.SelectedValue;
                card.ModuleID = ModuleManager.findModuleByName(module).ModuleID;
            }
            catch
            {
                Response.Write("<script language=javascript>alert('请先填写版块信息！')</script>");
                return;
            }
            card.CardContent = FreeTextBox1.Text;
            card.CardTime = DateTime.Now;
            card.CardPeople = strName;
            card.Pop = strPop;
            CardManager.addCard(card);
            Response.Write("<script language=javascript>alert('帖子发表成功！')</script>");
            txtCName.Text = FreeTextBox1.Text = string.Empty;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtCName.Text = FreeTextBox1.Text = string.Empty;
        }
    }

}