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
    public partial class DeleteManage : System.Web.UI.Page
    {
        Card card = new Card();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvBind();
            }
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            gvBind();
        }
        protected void gvInfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvInfo.PageIndex = e.NewPageIndex;
            gvBind();
        }
        protected void gvInfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            card.CardID = gvInfo.DataKeys[e.RowIndex].Value.ToString();
            CardManager.deleteCard(card);
            gvBind();
        }
        protected void gvInfo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)(e.Row.Cells[5].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
            }
        }
        protected void gvInfo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "detail")
            {
                string cardid = gvInfo.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                Session["CardID"] =cardid ;
                Response.Redirect("CardInfo.aspx?CardID=" + cardid);
            }
        }
        public void gvBind()
        {
            if (txtName.Text == string.Empty)
            {
                gvInfo.DataSource = CardManager.getAllCard();
                gvInfo.DataKeyNames = new string[] { "CardID" };
                gvInfo.DataBind();
                for (int i = 0; i < gvInfo.Rows.Count; i++)
                {
                    gvInfo.Rows[i].Cells[1].Text = SubStr(gvInfo.Rows[i].Cells[1].Text, 8);
                    gvInfo.Rows[i].Cells[2].Text = Convert.ToDateTime(gvInfo.Rows[i].Cells[2].Text).ToLongDateString();
                }
            }
            else
            {
                card.CardName = txtName.Text.Trim();
                gvInfo.DataSource = CardManager.FindCardByCardName(card);
                gvInfo.DataKeyNames = new string[] { "CardID" };
                gvInfo.DataBind();
                for (int i = 0; i < gvInfo.Rows.Count; i++)
                {
                    gvInfo.Rows[i].Cells[1].Text = SubStr(gvInfo.Rows[i].Cells[1].Text, 8);
                    gvInfo.Rows[i].Cells[2].Text = Convert.ToDateTime(gvInfo.Rows[i].Cells[2].Text).ToLongDateString();
                }
            }
        }
        public string SubStr(string sString, int nLeng)
        {
            if (sString.Length <= nLeng)
            {
                return sString;
            }
            string sNewStr = sString.Substring(0, nLeng);
            sNewStr = sNewStr + "...";
            return sNewStr;
        }
    }
}