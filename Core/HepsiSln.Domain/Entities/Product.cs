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
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IList<Category> Categories { get; set; }

        public Product()
        {
            
        }
        public Product(string Title,string Description,Guid BrandId,decimal Price, decimal Discount)
        {
            this.Title = Title;
            this.Description = Description;
            this.BrandId = BrandId;
            this.Price = Price;
            this.Discount = Discount;
            
        }
    }
}
