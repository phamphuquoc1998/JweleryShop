using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Emuns;

namespace WebApplication1.Entities
{
    public class Sanpham
    {
       public int MaSP { get; set; }
        public string MaLSP { get; set; }
        public string TenSP { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set; }
        public Status TrangThai { get; set; }
        public List<SanPhamTrongLoaiSanPham> SanPhamTrongLoaiSanPhams { get; set; }
        public List<Chitiethoadon> Chitiethoadons { get; set; }
        public List<Cart> Carts { get; set; }

    }
}
