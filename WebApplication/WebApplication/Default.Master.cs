using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                MultiView1.ActiveViewIndex = 2;
                lblUsername.Text = Session["Username"].ToString();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Session["CongifID"] = null;
            MultiView1.ActiveViewIndex = 0;
            Response.Redirect("Default.aspx");
        }

        protected void btnLogin2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            string encodedPass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");

            string sql = "select count(*) from Users where Password = '" + encodedPass + "' and username = '" + txtUsername.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int count = (int) cmd.ExecuteScalar();    
            conn.Close();
            

            if (count == 1)
            {
                Session["Username"] = txtUsername.Text;
                MultiView1.ActiveViewIndex = 2;
                lblUsername.Text = Session["Username"].ToString();
                Response.Redirect(Request.RawUrl);
            }
            else 
            {
                Session["Username"] = null;
                lblLoginStatus.Text = "Incorrect username or password";
                MultiView1.ActiveViewIndex = 1;
            }


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}