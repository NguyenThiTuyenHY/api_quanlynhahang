using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class khachhangConfiguration : IEntityTypeConfiguration<khachhang>
    {
        public void Configure(EntityTypeBuilder<khachhang> builder)
        {
            builder.ToTable("khachhangs");
            builder.HasKey(x => x.id);
            builder.Property(x => x.tenkh).IsRequired().HasMaxLength(255).IsUnicode();
            builder.Property(x => x.sdt).IsRequired().HasMaxLength(10).IsUnicode();
            builder.Property(x => x.diachi).IsRequired().HasMaxLength(500).IsUnicode();
        }
    }
}
