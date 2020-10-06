using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class userConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder)
        {
            builder.ToTable("users");
            builder.HasKey(x => x.id);
            builder.Property(x => x.sdt).HasMaxLength(10).IsRequired();
            builder.Property(x => x.diachi).IsRequired().HasMaxLength(500).IsUnicode();
            builder.Property(x => x.email).IsRequired().HasMaxLength(4000);
            builder.Property(x => x.password).IsRequired().HasMaxLength(4000);
            builder.Property(x => x.hinhanh).HasMaxLength(4000);
        }
    }
}
