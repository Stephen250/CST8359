using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Lab7Task2V2.Models;
using Microsoft.Azure;

namespace Lab7Task2V2
{
    /// <summary>
    /// Summary description for GetFileHandler
    /// </summary>
    public class GetFileHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int fileId = Convert.ToInt32(context.Request["fileid"]);

            var db = new Lab8Task2Entities ();
            var file = db.FileInfoes.Where(f => f.FileId == fileId).FirstOrDefault();

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("filestorage");

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            // Retrieve reference to a blob named from the given file
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(file.BlogFileName);

            try
            {
                // save the blob data into a readable stream
                System.IO.Stream fileStream = new MemoryStream();
                blockBlob.DownloadToStream(fileStream);

                // return to the beginning of the stream
                fileStream.Seek(0, SeekOrigin.Begin);

                // move the data into a byte array
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, (int)fileStream.Length);

                // close the stream
                if (fileStream != null)
                    fileStream.Close();

                context.Response.Clear();
                context.Response.ContentType = file.ContentType;
                context.Response.BinaryWrite(buffer);
            }
            catch
            {
                context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                context.Response.Cache.SetNoStore();
                context.Response.Cache.SetExpires(DateTime.MinValue);
                context.Response.StatusCode = 404;
                context.Response.End();
                return;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}