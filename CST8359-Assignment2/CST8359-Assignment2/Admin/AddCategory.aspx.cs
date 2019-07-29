using CST8359_Assignment2.DAL;
using CST8359_Assignment2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateCategory_Click(object sender, EventArgs e)
        {
            StoreEntities db = new StoreEntities();

            Category bWord = new Category();

            bWord.Name = Name.Text;

            db.Categories.Add(bWord);

            db.SaveChanges();

            Response.Redirect("~/Admin/Default");
        }
    }
}