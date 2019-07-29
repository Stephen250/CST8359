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

    public partial class Cart : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Convert.ToString(Session["userN"]);
            var lstBlog = (from u in db.Cart where u.UserName == user select u).ToList();
            List<Product> lstProducts = new List<Product>();
            decimal total = 0;

            foreach (var products in lstBlog)
            {
                var temp = (from u in db.Products where products.Product_ID == u.ID select u).FirstOrDefault();

                if (temp.IsOnSale)
                {
                    total += Convert.ToDecimal(temp.SalePrice);
                }
                else
                {
                    total += Convert.ToDecimal(temp.Price);
                }
                lstProducts.Add(temp);

            }

            TotalLiteral.Text = total.ToString("C2");
            //Assign data source to the repeater
            Repeater2.DataSource = lstProducts;

            //You need to rebind the repeater
            Repeater2.DataBind();
        }

        protected void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(Session["userN"]);
            var lstBlog = (from u in db.Cart where u.UserName == user select u).ToList();

            foreach (var products in lstBlog)
            {
                CST8359_Assignment2.Model.Cart bWord = db.Cart.Find(products.ID);

                db.Cart.Remove(bWord);
                db.SaveChanges();

            }

            Response.Redirect("~/CartPg.aspx");
        }
    }
}