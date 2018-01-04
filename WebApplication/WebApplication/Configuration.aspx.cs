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
        PCConfiguration config;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                if (Session["ConfigID"] != null)
                {
                    config = new PCConfiguration(Convert.ToInt32(Session["ConfigID"]));
                    //hide save button unless page is posted back.
                    if (!Page.IsPostBack)
                    {
                        txtConfigName.Text = config.Name;
                        btnSave.Visible = false;
                    }

                    foreach (PCPart p in config.parts) {
                        ConfigParts cl = (ConfigParts)Page.LoadControl("ConfigParts.ascx");
                        cl.InitializePart(p);
                        switch (p.category)
                        {
                            case 0:
                                if (config.countCPU > 1) { cl.SetWarning(); }
                                break;
                            case 1:
                                if (config.countMotherboard > 1) { cl.SetWarning(); }
                                break;
                            case 2:
                                if (config.countMemory > 1) { cl.SetWarning(); }
                                break;
                            case 3:
                                if (config.countStorage > 1) { cl.SetWarning(); }
                                break;
                            case 4:
                                if (config.countGraphics > 1) { cl.SetWarning(); }
                                break;
                            case 5:
                                if (config.countPower > 1) { cl.SetWarning(); }
                                break;
                            case 6:
                                if (config.countCase > 1) { cl.SetWarning(); }
                                break;
                        }

                        Panel1.Controls.Add(cl);
                    }
                    hideButtons();
                    if (config.parts.Count > 0) {
                        Button checkoutButton = new Button();
                        checkoutButton.Text = "Checkout";

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

        void hideButtons() {
            if (config.countCPU >= 1)
            {
                Panel2.Controls.Remove(btnCPU);
                btnCPU.Dispose();
            }
            if (config.countMotherboard >= 1)
            {
                Panel2.Controls.Remove(btnMotherboard);
                btnMotherboard.Dispose();
            }
            if (config.countMemory >= 1)
            {
                Panel2.Controls.Remove(btnMemory);
                btnMemory.Dispose();
            }
            if (config.countStorage >= 1)
            {
                Panel2.Controls.Remove(btnStorage);
                btnStorage.Dispose();
            }
            if (config.countGraphics >= 1)
            {
                Panel2.Controls.Remove(btnVideo);
                btnVideo.Dispose();
            }
            if (config.countPower >= 1)
            {
                Panel2.Controls.Remove(btnPower);
                btnPower.Dispose();
            }
            if (config.countCase >= 1)
            {
                Panel2.Controls.Remove(btnCases);
                btnCases.Dispose();
            }

        }

        protected void txtConfigName_TextChanged(object sender, EventArgs e)
        {
            //show save button when name in text box is changed
            btnSave.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //if config is valid run update name function and redirect back to this same page
            if (config != null) {
                config.UpdateName(txtConfigName.Text);
                Response.Redirect("Configuration.aspx");
            }
        }


        //add product buttons on click events
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 0);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 1);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 2);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 3);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 4);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 5);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Parts.aspx?Category=" + 6);
        }
    }  
}