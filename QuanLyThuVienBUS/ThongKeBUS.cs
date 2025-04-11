using System;
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
        public int soLuongTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return thongKeDAO.soLuongTheLoai(theLoaiDTO);
        }
        public int soLuongSach(SachDTO sachDTO)
        {
            return thongKeDAO.soLuongSach(sachDTO);
        }
        public int soLuongTacGia(SachDTO sachDTO)
        {
            return thongKeDAO.soluongTacGia(sachDTO);
        }
        public int soLuongNXB(SachDTO sachDTO)
        {
            return thongKeDAO.soLuongNXB(sachDTO);
        }
    }
}
