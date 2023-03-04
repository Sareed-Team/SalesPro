
using PayOffice.Domain.Commons;
using PayOffice.Domain.Enums;

namespace PayOffice.Domain.Entities
{
    public class OrderPanel : Auditable
    {
        public string ProductName { get; set; }
        public string FirmName { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public DateTime ArriveTime { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentType Payment { get; set; }
    }
}
