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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from systemUser where userID=@userID and password=@password", conn);
                cmd.Parameters.Add("@userID", SqlDbType.Char);
                cmd.Parameters.Add("@password", SqlDbType.Char);
                cmd.Parameters[0].Value = TextBox1.Text;
                cmd.Parameters[1].Value = TextBox2.Text;
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {

                    Session["CurrentUser"] = TextBox1.Text;
                    Response.Redirect("index.aspx?userName="+TextBox1.Text);
                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('登录异常')</script>");
            }

            finally
            {
                conn.Close();
            }

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
