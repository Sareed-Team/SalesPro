using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
    }
}
