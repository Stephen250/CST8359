using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CST8359_Assignment2.Model
{
    public class Cart
    {

        public int ID { get; set; }
        public int Product_ID { get; set; }
        public string UserName { get; set; }

        public virtual Product Products { get; set; }
    }
}