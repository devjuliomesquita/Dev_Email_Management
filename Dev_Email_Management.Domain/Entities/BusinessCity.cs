using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Entities
{
    public class BusinessCity
    {
        public BusinessCity(string city, int businessId)
        {
            City = city;
            BusinessId = businessId;
        }

        public int BusinessCityId { get; private set; }
        public string City { get; private set; }
        public int BusinessId { get; private set; }
    }
}
