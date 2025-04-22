using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class NhanVienDAO
    {

        private static DataProvider dp = new DataProvider();
        private List<NhanVienDTO> listNhanVien = new List<NhanVienDTO>();
        public List<NhanVienDTO> loadDSNV()
        {
            string select = "SELECT * FROM NhanVien WHERE TrangThai = 1 AND ChucVu = 'thuthu'";
            try
            {
                SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listNhanVien.Clear();

                while (dr.Read())
                {
                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.maNV = dr["MaNV"].ToString();
                    nhanVienDTO.tenNV = dr["TenNV"].ToString();
                    nhanVienDTO.chucVu = dr["ChucVu"].ToString();
                    nhanVienDTO.gioiTinh = dr["GioiTinh"].ToString();
                    nhanVienDTO.ngaySinh = dr["NgaySinh"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgaySinh"]);
                    nhanVienDTO.SDT = dr["SDT"].ToString();
                    nhanVienDTO.diaChi = dr["DiaChi"].ToString();
                    nhanVienDTO.luong = dr["Luong"] == DBNull.Value ? 0f : Convert.ToSingle(dr["Luong"]);
                    nhanVienDTO.userName = dr["Username"].ToString();
                    nhanVienDTO.password = dr["Password"].ToString();
                    nhanVienDTO.trangThai = Convert.ToInt32(dr["TrangThai"]);

                  
                    listNhanVien.Add(nhanVienDTO);
                }

                dp.Close();
                return listNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách nhân viên: " + ex.Message);
                return null;
            }
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
            DateTime ngaySinh;
            if (!DateTime.TryParse(nhanVienDTO.ngaySinh.ToString(), out ngaySinh) ||
                ngaySinh < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngaySinh > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngaySinh = DateTime.Now; 
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
            string delete = "UPDATE NhanVien SET Trangthai = 0 WHERE MaNV = @maNV";
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maNV", maNV);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public static bool updateNV(NhanVienDTO nhanVienDTO)
        {
            string update = "UPDATE NhanVien SET TenNV = @tenNV, ChucVu = @chucVu,GioiTinh = @gioiTinh," +
                "NgaySinh = @ngaySinh,SDT = @soDienThoai,DiaChi = @diaChi,Luong = @luong,Username = @userName, Password = @passWord " +
                "WHERE MaNV = @maNV";
            DateTime ngaySinh;
            if (!DateTime.TryParse(nhanVienDTO.ngaySinh.ToString(), out ngaySinh) ||
                ngaySinh < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngaySinh > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngaySinh = DateTime.Now;
            }
            SqlCommand cmd =  new SqlCommand(update, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maNV", nhanVienDTO.maNV);
            cmd.Parameters.AddWithValue("@tenNV", nhanVienDTO.tenNV);
            cmd.Parameters.AddWithValue("@chucVu", nhanVienDTO.chucVu);
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
