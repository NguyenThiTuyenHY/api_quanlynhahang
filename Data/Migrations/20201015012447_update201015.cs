using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class update201015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "3fcc3b2c-75f0-47d0-8a62-46e1fe8c9e0f");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18ed1c09-8b54-4467-9162-465ee6e88b06", "AQAAAAEAACcQAAAAENIKYWOIkkiRBQ1sHcSLpmXmC2ZuUcWvrEWfUV3AK3unl5utrpFfSIw/P03yuJXrFQ==" });

            migrationBuilder.InsertData(
                table: "loaimons",
                columns: new[] { "id", "tenloai" },
                values: new object[] { 4, "Món tráng miệng" });

            migrationBuilder.InsertData(
                table: "monans",
                columns: new[] { "id", "donvitinh", "gia", "hinhanh", "idloaimon", "mota", "tenmon" },
                values: new object[,]
                {
                    { 1, "đĩa", 20000, "bach-tuoc-nuong-900x600.jpg", 2, "Cập nhật sau", "Bạch tuộc nướng" },
                    { 2, "đĩa", 20000, "banh-cuon-900x587.jpg", 2, "Cập nhật sau", "Bánh cuốn" }
                });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 24, 47, 199, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 24, 47, 200, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 24, 47, 200, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 24, 47, 200, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.InsertData(
                table: "monans",
                columns: new[] { "id", "donvitinh", "gia", "hinhanh", "idloaimon", "mota", "tenmon" },
                values: new object[] { 3, "đĩa", 20000, "anh-caramen.jpg", 4, "Cập nhật sau", "Caramen" });

            migrationBuilder.InsertData(
                table: "monans",
                columns: new[] { "id", "donvitinh", "gia", "hinhanh", "idloaimon", "mota", "tenmon" },
                values: new object[] { 4, "đĩa", 20000, "bulgogi1.jpg", 4, "Cập nhật sau", "bulgogi vị dâu" });

            migrationBuilder.InsertData(
                table: "monans",
                columns: new[] { "id", "donvitinh", "gia", "hinhanh", "idloaimon", "mota", "tenmon" },
                values: new object[] { 5, "đĩa", 20000, "bulgogi2.jpg", 4, "Cập nhật sau", "bulgogi vị cam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "monans",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "monans",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "monans",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "monans",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "monans",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "loaimons",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "324c36a3-c450-4775-bbb6-da82e9a37cee");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56d71188-f451-4fb5-a401-868dca1fc56d", "AQAAAAEAACcQAAAAEKFdMXweEKLYrrw0ygreXl4G1rr5CM7rIVDfpK+LwqiEXEc0HcJ2dTkzpntkGeTwBQ==" });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 5, 18, 361, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 5, 18, 362, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 5, 18, 362, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 5, 18, 362, DateTimeKind.Local).AddTicks(9854));
        }
    }
}
