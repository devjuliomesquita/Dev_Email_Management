using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Domain.Services
{
    public class BusinessService : ServiceBase<Business>, IBusinessService
    {
        private readonly IBusinessService _businessService;
        public BusinessService(IRepositoryBase<Business> repository,
            IBusinessService businessService) : base(repository)
        {
            _businessService = businessService;
        }

        public IEnumerable<Business> BusinessEspec(IEnumerable<Business> businesses)
        {
            return businesses.Where(b => b.BusinessEspec(b));
        }

        public IEnumerable<Business> GetByName(string name)
        {
            return _businessService.GetByName(name);
        }
    }
}
