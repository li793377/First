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
    public partial class ModifyInfo : System.Web.UI.Page
    {
        User user = new User();
        Host host = new Host();
        Model.Image images = new Model.Image();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlPhoto.DataSource = ImageManager.getAllPhoto();
                ddlPhoto.DataTextField = "编号";
                ddlPhoto.DataBind();
                if (Session["Pop"].ToString() == "用户")
                {
                    user.UserName = Session["Name"].ToString();
                    user = UserManager.findUserByUserName(user);
                    txtName.Text = user.UserName;
                    txtPwd.Text = user.UserPwd;
                    txtTName.Text = user.TName;
                    if (user.Sex.ToString() == "True")
                        ddlSex.SelectedIndex = 0;
                    if (user.Sex.ToString() == "False")
                        ddlSex.SelectedIndex = 1;
                    txtBirthday.Text = user.Birthday.ToShortDateString();
                    txtTel.Text = user.Tel;
                    txtMobile.Text = user.Mobile;
                    txtQQ.Text = user.QQ.ToString();
                    imgPhoto.ImageUrl = user.Photo;
                    txtEmail.Text = user.Email;
                    txtHAddress.Text = user.FAddress;
                    txtRAddress.Text = user.RAddress;
                    txtIndex.Text = user.Index;
                    return;
                }
                if (Session["Pop"].ToString() == "版主")
                {
                    host.HostName = Session["Name"].ToString();
                    host = HostManager.FindHostByHostName(host);
                    txtName.Text = host.HostName;
                    txtPwd.Text = host.HostPwd;
                    txtTName.Text = host.TName;
                    if (host.Sex.ToString() == "True")
                        ddlSex.SelectedIndex = 0;
                    if (host.Sex.ToString() == "False")
                        ddlSex.SelectedIndex = 1;
                    txtBirthday.Text = host.Birthday.ToShortDateString();
                    txtTel.Text = host.Tel;
                    txtMobile.Text = host.Mobile;
                    txtQQ.Text = host.QQ.ToString();
                    imgPhoto.ImageUrl = host.Photo;
                    txtEmail.Text = host.Email;
                    txtHAddress.Text = host.FAddress;
                    txtRAddress.Text = host.RAddress;
                    txtIndex.Text = host.Index;
                    return;
                }
            }
        }
        protected void btnSelDate_Click(object sender, EventArgs e)
        {
            calDate.Visible = true;
        }
        protected void calDate_SelectionChanged(object sender, EventArgs e)
        {
            txtBirthday.Text = calDate.SelectedDate.ToShortDateString();
            calDate.Visible = false;
        }
        protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            images.PhotoID = ddlPhoto.SelectedValue;
            imgPhoto.ImageUrl = ImageManager.findImageByPhotoID(images).Photo;
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (Session["Pop"].ToString() == "用户")
            {
                user.UserName = txtName.Text;
                user.UserPwd = txtPwd.Text;
                user.TName = txtTName.Text;
                if (ddlSex.SelectedIndex == 0)
                    user.Sex = true;
                if (ddlSex.SelectedIndex == 1)
                    user.Sex = false;
                user.Birthday = DateTime.Parse(txtBirthday.Text);
                user.Tel = txtTel.Text;
                user.Mobile = txtMobile.Text;
                user.QQ = Int32.Parse(txtQQ.Text);
                images.PhotoID = ddlPhoto.SelectedValue;
                user.Photo = ImageManager.findImageByPhotoID(images).Photo;
                user.Email = txtEmail.Text;
                user.FAddress = txtHAddress.Text;
                user.RAddress = txtRAddress.Text;
                user.Index = txtIndex.Text;
                if (UserManager.UpdateUser(user) != 0)
                    Response.Write("<script language=javascript>alert('用户信息修改成功！')</script>");
                return;
            }
            if (Session["Pop"].ToString() == "版主")
            {
                host.HostName = txtName.Text;
                host.HostPwd = txtPwd.Text;
                host.TName = txtTName.Text;
                if (ddlSex.SelectedIndex == 0)
                    host.Sex = true;
                if (ddlSex.SelectedIndex == 1)
                    host.Sex = false;
                host.Birthday = DateTime.Parse(txtBirthday.Text);
                host.Tel = txtTel.Text;
                host.Mobile = txtMobile.Text;
                host.QQ = Int32.Parse(txtQQ.Text);
                images.PhotoID = ddlPhoto.SelectedValue;
                host.Photo = ImageManager.findImageByPhotoID(images).Photo;
                host.Email = txtEmail.Text;
                host.FAddress = txtHAddress.Text;
                host.RAddress = txtRAddress.Text;
                host.Index = txtIndex.Text;
                if (HostManager.UpdateHost(host) != 0)
                    Response.Write("<script language=javascript>alert('版主信息修改成功！')</script>");
                return;
            }
        }
    }

}