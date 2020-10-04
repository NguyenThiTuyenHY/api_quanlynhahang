using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class donhangConfiguration : IEntityTypeConfiguration<donhang>
    {
        public void Configure(EntityTypeBuilder<donhang> builder)
        {
            builder.ToTable("chitietdonhangs");
        }
    }
}
