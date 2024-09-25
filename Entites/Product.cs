using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Product:BaseEntity<Guid>
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<ProductCategory> Categories { get; set; }
    }
}
