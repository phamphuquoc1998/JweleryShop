using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class SanPhamTrongLoaiSanPham
    {
        public int SanPhamID { get; set; }

        public Sanpham Sanpham { get; set; }
        public string LoaiSanPhamID { get; set; }
        public Loaisanpham Loaisanpham { get; set; }
    }
}
