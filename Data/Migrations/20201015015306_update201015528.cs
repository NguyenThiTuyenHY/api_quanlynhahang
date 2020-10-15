using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class update201015528 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ngaynhap",
                table: "monans",
                nullable: false,
                defaultValueSql: "getdate()");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ngaynhap",
                table: "monans");

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

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "gia", "mota" },
                values: new object[] { 20000, "Cập nhật sau" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "gia", "mota" },
                values: new object[] { 20000, "Cập nhật sau" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "gia", "mota" },
                values: new object[] { 20000, "Cập nhật sau" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "gia", "mota" },
                values: new object[] { 20000, "Cập nhật sau" });

            migrationBuilder.UpdateData(
                table: "monans",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "gia", "mota" },
                values: new object[] { 20000, "Cập nhật sau" });

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
        }
    }
}
