using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;
using QuanLyThuVienDAO;
using System.Data.SqlClient;
namespace QuanLyThuVienBUS
{
    public class DangNhapBUS
    {
        private DangNhapDAO dangNhapDAO;
   

        public DangNhapBUS()
        {
            dangNhapDAO = new DangNhapDAO();
        }

        public bool dangNhap(DangNhapDTO dangNhapDTO)
        {
            return dangNhapDAO.dangNhap(dangNhapDTO);
        }

        public string getRole(DangNhapDTO dangNhapDTO)
        {
            return dangNhapDAO.getRole(dangNhapDTO);
        }
        public string getNameUser(DangNhapDTO dangNhapDTO)
        {
            return dangNhapDAO.getNameUser(dangNhapDTO);
        }
        public string getyMaNV(DangNhapDTO dangNhapDTO)
        {
            return dangNhapDAO.getMaNV(dangNhapDTO);
        }
    }
}
