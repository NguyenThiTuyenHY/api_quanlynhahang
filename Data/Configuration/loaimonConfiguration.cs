using System;
using System.Collections.Generic;
using System.Text;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class loaimonConfiguration : IEntityTypeConfiguration<loaimon>
    {
        public void Configure(EntityTypeBuilder<loaimon> builder)
        {
            builder.ToTable("loaimons");
            builder.HasKey(x => x.id);
            builder.Property(x => x.tenloai).IsRequired().IsUnicode();
        }
    }
}
