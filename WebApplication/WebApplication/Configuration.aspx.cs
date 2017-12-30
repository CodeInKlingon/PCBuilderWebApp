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
    public class PCConfiguration {

        public string Name { get; private set; }
        public int ConfigID { get; private set; }
        public string Username { get; private set; }

        List<PCPart> parts;

        bool hasCPU;
        bool hasMotherboard;
        bool hasCase;
        bool hasStorage;
        bool hasGraphics;
        bool hasMemory;
        bool hasPower;

        public PCConfiguration(int configID) {
            parts = new List<PCPart>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Configs where Config_Id = " + configID +";", conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ConfigID = reader.GetInt32(0);
                    Username = reader.GetString(1);
                    Name = reader.GetString(2);
                }
            }
            else
            {
               //no rows
            }
            reader.Close();
            conn.Close();
        }

        public void LoadItems() {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from ConfigItems join Products on Product_Id where ConfigItems.Config_Id =" + ConfigID + " ;", conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    //parts.Add(new PCPart());
                }
                ConfigID = reader.GetInt32(0);
                Username = reader.GetString(1);
                Name = reader.GetString(2);
            }
            else
            {
                //no rows
            }
            reader.Close();
            conn.Close();
        }

        public void UpdateName(string newName) {

        }
    }

    public class PCPart {

        public int Product_Id { get; private set; }
        public string ProductName { get; private set; }
        public float ProductPrice { get; private set; }
        public int Manufacturer_Id { get; private set; }
        public string FileName { get; private set; }
        public PartCategory category { get; private set; }

        public PCPart(int id, string name, float price, string file) {
            Product_Id = id;
            ProductName = name;
            ProductPrice = price;
            FileName = file;
        }
    }

    public enum PartCategory {

    }
}