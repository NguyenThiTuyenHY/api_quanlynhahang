using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Data.Configuration
{
    public class bananConfiguration : IEntityTypeConfiguration<banan>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<banan> builder)
        {
            builder.ToTable("banans");
            builder.HasKey(x => x.id);
            builder.Property(x => x.soghe).IsRequired();
            builder.Property(x => x.tinhtrang).IsRequired();
        }
    }
}
