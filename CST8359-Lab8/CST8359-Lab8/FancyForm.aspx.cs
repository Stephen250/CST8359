using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab8
{
    public partial class FancyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblPNumber.Text = "Phone Number: " + txtPnumber.Text;
            lblAge.Text = "Age: " + txtAgeDisplay.Text;
            lblDOB.Text = "DOB: " + txtCalendar.Text;
        }
    }
}