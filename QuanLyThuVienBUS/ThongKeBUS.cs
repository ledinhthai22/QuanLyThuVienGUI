﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class ThongKeBUS
    {
        ThongKeDAO thongKeDAO = new ThongKeDAO();
        public List<ThongKeDTO> ThongKeToanBo(DateTime tuNgay, DateTime denNgay)
        {
            return thongKeDAO.ThongKeToanBo(tuNgay, denNgay);
        }
    }
}
