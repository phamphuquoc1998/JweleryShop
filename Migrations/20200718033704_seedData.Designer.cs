﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.EF;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(JweleryDbcontext))]
    [Migration("20200718033704_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1b0333ea-1f11-4248-bc19-a7ae94e7b26d",
                            ConcurrencyStamp = "e8aa0685-f3a4-4099-ba85-5b6284cc7527",
                            Name = "Visitor",
                            NormalizedName = "VISITOR"
                        },
                        new
                        {
                            Id = "76a35a30-ddee-4545-bc2c-d1f16380e145",
                            ConcurrencyStamp = "35ef10c8-2d14-412e-9d4d-5065179bce36",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication1.Entities.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartID");

                    b.HasIndex("SanPhamID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("WebApplication1.Entities.Chitiethoadon", b =>
                {
                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<int>("MaHD")
                        .HasColumnType("int");

                    b.Property<string>("DonGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoLuong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP", "MaHD");

                    b.HasIndex("MaHD");

                    b.ToTable("chitiethoadon");
                });

            modelBuilder.Entity("WebApplication1.Entities.Danhgia", b =>
                {
                    b.Property<int>("MaBL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BinhLuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaSP")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBL")
                        .HasColumnType("datetime2");

                    b.HasKey("MaBL");

                    b.ToTable("danhgia");
                });

            modelBuilder.Entity("WebApplication1.Entities.Hoadon", b =>
                {
                    b.Property<int>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MaUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<int>("TongTien")
                        .HasColumnType("int");

                    b.HasKey("MaHD");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("WebApplication1.Entities.Loaisanpham", b =>
                {
                    b.Property<string>("MaLSP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLSP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLSP");

                    b.ToTable("loaisanpham");

                    b.HasData(
                        new
                        {
                            MaLSP = "Ma1",
                            HinhAnh = "Apple.jpg",
                            MoTa = "Dòng Này Bao Ngon",
                            TenLSP = "BraceLet"
                        },
                        new
                        {
                            MaLSP = "Ma2",
                            HinhAnh = "Coolpad.png",
                            MoTa = "Dòng Này Bao Ngon ",
                            TenLSP = "Earings"
                        },
                        new
                        {
                            MaLSP = "Ma3",
                            HinhAnh = "Huawei.jpg",
                            MoTa = "Dòng Này Bao Ngon ",
                            TenLSP = "Neckles"
                        });
                });

            modelBuilder.Entity("WebApplication1.Entities.SanPhamTrongLoaiSanPham", b =>
                {
                    b.Property<int>("SanPhamID")
                        .HasColumnType("int");

                    b.Property<string>("LoaiSanPhamID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SanPhamID", "LoaiSanPhamID");

                    b.HasIndex("LoaiSanPhamID");

                    b.ToTable("sanphamtrongloaisanpham");
                });

            modelBuilder.Entity("WebApplication1.Entities.Sanpham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaLSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("MaSP");

                    b.ToTable("sanpham");

                    b.HasData(
                        new
                        {
                            MaSP = 1,
                            DonGia = 80,
                            HinhAnh = "1.jpeg",
                            MaLSP = "Ma1",
                            SoLuong = 20,
                            TenSP = "Camila",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 2,
                            DonGia = 200,
                            HinhAnh = "2.jpeg",
                            MaLSP = "Ma2",
                            SoLuong = 20,
                            TenSP = "goldear",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 3,
                            DonGia = 200,
                            HinhAnh = "3.jpeg",
                            MaLSP = "Ma3",
                            SoLuong = 20,
                            TenSP = "blapla",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 4,
                            DonGia = 80,
                            HinhAnh = "4.jpeg",
                            MaLSP = "Ma1",
                            SoLuong = 20,
                            TenSP = "das",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 5,
                            DonGia = 80,
                            HinhAnh = "5.jpeg",
                            MaLSP = "Ma2",
                            SoLuong = 20,
                            TenSP = "brac",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 6,
                            DonGia = 80,
                            HinhAnh = "6.jpeg",
                            MaLSP = "Ma3",
                            SoLuong = 20,
                            TenSP = "6sa",
                            TrangThai = 1
                        },
                        new
                        {
                            MaSP = 7,
                            DonGia = 80,
                            HinhAnh = "7.jpeg",
                            MaLSP = "Ma1",
                            SoLuong = 20,
                            TenSP = "7somehitng",
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebApplication2.Models.Domain.UserRegistrationModel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("UserRegistrationModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplication2.Models.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplication2.Models.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApplication2.Models.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Entities.Cart", b =>
                {
                    b.HasOne("WebApplication1.Entities.Sanpham", "Sanpham")
                        .WithMany("Carts")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Entities.Chitiethoadon", b =>
                {
                    b.HasOne("WebApplication1.Entities.Hoadon", "Hoadon")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Sanpham", "Sanpham")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Entities.SanPhamTrongLoaiSanPham", b =>
                {
                    b.HasOne("WebApplication1.Entities.Loaisanpham", "Loaisanpham")
                        .WithMany("SanPhamTrongLoaiSanPhams")
                        .HasForeignKey("LoaiSanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Sanpham", "Sanpham")
                        .WithMany("SanPhamTrongLoaiSanPhams")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
