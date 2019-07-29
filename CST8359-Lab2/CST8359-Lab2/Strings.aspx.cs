using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab2
{
    public partial class Strings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void inputButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            string inText = inputTextBox.Text;
            string outText = "";

            foreach (char c in inText) 
            {
                if (x % 2 == 0)
                {
                    outText += Char.ToUpper(c);
                }
                else
                {
                    outText += Char.ToLower(c);
                }
                x++;    
            }
            
            outputLiteral.Text = outText;
        } 
    }
}