using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;

namespace WebApplication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool uniqueUsername(string uname) {
            return true;
        }

        bool uniqueEmail(string email) {
            return true;
        }

        bool passwordsMatch() {
            if (txtPassword.Text == txtPassword2.Text)
            {
                return true;
            }
            else {
                return false;
            }
        }

        bool validPassword() {
            if (txtPassword.Text.Contains(" "))
            {
                return false;
            }
            else {
                return true;
            }
        }

        void Validate() {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Page.IsValid) {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);



                conn.Open();
                string sql = "Select count(*) from Users where username = '" + txtUsername.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                int userCount = (int)comm.ExecuteScalar();

                sql = "Select count(*) from Users where email = '" + txtEmail.Text + "'";
                comm = new SqlCommand(sql, conn);
                int emailCount = (int)comm.ExecuteScalar();

                string status = "0";
                if (userCount == 0 && emailCount == 0)
                {
                    string encodedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
                    sql = "Insert into Users Values ( '" + txtUsername.Text + "','" + txtEmail.Text + "','" + encodedPassword + "')";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    Session["Username"] = txtUsername.Text;
                    Response.Redirect("MyConfigurations.aspx");
                }
                else
                {
                    conn.Close();
                    if (emailCount > 0 && userCount > 0)
                    {
                        lblStatus.Text = "Username and email is already registered to an account";
                    }
                    else if (emailCount > 0)
                    {
                        lblStatus.Text = "Email is already registered to an account";
                    }
                    else if (userCount > 0)
                    {
                        lblStatus.Text = "Username is already registered to an account";
                    }
                }
            }
            

            
        }
    }
}