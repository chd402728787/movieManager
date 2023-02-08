using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace 期末大作业
{
    public partial class register : System.Web.UI.Page
    {
        private bool UserNameIselgal = false;
        private bool PsdIselgal = false;
        private bool CanRegister = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }


        protected void linkToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (rUserNameText.Text == "用户名") return;
            Session["User"] = rUserNameText.Text;
            Session["Psd"] = rPsdText.Text;

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\System.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from systemUser where userID=@userID", conn);
            cmd.Parameters.Add("userID", SqlDbType.VarChar, 50).Value= Session["User"].ToString();
            int count = (int)cmd.ExecuteScalar();
            if (count>0)
            {
                Response.Write("<script>alert('用户名已存在!')</script>");
            }
            else
            {
                CanRegister = true;
            }
            CanRegister = CanRegister && UserNameIselgal && PsdIselgal;
            if (CanRegister)
            {
                string strIns = "insert into systemUser(userID, password) values(@userID, @password)";
                SqlCommand cm = new SqlCommand(strIns, conn);
                cm.Parameters.Add("@userID", SqlDbType.VarChar, 50);
                cm.Parameters.Add("@password", SqlDbType.VarChar, 50);

                cm.Parameters["@userID"].Value = Session["User"].ToString();
                cm.Parameters["@password"].Value =Session["Psd"].ToString();

                cm.ExecuteNonQuery();

                Session["CurrentUser"] = rUserNameText.Text;
                Response.Redirect("login.aspx");
            }

            conn.Close();
        }

        protected void CustomValidator1_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rUserNameText.Text.Equals("用户名"))
            {
                CustomValidator1.ErrorMessage = "*用户名为空";
                args.IsValid = false;
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(rUserNameText.Text, "^[0-9a-zA-Z]+$") &&
                  rUserNameText.Text.Length > 5 && rUserNameText.Text.Length < 11)
            {
                args.IsValid = true;
                UserNameIselgal = true;
            }
            else
            {
                CustomValidator1.ErrorMessage = "*用户名由6~10位数字和字母构成";
                args.IsValid = false;
            }


        }

        protected void CustomValidator2_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rPsdText.Text.Equals("密码"))
            {
                CustomValidator2.ErrorMessage = "*密码为空";
                args.IsValid = false;
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(rPsdText.Text, "^[0-9a-zA-Z]+$") &&
              rPsdText.Text.Length > 4)
            {
                args.IsValid = true;
            }
            else
            {
                CustomValidator2.ErrorMessage = "*密码由全数字和字母构成且不少于5位";
                args.IsValid = false;
            }
        }

        protected void CustomValidator3_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rrPsdText.Text.Equals("") || rrPsdText.Text.Equals("确认密码"))
            {
                args.IsValid = false;
                CustomValidator3.ErrorMessage = "*确认密码为空";
            }
            else if (!rrPsdText.Text.Equals(rPsdText.Text))
            {
                args.IsValid = false;
                CustomValidator3.ErrorMessage = "*两次密码不一致";
            }
            else
            {
                PsdIselgal = true;
                args.IsValid = true;
            }
        }
    }
}