using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure;
using System.IO;
using CST8359_Assignment2.Model;
using Microsoft.Azure;
using CST8359_Assignment2.DAL;

namespace CST8359_Assignment2.Admin
{
    public partial class AddProduct : System.Web.UI.Page
    {
        StoreEntities db = new StoreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = from c in db.Categories
                       orderby c.Name
                       select c;

            List<ListItem> items = new List<ListItem>();
           
            foreach (Category c in list)
            {
                items.Add(new ListItem(c.Name, Convert.ToString(c.ID)));
            }

            items.Sort(delegate(ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
            CategoryListDropDown.Items.AddRange(items.ToArray());

        }

        protected void CreateProduct_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile == false)
                return;

            try
            {
                 //Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

                 //Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                 //Retrieve a reference to a container. 
                CloudBlobContainer container = blobClient.GetContainerReference("filestorage");

                //HERE LIES THE PROBLEM...

                 //Create the container if it doesn't already exist.
                container.CreateIfNotExists();

                 //Retrieve reference to a blob named from the given file
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(Path.GetFileName(fileUpload.PostedFile.FileName));

                if (blockBlob.Exists())
                    blockBlob.Delete();

                 //Create the blob
                using (MemoryStream memoryStream = new MemoryStream(fileUpload.FileBytes))
                {
                    blockBlob.UploadFromStream(memoryStream);
                }

                 //now the file is in the cloud make a note of that in our database so we can pull it later

                var newFile = new Product();
                newFile.Name = txtPName.Text;
                newFile.Category_ID = Convert.ToInt32(CategoryListDropDown.SelectedValue);
                newFile.ShortDescription = txtShrtDescription.Text;
                newFile.LongDescription = txtLongDescription.Text;
                newFile.Price = Convert.ToDecimal(txtPrice.Text);

                if (chkSale.Checked)
                {
                    newFile.IsOnSale = true;
                }
                else
                {
                    newFile.IsOnSale = false;
                }

                newFile.SalePrice = Convert.ToDecimal(txtSPrice.Text);
                newFile.ImageName = Path.GetFileName(fileUpload.PostedFile.FileName);

                db.Products.Add(newFile);
                db.SaveChanges();

                Response.Redirect("~/Admin/Default.aspx");
           }
            catch
            {
                // an error occured
            }
        }
    }
}