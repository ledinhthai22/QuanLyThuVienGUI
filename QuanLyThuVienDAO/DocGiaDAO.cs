using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{

    public class DocGiaDAO
    {

        private static DataProvider dp = new DataProvider();
        public DataTable LoadDSDG()
        {
            string select = "SELECT * FROM Docgia WHERE Trangthai = 1 ";
            SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        public static bool addDocGia(DocGiaDTO docGiaDTO)
        {
            string newMaDocGia = "";
            dp.Open();

            using (SqlCommand getIdCmd = new SqlCommand("GetNextMaDocGia", dp.GetConnection()))
            {
                getIdCmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        newMaDocGia = reader.GetString(0);
                    }
                }
            }
            DateTime ngaySinh;
            if (!DateTime.TryParse(docGiaDTO.ngaySinh.ToString(), out ngaySinh) ||
                ngaySinh < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngaySinh > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngaySinh = DateTime.Now;
            }

            string insert = "INSERT INTO DocGia (MaDocGia, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email,TrangThai)" +
                            "VALUES(@maDG,@hoTen,@ngaySinh,@gioiTinh,@diaChi,@soDienThoai,@email,1)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maDG",newMaDocGia);
            cmd.Parameters.AddWithValue("@hoTen",docGiaDTO.hoTen);
            cmd.Parameters.AddWithValue("@gioiTinh",docGiaDTO.gioiTinh);
            cmd.Parameters.AddWithValue("@diaChi",docGiaDTO.diaChi);
            cmd.Parameters.AddWithValue("@soDienThoai",docGiaDTO.soDienThoai);
            cmd.Parameters.AddWithValue("@email",docGiaDTO.email);
            cmd.Parameters.AddWithValue("@ngaySinh",ngaySinh);
            cmd.Parameters.AddWithValue("@trangThai", docGiaDTO.TrangThai);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
    }
}
