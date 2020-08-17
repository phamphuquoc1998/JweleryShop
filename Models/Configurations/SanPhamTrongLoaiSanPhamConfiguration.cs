using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class SanPhamTrongLoaiSanPhamConfiguration : IEntityTypeConfiguration<SanPhamTrongLoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<SanPhamTrongLoaiSanPham> builder)
        {
            builder.HasKey(t => new { t.SanPhamID, t.LoaiSanPhamID });
            builder.ToTable("sanphamtrongloaisanpham");
            builder.HasOne(t => t.Loaisanpham).WithMany(sp => sp.SanPhamTrongLoaiSanPhams).HasForeignKey(sp => sp.LoaiSanPhamID);
            builder.HasOne(t => t.Sanpham).WithMany(sp => sp.SanPhamTrongLoaiSanPhams).HasForeignKey(sp => sp.SanPhamID);

        }
    }
}
