using api_quanlynhahang.Entities;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Extensions
{
    public static class ModelBuildExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<bananConfiguration>().HasData(
            //        new banan() { id = 1, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 2, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 3, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 4, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 5, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 6, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 7, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 8, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 9, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 10, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 11, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 12, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 13, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 14, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 15, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 16, makh = null, soghe = 12, tinhtrang = 0 },
            //        new banan() { id = 17, makh = null, soghe = 12, tinhtrang = 0 }
            //    );
            modelBuilder.Entity<bophan>().HasData(
                new bophan() { id= 1, tenbp = "Quản lý nhà hàng" },
                new bophan() { id = 2, tenbp = "Bộ phận Lễ tân"},
                new bophan() { id = 3, tenbp = "Bộ phận Phục Vụ" },
                new bophan() { id = 4, tenbp = "Bộ phận Bếp" }
                );
            modelBuilder.Entity<nhanvien>().HasData(
                new nhanvien() { id = 1, idbophan =1, hoten="Triệu Tiểu Đường", sdt ="0914557400", ngaysinh=new DateTime(1995,03,24), gioitinh = 1, diachi="Đồng Tiến - Khoái Châu - Hưng Yên", gianhap=DateTime.Now},
                new nhanvien() { id = 2, idbophan = 2, hoten = "Ngu Thư Hân", sdt = "0914557401", ngaysinh = new DateTime(1997, 03, 24), gioitinh = 1, diachi = "Hồng Hà - Yên Bái - Yên Bái", gianhap = DateTime.Now },
                new nhanvien() { id = 3, idbophan = 3, hoten = "Dụ Ngôn", sdt = "0914557402", ngaysinh = new DateTime(1997, 05, 25), gioitinh = 1, diachi = "Đồng Tiến - Khoái Châu - Hưng Yên", gianhap = DateTime.Now },
                new nhanvien() { id = 4, idbophan = 1, hoten = "Lục Khả Nhiên", sdt = "0914557403", ngaysinh = new DateTime(1995, 12, 12), gioitinh = 1, diachi = "Đồng Tiến - Khoái Châu - Hưng Yên", gianhap = DateTime.Now }
                );
            modelBuilder.Entity<loaimon>().HasData(
                new loaimon() { id = 1, tenloai ="Món chính"},
                new loaimon() { id = 2, tenloai = "Món phụ" },
                new loaimon() { id = 3, tenloai = "Món khai vị" }
                );
        }
    }
}
