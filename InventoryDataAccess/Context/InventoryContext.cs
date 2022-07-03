using InventoryDataAccess.data;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccess.Context
{
   public class InventoryContext: IdentityDbContext<ApplicationUser>
    {
        public InventoryContext(DbContextOptions<InventoryContext> options):base(options)
        {
          

        }
        public DbSet<Attributes> attributes { set; get; }
        public DbSet<AttributesValue> attributesValues { set; get; }
       
        public DbSet<Brand> brands { set; get; }
        public DbSet<Category> categories { set; get; }
        public DbSet<Company> companies { set; get; }
       
        public DbSet<Orders> orders { set; get; }
        public DbSet<Product> products { set; get; }
        
        public DbSet<Stores> stores { set; get; }
        public DbSet<Porduct_Order> Porduct_Order { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Porduct_Order>().HasKey(P => new {P.product_Id,P.orders_Id });
            base.OnModelCreating(modelBuilder);
        }
    }
}
