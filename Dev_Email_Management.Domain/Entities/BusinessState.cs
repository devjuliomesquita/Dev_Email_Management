using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Entities
{
    public class BusinessState
    {
        public BusinessState(string state, int businessId)
        {
            State = state;
            BusinessId = businessId;
        }

        public int BusinessStateId { get; private set; }
        public string State { get; private set; }
        public int BusinessId { get; private set; }
    }
}
