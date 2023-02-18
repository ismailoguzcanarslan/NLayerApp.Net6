using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.DbContexts.Configurations
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Price = 999,
                    Name = "Macbook Air 13 inch",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Price = 599,
                    Name = "Monster Abra A5 17.3",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Price = 699,
                    Name = "Lenovo Legion",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Price = 1299,
                    Name = "Iphone 14 Pro Max",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Price = 799,
                    Name = "Iphone 13",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Price = 399,
                    Name = "Samsung Note 10",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Price = 399,
                    Name = "Samsung EarBuds 2",
                    CreatedOn = DateTime.Now,
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Price = 399,
                    Name = "Apple Lightining EarPods",
                    CreatedOn = DateTime.Now,
                }
            );
        }
    }
}
