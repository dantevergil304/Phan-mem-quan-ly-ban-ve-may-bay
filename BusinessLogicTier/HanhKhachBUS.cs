using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class HanhKhachBUS
    {
        public HanhkhachDAO hanhkhachDAO;
        public HanhKhachBUS()
        {
            hanhkhachDAO = new HanhkhachDAO();
        }

        public bool ThemHanhKhach(HanhKhach hanhkhach)
        {
            return hanhkhachDAO.ThemThongTinHanhKhach(hanhkhach);
        }

        public bool KiemTraCMND(string CMND)
        {
            return hanhkhachDAO.KiemTraCMNDHanhKhach(CMND);
        }
        public string LayMaHanhKhachTheoCMND(string CMND)
        {
            return hanhkhachDAO.LayMaHanhKhachTheoCMND(CMND);
        }
    }
}
