using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2
{
    public partial class SiteAdminMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Session["userN"];
            if (user != null)
            {
                nameLiteral.Text = Convert.ToString(user);
            }

            Session["userN"] = user;
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["userN"] = null;
            Session["user"] = null;

            Response.Redirect("~/");
        }
    }
}