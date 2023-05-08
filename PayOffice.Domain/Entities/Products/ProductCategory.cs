using PayOffice.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Domain.Entities.Products
{
    public class ProductCategory : Auditable
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
