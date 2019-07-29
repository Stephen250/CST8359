using CST8359_Assignment2.DAL;
using CST8359_Assignment2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2.Admin
{
    public partial class EditCategory : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["CatEId"]);

                Category cat = db.Categories.Find(id);

                Name.Text = cat.Name;

                Session["CatEId"] = id;
            }
        }

        protected void EditCategory_Click(object sender, EventArgs e)
        {
            StoreEntities db = new StoreEntities();

            int id = Convert.ToInt32(Session["CatEId"]);

            Category bWord = db.Categories.Find(id);

            bWord.Name = Name.Text;

            db.Entry(bWord).State = EntityState.Modified;
            db.SaveChanges();

            Response.Redirect("~/Admin/Default");
        }
    }
}