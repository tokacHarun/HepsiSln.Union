using Bogus;
using HepsiSln.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Faker faker = new("tr");

            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Priorty = 1,
                ParentId = 0,
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Priorty = 2,
                ParentId = 0,

            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                Priorty = 1,
                ParentId = 1,
            };
            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadın",
                CreatedDate = DateTime.Now,
                ParentId = 2,
                IsDeleted = false,
                Priorty = 1,
            };
            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
