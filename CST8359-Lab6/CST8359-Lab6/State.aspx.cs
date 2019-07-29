using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_click(object sender, EventArgs e)
        {
            Session["FName"] = txtFName.Text;
            Session["LName"] = txtLName.Text;
            Session["Email"] = txtEmail.Text;
            Session["Calendar"] = Calendar1.SelectedDate.ToShortDateString();

            Response.Redirect("StateDisplay");
        }
    }
}