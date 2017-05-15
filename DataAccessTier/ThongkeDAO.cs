using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccessTier
{
    public class ThongkeDAO : DatabaseConnection
    {
        public ThongkeDAO()
            : base()
        {

        }

        public DataTable LayDoanhThuThang(int Thang, int Nam)
        {            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@V_THANG"] = Thang;
            parameters["@V_NAM"] = Nam;
            return ExcuteStoreProcedureReturnRecord("SP_DOANHTHU_BANVE_CHUYENBAY", parameters);
        }

        public DataTable LayDoanhThuNam(int Nam)
        {            
            Dictionary<string, object> parameters = new Dictionary<string, object>();            
            parameters["@V_NAM"] = Nam;
            return ExcuteStoreProcedureReturnRecord("SP_DOANHTHUNAM", parameters);
        }
    }
}
