using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Emuns;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<Sanpham>
    {
        public void Configure(EntityTypeBuilder<Sanpham> builder)
        {
            builder.ToTable("sanpham");
            builder.HasKey(x => x.MaSP);
            builder.Property(x => x.TrangThai).HasDefaultValue(Status.Active); 
            
        }
    }
}
