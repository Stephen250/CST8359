using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab3
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void button1_click(object sender, EventArgs e)
        {
            string display = "";
            display += "First Name: " + txtFName.Text + "<br />";
            display += "Last Name: " + txtLName.Text + "<br />";
            display += "Student Number: " + txtStuNum.Text + "<br />";
            display += "Email: " + txtEmail.Text + "<br />";
            display += "Date of Birth: " + String.Format(Convert.ToString(Calendar1.SelectedDate.ToShortDateString())) + "<br />";
            display += "Program of Study: " + txtStudy.Text + "<br />";
            display += "Favourite Games: ";

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    display += item.Text + "<br />";
                }
            }
            outputLiteral.Text = display;

        }


    }
}