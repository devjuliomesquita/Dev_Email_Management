using Dev_Email_Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Infrastructure.Persistence.Context
{
    public class Dev_Email_ManagementContext : DbContext
    {
        public Dev_Email_ManagementContext(DbContextOptions<Dev_Email_ManagementContext> options) : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessCity> Cities { get; set; }
        public DbSet<BusinessState> States { get; set; }
        public DbSet<BusinessEmail> Emails { get; set; }
        public DbSet<BusinessPhone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
