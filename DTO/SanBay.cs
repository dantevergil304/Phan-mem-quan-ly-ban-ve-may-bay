using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanBay
    {
        public string MaSanBay { get; set; }
        public string TenSanBay { get; set; }

        public SanBay(string MaSanBay, string TenSanBay)
        {
            this.MaSanBay = MaSanBay;
            this.TenSanBay = TenSanBay;
        }
    }
}
