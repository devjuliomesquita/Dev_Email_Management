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
    public class BusinessEmailService : IBusinessEmailService
    {
        private readonly IBusinessEmailService _IbusinessEmailService;
        public BusinessEmailService(IBusinessEmailService businessEmailService)
        {
            _IbusinessEmailService = businessEmailService;
        }
    }
}
