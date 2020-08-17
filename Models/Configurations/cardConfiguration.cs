using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Card");

            builder.HasKey(x => x.CartID);
            builder.Property(x => x.CartID).UseIdentityColumn();
            builder.HasOne(x => x.Sanpham).WithMany(x => x.Carts).HasForeignKey(x => x.SanPhamID);
           

        }
    }
}
