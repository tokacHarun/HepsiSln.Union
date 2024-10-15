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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("en_US");

            Detail detail1 = new()
            {
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = 1,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(2),
                Id = 1,
            };

            Detail detail2 = new()
            {
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = 3,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(2),
                Id = 2,
            };

            Detail detail3 = new()
            {
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                CategoryId = 4,
                Description = faker.Lorem.Sentence(5),
                Title = faker.Lorem.Sentence(2),
                Id = 3,
            };
            builder.HasData(detail1, detail2, detail3);
        }
    }
}
