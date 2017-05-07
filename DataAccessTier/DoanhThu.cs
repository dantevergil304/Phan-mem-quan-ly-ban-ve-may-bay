using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccessTier
{
    public class Doanhthu : DatabaseConnection
    {
        Doanhthu()
            : base()
        {

        }

        public DataTable LayDoanhThuThang(int Thang, int Nam)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@"] = Thang;
            parameters["@N"] = Nam;

            return ExecuteQuery(query, parameters);
        }

        public DataTable LayDoanhThuNam(int Nam)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();            
            parameters["@"] = Nam;
            return ExecuteQuery(query, parameters);
        }
    }
}
