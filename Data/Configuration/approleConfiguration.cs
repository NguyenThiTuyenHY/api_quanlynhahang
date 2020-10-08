using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class approleConfiguration : IEntityTypeConfiguration<approle>
    {
        public void Configure(EntityTypeBuilder<approle> builder)
        {
            builder.ToTable("approles");
            builder.Property(x => x.mieuta).HasMaxLength(200);
        }
    }
}
