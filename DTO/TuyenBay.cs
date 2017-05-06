using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenBay
    {
        public string MaTuyenBay { get; set; }
        public string MaSanBayDi { get; set; }
        public string MaSanBayDen { get; set; }

        public DateTime NgayBay { get; set; }

        public TuyenBay(string MaSanBayDi, string MaSanBayDen, DateTime NgayBay)
        {
            this.MaSanBayDi = MaSanBayDi;
            this.MaSanBayDen = MaSanBayDen;
            this.NgayBay = NgayBay;
        }
    }
}
