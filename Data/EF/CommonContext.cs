﻿using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EF
{
    public class CommonContext : DbContext
    {
        public CommonContext(DbContextOptions<CommonContext> opt):base(opt){}
        DbSet<loaimon> loaimons { get; set; }
        DbSet<monan>monans { get; set; }
        DbSet<banan> banans { get; set; }
        DbSet<bophan> bophans { get; set; }
        DbSet<khachhang> Khachhangs { get; set; }
        DbSet<nhanvien>nhanviens { get; set; }
        DbSet<calam> calams { get; set; }
        DbSet<donhang>donhangs { get; set; }
        DbSet<chitietdonhang>chitietdonhangs { get; set; }
        DbSet<phieugoimon> phieugoimons { get; set; }
        DbSet<chitietgoimon>chitietgoimons { get; set; }
        DbSet<khachthanhtoan>khachthanhtoans { get; set; }
        DbSet<slider> sliders { get; set; }
        DbSet<user>users { get; set; }
    }
}