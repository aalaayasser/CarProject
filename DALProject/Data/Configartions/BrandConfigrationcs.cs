using DALProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Data.Configartions
{
    internal class BrandConfigrationcs : IEntityTypeConfiguration<Brand>

    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(b => b.BrandName)
            .IsRequired()
            .HasColumnType("text"); // تحويل لـ text
        }
    }
}
