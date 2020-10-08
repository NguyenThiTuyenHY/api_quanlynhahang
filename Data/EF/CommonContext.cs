using api_quanlynhahang.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Configuration;
using Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Data.EF
{
    public class CommonContext : IdentityDbContext<appuser,approle,Guid>
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
            modelBuilder.ApplyConfiguration(new approleConfiguration());
            modelBuilder.ApplyConfiguration(new appuserConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("IdentityUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("IdentityUserRoles").HasKey(x=>new {x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("IdentityUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("IdentityRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("IdentityUserTokens").HasKey(x=>x.UserId);
            //Data seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
            //base.OnModelCreating(builder);
            var roleid = new Guid("DDE4BA55-808E-479F-BE8B-72F69913442F");
            var userid = new Guid("06E12DF2-49EC-4F5A-9D45-FD714EBCA62E");
            modelBuilder.Entity<approle>().HasData(new approle
            {
                Id = roleid,
                Name = "admin",
                NormalizedName = "admin"
            });

            var hasher = new PasswordHasher<appuser>();
            modelBuilder.Entity<appuser>().HasData(new appuser
            {
                Id = userid,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "trangchatrang98@gmail.com",
                NormalizedEmail = "trangchatrang98@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "a12345678"),
                SecurityStamp = string.Empty,
                Day = new DateTime(1999, 01, 30)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleid,
                UserId = userid
            });
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
