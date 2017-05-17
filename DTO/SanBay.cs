using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanBay
    {
        public int MaSanBay { get; set; }
        public string TenSanBay { get; set; }

        public SanBay(int MaSanBay, string TenSanBay)
        {
            this.MaSanBay = MaSanBay;
            this.TenSanBay = TenSanBay;
        }
    }
}
