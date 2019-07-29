using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST8359_Assignment2.Model
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}