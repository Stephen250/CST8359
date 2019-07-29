using CST8359_Assignment2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2
{
    public partial class Checkout : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_BuyNow_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(Session["userN"]);
            var lstBlog = (from u in db.Cart where u.UserName == user select u).ToList();

            foreach (var products in lstBlog)
            {
                CST8359_Assignment2.Model.Cart bWord = db.Cart.Find(products.ID);

                db.Cart.Remove(bWord);
                db.SaveChanges();

            }

            Response.Redirect("~/ThankYou.aspx");
        }
    }
}