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

    public class SachDAO
    {
        DataProvider dp = new DataProvider();
        SachDTO sachDTO = new SachDTO();
        public DataTable getSach(SachDTO sachDTO)
        {
            string query = "SELECT * FROM Sach";
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }


        public bool addSach(SachDTO sachDTO)
        {
            dp.Open();

            // Gọi stored procedure để lấy mã sách mới
            SqlCommand getIdCmd = new SqlCommand("GetNextMaSach", dp.GetConnection());
            getIdCmd.CommandType = CommandType.StoredProcedure;

            string newMaSach = "";
            using (SqlDataReader reader = getIdCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    newMaSach = reader.GetString(0);
                }
            }

            // Thêm sách mới với mã sách đã lấy
            string insert = "INSERT INTO Sach (MaSach, TenSach, TacGia, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuong, MoTa, TrangThai) " +
                            "VALUES (@maSach, @tenSach, @tacGia, @maTheLoai, @namXuatBan, @nhaXuatBan, @soLuong, @moTa, @trangThai)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", newMaSach);
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@tacGia", sachDTO.tacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            cmd.Parameters.Add("@namXuatBan", SqlDbType.Date).Value = sachDTO.namXuatBan.Date;
            cmd.Parameters.AddWithValue("@nhaXuatBan", sachDTO.nhaXuatBan);
            cmd.Parameters.AddWithValue("@soLuong", sachDTO.soLuong);
            cmd.Parameters.AddWithValue("@moTa", sachDTO.moTa);
            cmd.Parameters.AddWithValue("@trangThai", sachDTO.trangThai);

            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }

        public bool deleteSach(SachDTO sachDTO)
        {
            string delete = "DELETE FROM Sach  WHERE MaSach = @MaSach";
            dp.Open();
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", sachDTO.maSach);
            int n = (int)cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public bool updateSach(SachDTO sachDTO)
        {
            string update = "UPDATE Sach SET TenSach = @tenSach, TacGia = @tacGia, MaTheLoai = @maTheLoai, " +
                            "NamXuatBan = @namXuatBan, NhaXuatBan = @nhaXuatBan, " +
                            "SoLuong = @soLuong, MoTa = @moTa, " +
                            "TrangThai = 1 WHERE MaSach = @maSach";

            dp.Open();
            SqlCommand cmd = new SqlCommand(update, dp.GetConnection());

            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@tacGia", sachDTO.tacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            cmd.Parameters.Add("@namXuatBan", SqlDbType.Date).Value = sachDTO.namXuatBan.Date;
            cmd.Parameters.AddWithValue("@nhaXuatBan", sachDTO.nhaXuatBan);
            cmd.Parameters.AddWithValue("@soLuong", sachDTO.soLuong);
            cmd.Parameters.AddWithValue("@moTa", sachDTO.moTa);
            cmd.Parameters.AddWithValue("@trangThai", sachDTO.trangThai);
            cmd.Parameters.AddWithValue("@maSach", sachDTO.maSach);

            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }


        public bool kiemTraRangBuoc(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM CTPhieuMuon WHERE MaSach = @maSach";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", sachDTO.maSach);
            int n = (int)cmd.ExecuteScalar();
            dp.Close();
            return n > 0;
        }
        // Kiểm tra tồn tại sách trong cơ sở dữ liệu
        public bool kiemTraTonTai(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE TenSach = @tenSach AND MaTheLoai = @maTheLoai";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);

            int n = (int)cmd.ExecuteScalar();
            dp.Close();
            return n > 0;
        }

    }
}
