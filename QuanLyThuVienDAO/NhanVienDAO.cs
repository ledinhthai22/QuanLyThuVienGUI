using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class NhanVienDAO
    {

        private static DataProvider dp = new DataProvider();
       
        public DataTable LoadDSNV()
        {
            string select = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand(select, dp.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        public static bool addNV(NhanVienDTO nhanVienDTO)
        {
            string newMaNhanVien = "";
            dp.Open();

            using (SqlCommand getIdCmd = new SqlCommand("GetNextMaNhanVien", dp.GetConnection()))
            {
                getIdCmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        newMaNhanVien = reader.GetString(0);
                    }
                }
            }

            // Kiểm tra ngày hợp lệ
            DateTime ngaySinh;
            if (!DateTime.TryParse(nhanVienDTO.ngaySinh.ToString(), out ngaySinh) ||
                ngaySinh < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngaySinh > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngaySinh = DateTime.Now; // hoặc giá trị mặc định khác
            }

            string insert = @"INSERT INTO NhanVien 
                     (MaNV, TenNV, ChucVu, GioiTinh, NgaySinh, SDT, DiaChi, Luong, Username, Password, TrangThai)
                     VALUES(@maNV, @tenNV, @ChucVu, @gioiTinh, @ngaySinh, @soDienThoai, @diaChi, @luong, @userName, @passWord, 1)";

            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maNV", newMaNhanVien);
            cmd.Parameters.AddWithValue("@tenNV", nhanVienDTO.tenNV);
            cmd.Parameters.AddWithValue("@ChucVu", nhanVienDTO.chucVu);
            cmd.Parameters.AddWithValue("@gioiTinh", nhanVienDTO.gioiTinh);
            cmd.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("@soDienThoai", nhanVienDTO.SDT);
            cmd.Parameters.AddWithValue("@diaChi", nhanVienDTO.diaChi);
            cmd.Parameters.AddWithValue("@luong", nhanVienDTO.luong);
            cmd.Parameters.AddWithValue("@userName", nhanVienDTO.userName);
            cmd.Parameters.AddWithValue("@passWord", nhanVienDTO.password);

            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public static bool deleteNV(string maNV)
        {
            string delete = "DELETE FROM NhanVien WHERE MaNV = @maNV";
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maNV", maNV);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public static bool kiemTraNhanVienChoMuonSach(NhanVienDTO nhanVienDTO)
        {
            string query = "SELECT COUNT(*) FROM PhieuMuon WHERE MaNhanVien = @maNV";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maNV", nhanVienDTO.maNV);
                int count = (int)cmd.ExecuteScalar();
                dp.Close();
                return count > 0;
            }
        }
        public static bool kiemTraTonTai(NhanVienDTO nhanVienDTO)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE Username = @userName";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@userName", nhanVienDTO.userName);
                int count = (int)cmd.ExecuteScalar();
                dp.Close();
                return count > 0; 
            }
        }
    }
}
