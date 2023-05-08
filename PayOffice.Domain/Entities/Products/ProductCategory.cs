using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities.Products
{
    public class ProductCategory : Auditable
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
