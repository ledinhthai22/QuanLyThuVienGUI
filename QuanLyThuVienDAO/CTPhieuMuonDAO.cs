using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class CTPhieuMuonDAO
    {
        static DataProvider dp = new DataProvider();

        // Lấy danh sách sách đang được mượn bởi một độc giả cụ thể
        public static List<CTPhieuMuonDTO> GetDanhSachDangMuonTheoMaDocGia(string maDocGia)
        {
            string query = @"
                SELECT 
                    CTPM.MaCTPhieuMuon, 
                    CTPM.MaPhieuMuon, 
                    S.MaSach, 
                    S.TenSach, 
                    CTPM.NgayMuon, 
                    CTPM.NgayTra
                FROM CTPhieuMuon CTPM
                JOIN PhieuMuon PM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                JOIN Sach S ON S.MaSach = CTPM.MaSach
                WHERE PM.MaDocGia = @MaDocGia AND PM.TrangThai = 1";

            List<CTPhieuMuonDTO> danhSach = new List<CTPhieuMuonDTO>();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    dp.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new CTPhieuMuonDTO
                            {
                                maCTPhieuMuon = reader["MaCTPhieuMuon"].ToString(),
                                maPhieuMuon = reader["MaPhieuMuon"].ToString(),
                                maSach = reader["MaSach"].ToString(),
                                tenSach = reader["TenSach"].ToString(),
                                ngayMuon = Convert.ToDateTime(reader["NgayMuon"]),
                                ngayTra = Convert.ToDateTime(reader["NgayTra"])
                            };
                            danhSach.Add(item);
                        }
                    }
                    dp.Close();
                }

                return danhSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi DAO: " + ex.Message);
                return new List<CTPhieuMuonDTO>();
            }
        }

        // Tạo chi tiết phiếu mượn mới
        public static bool createCThieuMuon(CTPhieuMuonDTO ctPhieuMuonDTO)
        {
            try
            {
                dp.Open();

                // Lấy mã chi tiết phiếu mượn tiếp theo
                SqlCommand getIdCmd = new SqlCommand("GetNextMaCTPhieuMuon", dp.GetConnection())
                {
                    CommandType = CommandType.StoredProcedure
                };

                string newCTMaPhieuMuon = "";
                using (SqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        newCTMaPhieuMuon = reader.GetString(0);
                    }
                }

                // Xử lý ngày mượn và ngày trả an toàn với SQL
                DateTime ngayTra = ValidateDate(ctPhieuMuonDTO.ngayTra);
                DateTime ngayMuon = ValidateDate(ctPhieuMuonDTO.ngayMuon);

                // Thêm dữ liệu
                string insert = @"
                    INSERT INTO CTPhieuMuon (MaCTPhieuMuon, MaPhieuMuon, MaSach, NgayMuon, NgayTra, NgayThucTe) 
                    VALUES (@maCTPhieuMuon, @maPhieuMuon, @maSach, @ngayMuon, @ngayTra, NULL)";
                SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
                cmd.Parameters.AddWithValue("@maCTPhieuMuon", newCTMaPhieuMuon);
                cmd.Parameters.AddWithValue("@maPhieuMuon", ctPhieuMuonDTO.maPhieuMuon);
                cmd.Parameters.AddWithValue("@maSach", ctPhieuMuonDTO.maSach);
                cmd.Parameters.AddWithValue("@ngayMuon", ngayMuon);
                cmd.Parameters.AddWithValue("@ngayTra", ngayTra);

                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo chi tiết phiếu mượn: " + ex.Message);
                return false;
            }
            finally
            {
                dp.Close();
            }
        }
        public List<string> LayDanhSachMaSachDaMuon(string maPhieuMuon)
        {
            List<string> maSachList = new List<string>();

            try
            {
                dp.Open();

                string query = "SELECT MaSach FROM CTPHIEUMUON WHERE MaPhieuMuon = @MaPhieuMuon";
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                cmd.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maSachList.Add(reader["MaSach"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách mã sách: " + ex.Message);
            }
            finally
            {
                dp.Close();
            }

            return maSachList;
        }


        // Hàm hỗ trợ kiểm tra ngày có hợp lệ với SQL Server
        private static DateTime ValidateDate(DateTime inputDate)
        {
            if (inputDate < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                inputDate > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                return DateTime.Now;
            }
            return inputDate;
        }
    }
}
