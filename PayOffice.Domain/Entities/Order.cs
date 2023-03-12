using PayOffice.Domain.Commons;

namespace PayOffice.Domain.Entities
{
    public class Order : Auditable
    {
        public string CompanyName { get; set; }
        public string AgentName { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;
        public DateTime OrderArriveTime { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
