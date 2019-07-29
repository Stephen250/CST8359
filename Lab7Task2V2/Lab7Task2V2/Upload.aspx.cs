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
using Lab7Task2V2.Models;
using Microsoft.Azure;

namespace Lab7Task2V2
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile == false)
                return;

            try
            {
                // Retrieve storage account from connection string.
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

                // Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                // Retrieve a reference to a container. 
                CloudBlobContainer container = blobClient.GetContainerReference("filestorage");

                // Create the container if it doesn't already exist.
                container.CreateIfNotExists();

                // Retrieve reference to a blob named from the given file
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(Path.GetFileName(fileUpload.PostedFile.FileName));

                if (blockBlob.Exists())
                    blockBlob.Delete();

                // Create the blob
                using (MemoryStream memoryStream = new MemoryStream(fileUpload.FileBytes))
                {
                    blockBlob.UploadFromStream(memoryStream);
                }

                // now the file is in the cloud make a note of that in our database so we can pull it later
                var newFile = new Lab7Task2V2.Models.FileInfo();
                newFile.BlogFileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                newFile.ContentType = fileUpload.PostedFile.ContentType;

                var db = new Lab8Task2Entities();
                db.FileInfoes.Add(newFile);
                db.SaveChanges();

                Response.Redirect("~/Default.aspx");
            }
            catch
            {
                // an error occured
            }
        }
    }
}