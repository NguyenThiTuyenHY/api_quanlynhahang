using System;
using System.Collections.Generic;
using System.Text;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class nvcaConfiguration : IEntityTypeConfiguration<nvca>
    {
        public void Configure(EntityTypeBuilder<nvca> builder)
        {
            builder.ToTable("nvcas");
            builder.HasKey(x => x.id);
            builder.HasOne(nvca => nvca.calam).WithMany(cl => cl.nvca).HasForeignKey(nvca => nvca.idca);
            builder.Property(x => x.ngaydk).HasDefaultValueSql("GetDate()");
        }
    }
}
