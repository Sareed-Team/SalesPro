
using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities
{
    public class Warehouse : Auditable
    {
        public int NumberItems { get; set; }
        public long Code { get; set; }
        public long Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set;}
    }
}
