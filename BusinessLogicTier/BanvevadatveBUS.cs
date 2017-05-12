using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DataAccessTier;
using BusinessLogicTier;


namespace BusinessLogicTier
{
    public class BanvevadatveBUS
    {
        private BanvevadatveDAO datveDAO;
        private QuanlychuyenbayBUS chuyenbayDAO;        


        public BanvevadatveBUS()
        {
            datveDAO = new BanvevadatveDAO();
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
