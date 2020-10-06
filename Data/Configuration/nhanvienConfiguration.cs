using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Data.Configuration
{
    class nhanvienConfiguration : IEntityTypeConfiguration<nhanvien>
    {
        public void Configure(EntityTypeBuilder<nhanvien> builder)
        {
            builder.ToTable("nhanviens");
            builder.HasKey(x => x.id);
            builder.HasOne(nv => nv.bophan).WithMany(bp => bp.nhanviens).HasForeignKey(nv => nv.idbophan);
            builder.Property(x => x.hoten).IsUnicode().IsRequired().HasMaxLength(255);
            builder.Property(x => x.sdt).IsRequired().HasMaxLength(10);
            builder.Property(x => x.diachi).IsRequired().IsUnicode().HasMaxLength(4000);
            builder.Property(x => x.gianhap).IsUnicode().HasDefaultValueSql("GetDate()");
        }
    }
}
