using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Itatial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soghe = table.Column<int>(nullable: false, defaultValue: 0),
                    tinhtrang = table.Column<int>(nullable: false, defaultValue: 0),
                    makh = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "binhluans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iduser = table.Column<int>(nullable: false),
                    ngaybinhluan = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    noidung = table.Column<string>(maxLength: 4000, nullable: false),
                    rate = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_binhluans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bophans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenbp = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bophans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "calams",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenca = table.Column<string>(nullable: true),
                    giobd = table.Column<string>(maxLength: 100, nullable: true),
                    giokt = table.Column<string>(maxLength: 100, nullable: true),
                    ghichu = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "chitietgoimons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idpgm = table.Column<int>(nullable: false),
                    idmon = table.Column<int>(nullable: false),
                    soluong = table.Column<int>(nullable: false),
                    gia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitietgoimons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "donhang",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idkhach = table.Column<int>(nullable: true),
                    tinhtrang = table.Column<int>(nullable: false, defaultValue: 0),
                    sdtgiao = table.Column<string>(maxLength: 10, nullable: false),
                    diachigiao = table.Column<string>(maxLength: 4000, nullable: false),
                    tongtien = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donhang", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "khachhangs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkh = table.Column<string>(maxLength: 255, nullable: false),
                    sdt = table.Column<string>(maxLength: 10, nullable: false),
                    diachi = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachhangs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "loaimons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenloai = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaimons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "phieugoimons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    soban = table.Column<int>(nullable: false),
                    idkhach = table.Column<int>(nullable: false),
                    giogoi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phieugoimons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sliders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    td1 = table.Column<string>(maxLength: 500, nullable: true),
                    td2 = table.Column<string>(maxLength: 500, nullable: true),
                    url = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoten = table.Column<string>(nullable: true),
                    ngaysinh = table.Column<DateTime>(nullable: false),
                    sdt = table.Column<string>(maxLength: 10, nullable: false),
                    diachi = table.Column<string>(maxLength: 500, nullable: false),
                    email = table.Column<string>(maxLength: 4000, nullable: false),
                    password = table.Column<string>(maxLength: 4000, nullable: false),
                    chucvu = table.Column<int>(nullable: false),
                    hinhanh = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nhanviens",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idbophan = table.Column<int>(nullable: false),
                    hoten = table.Column<string>(maxLength: 255, nullable: false),
                    sdt = table.Column<string>(maxLength: 10, nullable: false),
                    ngaysinh = table.Column<DateTime>(nullable: false),
                    gioitinh = table.Column<int>(nullable: false),
                    diachi = table.Column<string>(maxLength: 4000, nullable: false),
                    gianhap = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanviens", x => x.id);
                    table.ForeignKey(
                        name: "FK_nhanviens_bophans_idbophan",
                        column: x => x.idbophan,
                        principalTable: "bophans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "monans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenmon = table.Column<string>(maxLength: 255, nullable: false),
                    donvitinh = table.Column<string>(maxLength: 100, nullable: false),
                    gia = table.Column<int>(nullable: false, defaultValue: 0),
                    mota = table.Column<string>(maxLength: 4000, nullable: true, defaultValue: "Đang cập nhật"),
                    hinhanh = table.Column<string>(maxLength: 4000, nullable: false),
                    idloaimon = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_monans", x => x.id);
                    table.ForeignKey(
                        name: "FK_monans_loaimons_idloaimon",
                        column: x => x.idloaimon,
                        principalTable: "loaimons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "khachthanhtoans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idphieu = table.Column<int>(nullable: false),
                    idkhach = table.Column<int>(nullable: true),
                    idnv = table.Column<int>(nullable: false),
                    giott = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    hinhthuctt = table.Column<string>(maxLength: 500, nullable: true),
                    sotien = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachthanhtoans", x => x.id);
                    table.ForeignKey(
                        name: "FK_khachthanhtoans_nhanviens_idnv",
                        column: x => x.idnv,
                        principalTable: "nhanviens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_khachthanhtoans_phieugoimons_idphieu",
                        column: x => x.idphieu,
                        principalTable: "phieugoimons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nvcas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idnv = table.Column<int>(nullable: false),
                    idca = table.Column<int>(nullable: false),
                    ngaydk = table.Column<DateTime>(nullable: false, defaultValueSql: "GetDate()"),
                    nhanvienid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nvcas", x => x.id);
                    table.ForeignKey(
                        name: "FK_nvcas_calams_idca",
                        column: x => x.idca,
                        principalTable: "calams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nvcas_nhanviens_nhanvienid",
                        column: x => x.nhanvienid,
                        principalTable: "nhanviens",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "chitietdonhangs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iddh = table.Column<int>(nullable: false),
                    idmon = table.Column<int>(nullable: false),
                    soluong = table.Column<int>(nullable: false, defaultValue: 0),
                    gia = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitietdonhangs", x => x.id);
                    table.ForeignKey(
                        name: "FK_chitietdonhangs_donhang_iddh",
                        column: x => x.iddh,
                        principalTable: "donhang",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chitietdonhangs_monans_idmon",
                        column: x => x.idmon,
                        principalTable: "monans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chitietdonhangs_iddh",
                table: "chitietdonhangs",
                column: "iddh");

            migrationBuilder.CreateIndex(
                name: "IX_chitietdonhangs_idmon",
                table: "chitietdonhangs",
                column: "idmon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_khachthanhtoans_idnv",
                table: "khachthanhtoans",
                column: "idnv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_khachthanhtoans_idphieu",
                table: "khachthanhtoans",
                column: "idphieu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_monans_idloaimon",
                table: "monans",
                column: "idloaimon");

            migrationBuilder.CreateIndex(
                name: "IX_nhanviens_idbophan",
                table: "nhanviens",
                column: "idbophan");

            migrationBuilder.CreateIndex(
                name: "IX_nvcas_idca",
                table: "nvcas",
                column: "idca");

            migrationBuilder.CreateIndex(
                name: "IX_nvcas_nhanvienid",
                table: "nvcas",
                column: "nhanvienid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banans");

            migrationBuilder.DropTable(
                name: "binhluans");

            migrationBuilder.DropTable(
                name: "chitietdonhangs");

            migrationBuilder.DropTable(
                name: "chitietgoimons");

            migrationBuilder.DropTable(
                name: "khachhangs");

            migrationBuilder.DropTable(
                name: "khachthanhtoans");

            migrationBuilder.DropTable(
                name: "nvcas");

            migrationBuilder.DropTable(
                name: "sliders");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "donhang");

            migrationBuilder.DropTable(
                name: "monans");

            migrationBuilder.DropTable(
                name: "phieugoimons");

            migrationBuilder.DropTable(
                name: "calams");

            migrationBuilder.DropTable(
                name: "nhanviens");

            migrationBuilder.DropTable(
                name: "loaimons");

            migrationBuilder.DropTable(
                name: "bophans");
        }
    }
}
