using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.BLL;
using MyBBS.Model;
namespace MyBBS.UserManage
{
    public partial class Register : System.Web.UI.Page
    {
        User user = new User();
        Model.Image images = new Model.Image();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                ddlPhoto.DataSource = ImageManager.getAllPhoto();
                ddlPhoto.DataTextField = "PhotoID";
                ddlPhoto.DataBind();
                images.PhotoID = ddlPhoto.SelectedValue;
                images = ImageManager.findImageByPhotoID(images);
                imgPhoto.ImageUrl = images.Photo;
            }
        }
        protected void btnTest_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('用户名不能为空！')</script>");
            }
            else
            {
                user.UserName = txtName.Text;
                user = UserManager.findUserByUserName(user);
                if (user.UserPwd != null)
                {
                    Response.Write("<script language=javascript>alert('该用户已经存在！')</script>");
                    txtName.Text = string.Empty;
                    txtName.Focus();
                }
                else
                    Response.Write("<script language=javascript>alert('您可以使用该用户名进行注册！')</script>");
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
        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('用户名不能为空！')</script>");
            }
            else
            {
                user.UserName = txtName.Text;
                user = UserManager.findUserByUserName(user);
                if (user.UserName != null)
                {
                    Response.Write("<script language=javascript>alert('该用户已经存在！')</script>");
                    txtName.Text = string.Empty;
                    txtName.Focus();
                }
                else
                {
                    user.UserPwd = txtPwd.Text;
                    user.TName = txtTName.Text;
                    if (ddlSex.SelectedIndex == 0)
                        user.Sex = true;
                    if (ddlSex.SelectedIndex == 1)
                        user.Sex = false;
                    user.Birthday = DateTime.Parse(txtBirthday.Text);
                    user.Tel = txtTel.Text;
                    user.Mobile = txtMobile.Text;
                    try
                    {
                        user.QQ = Int32.Parse(txtQQ.Text);
                    }
                    catch
                    {
                        txtQQ.Text = string.Empty;
                        Response.Write("<script language=javascript>alert('QQ号码输入错误！')</script>");
                        return;
                    }
                    images.PhotoID = ddlPhoto.SelectedValue;
                    user.Photo = ImageManager.findImageByPhotoID(images).Photo;
                    user.Email = txtEmail.Text;
                    user.FAddress = txtHAddress.Text;
                    user.RAddress = txtRAddress.Text;
                    user.Index = txtIndex.Text;
                    if (UserManager.addUser(user) != 0)
                        Response.Write("<script language=javascript>alert('用户注册成功！')</script>");
                    txtName.Text = txtPwd.Text = txtSPwd.Text = txtTName.Text = txtBirthday.Text = txtTel.Text
                        = txtMobile.Text = txtQQ.Text = txtEmail.Text = txtHAddress.Text = txtRAddress.Text = txtIndex.Text = string.Empty;
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPwd.Text = txtSPwd.Text = txtTName.Text = txtBirthday.Text = txtTel.Text
                = txtMobile.Text = txtQQ.Text = txtEmail.Text = txtHAddress.Text = txtRAddress.Text = txtIndex.Text = string.Empty;
        }
        protected void ddlPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            images.PhotoID = ddlPhoto.SelectedValue;
            imgPhoto.ImageUrl = ImageManager.findImageByPhotoID(images).Photo;
        }
    }

}