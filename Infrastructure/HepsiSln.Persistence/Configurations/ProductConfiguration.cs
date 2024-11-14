using Bogus;
using HepsiSln.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                CreatedDate = DateTime.Now,
                Description = faker.Commerce.ProductDescription(),
                Title = faker.Commerce.ProductName(),
                Discount = faker.Random.Decimal(0 - 10),
                Price = faker.Finance.Amount(10 - 1000)
            };

            Product product2 = new()
            {
                Id = 2,
                BrandId = 3,
                CreatedDate = DateTime.Now,
                Description = faker.Commerce.ProductDescription(),
                Title = faker.Commerce.ProductName(),
                Discount = faker.Random.Decimal(0 - 10),
                Price = faker.Finance.Amount(10 - 1000)
            };
            builder.HasData(product1, product2);
        }
    }
}
