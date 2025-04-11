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
            string query;
            SqlCommand cmd;

            if (sachDTO.trangThai == -1)
            {
                // Lấy tất cả sách, không lọc trạng thái
                query = "SELECT * FROM Sach";
                cmd = new SqlCommand(query, dp.GetConnection());
            }
            else
            {
                // Lọc theo trạng thái 0 hoặc 1
                query = "SELECT * FROM Sach WHERE TrangThai = @TrangThai";
                cmd = new SqlCommand(query, dp.GetConnection());
                cmd.Parameters.AddWithValue("@TrangThai", sachDTO.trangThai);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }

        public bool addSach(SachDTO sachDTO)
        {
            string insert = "INSERT INTO Sach (TenSach, TacGia, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuong, HinhAnh, MoTa,TrangThai) "
                + "VALUES (@tenSach, @tacGia, @maTheLoai, @namXuatBan, @nhaXuatBan, @soLuong, @hinhAnh, @moTa,@trangThai)";
            dp.Open();
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@tacGia", sachDTO.tacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            cmd.Parameters.Add("@namXuatBan", SqlDbType.Date).Value = sachDTO.namXuatBan.Date;
            cmd.Parameters.AddWithValue("@nhaXuatBan", sachDTO.nhaXuatBan);
            cmd.Parameters.AddWithValue("@soLuong", sachDTO.soLuong);
            cmd.Parameters.AddWithValue("@hinhAnh", sachDTO.hinhAnh);
            cmd.Parameters.AddWithValue("@moTa", sachDTO.moTa);
            cmd.Parameters.AddWithValue("@trangThai", sachDTO.trangThai);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public bool deleteSach(SachDTO sachDTO)
        {
            string delete = "DELETE FROM Sach WHERE MaSach = @MaSach";
            dp.Open();
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", sachDTO.maSach);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public bool updateSach(SachDTO sachDTO)
        {
            string update = "UPDATE Sach SET TenSach = @tenSach, TacGia = @tacGia, MaTheLoai = @maTheLoai, " +
                "NamXuatBan = @namXuatBan, NhaXuatBan = @nhaXuatBan," +
                " SoLuong = @soLuong, HinhAnh = @hinhAnh, MoTa = @moTa," +
                "TrangThai = @trangThai WHERE MaSach = @maSach";
            dp.Open();
            SqlCommand cmd = new SqlCommand(update, dp.GetConnection());
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public bool khoiPhucSach(SachDTO sachDTO)
        {
            string restore = "UPDATE Sach SET TrangThai = 1 WHERE MaSach = @maSach";
            dp.Open();
            SqlCommand cmd = new SqlCommand(restore, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", sachDTO.maSach);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public bool kiemTraRangBuoc(SachDTO sachDTO)
        {
            string query = "SELECT * FROM PhieuMuon WHERE MaSach = @maSach";
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
            string query = "SELECT * FROM Sach WHERE TenSach = @tenSach AND MaTheLoai = @maTheLoai";
            dp.Open();
            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            object result = cmd.ExecuteScalar();
            int n = result != null ? Convert.ToInt32(result) : 0;
            dp.Close();
            return n > 0;
        }
    }
}
