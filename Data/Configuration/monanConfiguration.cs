using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace Data.Configuration
{
    public class monanConfiguration : IEntityTypeConfiguration<monan>
    {
        public void Configure(EntityTypeBuilder<monan> builder)
        {
            builder.ToTable("monans");
            builder.HasKey(x => x.id);
            builder.Property(x => x.tenmon).IsRequired().IsUnicode().HasMaxLength(255);
            builder.Property(x => x.donvitinh).IsRequired().IsUnicode().HasMaxLength(100);
            builder.Property(x => x.gia).HasDefaultValue(0);
            builder.Property(x => x.mota).HasDefaultValue("Đang cập nhật").IsUnicode().HasMaxLength(4000);
            builder.Property(x => x.hinhanh).IsRequired().HasMaxLength(4000);
            builder.Property(x => x.ngaynhap).HasDefaultValueSql("getdate()");
            builder.HasOne(ma => ma.loaimon).WithMany(l => l.monans).HasForeignKey(ma => ma.idloaimon);
        }
    }
}
