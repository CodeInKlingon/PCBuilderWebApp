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
    public partial class ConfigParts : System.Web.UI.UserControl
    {
        PCPart thisPart;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void InitializePart(PCPart part) {
            thisPart = part;
            lblName.Text = part.ProductName;
            lblPrice.Text ="$" + part.ProductPrice.ToString();
            imgPreview.ImageUrl = "~/Images/products/" + part.FileName;
        }

        void SelectItem() {

            if (Session["Username"] != null)
            {
                if (Session["ConfigID"] != null)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
                    string sql = "Insert into ConfigItems Values ( NEXT VALUE FOR configitems_sequence,'" + Session["ConfigID"] + "','" + thisPart.Product_Id + "','" + thisPart.category + "');";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    Response.Redirect("Configuration.aspx");
                }
                else {
                    Response.Write("<script>"+
                        "if (window.confirm('Please select a configuration first before selecting products.')){ window.location = 'MyConfigurations.aspx'}else{ }" +
                        "</script>");
                    //select a config first.
                }
            }
            else {
                //login user
                Response.Write("<script>" +
                                        "if (window.confirm('Please login first before selecting products.')){ window.location = 'Login.aspx'}else{ }" +
                                        "</script>");
            }

        }

        public void SetWarning() {
            Image1.Visible = true;
            LiteralControl linebreakTag = default(LiteralControl);
            linebreakTag = new LiteralControl("<br />");
            Panel1.Controls.Add(linebreakTag);
            Label label = new Label();
            label.ID = "WarningLabel";
            label.Text = "Another item already exists for this type.";
            Panel1.Controls.Add(label);

            partContainerDiv.Attributes["class"] = "confiogPartWarning";

        }

        protected void lblName_Click(object sender, EventArgs e)
        {
            //SelectItem();
        }

        protected void imgPreview_Click(object sender, ImageClickEventArgs e)
        {
            //SelectItem();
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Delete top (1) from ConfigItems where Config_Id = '" + Session["ConfigId"] + "' and Product_Id = '" +thisPart.Product_Id+ "' ;", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Configuration.aspx");
        }
    }
}