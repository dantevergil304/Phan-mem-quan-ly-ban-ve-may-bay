using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinh
    {
        public  int SoLuongSanBayToiDa { get; set; }
        public  int ThoiGianBayToiThieu { get; set; }
        public  int SoSanBayTrungGianToiDa { get; set; }
        public  int ThoiGianDungToiThieu { get; set; }
        public  int ThoiGianDungToiDa { get; set; }
        //public static int SoLuongHangVe1ToiDa { get; set; }
        //public static int SoLuongHangVe2ToiDa { get; set; }
        public  int ThoiGianChamNhatDatVe { get; set; }

        public  int ThoiGianHuyDatVe { get; set; }
        public  QuyDinh(int SoLuongSanBayToiDa,int ThoiGianBayToiThieu, int SoSanBayTrungGianToiDa, int ThoiGianDungToiThieu, int ThoiGianDungToiDa, int ThoiGianChamNhatDatVe, int ThoiGianHuyVe)
        {
            this.SoLuongSanBayToiDa = SoLuongSanBayToiDa;
            this.ThoiGianBayToiThieu = ThoiGianBayToiThieu;
            this.SoSanBayTrungGianToiDa = SoSanBayTrungGianToiDa;
            this.ThoiGianDungToiThieu = ThoiGianDungToiThieu;
            this.ThoiGianDungToiDa = ThoiGianDungToiDa;
            this.ThoiGianChamNhatDatVe = ThoiGianChamNhatDatVe;
            this.ThoiGianHuyDatVe = ThoiGianHuyVe;
        }
    }
}
