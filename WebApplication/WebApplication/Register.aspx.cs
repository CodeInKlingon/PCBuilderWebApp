using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool uniqueUsername(string uname) {
            return true;
        }

        bool uniqueEmail(string email) {
            return true;
        }

        bool passwordsMatch() {
            if (txtPassword.Text == txtPassword2.Text)
            {
                return true;
            }
            else {
                return false;
            }
        }

        bool validPassword() {
            if (txtPassword.Text.Contains(" "))
            {
                return false;
            }
            else {
                return true;
            }
        }

        void Validate() {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}