using PayOffice.Domain.Commons;
using PayOffice.Domain.Enums;

namespace PayOffice.Domain.Entities
{
    public class Merchant : Auditable
    {
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole userRole { get; set; }
    }
}
