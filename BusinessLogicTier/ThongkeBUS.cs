using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
namespace BusinessLogicTier
{
    public class ThongkeBUS
    {
        private ThongkeDAO ThongKe;
        public ThongkeBUS()
        {
            ThongKe = new ThongkeDAO();
        }

        public DataTable LayDoanhThuThang(int Thang, int Nam)
        {
            return ThongKe.LayDoanhThuThang(Thang, Nam);
        }

        public DataTable LayDoanhThuNam(int Nam)
        {
            return ThongKe.LayDoanhThuNam(Nam);
        }

    }
}
