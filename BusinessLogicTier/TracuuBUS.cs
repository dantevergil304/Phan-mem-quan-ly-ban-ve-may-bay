using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DTO;
namespace BusinessLogicTier
{
    public class TracuuBUS
    {
        private TracuuDAO tracuuDAO;
        public TracuuBUS()
        {
            tracuuDAO = new TracuuDAO();
        }
        public DataTable LayDanhSachSanBay()
        {
            return tracuuDAO.LayDanhSachSanBay();
        }
        public DataTable LayDanhSachSanBayDenTheoSanBayDi(string MaSanBayDi)
        {
            return tracuuDAO.LayDanhSachSanBayDenTheoSanBayDi(MaSanBayDi);
        }        

        public DataTable LayThongTinChuyenBayTheoTuyenBay(TuyenBay tuyenbay)
        {
            return tracuuDAO.LayDanhSachChuyenBayTheoTuyenBay(tuyenbay);
        }

        public DataTable LayThongTinTatCaChuyenBay()
        {
            return tracuuDAO.LayThongTinTatCaChuyenBay();
        }
    }
}
