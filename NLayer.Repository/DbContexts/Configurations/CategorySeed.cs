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
    internal class CategorySeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Laptop" }, 
                new Category { Id = 2, Name = "Mobile Phone" },
                new Category { Id = 3, Name = "Earphones" });
        }
    }
}
