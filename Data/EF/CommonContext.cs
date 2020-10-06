using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Configuration;
using Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data.EF
{
    public class CommonContext : DbContext
    {
        public CommonContext(DbContextOptions<CommonContext> opt):base(opt){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configuration using Fluent API
            modelBuilder.ApplyConfiguration(new bananConfiguration());
            modelBuilder.ApplyConfiguration(new nhanvienConfiguration());
            modelBuilder.ApplyConfiguration(new khachhangConfiguration());
            modelBuilder.ApplyConfiguration(new bophanConfiguration());
            modelBuilder.ApplyConfiguration(new phieugoimonConfiguration());
            modelBuilder.ApplyConfiguration(new calamConfiguration());
            modelBuilder.ApplyConfiguration(new donhangConfiguration());
            modelBuilder.ApplyConfiguration(new chitietdonhangConfiguration());
            modelBuilder.ApplyConfiguration(new loaimonConfiguration());
            modelBuilder.ApplyConfiguration(new monanConfiguration());
            modelBuilder.ApplyConfiguration(new khachthanhtoanConfiguration());
            modelBuilder.ApplyConfiguration(new binhluanConfiguration());
            modelBuilder.ApplyConfiguration(new nvcaConfiguration());
            modelBuilder.ApplyConfiguration(new sliderConfiguration());
            modelBuilder.ApplyConfiguration(new userConfiguration());
            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<loaimon> loaimons { get; set; }
        public DbSet<monan>monans { get; set; }
        public DbSet<banan> banans { get; set; }
        public DbSet<bophan> bophans { get; set; }
        public DbSet<khachhang> Khachhangs { get; set; }
        public DbSet<nhanvien>nhanviens { get; set; }
        public DbSet<calam> calams { get; set; }
        public DbSet<donhang>donhangs { get; set; }
        public DbSet<chitietdonhang>chitietdonhangs { get; set; }
        public DbSet<phieugoimon> phieugoimons { get; set; }
        public DbSet<chitietgoimon>chitietgoimons { get; set; }
        public DbSet<khachthanhtoan>khachthanhtoans { get; set; }
        public DbSet<slider> sliders { get; set; }
        public DbSet<user>users { get; set; }
    }
}
