using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tintucs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tieude = table.Column<string>(maxLength: 500, nullable: true),
                    hinhanh = table.Column<string>(nullable: true),
                    tomtat = table.Column<string>(maxLength: 500, nullable: true),
                    noidung = table.Column<string>(maxLength: 4000, nullable: true),
                    luotxem = table.Column<int>(nullable: false, defaultValue: 0),
                    ngaydang = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tintucs", x => x.id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tintucs");

            migrationBuilder.UpdateData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"),
                column: "ConcurrencyStamp",
                value: "c6584667-38a8-49dd-b8bb-c1551c683936");

            migrationBuilder.UpdateData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1df94b9b-c8fd-4265-8cab-68f40506878c", "AQAAAAEAACcQAAAAEJIsDmiubIJpXZlI4Lvm+tezjBYmSBZ7k7fW7ow6bjbyEWrdRBWXshLvvanUq/FYxQ==" });

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 8, 12, 52, 33, 544, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 8, 12, 52, 33, 546, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 8, 12, 52, 33, 546, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 8, 12, 52, 33, 546, DateTimeKind.Local).AddTicks(196));
        }
    }
}
