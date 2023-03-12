using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities
{
    public class GiveMoney : Auditable
    {
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}