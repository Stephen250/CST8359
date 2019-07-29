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
    public partial class CategoryDetails : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ID = Convert.ToInt32(Server.UrlDecode(Request.QueryString["ID"]));
                List<Product> lstBlog = (from u in db.Products where u.Category_ID == ID select u).ToList();

                //Assign data source to the repeater
                Repeater1.DataSource = lstBlog;

                //You need to rebind the repeater
                Repeater1.DataBind();
            }
        }
    }
}