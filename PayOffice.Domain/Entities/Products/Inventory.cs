using PayOffice.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Domain.Entities.Products
{
    public class Inventory : Auditable
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        //Miqdori
        public int Amount { get; set; }
    }
}
