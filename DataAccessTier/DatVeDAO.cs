using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DataAccessTier
{
    public class DatveDAO : DatabaseConnection
    {      
        public DatveDAO() : base() { }
        public bool ThemThongTinDatCho(PhieuDatCho phieu)
        {
            string query = "INSERT INTO PHIEUDATCHO VALUES (@MaPhieuDat, @MaChuyenBay, @MaHanhKhach, @MaHangVe, @GiaTien, @NgayDat)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaPhieuDat"] = phieu.MaPhieuDatCho;
            parameters["@MaChuyenBay"] = phieu.MaChuyenBay;
            parameters["@MaHangVe"] = phieu.MaHangVe;
            parameters["@MaHanhKhach"] = phieu.MaHanhKhach;
            parameters["@GiaTien"] = phieu.GiaTien;
            parameters["@NgayDat"] = phieu.NgayDat;
            try
            {
                ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public DataTable LayHangVe()
        {
            string query = "SELECT * FROM HANGVE";
            return ExecuteQuery(query);
        }
        
    }
}
