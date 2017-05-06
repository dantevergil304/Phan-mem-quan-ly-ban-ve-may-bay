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
        public QuanLyChuyenBayDAO() : base() { }


        public void ThemThongTinChuyenBay (ThongTinChuyenBay thongtinchuyenbay, List<ChiTietChuyenBay> chitietchuyenbays)
        {                        
            if (!KiemTraKetNoi())
                connection.Open();
            try
            {
                string query = "INSERT INTO CHUYENBAY VALUES (@MaChuyenBay, @MaTuyenBay, @NgayGio, @ThoiGianBay, @SoLuongGheHang1, @SoLuongGheHang2)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaChuyenBay", thongtinchuyenbay.MaChuyenBay);
                command.Parameters.AddWithValue("@MaTuyenBay",thongtinchuyenbay.MaTuyenBay);
                command.Parameters.AddWithValue("@NgayGio", thongtinchuyenbay.NgayGio);
                command.Parameters.AddWithValue("@ThoiGianBay", thongtinchuyenbay.ThoiGianBay);
                command.Parameters.AddWithValue("@SoLuongGheHang1", thongtinchuyenbay.SoLuongGheHang1);
                command.Parameters.AddWithValue("@SoLuongGheHang2", thongtinchuyenbay.SoLuongGheHang2);
                command.ExecuteNonQuery();
                query = "INSERT INTO CHITIETCHUYENBAY VALUES (@MaChiTietChuyenBay, @MaChuyenBay, @SanBayTrungGian, @ThoiGianDung, @GhiChu)";
                command.CommandText = query;
                
                foreach (var chitiet in chitietchuyenbays)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@MaChiTietChuyenBay", chitiet.MaChiTietChuyenBay);
                    command.Parameters.AddWithValue("@MaChuyenBay", chitiet.MaChuyenBay);
                    command.Parameters.AddWithValue("@SanBayTrungGian", chitiet.MaSanBayTrungGian);
                    command.Parameters.AddWithValue("@ThoiGianDung", chitiet.ThoiGianDung);
                    command.Parameters.AddWithValue("@GhiChu", chitiet.GhiChu);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
        }

        public string TimMaTuyenBay(string MaSanBayDen, string MaSanBayDi)
        {
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                string query = "SELECT MATUYENBAY FROM TUYENBAY WHERE SANBAYDI = @MaSanBayDi AND SANBAYDEN=@MaSanBayDen";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSanBayDi",MaSanBayDi);
                command.Parameters.AddWithValue("@MaSanBayDen",MaSanBayDen);
                SqlDataReader reader = command.ExecuteReader();                
                if (reader.Read())
                {                   
                    return reader["MATUYENBAY"].ToString();
                }                
                return "";
            }
            catch (Exception)
            {
                
                return "";
            }
            finally
            {
                connection.Close();
            }
        }

        public bool KiemTraMaChuyenBay(string MaChuyenBay)
        {
            if (!KiemTraKetNoi())
            {
                connection.Open();
            }
            try
            {
                string query = "SELECT MACHUYENBAY FROM CHUYENBAY WHERE MACHUYENBAY = @MaChuyenBay";                
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters["@MaChuyenBay"] = MaChuyenBay;
                DataTable table = ExecuteQuery(query, parameters);
                if (table.Rows.Count == 0)
                {
                    return false;
                }
                return true;
                                
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable LayThongTinChuyenBay(string MACB = null)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string,object>();
            if (string.IsNullOrWhiteSpace(MACB))
                query = "";
            else {
                query = "";
                parameters["@"] = MACB; 
            }

            return ExecuteQuery(query, parameters);
        }

        public DataTable LayThongTinChiTietChuyenBay(string MACB)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaChuyenBay"] = MACB;
            return ExecuteQuery(query, parameters);
        }

        public void XoaChuyenBay(string MACB)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaChuyenBay"] = MACB;
            ExecuteNonQuery(query, parameters);
        }
        public void CapNhapChuyenBay(ThongTinChuyenBay t)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();         
            ExecuteNonQuery(query, parameters);
        }
        
    }
}
