using HepsiSln.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiSln.Domain.Entities
{
    public class Detail : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Detail()
        {
            
        }
        public Detail(string Title,string Description,Guid CategoryId)
        {
            this.Title = Title;
            this.Description = Description;
            this.CategoryId = CategoryId;
        }
    }
    
}
