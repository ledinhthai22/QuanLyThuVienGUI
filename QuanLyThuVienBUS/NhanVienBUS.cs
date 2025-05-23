﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO nhanVienDAO = new NhanVienDAO();

        public List<NhanVienDTO> loadDSNV()
        {
            return nhanVienDAO.loadDSNV();
        }
        public bool addNV(NhanVienDTO nhanVienDTO)
        {
            return NhanVienDAO.addNV(nhanVienDTO);
        }
        public bool deleteNV(string maNV)
        {
            return NhanVienDAO.deleteNV(maNV);
        }
        public bool updateNV(NhanVienDTO nhanVienDTO)
        {
            return NhanVienDAO.updateNV(nhanVienDTO);
        }
        public bool kiemTraTonTai(NhanVienDTO nhanVienDTO)
        {
            return NhanVienDAO.kiemTraTonTai(nhanVienDTO);
        }
     
    }
}
