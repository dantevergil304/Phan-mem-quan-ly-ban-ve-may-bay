using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessTier
{
    public class QuanLyChuyenBayDAO : DatabaseConnection
    {
        public QuanLyChuyenBayDAO()
            : base()
        {

        }

        public DataTable LayThongTinTatCaChuyenBay()
        {
            return ExcuteStoreProcedureReturnRecord("SP_LAY_THONGTIN_CUA_TATCA_CHUYENBAY");
        }

        public DataTable LayThongTinChuyenBayTheoMaChuyenBay(string MaChuyenBay)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@V_MACHUYENBAY"] = MaChuyenBay;
            return ExcuteStoreProcedureReturnRecord("SP_LAY_THONGTIN_CHUYENBAY_THEO_MA", parameters);
        }
    }
}
