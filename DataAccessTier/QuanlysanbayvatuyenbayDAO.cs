﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DataAccessTier
{
    public class QuanlysanbayvatuyenbayDAO : DatabaseConnection
    {
        public QuanlysanbayvatuyenbayDAO()
            : base()
        {

        }

        public void ThemSanBay(SanBay sanbay)
        {
            string query = "INSERT INTO SANBAY VALUES (N'@MaSanBay',N'@TenSanBay')";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaSanBay"] = sanbay.MaSanBay;
            parameters["@TenSanBay"] = sanbay.TenSanBay;
            ExecuteNonQuery(query, parameters);
        }
        public void ThemTuyenBay(TuyenBay tuyenbay)
        {
            string query = "INSERT INTO TUYENBAY VALUES (N'@MaTuyenBay',N'@MaSanBayDi',N'@MaSanBayDen')";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaTuyenBay"] = tuyenbay.MaTuyenBay;
            parameters["@MaSanBayDi"] = tuyenbay.MaSanBayDi;
            parameters["@MaSanBayDen"] = tuyenbay.MaSanBayDen;
            ExecuteNonQuery(query, parameters);
        }

        public void XoaSanBay(string MaSanBay)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaSanBay"] = MaSanBay;
            ExecuteNonQuery(query, parameters);
        }
        public void XoaTuyenBay(string MaTuyenBay)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters["@MaSanBay"] = MaTuyenBay;
            ExecuteNonQuery(query, parameters);
        }

        public void CapNhapTuyenBay(TuyenBay tuyenbay)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            ExecuteNonQuery(query, parameters);
        }
        public void CapNhapSanBay(SanBay tuyenbay)
        {
            string query = "";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            ExecuteNonQuery(query, parameters);
        }

        public DataTable LayDanhSachSanBay()
        {
            return ExcuteStoreProcedureReturnRecord("SP_DANHSACH_TATCA_SANBAY");
        }        

        public DataTable LayDanhSachTuyenBay()
        {
            return ExcuteStoreProcedureReturnRecord("SP_DANHSACH_TATCA_TUYENBAY");
        }
    }
}
