using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment02
{
    public partial class MasterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LblCalendar.Text = "The selected date(s):" + "<br />";
            for (int i = 0; i <= Calendar1.SelectedDates.Count - 1; i++)
            { 
            LblCalendar.Text += Calendar1.SelectedDates[i].ToShortDateString() + "<br />";
            }
        }
    }
}