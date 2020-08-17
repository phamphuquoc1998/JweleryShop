using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Loaisanpham
    {
        public string MaLSP { get; set; }
        public string TenLSP { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public List<SanPhamTrongLoaiSanPham> SanPhamTrongLoaiSanPhams { get; set; }
    }
}
