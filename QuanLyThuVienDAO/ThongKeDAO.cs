using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class ThongKeDAO
    {
        DataProvider dp = new DataProvider();
        public int soLuongTheLoai(TheLoaiDTO theLoaiDTO)
        {
            string query = "SELECT COUNT(*) FROM TheLoai";
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            int count = (int)cmd.ExecuteScalar();
            dp.Close();
            return count;
        }
        public int soLuongSach(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM  Sach";
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            int count = (int)cmd.ExecuteScalar();
            dp.Close();
            return count;
        }
        public int soluongTacGia(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(DISTINCT TacGia) FROM Sach";
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            int count = (int)cmd.ExecuteScalar();
            dp.Close();
            return count;
        }
        public int soLuongNXB(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(DISTINCT NhaXuatBan) FROM Sach";
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            int count = (int)cmd.ExecuteScalar();
            dp.Close();
            return count;
        }
    }
}
