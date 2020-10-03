using System;
using System.Collections.Generic;
using System.Text;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class binhluanConfiguration : IEntityTypeConfiguration<binhluan>
    {
        public void Configure(EntityTypeBuilder<binhluan> builder)
        {
            builder.ToTable("binhluans");
            builder.HasKey(x => x.id);
            builder.Property(x => x.iduser).IsRequired();
            builder.Property(x => x.ngaybinhluan).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.rate).HasDefaultValue(0);
            builder.Property(x => x.noidung).IsRequired();
        }
    }
}
