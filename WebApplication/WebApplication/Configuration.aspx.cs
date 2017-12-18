using System;
using System.Collections.Generic;
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
                    MultiView2.ActiveViewIndex = 1;
                    txtConfigName.Text = ConfigGridView.Rows[0].Cells[2].Text;
                }
                else {
                    Response.Redirect("MyConfigurations.aspx");
                }
            }
            else {
                Response.Redirect("MyConfigurations.aspx");
            }
        }
    }
}