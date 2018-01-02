using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class PCConfiguration
    {

        public string Name { get; private set; }
        public int ConfigID { get; private set; }
        public string Username { get; private set; }

        public List<PCPart> parts;

        int countCPU = 0;
        int countMotherboard = 0;
        int countCase = 0;
        int countStorage = 0;
        int countGraphics = 0;
        int countMemory = 0;
        int countPower = 0;

        //constructor that reads data from sql
        public PCConfiguration(int configID)
        {
            parts = new List<PCPart>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Configs where Config_Id = " + configID + ";", conn);
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
                    LoadItems();
                }
            }
            else
            {
                //no rows
            }
            reader.Close();
            conn.Close();
        }


        //using a sql select to load in pc parts and save them to a list.
        public void LoadItems()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from ConfigItems Config_Id = " + ConfigID + ";", conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    parts.Add(new PCPart(reader.GetInt32(2)));
                }
                //all rows have been read 
                    
                //count the parts and add up for each category    

                //sort pc parts.
                SortItems();
            }
            else
            {
                //no rows
            }
            reader.Close();
            conn.Close();
        }

        //sorts items by product id ... i hope, not tested yet
        void SortItems() {

            List<PCPart> sortedParts = new List<PCPart>();

            while (parts.Count > 1)
            {
                PCPart nextPart = parts[0];
                foreach (PCPart p in parts)
                {
                    if (p.Product_Id >= nextPart.Product_Id) {
                        nextPart = p;
                    }
                }
                sortedParts.Add(nextPart);
                parts.Remove(nextPart);
            }
            parts = sortedParts;

        }

        void countCategory(int category) {
            foreach (PCPart p in parts) {
                switch (p.category) {
                    case 1:
                        countCPU++;
                        break;
                    case 2:
                        countMotherboard++;
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }
            }
        }

        public void UpdateName(string newName)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("UPDATE Configs SET ConfigName = '" + newName + "' WHERE Config_Id = '" + ConfigID +"';", conn);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}