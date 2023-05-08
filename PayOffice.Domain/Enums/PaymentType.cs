using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Domain.Enums
{
    public enum PaymentType : byte
    {
        Cash,
        HumoCard,
        UzCard,
        Online,
        Credit
    }
}
