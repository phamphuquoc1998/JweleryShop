using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class initdataq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "danhgia",
                columns: table => new
                {
                    MaBL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinhLuan = table.Column<string>(nullable: true),
                    NgayBL = table.Column<DateTime>(nullable: false),
                    MaSP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhgia", x => x.MaBL);
                });

            migrationBuilder.CreateTable(
                name: "hoadon",
                columns: table => new
                {
                    MaHD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayLap = table.Column<DateTime>(nullable: false),
                    NguoiNhan = table.Column<string>(nullable: true),
                    SDT = table.Column<int>(nullable: false),
                    TongTien = table.Column<int>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    MaUser = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoadon", x => x.MaHD);
                });

            migrationBuilder.CreateTable(
                name: "loaisanpham",
                columns: table => new
                {
                    MaLSP = table.Column<string>(nullable: false),
                    TenLSP = table.Column<string>(nullable: true),
                    HinhAnh = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaisanpham", x => x.MaLSP);
                });

            migrationBuilder.CreateTable(
                name: "sanpham",
                columns: table => new
                {
                    MaSP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLSP = table.Column<string>(nullable: true),
                    TenSP = table.Column<string>(nullable: true),
                    DonGia = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanpham", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "UserRegistrationModel",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistrationModel", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamID = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<int>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Cart_sanpham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "sanpham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chitiethoadon",
                columns: table => new
                {
                    MaHD = table.Column<int>(nullable: false),
                    MaSP = table.Column<int>(nullable: false),
                    SoLuong = table.Column<string>(nullable: true),
                    DonGia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chitiethoadon", x => new { x.MaSP, x.MaHD });
                    table.ForeignKey(
                        name: "FK_chitiethoadon_hoadon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "hoadon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chitiethoadon_sanpham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "sanpham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanphamtrongloaisanpham",
                columns: table => new
                {
                    SanPhamID = table.Column<int>(nullable: false),
                    LoaiSanPhamID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanphamtrongloaisanpham", x => new { x.SanPhamID, x.LoaiSanPhamID });
                    table.ForeignKey(
                        name: "FK_sanphamtrongloaisanpham_loaisanpham_LoaiSanPhamID",
                        column: x => x.LoaiSanPhamID,
                        principalTable: "loaisanpham",
                        principalColumn: "MaLSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanphamtrongloaisanpham_sanpham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "sanpham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49307cd4-7a22-4edf-a6b2-1cea1b86a352", "fd4dddbf-ebad-4a9a-b853-1e882572e5cc", "Visitor", "VISITOR" },
                    { "91a29ddf-2ff7-4425-8e28-12c25b2a181c", "1eeb140e-a659-4c3c-8341-4bca0cf1eb22", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "loaisanpham",
                columns: new[] { "MaLSP", "HinhAnh", "MoTa", "TenLSP" },
                values: new object[,]
                {
                    { "Ma1", "Apple.jpg", "Dòng Này Bao Ngon", "BraceLet" },
                    { "Ma2", "Coolpad.png", "Dòng Này Bao Ngon ", "Earings" },
                    { "Ma3", "Huawei.jpg", "Dòng Này Bao Ngon ", "Neckles" }
                });

            migrationBuilder.InsertData(
                table: "sanpham",
                columns: new[] { "MaSP", "DonGia", "HinhAnh", "MaLSP", "SoLuong", "TenSP", "TrangThai" },
                values: new object[,]
                {
                    { 1, 80, "1.jpeg", "Ma1", 20, "Camila", 1 },
                    { 2, 200, "2.jpeg", "Ma2", 20, "goldear", 1 },
                    { 3, 200, "3.jpeg", "Ma3", 20, "blapla", 1 },
                    { 4, 80, "4.jpeg", "Ma1", 20, "das", 1 },
                    { 5, 80, "5.jpeg", "Ma2", 20, "brac", 1 },
                    { 6, 80, "6.jpeg", "Ma3", 20, "6sa", 1 },
                    { 7, 80, "7.jpeg", "Ma1", 20, "7somehitng", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_SanPhamID",
                table: "Cart",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_chitiethoadon_MaHD",
                table: "chitiethoadon",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_sanphamtrongloaisanpham_LoaiSanPhamID",
                table: "sanphamtrongloaisanpham",
                column: "LoaiSanPhamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "chitiethoadon");

            migrationBuilder.DropTable(
                name: "danhgia");

            migrationBuilder.DropTable(
                name: "sanphamtrongloaisanpham");

            migrationBuilder.DropTable(
                name: "UserRegistrationModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "hoadon");

            migrationBuilder.DropTable(
                name: "loaisanpham");

            migrationBuilder.DropTable(
                name: "sanpham");
        }
    }
}
