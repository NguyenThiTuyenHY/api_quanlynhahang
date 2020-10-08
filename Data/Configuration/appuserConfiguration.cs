using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class appuserConfiguration : IEntityTypeConfiguration<appuser>
    {
        public void Configure(EntityTypeBuilder<appuser> builder)
        {
            builder.ToTable("appusers");
        }
    }
}
