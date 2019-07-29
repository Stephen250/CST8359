using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class RequestDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //Retrieving UserName from Session
                lblFName.Text = "R FirstName : " + Server.UrlDecode(Request.QueryString["FName"]);

                //Retrieving UserName from Session
                lblLName.Text = "R LastName : " + Server.UrlDecode(Request.QueryString["LName"]); 


                //Retrieving UserName from Session
                lblEmail.Text = "R Email : " + Server.UrlDecode(Request.QueryString["Email"]);

                //Retrieving UserName from Session
                lblCalendar.Text = "R Calendar : " + Server.UrlDecode(Request.QueryString["Calendar"]);

            }
        }
    }
}