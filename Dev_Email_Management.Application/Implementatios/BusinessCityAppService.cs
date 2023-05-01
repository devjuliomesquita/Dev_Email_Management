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
    public class BusinessCityAppService : AppServiceBase<BusinessCity>, IBusinessCityAppService
    {
        public BusinessCityAppService(IServiceBase<BusinessCity> service) : base(service)
        {
        }
    }
}
