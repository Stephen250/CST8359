using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8359_Lab3
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void itemSelected(object sender, EventArgs e)
        {
            double total = 0.0;
            string operation = ddlOperations.SelectedValue;

            double op1Chk;
            if (double.TryParse(TextBox1.Text, out op1Chk))
            {
                total = op1Chk;
            }
            else
            {
                result.Text = "Error Please Check Your Fields";
                return;
            }

            double op2Chk;
            if (double.TryParse(TextBox1.Text, out op2Chk))
            {
                if (operation.Equals("add")) { total += op2Chk; }
                else if (operation.Equals("subtract")) { total -= op2Chk; }
                else if (operation.Equals("multiply")) { total *= op2Chk; }
                else if (operation.Equals("divide")) { total /= op2Chk; }
                else if (operation.Equals("exp")) { total = Math.Pow(total, op2Chk); }

                result.Text = Convert.ToString(total);
            }
            else
            {
                result.Text = "Error Please Check Your Fields";
            }

            return;
            
            

           
        }
    }
}