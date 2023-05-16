using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOffice.Service.Exceptions
{
    public class PayOfficeException : Exception
    {
        public int Code { get; set; }
        public PayOfficeException(int code, string message = "something wrong")
            : base(message)
        {
            Code = code;
        }
    }
}
