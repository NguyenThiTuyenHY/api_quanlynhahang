using api_quanlynhahang.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class appuser:IdentityUser<Guid>
    {
        public DateTime Day { get; set; }
    }
}
