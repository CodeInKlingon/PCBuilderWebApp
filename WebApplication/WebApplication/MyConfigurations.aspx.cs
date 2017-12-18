using System;
using System.Collections.Generic;
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
            Label testLabe = new Label();
            testLabe.Text = "hello";
            Panel1.Controls.Add(testLabe);

            

            MultiView1.ActiveViewIndex = 1;
            if (Session["Username"] != null)
            {
                
                if (GridView1.Rows.Count == 0)
                {
                    //no configs created yet
                    CreateNewConfigControl uc = (CreateNewConfigControl)Page.LoadControl("CreateNewConfigControl.ascx");
                    Panel1.Controls.Add(uc);
                }
                else
                {
                    for (int row = 0; row <= GridView1.Rows.Count; row++)
                    {
                        ConfigListItemControl cl = (ConfigListItemControl)Page.LoadControl("ConfigListItemControl.ascx");
                        Panel1.Controls.Add(cl);
                    }
                    CreateNewConfigControl uc = (CreateNewConfigControl)Page.LoadControl("CreateNewConfigControl.ascx");
                    Panel1.Controls.Add(uc);
                }
            }
            else {
                //add control to prompt for login
                //Panel1.Controls.Clear();
                LoginAndRegisterPromptControl uc = (LoginAndRegisterPromptControl)Page.LoadControl("LoginAndRegisterPromptControl.ascx");
                Panel1.Controls.Add(uc);
            }
        }
    }
}