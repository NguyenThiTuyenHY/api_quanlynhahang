using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IdentityUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"), new Guid("dde4ba55-808e-479f-be8b-72f69913442f") });

            migrationBuilder.InsertData(
                table: "approles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "mieuta" },
                values: new object[] { new Guid("dde4ba55-808e-479f-be8b-72f69913442f"), "c6584667-38a8-49dd-b8bb-c1551c683936", "admin", "admin", null });

            migrationBuilder.InsertData(
                table: "appusers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Day", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"), 0, "1df94b9b-c8fd-4265-8cab-68f40506878c", new DateTime(1999, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "trangchatrang98@gmail.com", true, false, null, "trangchatrang98@gmail.com", "admin", "AQAAAAEAACcQAAAAEJIsDmiubIJpXZlI4Lvm+tezjBYmSBZ7k7fW7ow6bjbyEWrdRBWXshLvvanUq/FYxQ==", null, false, "", false, "admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"), new Guid("dde4ba55-808e-479f-be8b-72f69913442f") });

            migrationBuilder.DeleteData(
                table: "approles",
                keyColumn: "Id",
                keyValue: new Guid("dde4ba55-808e-479f-be8b-72f69913442f"));

            migrationBuilder.DeleteData(
                table: "appusers",
                keyColumn: "Id",
                keyValue: new Guid("06e12df2-49ec-4f5a-9d45-fd714ebca62e"));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 7, 21, 50, 31, 961, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 7, 21, 50, 31, 962, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 7, 21, 50, 31, 962, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 7, 21, 50, 31, 962, DateTimeKind.Local).AddTicks(2397));
        }
    }
}
