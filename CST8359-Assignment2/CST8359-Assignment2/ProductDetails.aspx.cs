using CST8359_Assignment2.DAL;
using CST8359_Assignment2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Assignment2
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            Product temp = db.Products.Find(id);
            
            List<Product> oneItem = new List<Product>();

            string userN = Convert.ToString(Session["userN"]);

            var user = db.Cart.Where(c => c.Product_ID == id && c.UserName == userN).FirstOrDefault();
            if (user != null)
            {
                btnAddToCart.Visible = false;
            }
            lblLongDescription.Text = temp.LongDescription;
            
            lblName.Text = temp.Name;

            List<Comment> comment = (from u in db.Comments where u.ProductId == id select u).ToList();
            string displayComment = null;

            foreach (var commentStg in comment)
            {
                displayComment += "User: " + commentStg.UserName + "<br />";
                displayComment += "Comment: " + parseForBadWords(commentStg.ProdComment) + "<br />";
                displayComment += "<hr />";

            }
            if (userN != null)
            {
                if (displayComment == null)
                {
                    displayComment = "No comments, Be the first to comment";
                }
            }
            else
            {
                displayComment = "Login to post a comment";
            }

            commentLiteral.Text = displayComment;

            oneItem.Add(temp);
            //Assign data source to the repeater
            Repeater1.DataSource = oneItem;

            //You need to rebind the repeater
            Repeater1.DataBind();

            Session["prodID"] = id;
        }
        protected void CreateComment(object sender, EventArgs e)
        {
            Comment user = new Comment();

            int ID = Convert.ToInt32(Session["prodID"].ToString());


            user.ProductId = ID;
            user.UserName = Convert.ToString(Session["userN"]);
            user.ProdComment = txtComment.Text;
            user.CreatedOn = DateTime.Now;

            db.Comments.Add(user);
            db.SaveChanges();

            Session["prodID"] = ID;

            Response.Redirect("~/ProductDetails.aspx?id=" + ID);
        }

        protected string parseForBadWords(string parseString)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string[] words = parseString.Split(delimiterChars);

            List<String> badWords = db.BadWords.Select(s => s.Word).ToList();

            for (int ctr = 0; ctr < words.Count(); ctr++)
            {
                string temp = words[ctr];

                if (db.BadWords.Select(s => s.Word).Any(s => s.Equals(temp, StringComparison.OrdinalIgnoreCase)))
                {


                    StringBuilder sb = new StringBuilder(temp);

                    for (int ctr1 = 0; ctr1 < temp.Count(); ctr1++)
                    {
                        if (ctr1 == 0)
                        {
                            sb[ctr1] = temp[ctr1];
                        }
                        else
                        {
                            sb[ctr1] = '*';
                        }
                    }
                    words[ctr] = sb.ToString();
                }
            }

            return string.Join(" ", words);
        }
        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["prodID"]);

            CST8359_Assignment2.Model.Cart temp = new CST8359_Assignment2.Model.Cart();

            temp.Product_ID = id;
            temp.UserName = Convert.ToString(Session["userN"]);

            db.Cart.Add(temp);
            db.SaveChanges();

            Response.Redirect("~/ProductDetails?ID=" + id);
        }
    }
}