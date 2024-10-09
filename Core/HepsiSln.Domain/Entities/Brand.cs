using HepsiSln.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public IList<Product> Products { get; set; }

        public Brand()
        {
            
        }
        public Brand(string name)
        {
            Name = name;
        }
    }
}
