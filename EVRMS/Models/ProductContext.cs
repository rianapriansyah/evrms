using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVRMS.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<ProductStock> ProductStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductStock>().HasData(
                new ProductStock()
                {
                    Id = 1,
                    ProductName = "Panci Tahan Banting",
                    UnitStock = 10
                },
                new ProductStock()
                {
                    Id = 2,
                    ProductName = "Ember Serba Guna",
                    UnitStock = 10
                }
            );
        }
    }
}
