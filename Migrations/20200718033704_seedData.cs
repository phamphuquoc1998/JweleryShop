using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49307cd4-7a22-4edf-a6b2-1cea1b86a352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91a29ddf-2ff7-4425-8e28-12c25b2a181c");

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
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 2,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 3,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 4,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 5,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 6,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 7,
                column: "TrangThai",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "49307cd4-7a22-4edf-a6b2-1cea1b86a352", "fd4dddbf-ebad-4a9a-b853-1e882572e5cc", "Visitor", "VISITOR" },
                    { "91a29ddf-2ff7-4425-8e28-12c25b2a181c", "1eeb140e-a659-4c3c-8341-4bca0cf1eb22", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 1,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 2,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 3,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 4,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 5,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 6,
                column: "TrangThai",
                value: 1);

            migrationBuilder.UpdateData(
                table: "sanpham",
                keyColumn: "MaSP",
                keyValue: 7,
                column: "TrangThai",
                value: 1);
        }
    }
}
