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
        public List<SachDTO> loadSach()
        {
            List<SachDTO> danhSach = new List<SachDTO>();
            string query = "SELECT S.MaSach, S.TenSach, S.TacGia, S.MaTheLoai, TL.TenTheLoai, " +
                           "S.NamXuatBan, S.NhaXuatBan, S.SoLuong, S.MoTa, S.TrangThai, S.NhaCungCap " +
                           "FROM Sach S JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SachDTO s = new SachDTO();
                s.maSach = reader["MaSach"].ToString();
                s.tenSach = reader["TenSach"].ToString();
                s.tacGia = reader["TacGia"].ToString();
                s.maTheLoai = reader["MaTheLoai"].ToString();
                s.tenTheLoai = reader["TenTheLoai"].ToString();
                s.namXuatBan = DateTime.Parse(reader["NamXuatBan"].ToString());
                s.nhaXuatBan = reader["NhaXuatBan"].ToString();
                s.soLuong = int.Parse(reader["SoLuong"].ToString());
                s.moTa = reader["MoTa"].ToString();
                s.trangThai = int.Parse(reader["TrangThai"].ToString());
                s.nhaCungCap = reader["NhaCungCap"].ToString();
                danhSach.Add(s);
            }

            reader.Close();
            return danhSach;
        }
        public List<SachDTO> loadSachMuon()
        {
            List<SachDTO> danhSach = new List<SachDTO>();
            string query = "SELECT S.MaSach, S.TenSach, S.TacGia, S.MaTheLoai, TL.TenTheLoai, " +
                           "S.NamXuatBan, S.NhaXuatBan, S.SoLuong, S.MoTa, S.TrangThai, S.NhaCungCap " +
                           "FROM Sach S JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai WHERE TrangThai = 1";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SachDTO s = new SachDTO();
                s.maSach = reader["MaSach"].ToString();
                s.tenSach = reader["TenSach"].ToString();
                s.tacGia = reader["TacGia"].ToString();
                s.maTheLoai = reader["MaTheLoai"].ToString();
                s.tenTheLoai = reader["TenTheLoai"].ToString();
                s.namXuatBan = DateTime.Parse(reader["NamXuatBan"].ToString());
                s.nhaXuatBan = reader["NhaXuatBan"].ToString();
                s.soLuong = int.Parse(reader["SoLuong"].ToString());
                s.moTa = reader["MoTa"].ToString();
                s.trangThai = int.Parse(reader["TrangThai"].ToString());
                s.nhaCungCap = reader["NhaCungCap"].ToString();
                danhSach.Add(s);
            }

            reader.Close();
            return danhSach;
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

            string insert = "INSERT INTO Sach (MaSach, TenSach, TacGia, MaTheLoai, NamXuatBan, NhaXuatBan, SoLuong, MoTa, TrangThai,NhaCungCap) " +
                            "VALUES (@maSach, @tenSach, @tacGia, @maTheLoai, @namXuatBan, @nhaXuatBan, @soLuong, @moTa, 1,@nhaCungCap)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", newMaSach);
            cmd.Parameters.AddWithValue("@tenSach", sachDTO.tenSach);
            cmd.Parameters.AddWithValue("@tacGia", sachDTO.tacGia);
            cmd.Parameters.AddWithValue("@maTheLoai", sachDTO.maTheLoai);
            cmd.Parameters.AddWithValue("@NamXuatBan", sachDTO.namXuatBan);
            cmd.Parameters.AddWithValue("@nhaXuatBan", sachDTO.nhaXuatBan);
            cmd.Parameters.AddWithValue("@soLuong", sachDTO.soLuong);
            cmd.Parameters.AddWithValue("@moTa", sachDTO.moTa);
            cmd.Parameters.AddWithValue("@nhaCungCap", sachDTO.nhaCungCap);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public static bool deteleSach(string maSach)
        {
            string delete = "DELETE FROM Sach WHERE MaSach = @maSach";
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maSach", maSach);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }
        public static bool updateSach(SachDTO sachDTO)
        {
            int trangThai = 0;
            if (sachDTO.soLuong > 0)
            {
                trangThai = 1;
            }
            else
            {
                trangThai = 0;
            }    

            string updateQuery = @"UPDATE Sach
                                SET TenSach = @TenSach, 
                                TacGia = @TacGia, 
                                MoTa = @MoTa, 
                                NhaXuatBan = @NhaXuatBan, 
                                NamXuatBan = @NamXuatBan, 
                                SoLuong = @SoLuong, 
                                MaTheLoai = @MaTheLoai, 
                                TrangThai = @TrangThai, 
                                NhaCungCap = @nhaCungCap
                                FROM Sach
                                JOIN TheLoai ON Sach.MaTheLoai = TheLoai.MaTheLoai
                                WHERE MaSach = @MaSach";

            try
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, dp.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@TenSach", sachDTO.tenSach);
                    cmd.Parameters.AddWithValue("@TacGia", sachDTO.tacGia);
                    cmd.Parameters.AddWithValue("@MoTa", sachDTO.moTa);
                    cmd.Parameters.AddWithValue("@NhaXuatBan", sachDTO.nhaXuatBan);
                    cmd.Parameters.AddWithValue("@NamXuatBan", sachDTO.namXuatBan);
                    cmd.Parameters.AddWithValue("@SoLuong", sachDTO.soLuong);
                    cmd.Parameters.AddWithValue("@MaTheLoai", sachDTO.maTheLoai);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@MaSach", sachDTO.maSach);
                    cmd.Parameters.AddWithValue("@nhaCungCap", sachDTO.nhaCungCap);

                    
                    int n = cmd.ExecuteNonQuery();

                    return n > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật sách: " + ex.Message);
                return false;
            }
        }



        public bool updateSachSauMuon(List<string> maSachList)
        {
           
            try
            {

                
                dp.Open();

                foreach (string maSach in maSachList)
                {
                    // Trước hết, lấy số lượng hiện tại của sách
                    string selectQuery = "SELECT SoLuong FROM SACH WHERE MaSach = @MaSach";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, dp.GetConnection());
                    selectCmd.Parameters.AddWithValue("@MaSach", maSach);

                    int currentQuantity = Convert.ToInt32(selectCmd.ExecuteScalar());

                    if (currentQuantity <= 0)
                    {
                        throw new Exception("Sách có mã " + maSach + " đã hết");
                    }

                    // Giảm số lượng sách đi 1
                    string updateQuery = "UPDATE SACH SET SoLuong = SoLuong - 1 WHERE MaSach = @MaSach";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, dp.GetConnection());
                    updateCmd.Parameters.AddWithValue("@MaSach", maSach);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    // Kiểm tra trạng thái sách sau khi cập nhật
                    string checkQuery = "SELECT SoLuong FROM SACH WHERE MaSach = @MaSach";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, dp.GetConnection());
                    checkCmd.Parameters.AddWithValue("@MaSach", maSach);

                    int newQuantity = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // Nếu số lượng = 0, cập nhật trạng thái thành "Không có sẵn"
                    if (newQuantity == 0)
                    {
                        string updateStatusQuery = "UPDATE SACH SET TrangThai = 0 WHERE MaSach = @MaSach";
                        SqlCommand statusCmd = new SqlCommand(updateStatusQuery, dp.GetConnection());
                        statusCmd.Parameters.AddWithValue("@MaSach", maSach);
                        statusCmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật sách sau mượn: " + ex.Message);
                return false;
            }
            finally
            {
                // Đảm bảo kết nối luôn được đóng ngay cả khi có lỗi
                dp.Close();
            }
        }

        public static bool kiemTraTonTai(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE TenSach = @TenSach";
            // nếu đang sửa, cần thêm điều kiện loại trừ sách cũ ra:
            if (sachDTO.maSach != null)
            {
                query += " AND MaSach != @MaSach";
            }

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            cmd.Parameters.AddWithValue("@TenSach", sachDTO.tenSach);

            if (sachDTO.maSach != null)
                cmd.Parameters.AddWithValue("@MaSach", sachDTO.maSach);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public static bool kiemTraSachDangDuocMuon(SachDTO sachDTO)
        {
            string query = "SELECT COUNT(*) FROM CTPhieuMuon WHERE MaSach = @MaSach";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@MaSach", sachDTO.maSach);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }

        }

    }
}
