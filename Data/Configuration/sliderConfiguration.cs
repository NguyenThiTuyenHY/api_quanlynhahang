using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class sliderConfiguration : IEntityTypeConfiguration<slider>
    {
        public void Configure(EntityTypeBuilder<slider> builder)
        {
            builder.ToTable("sliders");
            builder.HasKey(x => x.id);
            builder.Property(x => x.td1).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.td2).IsUnicode().HasMaxLength(500);
            builder.Property(x => x.url).IsUnicode().HasMaxLength(4000);
        }
    }
}
