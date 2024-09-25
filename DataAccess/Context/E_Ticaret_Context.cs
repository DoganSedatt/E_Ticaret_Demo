using Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class E_Ticaret_Context : DbContext
    {
        public E_Ticaret_Context(DbContextOptions options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                 .HasKey(pc => new { pc.ProductId, pc.CategoryId });
            //Kompozit PK

            modelBuilder.Entity<ProductCategory>()
            .HasOne(cp => cp.Product)
            .WithMany(p => p.Categories)
            .HasForeignKey(cp => cp.ProductId);
            //ProductCategory sınıfı, Product sınıfına bir bağlı
            //Product sınıfı ,Categories nav. prop. üzerinden ProductCategory sınıfına çok bağlı
            //Aralarında bire çok ilişki söz konusu

            modelBuilder.Entity<ProductCategory>()
                .HasOne(cp => cp.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(cp => cp.CategoryId);
            //ProductCategory sınıfı, Category sınıfına bir bağlı
            //Category sınıfı ,Products nav. prop. üzerinden ProductCategory sınıfına çok bağlı
            //Aralarında bire çok ilişki söz konusu
        }
    }
}
