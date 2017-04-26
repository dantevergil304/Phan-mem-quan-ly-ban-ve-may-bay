using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DataAccessTier;
using System.Text.RegularExpressions;

namespace BusinessLogicTier
{
    public class DatveBUS
    {
        private DatVeDAO datveDAO;
        private NhapThongTinChuyenBayDAO chuyenbayDAO;
        private Match match;


        public DatveBUS()
        {
            datveDAO = new DatVeDAO();
            chuyenbayDAO = new NhapThongTinChuyenBayDAO();
        }

        public DataTable LayHangVe()
        {
            return datveDAO.LayHangVe();
        }

        public void ThemThongTinDatCho(PhieuDatCho phieu)
        {
            if (chuyenbayDAO.KiemTraMaChuyenBay(phieu.MaChuyenBay))
                datveDAO.ThemThongTinDatCho(phieu);
            else
            {
                           
            }              
            
        }

    }
}
