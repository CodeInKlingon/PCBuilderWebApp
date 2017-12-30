using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class PartsListItem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void InitializePart(PCPart part) {
            lblName.Text = part.ProductName;
            lblPrice.Text ="$" + part.ProductPrice.ToString();
            imgPreview.ImageUrl = "~/Images/products/" + part.FileName;
        }
    }
}