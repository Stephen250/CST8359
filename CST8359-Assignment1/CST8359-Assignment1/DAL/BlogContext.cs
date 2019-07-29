using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CST8359_Assignment1.Models;

namespace CST8359_Assignment1.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogContext")
        { }

        public DbSet<BlogModel> BlogModel { get; set; }
        public DbSet<BadWordsModel> BadWordsModel  { get; set; }
        //public DbSet<>  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}