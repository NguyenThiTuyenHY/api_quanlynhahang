using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net.Http;

namespace Data.Configuration
{
    public class chitietdonhangConfiguration : IEntityTypeConfiguration<chitietdonhang>
    {
        public void Configure(EntityTypeBuilder<chitietdonhang> builder)
        {
            builder.ToTable("chitietdonhangs");
            builder.HasKey(x => x.id);
            builder.HasOne(ctdh => ctdh.donhang).WithMany(dh=>dh.chitietdonhangs).HasForeignKey(ctdh=>ctdh.iddh);
            builder.HasOne(ctdh => ctdh.monan).WithOne(ma => ma.chitietdonhang).HasForeignKey<chitietdonhang>(ctdh => ctdh.idmon);
            builder.Property(x => x.soluong).HasDefaultValue(0);
            builder.Property(x => x.gia).HasDefaultValue(0);
        }
    }
}
