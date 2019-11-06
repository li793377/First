using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBBS.UserManage
{
    public partial class RegPro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgree_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
        protected void btnRefuse_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ModuleManage/ModuleInfo.aspx");
        }
    }
}