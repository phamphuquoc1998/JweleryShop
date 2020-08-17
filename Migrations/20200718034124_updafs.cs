using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class updafs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b0333ea-1f11-4248-bc19-a7ae94e7b26d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a35a30-ddee-4545-bc2c-d1f16380e145");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fa9c45f-d057-4397-aeb4-c2eac6e47cbf", "19070504-bed7-4def-add9-c9936c8189d1", "Visitor", "VISITOR" },
                    { "41620dd6-f37a-45f0-bf53-5b317530941d", "9886fae3-c64e-4b6c-b4ad-7513f4ebad1e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 1,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "Camila BraceLet", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 2,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "goldear BraceLet", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 3,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "blapla Earings", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 4,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "das Earings", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 5,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "brac Neckles", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 6,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "6sa Neckles", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 7,
                columns: new[] { "MaLSP", "TrangThai" },
                values: new object[] { "Ma1 Neckles", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41620dd6-f37a-45f0-bf53-5b317530941d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa9c45f-d057-4397-aeb4-c2eac6e47cbf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b0333ea-1f11-4248-bc19-a7ae94e7b26d", "e8aa0685-f3a4-4099-ba85-5b6284cc7527", "Visitor", "VISITOR" },
                    { "76a35a30-ddee-4545-bc2c-d1f16380e145", "35ef10c8-2d14-412e-9d4d-5065179bce36", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 1,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "Camila", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 2,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "goldear", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 3,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "blapla", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 4,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "das", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 5,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "brac", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 6,
                columns: new[] { "TenSP", "TrangThai" },
                values: new object[] { "6sa", 1 });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 7,
                columns: new[] { "MaLSP", "TrangThai" },
                values: new object[] { "Ma1", 1 });
        }
    }
}
