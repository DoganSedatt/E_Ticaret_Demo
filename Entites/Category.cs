using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Category:BaseEntity<Guid>
    {
        public string CategoryName { get; set; }
        public virtual ICollection<ProductCategory> Products { get; set; }

    }
}
