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
    public class BusinessRepository : RepositoryBase<Business>, IBusinessRepository
    {
        private readonly Dev_Email_ManagementContext _context;
        public BusinessRepository(Dev_Email_ManagementContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Business> GetByName(string name)
        {
            return _context.Businesses.Where(b => b.BusinessName == name);
        }
    }
}
