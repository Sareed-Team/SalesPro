using PayOffice.Domain.Commons;
using PayOffice.Domain.Enums;

namespace PayOffice.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public string CompanyName { get; set; }
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }
        public string OrderNames { get; set; }
        public decimal Price { get; set; }
        public OrderPaymentType PaymentType { get; set; }
        public DateTime InComeDay { get; set; }
        public OrderStatus Status { get; set; }
    }
}
