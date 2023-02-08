using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 期末大作业
{
    public partial class zhujiemian : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = Request["userName"];
        }

        protected void btnIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}