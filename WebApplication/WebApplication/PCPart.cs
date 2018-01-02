using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class PCPart
    {

        public int Product_Id { get; private set; }
        public string ProductName { get; private set; }
        public float ProductPrice { get; private set; }
        public int Manufacturer_Id { get; private set; }
        public string FileName { get; private set; }
        public int category { get; private set; }

        //constructor that reads data from sql
        public PCPart(int id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Products where Product_Id = " + id + "", conn);
            SqlDataReader reader;
            conn.Open();
            reader = cmd.ExecuteReader();

            reader.Read();
            Product_Id = reader.GetInt32(0);
            ProductName = reader.GetString(1);
            Manufacturer_Id = reader.GetInt32(2);
            FileName = reader.GetString(3);
            ProductPrice = (float)reader.GetDouble(5);
            conn.Close();
        }

        //constructor that is fed data not directly from sql
        public PCPart(int id, string name, float price, string file)
        {
            Product_Id = id;
            ProductName = name;
            ProductPrice = price;
            FileName = file;
        }
    }
}