using CST8359_Assignment2.AlgonquinService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            AuthenticateServiceSoapClient client = new AuthenticateServiceSoapClient();

            client.Open();
            AlgonquinCollegeUser user = client.AuthenticateUser(Email.Text, Password.Text);
            client.Close();

            if (string.IsNullOrEmpty(Password.Text))
                ModelState.AddModelError("", "The user login or password provided is incorrect.");
            else
            {
                if (user != null){
                
                    Session["userN"] = user.FirstName + " " + user.LastName;
                    Session["user"] = user;
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    ModelState.AddModelError("", "The password provided is incorrect.");
                    return;
                }
            }
        }
    }
}
