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
    public partial class CreateNewConfigControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["Username"] != null) {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
                string sql = "Insert into Configs Values ( NEXT VALUE FOR config_sequence,'" + Session["Username"] + "','New Config',getdate() )";
                SqlCommand comm = new SqlCommand(sql, conn);

                conn.Open();
                int userCount = (int)comm.ExecuteNonQuery();
                sql = "SELECT current_value FROM sys.sequences WHERE name = 'config_sequence' ";
                comm = new SqlCommand(sql, conn);
                Session["ConfigID"] = (int)comm.ExecuteScalar();
                conn.Close();
                Response.Redirect("Configuration.aspx");
                
            }
        }
    }
}