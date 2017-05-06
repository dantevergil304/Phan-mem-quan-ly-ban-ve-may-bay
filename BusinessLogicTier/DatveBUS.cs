using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DataAccessTier;
using BusinessLogicTier;
using System.Text.RegularExpressions;

namespace BusinessLogicTier
{
    public class DatveBUS
    {
        private DatveDAO datveDAO;
        private QuanlychuyenbayBUS chuyenbayDAO;
        private Match match;


        public DatveBUS()
        {
            datveDAO = new DatveDAO();
            chuyenbayDAO = new QuanlychuyenbayBUS();
        }

        public DataTable LayHangVe()
        {
            return datveDAO.LayHangVe();
        }

        public void ThemThongTinDatCho(PhieuDatCho phieu)
        {          
            
        }

    }
}
