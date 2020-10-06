using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace Data.Configuration
{
    class khachthanhtoanConfiguration : IEntityTypeConfiguration<khachthanhtoan>
    {
        public void Configure(EntityTypeBuilder<khachthanhtoan> builder)
        {
            builder.ToTable("khachthanhtoans");
            builder.HasKey(x => x.id);
            builder.HasOne(ktt => ktt.phieugoimon).WithOne(pgm => pgm.khachthanhtoan).HasForeignKey<khachthanhtoan>(ktt => ktt.idphieu);
            builder.HasOne(ktt => ktt.nhanvien).WithOne(pgm => pgm.khachthanhtoan).HasForeignKey<khachthanhtoan>(x => x.idnv);
            builder.Property(x => x.giott).HasDefaultValueSql("GetDate()");
            builder.Property(x => x.hinhthuctt).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.sotien).HasDefaultValue(0);
        }
    }
}
