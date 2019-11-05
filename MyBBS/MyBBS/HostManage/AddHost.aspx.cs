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
    public partial class AddHost : System.Web.UI.Page
    {

        Host host = new Host();
        Module module = new Module();
        Model.Image images = new Model.Image();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlModule.DataSource = ModuleManager.getAllModule();
                ddlModule.DataTextField = "版块名称";
                ddlModule.DataBind();
                ddlPhoto.DataSource = ImageManager.getAllPhoto();
                ddlPhoto.DataTextField = "编号";
                ddlPhoto.DataBind();
                images.PhotoID = ddlPhoto.SelectedValue;
                imgPhoto.ImageUrl = ImageManager.findImageByPhotoID(images).Photo;
            }
        }
        protected void btnTest_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('版主名不能为空！')</script>");
            }
            else
            {
                host.HostName = txtName.Text;
                host = HostManager.FindHostByHostName(host);
                if (host.HostName!=null)
                {
                    Response.Write("<script language=javascript>alert('该版主已经存在！')</script>");
                    txtName.Text = string.Empty;
                    txtName.Focus();
                }
                else
                    Response.Write("<script language=javascript>alert('您可以添加该版主！')</script>");
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
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                Response.Write("<script language=javascript>alert('版主名不能为空！')</script>");
            }
            else
            {
                host.HostName = txtName.Text;
                host = HostManager.FindHostByHostName(host);
                if (host.HostName!=null)
                {
                    Response.Write("<script language=javascript>alert('该版主已经存在！')</script>");
                    txtName.Text = string.Empty;
                    txtName.Focus();
                }
                else
                {
                    try
                    {
                        module.ModuleName = ddlModule.SelectedValue;
                        host.ModuleID = ModuleManager.findModuleByModuleName(module).ModuleID;
                    }
                    catch
                    {
                        Response.Write("<script language=javascript>alert('请先填写版块信息！')</script>");
                        return;
                    }
                    host.HostPwd = txtPwd.Text;
                    host.TName = txtTName.Text;
                    if (ddlSex.SelectedIndex == 0)
                        host.Sex = true;
                    if (ddlSex.SelectedIndex == 1)
                        host.Sex = false;
                    host.Birthday = DateTime.Parse(txtBirthday.Text);
                    host.Tel = txtTel.Text;
                    host.Mobile = txtMobile.Text;
                    try
                    {
                        host.QQ = Int32.Parse(txtQQ.Text);
                    }
                    catch
                    {
                        txtQQ.Text = string.Empty;
                        Response.Write("<script language=javascript>alert('QQ号码输入错误！')</script>");
                        return;
                    }
                    images.PhotoID = ddlPhoto.SelectedValue;
                    host.Photo = ImageManager.findImageByPhotoID(images).Photo;
                    host.Email = txtEmail.Text;
                    host.FAddress = txtHAddress.Text;
                    host.RAddress = txtRAddress.Text;
                    host.Index = txtIndex.Text;
                    HostManager.addHost(host);
                    Response.Write("<script language=javascript>alert('版主添加成功！')</script>");
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
    }


}