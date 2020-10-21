using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class update20201021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tenkhach",
                table: "donhang",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "ca975913-1d56-410d-8f44-9154de4af049");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08e9570a-a244-4198-83c2-b520a285db47", "AQAAAAEAACcQAAAAEKqj9Dc/ahYb1E6ywqnaTi/zrxigd9Fer0+McBXLmKKcavGzZo0HB82yGMfJkwrMYg==" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 35, 19, 474, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 35, 19, 474, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 35, 19, 474, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 35, 19, 474, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 35, 19, 474, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 35, 19, 472, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 35, 19, 473, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 35, 19, 473, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 35, 19, 473, DateTimeKind.Local).AddTicks(5601));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tenkhach",
                table: "donhang");

            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "5537e1e7-ffa5-424c-adf0-f38e29260edb");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19904862-28d6-486e-a79e-7ca1b2f70c10", "AQAAAAEAACcQAAAAEKPetSzK7cuJUIaPss6WlEE0HotaVWMa+DU8EEkDD+atgEY6XtyK97xnpWrpzRxH0A==" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 15, 8, 53, 5, 799, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 15, 8, 53, 5, 799, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 15, 8, 53, 5, 799, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 15, 8, 53, 5, 799, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 15, 8, 53, 5, 799, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 53, 5, 797, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 53, 5, 798, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 53, 5, 798, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 15, 8, 53, 5, 798, DateTimeKind.Local).AddTicks(5516));
        }
    }
}
