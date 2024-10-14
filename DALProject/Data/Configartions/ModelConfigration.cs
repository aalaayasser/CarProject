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
    internal class ModelConfigration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(m => m.ModelName)
           .IsRequired()
           .HasColumnType("text"); // تحويل لـ text
        }
    }
}
