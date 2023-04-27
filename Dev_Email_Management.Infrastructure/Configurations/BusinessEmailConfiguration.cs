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
    public class BusinessEmailConfiguration : IEntityTypeConfiguration<BusinessEmail>
    {
        public void Configure(EntityTypeBuilder<BusinessEmail> builder)
        {
            builder
                .HasKey(be => be.BusinessEmailId);
            builder
                .ToTable("Email");
            builder
                .Property(be => be.Email)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
