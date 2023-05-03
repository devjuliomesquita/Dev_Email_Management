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
    public class BusinessStateService : IBusinessStateService
    {
        private readonly IBusinessStateService _IbusinessStateService;
        public BusinessStateService(IBusinessStateService businessStateService)
        {
            _IbusinessStateService = businessStateService;
        }
    }
}
