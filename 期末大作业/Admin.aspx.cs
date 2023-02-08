using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 期末大作业
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "admin" && TextBox2.Text == "123456")
            {
                Response.Redirect("Admin_change.aspx?userName="+"admin");
            }
               
            else
                Response.Write("<script>alert('请使用管理员账户！')</script>");
        }
    }
}