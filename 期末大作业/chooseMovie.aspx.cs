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
    public partial class chooseMovie : System.Web.UI.Page
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
            int count = ds.Tables[0].Rows.Count;
            Table1.Controls.Clear();
            for (int i = 0; i < count; i++)
            {
                //添加影片图片并添加单击事件
                ImageButton img = new ImageButton();
                img.ID = string.Format("newImg{0}", i);
                img.ImageUrl = ds.Tables["movie"].Rows[i]["imgUrl"].ToString();
                img.Width = 240;
                img.Height = 360;
                img.CommandArgument = i.ToString();
                img.Command += new CommandEventHandler(this.OnButton);
                TableRow newtr1 = new TableRow();
                TableCell newcl1 = new TableCell();
                newcl1.Controls.Add(img);
                newtr1.Controls.Add(newcl1);
                this.Table1.Controls.Add(newtr1);

                //添加影片名并添加单击事件
                LinkButton lb = new LinkButton();
                lb.ID = string.Format("newLbl{0}", i);
                lb.Text = "影片名：" + ds.Tables["movie"].Rows[i]["movieName"].ToString();
                lb.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
                lb.CommandArgument = i.ToString();
                lb.Command += new CommandEventHandler(this.OnButton);
                TableCell newcl2 = new TableCell();
                newcl2.Controls.Add(lb);
                newtr1.Controls.Add(newcl2);
            }

            co.Close();
        }
        public void OnButton(Object Sender, CommandEventArgs e)
        {
            Response.Redirect("movieContent.aspx?id=" + e.CommandArgument);
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection();
            co.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            co.Open();
            SqlCommand cm = new SqlCommand("select * from movie", co);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataSet ds = new DataSet();
            da.Fill(ds, "movie");

            if (txtKey.Text.Trim() == "")
            {
                Response.Write("<script>alert('关键字不能为空！')</script>");
                return;
            }
            string strExpr = ddlkey.SelectedValue + " like '%" + txtKey.Text.Trim() + "%'";
            DataTable dt = ds.Tables["movie"];
            DataRow[] drs = dt.Select(strExpr);

            int length = drs.Length;
            Table1.Controls.Clear();
            for (int i = 0; i < length; i++)
            {
                //添加影片图片并添加单击事件
                ImageButton img = new ImageButton();
                img.ID = string.Format("findImg{0}", i);
                img.ImageUrl = drs[i]["imgUrl"].ToString();
                img.Width = 240;
                img.Height = 360;
                img.CommandArgument = i.ToString();
                img.Command += new CommandEventHandler(this.OnButton);
                TableRow newtr1 = new TableRow();
                TableCell newcl1 = new TableCell();
                newcl1.Controls.Add(img);
                newtr1.Controls.Add(newcl1);
                this.Table1.Controls.Add(newtr1);

                //添加影片名并添加单击事件
                LinkButton lb = new LinkButton();
                lb.ID = string.Format("findLbl{0}", i);
                lb.Text = "影片名：" + drs[i]["movieName"].ToString();
                lb.ForeColor = System.Drawing.Color.FromArgb(51, 153, 255);
                lb.CommandArgument = i.ToString();
                lb.Command += new CommandEventHandler(this.OnButton);
                TableCell newcl2 = new TableCell();
                newcl2.Controls.Add(lb);
                newtr1.Controls.Add(newcl2);
            }

            if (length == 0)
            {
                Response.Write("<script>alert('未找到符合条件的记录！')</script>");
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {

        }
    }
}