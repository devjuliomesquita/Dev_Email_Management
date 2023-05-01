using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Entities
{
    public class Business
    {
        public Business(string businessName)
        {
            BusinessName = businessName;

            BusinessNNI = false;
            Active = true;
            CreatedAt = DateTime.Now;
            Cities = new List<BusinessCity>();
            States = new List<BusinessState>();
            Emails = new List<BusinessEmail>();
            Phones = new List<BusinessPhone>();
        }

        public int BusinessId { get; private set; }
        public string BusinessName { get; private set; }
        public bool BusinessNNI { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime CanceledAt { get; private set; }
        public List<BusinessCity> Cities { get; private set; }
        public List<BusinessState> States { get; private set; }
        public List<BusinessEmail> Emails { get; private set; }
        public List<BusinessPhone> Phones { get; private set; }

        public void Update(string businessName, bool businessNNI)
        {
            BusinessName = businessName;
            BusinessNNI = businessNNI;
        }
        public void Cancel(Business business) 
        {
            if(Active == true)
            {
                Active = false;
                CanceledAt = DateTime.Now;
            }
        }
        public bool BusinessEspec(Business business)
        {
            return business.Active && DateTime.Now.Year - CreatedAt.Year < 1;
        }
    }
}
