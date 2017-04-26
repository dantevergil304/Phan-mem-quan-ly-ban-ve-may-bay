using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinVe
    {
        public string MaVe { get; set; }
        public string MaChuyenBay { get; set; }
        public string MaHangVe { get; set; }
        public string MaHanhKhach { get; set; }
        public double GiaTien { get; set;}

        public ThongTinVe(string MaVe = null, string MaChuyenBay = null, string MaHangVe = null, string MaHanhKhach = null, double GiaTien = 0.0)
        {
            this.MaVe = MaVe;
            this.MaChuyenBay = MaChuyenBay;
            this.MaHanhKhach = MaHanhKhach;
            this.GiaTien = GiaTien;
        }
    }

}
