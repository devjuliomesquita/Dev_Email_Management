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
    public class BusinessEmailService : ServiceBase<BusinessEmail>, IBusinessEmailService
    {
        public BusinessEmailService(IRepositoryBase<BusinessEmail> repository) : base(repository)
        {
        }
    }
}
