using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace CST8359_Lab2
{
    public partial class Manual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            double sizeCnt = 0;

            foreach (string fileName in fileEntries)
            {
                FileInfo write = new FileInfo(fileName);

                Response.Write("<br />Name: " + write.Name);
                Response.Write("<br />Size: " + write.Length + " KB");
                Response.Write("<br />Full Name: " + write.FullName);
                Response.Write("<br />Directory Name: " + write.DirectoryName);
                Response.Write("<br />Extension: " + write.Extension);
                Response.Write("<br /><br />");

                sizeCnt += write.Length;
            }

            Response.Write(sizeCnt/1000 + " MB");
        }
    }
}