using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HanhKhach
    {
        public string MaHanhKhach { get; set; }
        public string TenHanhKhach { get; set; }
        public string CMND { get; set; }
        public string DienThoai { get; set; }

        private string TaoMaHanhKhach()
        {
            Random random = new Random();
            return "HK" + random.Next(1000, 9999).ToString();
        }
        public HanhKhach( string TenHanhKhach = null, string CMND = null, string DienThoai = null)
        {
            this.MaHanhKhach = TaoMaHanhKhach();
            this.TenHanhKhach = TenHanhKhach;
            this.CMND = CMND;
            this.DienThoai = DienThoai;
        }
    }
}
