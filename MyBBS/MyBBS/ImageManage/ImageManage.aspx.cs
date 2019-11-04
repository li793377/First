using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.BLL;
using MyBBS.Model;
namespace MyBBS.ImageManage
{
    public partial class ImageManage : System.Web.UI.Page
    {
        Model.Image images = new Model.Image();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dlBind();
            }
        }
        protected void UploadImage_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (imageUpload.PostedFile.FileName == "")
                {
                    Response.Write("<script language=javascript>alert('要上传的头像不允许为空！')</script>");
                    return;
                }
                else
                {
                    string filePath = imageUpload.PostedFile.FileName;
                    string filename = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                    string fileEx = filePath.Substring(filePath.LastIndexOf(".") + 1);
                    string serverpath = Server.MapPath(@"..\Images\Photo\") + filename;
                    string relativepath = @"..\Images\Photo\" + filename;
                    if (File.Exists(serverpath))
                    {
                        Response.Write("<script language=javascript>alert('该头像已经存在！')</script>");
                        return;
                    }
                    //判断图片格式
                    if (fileEx == "jpg" || fileEx == "bmp" || fileEx == "gif")
                    {
                        //生成缩略图
                        System.Drawing.Image image, newimage;
                        image = System.Drawing.Image.FromFile(filePath);
                        System.Drawing.Image.GetThumbnailImageAbort callb = null;
                        newimage = image.GetThumbnailImage(45, 50, callb, new System.IntPtr());
                        //把缩略图保存到指定的虚拟路径
                        newimage.Save(serverpath);
                        //释放image对象占用的资源
                        newimage.Dispose();
                        image.Dispose();
                        images.PhotoID = "IMG" + (Convert.ToInt32(ImageManager.getMaxPhotoID().Substring(3, 4)) + 1);
                        images.Photo = relativepath;
                        ImageManager.addPhoto(images);
                        dlBind();
                        Response.Write("<script language=javascript>alert('头像上传成功！')</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('上传的头像扩展名错误！')</script>");
                    }
                }
            }
            catch { }
        }
        protected void dlImage_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            images.PhotoID = dlImage.DataKeys[e.Item.ItemIndex].ToString();
            images = ImageManager.findImageByPhotoID(images);
            string strUrl = images.Photo;
            //删除指定文件的图片
            string strFilePath = Server.MapPath(@"..\Images\Photo\") + strUrl.Substring(strUrl.LastIndexOf("\\") + 1, strUrl.Length - strUrl.LastIndexOf("\\") - 1);
            File.Delete(strFilePath);
            ImageManager.deletePhoto(images);
            dlBind();
            Response.Write("<script language=javascript>alert('头像删除成功！')</script>");
        }
        protected void lnkbtnOne_Click(object sender, EventArgs e)
        {
            labPage.Text = "1";
            dlBind();
        }
        protected void lnkbtnUp_Click(object sender, EventArgs e)
        {
            labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
            dlBind();
        }
        protected void lnkbtnNext_Click(object sender, EventArgs e)
        {
            labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
            dlBind();
        }
        protected void lnkbtnBack_Click(object sender, EventArgs e)
        {
            labPage.Text = labBackPage.Text;
            dlBind();
        }
        public void dlBind()
        {
            int curpage = Convert.ToInt32(labPage.Text);
            PagedDataSource ps = new PagedDataSource();
            ps.DataSource = ImageManager.getAllPhoto().DefaultView;
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 20; //显示的数量
            ps.CurrentPageIndex = curpage - 1; //取得当前页的页码
            lnkbtnUp.Enabled = true;
            lnkbtnNext.Enabled = true;
            lnkbtnBack.Enabled = true;
            lnkbtnOne.Enabled = true;
            if (curpage == 1)
            {
                lnkbtnOne.Enabled = false;//不显示第一页按钮
                lnkbtnUp.Enabled = false;//不显示上一页按钮
            }
            if (curpage == ps.PageCount)
            {
                lnkbtnNext.Enabled = false;//不显示下一页
                lnkbtnBack.Enabled = false;//不显示最后一页
            }
            this.labBackPage.Text = Convert.ToString(ps.PageCount);
            dlImage.DataSource = ps;
            dlImage.DataKeyField = "编号";
            dlImage.DataBind();
        }
    }

}