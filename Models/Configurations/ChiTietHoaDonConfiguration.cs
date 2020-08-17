using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class ChiTietHoaDonConfiguration : IEntityTypeConfiguration<Chitiethoadon>
    {
        public void Configure(EntityTypeBuilder<Chitiethoadon> builder)
        {
            builder.ToTable("chitiethoadon");
            builder.HasKey(x => new { x.MaSP, x.MaHD });
            builder.HasOne(x => x.Hoadon).WithMany(x => x.Chitiethoadons).HasForeignKey(x => x.MaHD);
            builder.HasOne(x => x.Sanpham).WithMany(x => x.Chitiethoadons).HasForeignKey(x => x.MaSP);
        }
    }
}
