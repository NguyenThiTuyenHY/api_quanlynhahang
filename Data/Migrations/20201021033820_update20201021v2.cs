using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class update20201021v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tenkhach",
                table: "donhang",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "fa94163e-c163-4f79-bd43-dfa8249b76ae");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09a2b370-a39a-4311-bf5e-fb4e2afa4d94", "AQAAAAEAACcQAAAAEKovSOuyh/BvY7J6kCj8eNpg6uV/ce7QP8App5+aqbXcmmKgybDLsQ5gESAu9TOB6g==" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 38, 19, 185, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 38, 19, 185, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 38, 19, 185, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 38, 19, 185, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "gia", "mota", "ngaynhap" },
                values: new object[] { 20000, "Cập nhật sau", new DateTime(2020, 10, 21, 10, 38, 19, 185, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 38, 19, 183, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 38, 19, 184, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 38, 19, 184, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 21, 10, 38, 19, 184, DateTimeKind.Local).AddTicks(9415));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tenkhach",
                table: "donhang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true);

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
    }
}
