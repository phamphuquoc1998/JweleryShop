using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Cart
    {
        public int CartID{ get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public Guid UserID { get; set; }
        public DateTime NgayTao { get; set; }
        public Sanpham Sanpham { get; set; }
       

    }
}
