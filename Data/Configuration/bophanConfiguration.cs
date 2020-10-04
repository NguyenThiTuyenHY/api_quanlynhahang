using System;
using System.Collections.Generic;
using System.Text;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class bophanConfiguration : IEntityTypeConfiguration<bophan>
    {
        public void Configure(EntityTypeBuilder<bophan> builder)
        {
            builder.ToTable("bophans");
            builder.HasKey(x => x.id);
            builder.Property(x => x.tenbp).IsRequired().IsUnicode().HasMaxLength(255);
        }
    }
}
