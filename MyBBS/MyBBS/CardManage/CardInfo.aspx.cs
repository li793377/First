using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBBS.Model;
using MyBBS.BLL;
namespace MyBBS.CardManage
{
    public partial class CardInfo : System.Web.UI.Page
    {
            Card card = new Card();
            Revert revert = new Revert();
            User user = new User();
            Host host = new Host();
            protected void Page_Load(object sender, EventArgs e)
            {
                try
                {
                    dataBind();
                }
                catch(Exception exp)
                {
                    Response.Write(exp);
                }
            }
            protected void lnkbtnOne_Click(object sender, EventArgs e)
            {
                labPage.Text = "1";
                pageCount();
            }
            protected void lnkbtnUp_Click(object sender, EventArgs e)
            {
                labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) - 1);
                pageCount();
            }
            protected void lnkbtnNext_Click(object sender, EventArgs e)
            {
                labPage.Text = Convert.ToString(Convert.ToInt32(labPage.Text) + 1);
                pageCount();
            }
            protected void lnkbtnBack_Click(object sender, EventArgs e)
            {
                labPage.Text = labBackPage.Text;
                pageCount();
            }
            protected void LinkButton1_Click(object sender, EventArgs e)
            {
                string cardid = "";
                if (Page.Request.QueryString["CardID"] != null)
                {
                    cardid = Page.Request.QueryString["CardID"].ToString();
                    Page.Response.Redirect("RevertCard.aspx?CardID=" + cardid + "");
                    return;
                }
                if (Session["CardID"].ToString() != null)
                {
                    cardid = Session["CardID"].ToString();
                    Page.Response.Redirect("RevertCard.aspx?CardID=" + cardid + "");
                    return;
                }
            }
            protected void dlInfo_DeleteCommand(object source, DataListCommandEventArgs e)
            {
                Session["Pop"] = "管理员";
            if (Session["Pop"].ToString().Trim() == "管理员" || Session["Pop"].ToString().Trim() == "版主")
            {
                string revertid = dlInfo.DataKeys[e.Item.ItemIndex].ToString(); //获取当前DataList控件列
                revert.RevertID = revertid;
                int result = RevertManager.DeleteRevertByRevertID(revert);
                if (result>0)
                    Response.Write("<script>alert('回帖信息--删除成功')</script>");
                else
                    Response.Write("<script>alert('回帖信息--删除失败')</script>");
                dataBind();
            }
            else
                Response.Redirect("../Common/LimitPop.aspx");
        }
            public void dlBind(string str)
            {
                int curpage = Convert.ToInt32(labPage.Text);
                PagedDataSource ps = new PagedDataSource();
                revert.CardID = str;
                ps.DataSource = RevertManager.FindRevertByCardID(revert);
                ps.AllowPaging = true; //是否可以分页
                ps.PageSize = 2; //显示的数量
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
                dlInfo.DataSource = ps;
                dlInfo.DataKeyField = "RevertID";
                dlInfo.DataBind();
            }
            public void dataBind()
            {
              string cardid = Page.Request.QueryString["CardID"];

               if (cardid != null)
                {  
                   cardBind(cardid);
                   dlBind(cardid);
                return;
                }
                if (Session["CardID"] != null)
                {
                    cardBind(Session["CardID"].ToString());
                    dlBind(Session["CardID"].ToString());
                    return;
                }
            }
            public void cardBind(string str)
            {
                try
                {
                    card.CardID = str;
                    card = CardManager.FindCardByCardID(card);
                    Label1.Text = card.CardTime.ToString();
                    Label2.Text = card.CardPeople;
                    Label4.Text = card.CardName;
                    Label8.Text = card.CardContent;
                    string strPop = card.Pop.Trim();
                    string strPhoto = "";
                    if (strPop == "游客")
                    {
                        strPhoto = "../Images/Visiter.jpg";
                    }
                    if (strPop == "用户")
                    {
                        user.UserName = card.CardPeople;
                        user= UserManager.findUserByUserName(user);
                        strPhoto = user.Photo;
                        Label2.Text = user.TName;
                }
                    if (strPop == "版主")
                    {
                        host.ModuleID = card.ModuleID;
                        host = HostManager.FindHostByModuleID(host);
                        strPhoto = host.Photo;
                        Label2.Text = host.TName;
                    }
                    if (strPop == "管理员")
                    {
                        strPhoto = "../Images/Admin.jpg";
                    }
                     
                    Image2.ImageUrl = strPhoto;
                }
                catch (Exception exp)
            {
                Response.Write(exp);
                

            }
            }
            public void pageCount()
            {
                if (Page.Request.QueryString["CardID"] != null)
                {
                    dlBind(Page.Request.QueryString["CardID"].ToString());
                    return;
                }
                if (Session["CardID"] != null)
                {
                    dlBind(Session["CardID"].ToString());
                    return;
                }
            }
            public string getPhoto(string str)
            {
                string strPhoto = "";
                revert.RevertID = str;
            revert = RevertManager.FindRevertByRevertID(revert);
            string strPop = revert.Pop.Trim();

                if (strPop == "用户")
                {
                user.UserName = revert.RevertPeople;
                user = UserManager.findUserByUserName(user);
                strPhoto = user.Photo;
                }
                if (strPop == "版主")
                {
                host.HostName = revert.RevertPeople;
                    host = HostManager.FindHostByHostName(host);
                    strPhoto = host.Photo;
                }
                if (strPop == "管理员")
                {
                    strPhoto = "../Images/Admin.jpg";
                }
                return strPhoto;
            }
        }
    }