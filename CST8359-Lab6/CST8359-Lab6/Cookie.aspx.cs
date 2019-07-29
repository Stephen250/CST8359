using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab6
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button1_click(object sender, EventArgs e)
        {
            HttpCookie _userCookie = new HttpCookie("UserCookie");
            //Writing Multiple values in single cookie
            _userCookie["FName"] = txtFName.Text;
            _userCookie["LName"] = txtLName.Text;
            _userCookie["Email"] = txtEmail.Text;
            _userCookie["Calendar"] = Calendar1.SelectedDate.ToShortDateString();
            Response.Cookies.Add(_userCookie);
            Response.Redirect("CookieDisplay.aspx");
        }
    }
}