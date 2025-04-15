using System;
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

        public DataTable getNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanVienDAO.getNhanVien(nhanVienDTO);
        }

    }
}
