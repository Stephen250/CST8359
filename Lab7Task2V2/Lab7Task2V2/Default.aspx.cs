using Lab7Task2V2.Models;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7Task2V2
{
    public partial class _Default : Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // bind the files to the grid
            if (!IsPostBack)
                BindInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindInformation()
        {
            Lab8Task2Entities db = new Lab8Task2Entities();
            imagesGridView.DataSource = db.FileInfoes.ToList();
            imagesGridView.DataBind();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void deleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;

            int fileId = Convert.ToInt32(deleteButton.CommandArgument);

            var db = new Lab8Task2Entities();
            var file = db.FileInfoes.Where(f => f.FileId == fileId).FirstOrDefault();

            // access your storage account
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("filestorage");

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            try
            {
                // Retrieve reference to a blob named from the given file
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(file.BlogFileName);
                blockBlob.Delete();
            }
            catch
            {
                // just in case something went wrong
            }

            try
            {
                // remove the file from the database as well
                db.FileInfoes.Remove(file);
                db.SaveChanges();
            }
            catch
            {
                // just in case something went wrong
            }

            // rebind the information
            BindInformation();
        }
    }
}