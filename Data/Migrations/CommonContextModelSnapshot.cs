﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(CommonContext))]
    partial class CommonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api_quanlynhahang.Entities.banan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("makh")
                        .HasColumnType("int");

                    b.Property<int>("soghe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("tinhtrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.ToTable("banans");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.binhluan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("iduser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngaybinhluan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("noidung")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.Property<int>("rate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.ToTable("binhluans");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.bophan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenbp")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("id");

                    b.ToTable("bophans");

                    b.HasData(
                        new
                        {
                            id = 1,
                            tenbp = "Quản lý nhà hàng"
                        },
                        new
                        {
                            id = 2,
                            tenbp = "Bộ phận Lễ tân"
                        },
                        new
                        {
                            id = 3,
                            tenbp = "Bộ phận Phục Vụ"
                        },
                        new
                        {
                            id = 4,
                            tenbp = "Bộ phận Bếp"
                        });
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.calam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ghichu")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<string>("giobd")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("giokt")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("tenca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("calams");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.chitietdonhang", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("gia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("iddh")
                        .HasColumnType("int");

                    b.Property<int>("idmon")
                        .HasColumnType("int");

                    b.Property<int>("soluong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.HasIndex("iddh");

                    b.HasIndex("idmon")
                        .IsUnique();

                    b.ToTable("chitietdonhangs");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.chitietgoimon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("gia")
                        .HasColumnType("int");

                    b.Property<int>("idmon")
                        .HasColumnType("int");

                    b.Property<int>("idpgm")
                        .HasColumnType("int");

                    b.Property<int>("soluong")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("chitietgoimons");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.donhang", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachigiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.Property<int?>("idkhach")
                        .HasColumnType("int");

                    b.Property<string>("sdtgiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("tinhtrang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("tongtien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.ToTable("donhang");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.khachhang", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<string>("sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(true);

                    b.Property<string>("tenkh")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("id");

                    b.ToTable("khachhangs");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.khachthanhtoan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("giott")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("hinhthuctt")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<int?>("idkhach")
                        .HasColumnType("int");

                    b.Property<int>("idnv")
                        .HasColumnType("int");

                    b.Property<int>("idphieu")
                        .HasColumnType("int");

                    b.Property<int>("sotien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("id");

                    b.HasIndex("idnv")
                        .IsUnique();

                    b.HasIndex("idphieu")
                        .IsUnique();

                    b.ToTable("khachthanhtoans");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.loaimon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenloai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .IsUnicode(true);

                    b.HasKey("id");

                    b.ToTable("loaimons");

                    b.HasData(
                        new
                        {
                            id = 1,
                            tenloai = "Món chính"
                        },
                        new
                        {
                            id = 2,
                            tenloai = "Món phụ"
                        },
                        new
                        {
                            id = 3,
                            tenloai = "Món khai vị"
                        });
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.monan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("donvitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<int>("gia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("hinhanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<int>("idloaimon")
                        .HasColumnType("int");

                    b.Property<string>("mota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(true)
                        .HasDefaultValue("Đang cập nhật");

                    b.Property<string>("tenmon")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("id");

                    b.HasIndex("idloaimon");

                    b.ToTable("monans");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.nhanvien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.Property<DateTime>("gianhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()")
                        .IsUnicode(true);

                    b.Property<int>("gioitinh")
                        .HasColumnType("int");

                    b.Property<string>("hoten")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<int>("idbophan")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.HasIndex("idbophan");

                    b.ToTable("nhanviens");

                    b.HasData(
                        new
                        {
                            id = 1,
                            diachi = "Đồng Tiến - Khoái Châu - Hưng Yên",
                            gianhap = new DateTime(2020, 10, 6, 21, 59, 56, 829, DateTimeKind.Local).AddTicks(4832),
                            gioitinh = 1,
                            hoten = "Triệu Tiểu Đường",
                            idbophan = 1,
                            ngaysinh = new DateTime(1995, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sdt = "0914557400"
                        },
                        new
                        {
                            id = 2,
                            diachi = "Hồng Hà - Yên Bái - Yên Bái",
                            gianhap = new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(6972),
                            gioitinh = 1,
                            hoten = "Ngu Thư Hân",
                            idbophan = 2,
                            ngaysinh = new DateTime(1997, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sdt = "0914557401"
                        },
                        new
                        {
                            id = 3,
                            diachi = "Đồng Tiến - Khoái Châu - Hưng Yên",
                            gianhap = new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7018),
                            gioitinh = 1,
                            hoten = "Dụ Ngôn",
                            idbophan = 3,
                            ngaysinh = new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sdt = "0914557402"
                        },
                        new
                        {
                            id = 4,
                            diachi = "Đồng Tiến - Khoái Châu - Hưng Yên",
                            gianhap = new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7021),
                            gioitinh = 1,
                            hoten = "Lục Khả Nhiên",
                            idbophan = 1,
                            ngaysinh = new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sdt = "0914557403"
                        });
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.nvca", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idca")
                        .HasColumnType("int");

                    b.Property<int>("idnv")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngaydk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("nhanvienid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idca");

                    b.HasIndex("nhanvienid");

                    b.ToTable("nvcas");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.phieugoimon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("giogoi")
                        .HasColumnType("datetime2");

                    b.Property<int>("idkhach")
                        .HasColumnType("int");

                    b.Property<int>("soban")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("phieugoimons");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.slider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("td1")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<string>("td2")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.HasKey("id");

                    b.ToTable("sliders");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("chucvu")
                        .HasColumnType("int");

                    b.Property<string>("diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("hinhanh")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("hoten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.chitietdonhang", b =>
                {
                    b.HasOne("api_quanlynhahang.Entities.donhang", "donhang")
                        .WithMany("chitietdonhangs")
                        .HasForeignKey("iddh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_quanlynhahang.Entities.monan", "monan")
                        .WithOne("chitietdonhang")
                        .HasForeignKey("api_quanlynhahang.Entities.chitietdonhang", "idmon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.khachthanhtoan", b =>
                {
                    b.HasOne("api_quanlynhahang.Entities.nhanvien", "nhanvien")
                        .WithOne("khachthanhtoan")
                        .HasForeignKey("api_quanlynhahang.Entities.khachthanhtoan", "idnv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_quanlynhahang.Entities.phieugoimon", "phieugoimon")
                        .WithOne("khachthanhtoan")
                        .HasForeignKey("api_quanlynhahang.Entities.khachthanhtoan", "idphieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.monan", b =>
                {
                    b.HasOne("api_quanlynhahang.Entities.loaimon", "loaimon")
                        .WithMany("monans")
                        .HasForeignKey("idloaimon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.nhanvien", b =>
                {
                    b.HasOne("api_quanlynhahang.Entities.bophan", "bophan")
                        .WithMany("nhanviens")
                        .HasForeignKey("idbophan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_quanlynhahang.Entities.nvca", b =>
                {
                    b.HasOne("api_quanlynhahang.Entities.calam", "calam")
                        .WithMany("nvca")
                        .HasForeignKey("idca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_quanlynhahang.Entities.nhanvien", null)
                        .WithMany("nvca")
                        .HasForeignKey("nhanvienid");
                });
#pragma warning restore 612, 618
        }
    }
}
