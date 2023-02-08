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
    public partial class Admin_movieAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            co.Open();
            SqlCommand cm = new SqlCommand("select * from movie", co);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataSet ds = new DataSet();
            da.Fill(ds, "movie");

            TextBox1.Text = (ds.Tables["movie"].Rows.Count + 1).ToString();

            co.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_change.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            co.Open();

            SqlCommand cmd = new SqlCommand("insert into movie (movieID,movieName,director,type,time,content,point,imgUrl) " +
                "values(@movieID,@movieName,@director,@type,@time,@content,@point,@imgUrl);");
            cmd.Parameters.Add("@movieID", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
            cmd.Parameters.Add("@movieName", SqlDbType.NVarChar,50).Value = TextBox2.Text;
            cmd.Parameters.Add("@director", SqlDbType.NVarChar, 50).Value = TextBox3.Text;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = TextBox4.Text;
            cmd.Parameters.Add("@time", SqlDbType.NVarChar, 50).Value = TextBox5.Text;
            cmd.Parameters.Add("@content", SqlDbType.NText).Value = TextBox6.Text;
            cmd.Parameters.Add("@point", SqlDbType.NVarChar, 50).Value = TextBox7.Text;
            cmd.Parameters.Add("@imgUrl", SqlDbType.NVarChar, 2083).Value = TextBox8.Text;
            cmd.Connection = co;

            cmd.ExecuteNonQuery();
            co.Close();

            Response.Redirect("Admin_change.aspx?userName=admin");
        }
    }
}