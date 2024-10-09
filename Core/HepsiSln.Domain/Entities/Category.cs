using HepsiSln.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }
        public IList<Detail> Details { get; set; }
        public IList<Product> Products { get; set; }

        public Category()
        {

        }
        public Category(Guid ParentId, string Name, int Priorty)
        {
            this.ParentId = ParentId;
            this.Name = Name;
            this.Priorty = Priorty;
        }
    }
}
