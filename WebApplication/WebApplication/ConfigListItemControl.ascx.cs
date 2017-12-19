using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ConfigListItemControl : System.Web.UI.UserControl
    {
        int configID; 
        public void InitializeConfig(int configID, string configName, string dateCreated)
        {
            lblConfigName.Text = configName;
            lblDate.Text = dateCreated;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            Session["ConfigID"] = configID;
            Response.Redirect("Configuration.aspx");
        }
    }
}