using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using CST8359_Lab4.Model;
using System.Data;

namespace CST8359_Lab4
{
    public partial class Default : System.Web.UI.Page
    {
        Lab4Entities db = new Lab4Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Rescan();
            }

        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            List<CST8359_Lab4.Model.FileInfo> list = new List<Model.FileInfo>();
            var record = db.FileInfoes.OrderBy(x => x.FileId).Select(u => u).FirstOrDefault();

            if (record != null)
            {
                list.Add(record);
                GridView1.DataSource = list;
            }
            else {
                GridView1.DataSource = (from u in db.FileInfoes select u).ToList();
            }
            
            GridView1.DataBind();
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            List<CST8359_Lab4.Model.FileInfo> list = new List<Model.FileInfo>();
            var record = db.FileInfoes.OrderByDescending(x => x.FileId).Select(u => u).FirstOrDefault();

            if (record != null)
            {
                list.Add(record);
                GridView1.DataSource = list;
            }
            else
            {
                GridView1.DataSource = (from u in db.FileInfoes select u).ToList();
            }

            GridView1.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE FileInfo");

            GridView1.DataSource = (from u in db.FileInfoes select u).ToList();
            GridView1.DataBind();
        }

        protected void btnRescan_Click(object sender, EventArgs e)
        {
            Rescan();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            
            CST8359_Lab4.Model.FileInfo record = db.FileInfoes.Find(Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[1].Text));
            db.FileInfoes.Remove(record);
            db.SaveChanges();

            GridView1.DataSource = (from u in db.FileInfoes select u).ToList();
            GridView1.DataBind();

        }
        protected void Rescan() 
        {
            string[] fileEntries = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);

            System.IO.FileInfo write;
            CST8359_Lab4.Model.FileInfo read;

            foreach (string fileName in fileEntries)
            {
                write = new System.IO.FileInfo(fileName);
                read = new CST8359_Lab4.Model.FileInfo();

                read.FileName = write.FullName;
                read.Length = write.Length;
                read.Extension = write.Extension;


                db.FileInfoes.Add(read);
                db.SaveChanges();
            }

            GridView1.DataSource = (from u in db.FileInfoes select u).ToList();
            GridView1.DataBind();
        }
    }
}