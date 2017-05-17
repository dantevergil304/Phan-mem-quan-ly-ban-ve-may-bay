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
            QuanlychuyenbayDAO = new QuanLyChuyenBayDAO();
        }

        public void ThemThongTinChuyenBay(ThongTinChuyenBay thongtin)
        {
           
        }

        public DataTable LayThongTinTatCaChuyenBay(string MACB = null)
        {
            return QuanlychuyenbayDAO.LayThongTinTatCaChuyenBay();
        }

        public DataTable LayThongTinChuyenBay(string MaChuyenBay)
        {
            return QuanlychuyenbayDAO.LayThongTinChuyenBayTheoMaChuyenBay(MaChuyenBay);
        }

       

    }
}
