
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loaisanpham>().HasData(
                new Loaisanpham() { MaLSP = "Ma1", TenLSP= "BraceLet", HinhAnh = "Apple.jpg",MoTa="Dòng Này Bao Ngon" },
                new Loaisanpham() { MaLSP = "Ma2", TenLSP = "Earings", HinhAnh = "Coolpad.png",MoTa = "Dòng Này Bao Ngon " },
                new Loaisanpham() { MaLSP = "Ma3", TenLSP = "Neckles", HinhAnh = "Huawei.jpg",MoTa = "Dòng Này Bao Ngon " });

            modelBuilder.Entity<Sanpham>().HasData(
                new Sanpham()
                {
                    MaSP=1,
                    MaLSP= "Ma1",
                    TenSP = "Camila BraceLet",
                    DonGia=80,
                    SoLuong=20,
                    HinhAnh= "1.jpeg",
                    TrangThai=Emuns.Status.Active                   
                },
                new Sanpham()
                {
                    MaSP = 2,
                    MaLSP = "Ma2",
                    TenSP = "goldear BraceLet",
                    DonGia = 200,
                    SoLuong = 20,
                    HinhAnh = "2.jpeg",
                    TrangThai = Emuns.Status.Active
                },
                new Sanpham()
                {
                    MaSP = 3,
                    MaLSP = "Ma3",
                    TenSP = "blapla Earings",
                    DonGia = 200,
                    SoLuong = 20,
                    HinhAnh = "3.jpeg",
                    TrangThai = Emuns.Status.Active
                },
                new Sanpham()
                {
                    MaSP = 4,
                    MaLSP = "Ma1",
                    TenSP = "das Earings",
                    DonGia = 80,
                    SoLuong = 20,
                    HinhAnh = "4.jpeg",
                    TrangThai = Emuns.Status.Active
                },
                new Sanpham()
                {
                    MaSP = 5,
                    MaLSP = "Ma2",
                    TenSP = "brac Neckles",
                    DonGia = 80,
                    SoLuong = 20,
                    HinhAnh = "5.jpeg",
                    TrangThai = Emuns.Status.Active
                },
                new Sanpham()
                {
                    MaSP = 6,
                    MaLSP = "Ma3",
                    TenSP = "6sa Neckles",
                    DonGia = 80,
                    SoLuong = 20,
                    HinhAnh = "6.jpeg",
                    TrangThai = Emuns.Status.Active
                },
                new Sanpham()
                {
                    MaSP = 7,
                    MaLSP = "Ma1 Neckles",
                    TenSP = "7somehitng",
                    DonGia = 80,
                    SoLuong = 20,
                    HinhAnh = "7.jpeg",
                    TrangThai = Emuns.Status.Active
                });
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "Visitor",
                    NormalizedName = "VISITOR"

                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });;
        }
    }
}
