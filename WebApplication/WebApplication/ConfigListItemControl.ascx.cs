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
    public partial class ConfigListItemControl : System.Web.UI.UserControl
    {
        public int ConfigID; 
        public void InitializeConfig(int configID, string configName, string dateCreated)
        {
            ConfigID = configID;
            lblConfigName.Text = configName.Substring(0, 30);
            lblDate.Text = dateCreated;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetActive() {
            btnSelect.Text = "Selected";
            btnSelect.CssClass = "cliSelected";
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Session["ConfigID"] = ConfigID;
            Response.Redirect("Configuration.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["ConfigID"]) == ConfigID) {
                Session["ConfigID"] = null;
            }
            //drop config from database
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Delete Configs where Config_Id = " + ConfigID + "", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            //refresh page to view updated list of configurations
            Response.Redirect("MyConfigurations.aspx");
        }
    }
}