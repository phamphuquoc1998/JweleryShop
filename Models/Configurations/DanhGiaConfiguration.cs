using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Configurations
{
    public class DanhGiaConfiguration : IEntityTypeConfiguration<Danhgia>
    {
        public void Configure(EntityTypeBuilder<Danhgia> builder)
        {
            builder.ToTable("danhgia");

            builder.HasKey(x => x.MaBL);

        }
    }
}
