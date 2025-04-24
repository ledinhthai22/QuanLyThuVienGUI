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

    public class SachDAO
    {
        static DataProvider dp = new DataProvider();
        SachDTO sachDTO = new SachDTO();
        public DataTable loadSach()
        {
            string query = "SELECT S.MaSach, S.TenSach, S.TacGia, S.MaTheLoai, TL.TenTheLoai, " +
               "S.NamXuatBan, S.NhaXuatBan, S.SoLuong, S.MoTa, S.TrangThai " +
               "FROM Sach S JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai " +
               "WHERE S.TrangThai = 1 AND S.SoLuong > 0";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }


        public static bool addSach(SachDTO sachDTO)
        {
            dp.Open();
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

            string insert = "INSERT INTO Sach (MaSach, TenSach, TacGia, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuong, MoTa, TrangThai) " +
                            "VALUES (@maSach, @tenSach, @tacGia, @maTheLoai, @namXuatBan, @nhaXuatBan, @soLuong, @moTa, 1)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", newMaSach);
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@tacGia", sachDTO.tacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            cmd.Parameters.Add("@namXuatBan", SqlDbType.Date).Value = sachDTO.namXuatBan.Date;
            cmd.Parameters.AddWithValue("@nhaXuatBan", sachDTO.nhaXuatBan);
            cmd.Parameters.AddWithValue("@soLuong", sachDTO.soLuong);
            cmd.Parameters.AddWithValue("@moTa", sachDTO.moTa);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }

        public static bool kiemTraTonTai(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE TenSach = @tenSach";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
                int count = (int)cmd.ExecuteScalar();
                dp.Close();
                return count > 0;
            }
        }
        public static bool kiemTraSachDangDuocMuon(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM ChiTietPhieuMuon WHERE MaSach = @MaSach"; // giả sử TrangThai = 0 là chưa trả
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@MaSach", sachDTO.maSach);
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // nếu có dòng thoả => sách đang được mượn
            }

        }

    }
}
