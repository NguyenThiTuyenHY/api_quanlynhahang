using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "bophans",
                columns: new[] { "id", "tenbp" },
                values: new object[,]
                {
                    { 1, "Quản lý nhà hàng" },
                    { 2, "Bộ phận Lễ tân" },
                    { 3, "Bộ phận Phục Vụ" },
                    { 4, "Bộ phận Bếp" }
                });

            migrationBuilder.InsertData(
                table: "loaimons",
                columns: new[] { "id", "tenloai" },
                values: new object[,]
                {
                    { 1, "Món chính" },
                    { 2, "Món phụ" },
                    { 3, "Món khai vị" }
                });

            migrationBuilder.InsertData(
                table: "nhanviens",
                columns: new[] { "id", "diachi", "gianhap", "gioitinh", "hoten", "idbophan", "ngaysinh", "sdt" },
                values: new object[,]
                {
                    { 1, "Đồng Tiến - Khoái Châu - Hưng Yên", new DateTime(2020, 10, 6, 21, 59, 56, 829, DateTimeKind.Local).AddTicks(4832), 1, "Triệu Tiểu Đường", 1, new DateTime(1995, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914557400" },
                    { 4, "Đồng Tiến - Khoái Châu - Hưng Yên", new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7021), 1, "Lục Khả Nhiên", 1, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914557403" },
                    { 2, "Hồng Hà - Yên Bái - Yên Bái", new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(6972), 1, "Ngu Thư Hân", 2, new DateTime(1997, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914557401" },
                    { 3, "Đồng Tiến - Khoái Châu - Hưng Yên", new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7018), 1, "Dụ Ngôn", 3, new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0914557402" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "bophans",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "loaimons",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "loaimons",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "loaimons",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "bophans",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "bophans",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "bophans",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
