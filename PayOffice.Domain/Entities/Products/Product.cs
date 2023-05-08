using PayOffice.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Domain.Entities.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public long CategoryId { get; set; }
        public ProductCategory Category { get; set; }
    }
}
