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
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request["choose"];//接受排序方法字段

            SqlConnection co = new SqlConnection();
            co.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            co.Open();
            SqlCommand cm = new SqlCommand("select * from movie", co);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataSet ds = new DataSet();
            da.Fill(ds, "movie");

            DataTable dt = ds.Tables["movie"];
            DataView dv = new DataView();
            dv.Table = dt;
            switch (s)
            {
                case "point": dv.Sort = "point DESC"; break;
                case "first": dv.Sort = "movieName";break;
                case "id": dv.Sort = "movieID"; break;
            }
            
            DataTable dtnew = dv.ToTable();

            int count = dtnew.Rows.Count;
            Table1.Controls.Clear();
            for (int i = 0; i < count; i++)
            {
                //添加影片图片并添加单击事件
                ImageButton img = new ImageButton();
                img.ID = string.Format("newImg{0}", i);
                img.ImageUrl = dtnew.Rows[i]["imgUrl"].ToString();
                img.Width = 240;
                img.Height = 360;
                img.CommandArgument = dtnew.Rows[i]["movieID"].ToString(); 
                img.Command += new CommandEventHandler(this.OnButton);
                TableRow newtr1 = new TableRow();
                TableCell newcl1 = new TableCell();
                newcl1.Controls.Add(img);
                newtr1.Controls.Add(newcl1);
                this.Table1.Controls.Add(newtr1);

                //添加影片名并添加单击事件
                LinkButton lb = new LinkButton();
                lb.ID = string.Format("newLbl{0}", i);
                lb.Text = "影片名：" + dtnew.Rows[i]["movieName"].ToString();
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
            Response.Redirect("movieContent.aspx?id=" + (Convert.ToInt32(e.CommandArgument)-1));
        }

        protected void lbPoint_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx?choose="+"point");
        }

        protected void lbFirst_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx?choose=" + "first");
        }

        protected void lbID_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx?choose=" + "id");
        }
    }
}