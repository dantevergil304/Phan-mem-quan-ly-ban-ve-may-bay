using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class QuyDinhBUS
    {
        private QuydinhDAO quydinhDAO;
        public QuyDinhBUS()
        {
            quydinhDAO = new QuydinhDAO();
        }

        public QuyDinh LayDanhSachQuyDinh()
        {
            return quydinhDAO.LayDanhSachQuyDinh();
        }
    }
}
