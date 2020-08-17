using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Hoadon
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string NguoiNhan { get; set; }
        public int SDT { get; set; }
        public int TongTien { get; set; }
        public string DiaChi { get; set; }
        public Guid MaUser { get; set; }

        public List<Chitiethoadon> Chitiethoadons { get; set; }
        //public User User { get; set; }

    }
}
