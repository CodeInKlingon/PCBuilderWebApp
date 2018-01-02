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
    public partial class Configuration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                if (Session["ConfigID"] != null)
                {
                    PCConfiguration config = new PCConfiguration(Convert.ToInt32(Session["ConfigID"]));
                    txtConfigName.Text = config.Name;
                    btnSave.Visible = false;

                    foreach (PCPart p in config.parts) {
                        PartsListItem cl = (PartsListItem)Page.LoadControl("PartsListItem.ascx");
                        cl.InitializePart(p);
                        Panel1.Controls.Add(cl);
                    }

                }
                else
                {
                    Response.Redirect("MyConfigurations.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void txtConfigName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }
    }  
}