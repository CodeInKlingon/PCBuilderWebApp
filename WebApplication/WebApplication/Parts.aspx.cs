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
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Request.QueryString["Category"] == null)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                MultiView1.ActiveViewIndex = 1;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
                int category = Convert.ToInt32(Request.QueryString["Category"]);
                SqlCommand cmd = new SqlCommand("Select * from Products where PartType = " + category + "", conn);
                SqlDataReader reader;

                conn.Open();
                reader = cmd.ExecuteReader();

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

                }
                reader.Close();
                conn.Close();
            }
        }

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