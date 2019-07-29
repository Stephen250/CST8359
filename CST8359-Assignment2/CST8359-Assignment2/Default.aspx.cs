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
    public partial class _Default : Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> lstBlog = (from u in db.Products orderby u.Name select u).Take(5).ToList();

            //Assign data source to the repeater
            Repeater1.DataSource = lstBlog;

            //You need to rebind the repeater
            Repeater1.DataBind();
        }
    }
}