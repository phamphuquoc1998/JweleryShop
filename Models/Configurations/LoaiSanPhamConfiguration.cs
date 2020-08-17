using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class LoaiSanPhamConfiguration : IEntityTypeConfiguration<Loaisanpham>
    {
        public void Configure(EntityTypeBuilder<Loaisanpham> builder)
        {
            builder.ToTable("loaisanpham");
            builder.HasKey(x => x.MaLSP);
            

        }
    }
}
