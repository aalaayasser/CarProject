using DALProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Data.Configurations
{
    internal class TechnicalConfigurations : IEntityTypeConfiguration<Technical>
    {
        public void Configure(EntityTypeBuilder<Technical> builder)
        {
            builder.Property(e => e.Name)
             .IsRequired()
             .HasColumnType("varchar")
             .HasMaxLength(100);

            builder.Property(e => e.City)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(e => e.ContactNumber)
                .HasColumnType("bigint")
                .IsRequired();


            builder.Property(e => e.Availability)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(100);

            builder.Property(e => e.BirthDate)
               .IsRequired();

           
        }
    }
}

