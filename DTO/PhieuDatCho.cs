using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatCho
    {
        public string MaPhieuDatCho { get; set; }
        public string MaChuyenBay { get; set; }
        public string MaHangVe { get; set; }
        public string MaHanhKhach { get; set; }
        public int GiaTien { get; set; }
        public DateTime NgayDat{ get; set; }
        private string TaoMaPhieuDatCho()
        {
            Random random = new Random();
            return "PD" + random.Next(1000, 9999).ToString();
        }
        public PhieuDatCho( string MaChuyenBay = null,string MaHanhKhach = null, string MaHangVe = null,  int GiaTien = 0)
        {
            this.MaPhieuDatCho = TaoMaPhieuDatCho() ;
            this.MaChuyenBay = MaChuyenBay;
            this.MaHanhKhach = MaHanhKhach;
            this.MaHangVe = MaHangVe;
            this.GiaTien = GiaTien;
            this.NgayDat = DateTime.Now;
        }
    }
}
