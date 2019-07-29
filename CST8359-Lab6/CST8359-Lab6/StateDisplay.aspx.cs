using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class StateDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["FName"] != null)
            {
                //Retrieving UserName from Session
                lblFName.Text = "SS FirstName : " + Session["FName"];
            }
            else
            {
                lblFName.Text = "Error...";
            }
            if (Session["LName"] != null)
            {
                //Retrieving UserName from Session
                lblLName.Text = "SS LastName : " + Session["LName"];
            }
            else
            {
                lblLName.Text = "Error...";
            }
            if (Session["Email"] != null)
            {
                //Retrieving UserName from Session
                lblEmail.Text = "SS Email : " + Session["Email"];
            }
            else
            {
                lblEmail.Text = "Error...";
            }
            if (Session["Calendar"] != null)
            {
                //Retrieving UserName from Session
                lblCalendar.Text = "SS Calendar : " + Session["Calendar"];
            }
            else
            {
                lblCalendar.Text = "Error...";
            }
           

        }
    }
}