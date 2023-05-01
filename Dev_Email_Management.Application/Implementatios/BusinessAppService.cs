using Dev_Email_Management.Application.Interfaces;
using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Application.Implementatios
{
    public class BusinessAppService : AppServiceBase<Business>, IBusinessAppService
    {
        private readonly IBusinessAppService _businessAppService;

        public BusinessAppService(IServiceBase<Business> service, IBusinessAppService businessAppService) : base(service)
        {
            _businessAppService = businessAppService;
        }

        public IEnumerable<Business> BusinessEspec(IEnumerable<Business> businesses)
        {
            return _businessAppService.BusinessEspec(businesses);
        }

        public IEnumerable<Business> GetByName(string name)
        {
            return _businessAppService.GetByName(name);
        }
    }
}
