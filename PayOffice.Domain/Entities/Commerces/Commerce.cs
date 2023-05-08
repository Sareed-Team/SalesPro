using PayOffice.Domain.Commons;
using PayOffice.Domain.Entities.Products;
using PayOffice.Domain.Entities.Users;
using PayOffice.Domain.Enums;

namespace PayOffice.Domain.Entities.Commerces
{
    public class Commerce : Auditable
    {
        public decimal Amount { get; set; }
        public PaymentType PaymentType { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
