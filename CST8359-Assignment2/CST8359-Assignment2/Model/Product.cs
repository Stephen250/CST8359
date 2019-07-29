using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST8359_Assignment2.Model
{
    public class Product
    {
        public int ID { get; set; }
        
        [Display(Name = "Category")]
        public int Category_ID { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set;}
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Sale Price")]
        public decimal SalePrice { get; set; }
        [Display(Name = "On Sale")]
        public bool IsOnSale { get; set; }
        [Display(Name = "Product Image")]
        public string ImageName { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}