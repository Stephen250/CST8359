using CST8359_Assignment2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CST8359_Assignment2.DAL
{
    public class StoreEntities: DbContext
  {
        public StoreEntities()
            : base("StoreEntities")
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<CST8359_Assignment2.Model.Cart> Cart { get; set; }
    public DbSet<BadWord> BadWords { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
  }
}