using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Chitiethoadon
    {
        public int  MaHD {get;set;}
        public int  MaSP { get; set; }
        public string  SoLuong {get;set;}
        public string  DonGia  {get;set; }
                                
        public Hoadon Hoadon { get; set; }
        public Sanpham Sanpham { get; set; }
}
}
