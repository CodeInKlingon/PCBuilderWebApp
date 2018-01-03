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
    public partial class Parts : System.Web.UI.Page
    {
        int category;

        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Category"] == null)
            {
                //no category selected using query string
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                //category selected
                MultiView1.ActiveViewIndex = 1;
                LoadParts();
                if (!Page.IsPostBack)
                {
                    loadManufacturers();
                }
            }
        }
        void LoadParts()
        {

            //sql statements to load products
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            category = Convert.ToInt32(Request.QueryString["Category"]);

            //build string for optional manufacturer sql
            string manufactfilter = "";
            List<string> manufacturers = new List<string>();
            manufacturers  = chkListMan.Items.Cast<ListItem>().Where(li => li.Selected).Select(li => li.Value).ToList();
            string andor = " and (";
            if (manufacturers.Count > 0) {
                foreach (string s in manufacturers) {
                    manufactfilter += andor + " Manufacturer = '" + s+ "'";
                    andor = " or";
                }
                manufactfilter += ")";
            }

            string baseSQL = "Select * from Products where PartType = " + category + manufactfilter;
                
            SqlCommand cmd = new SqlCommand(baseSQL , conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            //sql returned rows
            if (reader.HasRows)
            {
                PlaceHolder1.Controls.Clear();
                while (reader.Read())
                {
                    PartsListItem cl = (PartsListItem)Page.LoadControl("PartsListItem.ascx");
                    //id name price file
                    cl.InitializePart(new PCPart(reader.GetInt32(0), reader.GetString(1), (float)reader.GetDouble(5), reader.GetString(3)));
                    PlaceHolder1.Controls.Add(cl);
                }

            }
            else
            {
                //no rows returned
            }
            reader.Close();
            conn.Close();
        }

        void loadManufacturers() {
            //chkListMan.Items.Clear();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Manufacturer from Products where PartType = " + category + "", conn);
            SqlDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    chkListMan.Items.Add(reader.GetString(0));
                }
            }
            reader.Close();
            conn.Close();
        }


        //category buttons
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

        protected void chkListMan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParts();
        }
    }
}