using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class tintucCofiguration : IEntityTypeConfiguration<tintuc>
    {
        public void Configure(EntityTypeBuilder<tintuc> builder)
        {
            builder.ToTable("tintucs");
            builder.HasKey(x => x.id);
            builder.Property(x => x.tieude).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.noidung).IsUnicode().HasMaxLength(4000);
            builder.Property(x => x.tomtat).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.ngaydang).HasDefaultValueSql("getdate()");
            builder.Property(x => x.luotxem).HasDefaultValue(0);
        }
    }
}
