using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class DangNhapDAO
    {

        DataProvider dp = new DataProvider();
        public DangNhapDAO()
        {
        }

        public bool dangNhap(DangNhapDTO dangNhapDTO)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE UserName = @userName AND PassWord = @passWord";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@userName", dangNhapDTO.userName);
            cmd.Parameters.AddWithValue("@passWord", dangNhapDTO.passWord);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;

        }

        public string getRole(DangNhapDTO dangNhapDTO)
        {
            string query = "SELECT ChucVu FROM NhanVien WHERE UserName = @userName AND PassWord = @passWord";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@userName", dangNhapDTO.userName);
            cmd.Parameters.AddWithValue("@passWord", dangNhapDTO.passWord);
            object result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                dp.Close();
                return null;
            }
            dp.Close();
            return (string)result;
        }
        public string getNameUser(DangNhapDTO dangNhapDTO)
        {
            string query = "SELECT TenNV FROM NhanVien WHERE UserName = @userName AND PassWord = @passWord";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@userName", dangNhapDTO.userName);
            cmd.Parameters.AddWithValue("@passWord", dangNhapDTO.passWord);
            object result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                dp.Close();
                return null;
            }
            dp.Close();
            return (string)result;
        }
        public string getMaNV(DangNhapDTO dangNhapDTO)
        {
            string query = "SELECT MaNV FROM NhanVien WHERE UserName = @userName AND PassWord = @passWord";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@userName", dangNhapDTO.userName);
            cmd.Parameters.AddWithValue("@passWord", dangNhapDTO.passWord);
            object result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                dp.Close();
                return null;
            }
            dp.Close();
            return (string)result;
        }

    }
}
