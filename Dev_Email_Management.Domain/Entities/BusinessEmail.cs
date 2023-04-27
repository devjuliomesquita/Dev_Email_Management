using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Entities
{
    public class BusinessEmail
    {
        public BusinessEmail(string email, int businessId)
        {
            Email = email;
            BusinessId = businessId;
        }

        public int BusinessEmailId { get; private set; }
        public string Email { get; private set; }
        public int BusinessId { get; private set; }
    }
}
