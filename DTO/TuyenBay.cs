using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenBay
    {
        public int MaTuyenBay { get; set; }
        public int MaSanBayDi { get; set; }
        public int MaSanBayDen { get; set; }
        

        public TuyenBay(int MaSanBayDi, int MaSanBayDen, int MaTuyenBay = 0 )
        {
            this.MaTuyenBay = MaTuyenBay;
            this.MaSanBayDi = MaSanBayDi;
            this.MaSanBayDen = MaSanBayDen;
        }
    }
}
