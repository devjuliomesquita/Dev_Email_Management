using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Infrastructure.Repositories
{
    public class BusinessPhoneRepository : RepositoryBase<BusinessPhone>, IBusinessPhoneRepository
    {
        public BusinessPhoneRepository(Dev_Email_ManagementContext context) : base(context)
        {
        }
    }
}
