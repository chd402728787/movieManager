using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace 期末大作业
{
    public partial class Admin_change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbAddMovie_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_movieAdd.aspx");
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Trim() == "")
            {
                Response.Write("<script>alert('关键字不能为空！')</script>");
                return;
            }
            MovieDataSource1.FilterExpression = ddlkey.SelectedValue + " like '%" + txtKey.Text.Trim() + "%'";
            int num = ((DataView)MovieDataSource1.Select(DataSourceSelectArguments.Empty)).Count;
            if (num == 0)
            {
                Response.Write("<script>alert('未找到符合条件的记录！')</script>");
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            GridView1.DataSourceID = "MovieDataSource1";
            GridView1.DataBind();
        }
    }
}