using PayOffice.Domain.Commons;
using PayOffice.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
