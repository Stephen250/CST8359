using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8359_Assignment2.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string UserName { get; set; }
        public string ProdComment { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }

        public virtual Product Products { get; set; }
    }
}