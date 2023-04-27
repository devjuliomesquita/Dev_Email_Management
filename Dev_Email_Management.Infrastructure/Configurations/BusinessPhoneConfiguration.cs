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
    public class BusinessPhoneConfiguration : IEntityTypeConfiguration<BusinessPhone>
    {
        public void Configure(EntityTypeBuilder<BusinessPhone> builder)
        {
            builder
                .HasKey(bp => bp.BusinessPhoneId);
            builder
                .ToTable("Phone");
            builder
                .Property(bp => bp.Phone)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
