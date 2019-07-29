using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8359_Assignment1.Models
{
    public class BlogModel
    {
        public int ID { get; set; }
        public string BlogPostTitle { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string HTMLText { get; set; }
        public bool IsAvaliable { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}