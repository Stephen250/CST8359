using CST8359_Assignment2.DAL;
using CST8359_Assignment2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2
{
    public partial class SiteMenu : System.Web.UI.MasterPage
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            var list = from c in db.Categories
                       orderby c.Name
                       select c;

            foreach (Category c in list)
            {
                display += "<li><a runat='server' href='CategoryDetails?ID=" + c.ID + "'>" + c.Name + "</a></li>";
            }

            outputLiteral.Text = display;

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