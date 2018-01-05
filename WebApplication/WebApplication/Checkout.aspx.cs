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
    public partial class Checkout : System.Web.UI.Page
    {
        PCConfiguration config;
        float itemCost = 0;
        float discountAmount = 0;
        string CODE = "";
        float totalPrice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                if (Session["ConfigID"] != null)
                {
                    config = new PCConfiguration(Convert.ToInt32(Session["ConfigID"]));

                    //build table from parts
                    buildTable();

                }
                else {
                    Response.Redirect("MyConfigurations.aspx");
                }
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }


        void buildTable() {
            itemCost = 0;
            totalPrice = 0;

            tblOrderItems.Rows.Clear();

            TableRow tRow0 = new TableRow();
            tRow0.Height = 45;
            TableCell tCellL0 = new TableCell();
            tCellL0.Text = "Item";
            tCellL0.Font.Bold = true;
            tCellL0.Width = 350;

            TableCell tCellR0 = new TableCell();
            tCellR0.Text = "Price";
            tCellR0.Font.Bold = true;
            tCellR0.Width = 35;

            tRow0.Cells.Add(tCellL0);
            tRow0.Cells.Add(tCellR0);

            tblOrderItems.Rows.Add(tRow0);


            foreach (PCPart p in config.parts)
            {
                TableRow tRow = new TableRow();
                TableCell tCellL = new TableCell();
                tCellL.Text = p.ProductName;
                tCellL.Width = 350;

                TableCell tCellR = new TableCell();
                tCellR.Text = "$" + p.ProductPrice;
                itemCost += p.ProductPrice;
                tCellR.Width = 35;

                tRow.Cells.Add(tCellL);
                tRow.Cells.Add(tCellR);


                tblOrderItems.Rows.Add(tRow);

            }

            //row for cost added up
            TableRow tRow2 = new TableRow();
            tRow2.Height = 45;
            TableCell tCellL2 = new TableCell();
            tCellL2.Text = "Item Cost:";
            //tCellL2.Font.Bold = true;
            tCellL2.Width = 350;

            TableCell tCellR2 = new TableCell();
            tCellR2.Text = "$" + itemCost;
            //tCellR2.Font.Bold = true;
            tCellR2.Width = 35;

            tRow2.Cells.Add(tCellL2);
            tRow2.Cells.Add(tCellR2);

            tblOrderItems.Rows.Add(tRow2);


            TableRow tRow3 = new TableRow();
            tRow3.Height = 45;
            TableCell tCellL3 = new TableCell();
            tCellL3.Text = "Discount: " + CODE;
            tCellL3.Width = 350;

            TableCell tCellR3 = new TableCell();
            tCellR3.Text = "- $" + discountAmount;
            tCellR3.Width = 35;

            tRow3.Cells.Add(tCellL3);
            tRow3.Cells.Add(tCellR3);

            tblOrderItems.Rows.Add(tRow3);


            totalPrice = itemCost - discountAmount;

            TableRow tRow4 = new TableRow();
            tRow4.Height = 45;
            TableCell tCellL4 = new TableCell();
            tCellL4.Text = "Order Cost:";
            tCellL4.Font.Bold = true;
            tCellL4.Width = 350;

            TableCell tCellR4 = new TableCell();
            tCellR4.Text = " $" + totalPrice;
            tCellR4.Font.Bold = true;
            tCellR4.Width = 35;

            tRow4.Cells.Add(tCellL4);
            tRow4.Cells.Add(tCellR4);

            tblOrderItems.Rows.Add(tRow4);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Databas1ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select DiscountAmount from Coupon where CouponCode = '" + txtCouponCode.Text.ToUpper() + "';", conn);
            SqlDataReader reader;


            conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows){
                reader.Read();
                discountAmount = (float)reader.GetDouble(0);
                CODE = txtCouponCode.Text.ToUpper();
                buildTable();
            }
            else {
                lblCouponStatus.Text = "No coupon was found for the code: " + txtCouponCode.Text.ToUpper();
                discountAmount = 0;
                CODE = "";
            }
            reader.Close();
            conn.Close();
        }
    }
}