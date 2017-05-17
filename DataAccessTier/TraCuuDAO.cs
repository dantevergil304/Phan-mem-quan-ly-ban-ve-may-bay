using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Data.SqlTypes;

namespace DataAccessTier
{
    public class TracuuDAO : DatabaseConnection
    {
        public TracuuDAO() : base() { }
                
        public DataTable LayDanhSachChuyenBayTheoTuyenBay(TuyenBay tuyenbay, DateTime date)
        {            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@V_MASANBAYDI"] = tuyenbay.MaSanBayDi;
            parameters["@V_MASANBAYDEN"] = tuyenbay.MaSanBayDen;
            parameters["@V_DATE"] = date;
            return ExcuteStoreProcedureReturnRecord("SP_DANHSACH_CHUYENBAY_THOA_DIEUKIEN", parameters);            
        }
           
        public DataTable LayThongTinTatCaChuyenBay()
        {
            return ExcuteStoreProcedureReturnRecord("SP_DANHSACH_TATCA_CHUYENBAY");
        }

    }
}
