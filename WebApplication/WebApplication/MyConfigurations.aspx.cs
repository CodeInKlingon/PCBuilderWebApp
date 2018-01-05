using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class MyConfigurations : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();            

            MultiView1.ActiveViewIndex = 1;
            if (Session["Username"] != null)
            {


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Configs where Username = '" + Session["Username"] +"'", conn);
                SqlDataReader reader;

                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) {
                        ConfigListItemControl cl = (ConfigListItemControl)Page.LoadControl("ConfigListItemControl.ascx");
                        cl.InitializeConfig(reader.GetInt32(0), reader.GetString(2), reader.GetDateTime(3).ToShortDateString());
                        if (cl.ConfigID == Convert.ToInt32(Session["ConfigID"])) {
                            cl.SetActive();
                        }
                        Panel1.Controls.Add(cl);
                    }
                    CreateNewConfigControl uc = (CreateNewConfigControl)Page.LoadControl("CreateNewConfigControl.ascx");
                    Panel1.Controls.Add(uc);
                }
                else
                {
                    //no rows
                    CreateNewConfigControl uc = (CreateNewConfigControl)Page.LoadControl("CreateNewConfigControl.ascx");

                    Panel1.Controls.Add(uc);
                }
                reader.Close();
                conn.Close();
 
            }
            else {
                //add control to prompt for login
                //Panel1.Controls.Clear();
                Response.Redirect("Login.aspx");
            }
        }
    }
}