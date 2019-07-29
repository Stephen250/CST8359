using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_click(object sender, EventArgs e)
        {
            string destinationParam = "?FName=" + txtFName.Text + "&LName=" + txtLName.Text + "&Calendar=" + Calendar1.SelectedDate.ToShortDateString() + "&Email=" + txtEmail.Text;
            Response.Redirect("RequestDisplay.aspx" + destinationParam);
        }
    }
}