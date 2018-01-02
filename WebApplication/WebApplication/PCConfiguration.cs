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

        bool hasCPU;
        bool hasMotherboard;
        bool hasCase;
        bool hasStorage;
        bool hasGraphics;
        bool hasMemory;
        bool hasPower;

        //constructor that reads data from sql
        public PCConfiguration(int configID)
        {
            parts = new List<PCPart>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Configs Config_Id = " + configID + ";", conn);
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

        public void LoadItems()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from ConfigItems as ci left join Configs as cc on cc.Config_Id = ci.Config_Id where cc.Config_Id = " + ConfigID + ";", conn);
            SqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    parts.Add(new PCPart(reader.GetInt32(2)));
                }
                
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
        }

        public void UpdateName(string newName)
        {

        }
    }
}