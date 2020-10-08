using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AspNetCore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "approles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    mieuta = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_approles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "appusers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appusers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserTokens", x => x.UserId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "approles");

            migrationBuilder.DropTable(
                name: "appusers");

            migrationBuilder.DropTable(
                name: "IdentityRoleClaims");

            migrationBuilder.DropTable(
                name: "IdentityUserClaims");

            migrationBuilder.DropTable(
                name: "IdentityUserLogins");

            migrationBuilder.DropTable(
                name: "IdentityUserRoles");

            migrationBuilder.DropTable(
                name: "IdentityUserTokens");

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 1,
                column: "gianhap",
                value: new DateTime(2020, 10, 6, 21, 59, 56, 829, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 2,
                column: "gianhap",
                value: new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 3,
                column: "gianhap",
                value: new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "nhanviens",
                keyColumn: "id",
                keyValue: 4,
                column: "gianhap",
                value: new DateTime(2020, 10, 6, 21, 59, 56, 830, DateTimeKind.Local).AddTicks(7021));
        }
    }
}
