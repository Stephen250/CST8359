using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class CookieDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie _userCookie = Request.Cookies["UserCookie"];
            if (_userCookie != null)
            {
                //Retrieving UserName from Session
                lblFName.Text = "C FirstName : " + _userCookie["FName"];

                //Retrieving UserName from Session
                lblLName.Text = "C LastName : " + _userCookie["LName"];


                //Retrieving UserName from Session
                lblEmail.Text = "C Email : " + _userCookie["Email"];

                //Retrieving UserName from Session
                lblCalendar.Text = "C Calendar : " + _userCookie["Calendar"];
            }
           
        }
    }
}