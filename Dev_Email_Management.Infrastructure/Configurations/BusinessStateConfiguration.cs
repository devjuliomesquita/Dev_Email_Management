using Dev_Email_Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Email_Management.Infrastructure.Configurations
{
    public class BusinessStateConfiguration : IEntityTypeConfiguration<BusinessState>
    {
        public void Configure(EntityTypeBuilder<BusinessState> builder)
        {
            builder
                .HasKey(bs => bs.BusinessStateId);
            builder
                .ToTable("State");
            builder
                .Property(bs => bs.State)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
