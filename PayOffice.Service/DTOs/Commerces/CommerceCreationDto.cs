using PayOffice.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Service.DTOs.Commerces
{
    public class CommerceCreationDto
    {
        public decimal Amount { get; set; }
        public PaymentType PaymentType { get; set; }
        public long UserId { get; set; }

    }
}
