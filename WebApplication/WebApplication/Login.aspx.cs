using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            string encodedPass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");

            string sql = "select count(*) from Users where Password = '" + encodedPass + "' and username = '" + txtUsername.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();


            if (count == 1)
            {
                Session["Username"] = txtUsername.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["Username"] = null;
                lblLoginStatus.Text = "Incorrect username or password";

            }


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}