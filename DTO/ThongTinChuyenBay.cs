using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinChuyenBay
    {
        public string MaChuyenBay { get; set; }
        public string MaTuyenBay { get; set; }
        public DateTime NgayGio {get; set; }
        public int ThoiGianBay { get; set; }
        public int SoLuongGheHang1 { get; set; }
        public int SoLuongGheHang2 { get; set; }

        public List<ChiTietChuyenBay> danhSachSanBayTrungGian;

    }
}
