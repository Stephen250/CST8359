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
    public partial class BadWords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateBad_Click(object sender, EventArgs e)
        {
            StoreEntities db = new StoreEntities();

            BadWord bWord = new BadWord();

            bWord.Word = BadWord.Text;

            db.BadWords.Add(bWord);

            db.SaveChanges();

            Response.Redirect("~/Admin/Default");
        }
    }
}