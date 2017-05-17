using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;
using DTO;

namespace DataAccessTier
{
    public class QuydinhDAO : DatabaseConnection
    {
        public QuydinhDAO()
            : base()
        {

        }

        public QuyDinh LayDanhSachQuyDinh()
        {
            DataTable table = ExcuteStoreProcedureReturnRecord("SP_QUYDINH");
            return new QuyDinh((int)table.Rows[0][0], (int)table.Rows[0][1], (int)table.Rows[0][2], (int)table.Rows[0][3], (int)table.Rows[0][4], (int)table.Rows[0][5], (int)table.Rows[0][6]);
        }
    }
}
