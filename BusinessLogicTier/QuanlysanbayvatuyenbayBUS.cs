using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class QuanlysanbayvatuyenbayBUS
    {
        private QuanlysanbayvatuyenbayDAO quanly;
        public QuanlysanbayvatuyenbayBUS()
        {
            quanly = new QuanlysanbayvatuyenbayDAO();
        }

        public void ThemSanBay(SanBay sanbay)
        {
            quanly.ThemSanBay(sanbay);
        }

        public void ThemTuyenBay(TuyenBay tuyenbay)
        {
            quanly.ThemTuyenBay(tuyenbay);
        }
        public void XoaTuyenBay(string MaTuyenBay)
        {
            quanly.XoaTuyenBay(MaTuyenBay);
        }

        public void XoaSanBay(string MaSanBay)
        {
            quanly.XoaSanBay(MaSanBay);
        }

        public void CapNhapTuyenBay(TuyenBay tuyenbay)
        {
            quanly.CapNhapTuyenBay(tuyenbay);
        }

        public void CapNhapSanBay(SanBay sanbay)
        {
            quanly.CapNhapSanBay(sanbay);
        }

        public DataTable LayDanhSachSanBay()
        {
            return quanly.LayDanhSachSanBay();
        }

        public DataTable LayDanhSachTuyenBay()
        {
            return quanly.LayDanhSachTuyenBay();
        }
    }
}
