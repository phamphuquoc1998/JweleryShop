using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<Hoadon>
    {
        public void Configure(EntityTypeBuilder<Hoadon> builder)
        {
            builder.ToTable("hoadon");
            builder.HasKey(x => x.MaHD);
            //builder.HasOne(x => x.User).WithMany(x => x.Hoadons).HasForeignKey(x => x.MaUser);
        }
    }
}
