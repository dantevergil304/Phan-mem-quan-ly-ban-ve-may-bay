using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessTier
{
    public class HanhKhachDAO : DatabaseConnection
    {
        public HanhKhachDAO() : base() { }

        public bool KiemTraCMNDHanhKhach(string CMND)
        {
            string query = "SELECT * FROM HANHKHACH WHERE CMND =@CMND";
            Dictionary<string, object> paramters = new Dictionary<string, object>();
            paramters["@CMND"] = CMND;
            DataTable table = ExecuteQuery(query, paramters);
            if (table.Rows.Count == 0) 
                return true;
            else
                return false;
        }
        public bool ThemThongTinHanhKhach(HanhKhach hanhkhach)
        {
            string query = "INSERT INTO HANHKHACH VALUES (@MaHanhKhach, @TenHanhKhach, @CMND, @DienThoai)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaHanhKhach"] = hanhkhach.MaHanhKhach;
            parameters["@TenHanhKhach"] = hanhkhach.TenHanhKhach;
            parameters["@CMND"] = hanhkhach.CMND;
            parameters["@DienThoai"] = hanhkhach.DienThoai;
            try
            {
                ExecuteNonQuery(query, parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public string LayMaHanhKhachTheoCMND(string CMND)
        {
            if (!KiemTraKetNoi())
                connection.Open();            
            try
            {
                string query = "SELECT MAHANHKHACH FROM HANHKHACH WHERE CMND = @CMND";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CMND", CMND);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader["MAHANHKHACH"].ToString();
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
    }
}
