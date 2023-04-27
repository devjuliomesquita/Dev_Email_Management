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
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasKey(b => b.BusinessId);
            builder
                .ToTable("Business");
            //Inicio do relacionamento de tabelas
            builder
                .HasMany(b => b.Cities)
                .WithOne()
                .HasForeignKey(b => b.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(b => b.States)
                .WithOne()
                .HasForeignKey(b => b.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(b => b.Emails)
                .WithOne()
                .HasForeignKey(b => b.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasMany(b => b.Phones)
                .WithOne()
                .HasForeignKey(b => b.BusinessId)
                .OnDelete(DeleteBehavior.Restrict);
            //Fim do relacionamento de tabelas
            builder
                .Property(b => b.BusinessName)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
