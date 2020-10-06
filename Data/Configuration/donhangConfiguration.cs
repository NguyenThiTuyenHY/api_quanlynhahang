using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class donhangConfiguration : IEntityTypeConfiguration<donhang>
    {
        public void Configure(EntityTypeBuilder<donhang> builder)
        {
            builder.ToTable("donhang");
            builder.Property(x => x.sdtgiao).HasMaxLength(10).IsRequired();
            builder.Property(x => x.diachigiao).HasMaxLength(4000).IsUnicode().IsRequired();
            builder.Property(x => x.tongtien).HasDefaultValue(0);
            builder.Property(x => x.tinhtrang).HasDefaultValue(0);
        }
    }
}
