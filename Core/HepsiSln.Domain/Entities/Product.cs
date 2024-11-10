using HepsiSln.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IList<ProductCategory> ProductCategories { get; set; }

        public Product()
        {
            
        }
       

        public Product(int brandId, string title, string description, decimal price, decimal discount)
        {
            BrandId = brandId;
            Title = title;
            Description = description;
            Price = price;
            Discount = discount;
        }
    }
}
