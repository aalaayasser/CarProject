﻿using DALProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Data.Configartions
{
    internal class CarConfigration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.KiloMetres)
             .IsRequired()
             .HasColumnType("bigint"); // تحويل لـ bigint

            builder.Property(c => c.Description)
            .HasColumnType("text"); // تحويل لـ varchar
        }
    }

}