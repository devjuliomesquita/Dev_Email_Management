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
    public class BusinessCityConfiguration : IEntityTypeConfiguration<BusinessCity>
    {
        public void Configure(EntityTypeBuilder<BusinessCity> builder)
        {
            builder
                .HasKey(bc => bc.BusinessCityId);
            builder
                .ToTable("City");
            builder
                .Property(bc => bc.City)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
