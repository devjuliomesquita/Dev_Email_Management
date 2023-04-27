using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Entities
{
    public class BusinessPhone
    {
        public BusinessPhone(string phone, int businessId)
        {
            Phone = phone;
            BusinessId = businessId;
        }

        public int BusinessPhoneId { get; private set; }
        public string Phone { get; private set; }
        public int BusinessId { get; private set; }
    }
}
