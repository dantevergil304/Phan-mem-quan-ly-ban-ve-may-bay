﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DTO;
namespace BusinessLogicTier
{
    public class TracuuBUS
    {
        private TracuuDAO tracuuDAO;
        public TracuuBUS()
        {
            tracuuDAO = new TracuuDAO();
        }               

        public DataTable LayThongTinChuyenBayTheoTuyenBay(TuyenBay tuyenbay, DateTime date)
        {
            return tracuuDAO.LayDanhSachChuyenBayTheoTuyenBay(tuyenbay, date);
        }

        public DataTable LayThongTinTatCaChuyenBay()
        {
            return tracuuDAO.LayThongTinTatCaChuyenBay();
        }
    }
}
