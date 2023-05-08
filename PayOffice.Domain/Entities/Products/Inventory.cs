using PayOffice.Domain.Commons;

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
