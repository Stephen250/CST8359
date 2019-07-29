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
    public partial class Default : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = (from u in db.BadWords select u).ToList();
            GridView1.DataBind();

            GridView2.DataSource = (from u in db.Categories select u).ToList();
            GridView2.DataBind();

            GridView3.DataSource = (from u in db.Products select u).ToList();
            GridView3.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRow = GridView3.SelectedIndex;

            int id = Convert.ToInt32(GridView3.Rows[selectedRow].Cells[3].Text);

            Session["ProdId"] = id;

            Response.Redirect("~/ProductDetails.aspx");
        }

        protected void OnRowDeletingB(object sender, GridViewDeleteEventArgs e)
        {


            int selectedRow = e.RowIndex;

            BadWord bWord = db.BadWords.Find(Convert.ToInt32(GridView1.Rows[selectedRow].Cells[1].Text));

            db.BadWords.Remove(bWord);
            db.SaveChanges();

            Response.Redirect("~/Admin/Default");

        }
        protected void OnRowDeletingC(object sender, GridViewDeleteEventArgs e)
        {


            int selectedRow = e.RowIndex;

            Category category = db.Categories.Find(Convert.ToInt32(GridView2.Rows[selectedRow].Cells[2].Text));

            db.Categories.Remove(category);
            db.SaveChanges();

            Response.Redirect("~/Admin/Default");

        }
        protected void OnRowDeletingP(object sender, GridViewDeleteEventArgs e)
        {


            int selectedRow = e.RowIndex;

            Product product = db.Products.Find(Convert.ToInt32(GridView3.Rows[selectedRow].Cells[3].Text));

            db.Products.Remove(product);
            db.SaveChanges();

            Response.Redirect("~/Admin/Default");

        }
        protected void OnRowEditingC(object sender, GridViewEditEventArgs e)
        {
            int selectedRow = e.NewEditIndex;

            Category category = db.Categories.Find(Convert.ToInt32(GridView2.Rows[selectedRow].Cells[2].Text));

            Session["CatEId"] = category.ID;

            Response.Redirect("~/Admin/EditCategory.aspx");
        }
        protected void OnRowEditingP(object sender, GridViewEditEventArgs e)
        {
            int selectedRow = e.NewEditIndex;

            Product product = db.Products.Find(Convert.ToInt32(GridView3.Rows[selectedRow].Cells[3].Text));

            Session["ProdEId"] = product.ID;

            Response.Redirect("~/Admin/EditProduct.aspx");
        }
    }
}