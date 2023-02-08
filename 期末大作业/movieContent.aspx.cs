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
    public partial class movieContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);//获取参数
            SqlConnection co = new SqlConnection();
            co.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            co.Open();
            SqlCommand cm = new SqlCommand("select * from movie", co);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataSet ds = new DataSet();
            da.Fill(ds, "movie");

            Image img = new Image();
            img.ID = string.Format("contentImg{0}",id);
            img.ImageUrl = ds.Tables["movie"].Rows[id]["imgUrl"].ToString();
            img.Width = 240;
            img.Height = 360;

            //添加图片到表格内
            Table1.Controls.Clear();
            int rows = 7;
            TableRow imgRow = new TableRow();
            this.Table1.Controls.Add(imgRow);
            TableCell imgCell = new TableCell();
            imgCell.RowSpan = rows+1;
            imgCell.Controls.Add(img);
            imgRow.Controls.Add(imgCell);

            for (int i = 0; i < rows; i++)
            {
                //添加电影的文字内容到表格中
                TableRow newRow = new TableRow();
                this.Table1.Controls.Add(newRow);
                TableCell newCell = new TableCell();

                Label newLbl = new Label();
                newLbl.Text = ds.Tables["movie"].Columns[i].ColumnName + ":" + ds.Tables["movie"].Rows[id][i].ToString();
                newCell.Controls.Add(newLbl);
                newRow.Controls.Add(newCell);
            }
        }
    }
}