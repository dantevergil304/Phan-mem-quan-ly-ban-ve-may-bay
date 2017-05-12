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
    public class QuanlychuyenbayBUS
    {
        private int ThoiGianBayToiThieu;
        private int ThoiGianDungToiThieu;
        private int ThoiGianDungToiDa;
        private int SoLuongGheToiDa;
        private QuanLyChuyenBayDAO QuanlychuyenbayDAO;
        public QuanlychuyenbayBUS()
        {

        }

        public void ThemThongTinChuyenBay(ThongTinChuyenBay thongtin)
        {
           
        }

        public DataTable LayThongTinChuyenBay(string MACB = null)
        {
            if (!string.IsNullOrWhiteSpace(MACB))
                return QuanlychuyenbayDAO.LayThongTinChuyenBay(MACB);
            else
                return QuanlychuyenbayDAO.LayThongTinChuyenBay();
        }

        public DataTable LayChiTietThongTinChuyenBay(string MACB)
        {
            return QuanlychuyenbayDAO.LayThongTinChiTietChuyenBay(MACB);
        }

       

    }
}
