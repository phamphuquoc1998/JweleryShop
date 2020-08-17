using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebApplication1.Configurations;
using WebApplication1.Entities;
using WebApplication1.Extensions;
using WebApplication2.Models.Domain;

namespace WebApplication1.EF
{
    public class JweleryDbcontext : IdentityDbContext<User>
    {
        public JweleryDbcontext(  DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new DanhGiaConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamTrongLoaiSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietHoaDonConfiguration());

            modelBuilder.Seed();
        }
        public DbSet<Sanpham> Sanphams { get; set;}
        public DbSet<Loaisanpham> Loaisanphams { get; set; }
        public DbSet<Danhgia> Danhgias { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<SanPhamTrongLoaiSanPham> SanPhamTrongLoaiSanPhams { get; set; }
        public DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public DbSet<WebApplication2.Models.Domain.UserRegistrationModel> UserRegistrationModel { get; set; }
    }
}
