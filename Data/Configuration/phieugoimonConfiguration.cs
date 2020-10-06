using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Data.Configuration
{
    class phieugoimonConfiguration : IEntityTypeConfiguration<phieugoimon>
    {
        public void Configure(EntityTypeBuilder<phieugoimon> builder)
        {
            
        }
    }
}
