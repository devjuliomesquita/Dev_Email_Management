﻿using Dev_Email_Management.Domain.Entities;
using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Infrastructure.Repositories
{
    public class BusinessPhoneRepository : RepositoryBase<BusinessPhone>, IBusinessPhoneRepository
    {
        private readonly DbContextOptions<Dev_Email_ManagementContext> _context;
        public BusinessPhoneRepository()
        {
            _context = new DbContextOptions<Dev_Email_ManagementContext>();
        }
    }
}
