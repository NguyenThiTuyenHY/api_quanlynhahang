using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class calamConfiguration : IEntityTypeConfiguration<calam>
    {
        public void Configure(EntityTypeBuilder<calam> builder)
        {
            builder.ToTable("calams");
            builder.HasKey(x => x.id);
            builder.Property(x => x.giobd).HasMaxLength(100);
            builder.Property(x => x.giokt).HasMaxLength(100);
            builder.Property(x => x.ghichu).HasMaxLength(255).IsUnicode();
        }
    }
}
