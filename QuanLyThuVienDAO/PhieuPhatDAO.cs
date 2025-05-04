using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;
using System.Windows.Forms;
using System.Data;

namespace QuanLyThuVienDAO
{
    public class PhieuPhatDAO
    {
        private static DataProvider dp = new DataProvider();
        private List<PhieuPhatDTO> listPhieuPhat= new List<PhieuPhatDTO>();
        public List<PhieuPhatDTO> loadDSPPAll()
        {
            string query = "SELECT pp.MaPhieuPhat, pm.MaPhieuMuon, ctpm.MaCTPhieuMuon, dg.MaDocGia, dg.HoTen, SoTien, LyDoPhat, NgayThanhToan, pp.TrangThai " +
               "FROM PhieuPhat pp " +
               "JOIN PhieuMuon pm ON pp.MaPhieuMuon = pm.MaPhieuMuon " +
               "JOIN CTPhieuMuon ctpm ON pm.MaPhieuMuon = ctpm.MaPhieuMuon " +
               "JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuPhat.Clear();

                while (dr.Read())
                {
                    PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
                    phieuPhatDTO.maPhieuPhat = dr["MaPhieuPhat"].ToString();
                    phieuPhatDTO.maPhieuMuon = dr["MaPhieuMuon"].ToString();
                    phieuPhatDTO.maCTPhieuMuon = dr["MaCTPhieuMuon"].ToString();
                    phieuPhatDTO.maDocGia = dr["MaDocGia"].ToString();
                    phieuPhatDTO.hoTenDocGia = dr["HoTen"].ToString();
                    phieuPhatDTO.soTien = dr["SoTien"] != DBNull.Value ? Convert.ToInt32(dr["SoTien"]) : 0;
                    phieuPhatDTO.lyDoPhat = dr["LyDoPhat"] != DBNull.Value ? dr["LyDoPhat"].ToString() : "";
                    phieuPhatDTO.ngayThanhToan = dr["NgayThanhToan"] != DBNull.Value ? Convert.ToDateTime(dr["NgayThanhToan"]) : DateTime.Now;

                    phieuPhatDTO.trangThai = Convert.ToInt32(dr["TrangThai"]);
                    listPhieuPhat.Add(phieuPhatDTO);
                }
                dp.Close();
                return listPhieuPhat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách phiếu mượn: " + ex.Message);
                return null;
            }
        }
        //public static bool CreatePhieuPhat(PhieuPhatDTO phieuPhatDTO, string maPhieuMuon, string maCTPhieuMuon)
        //{
        //    dp.Open();

        //    // Gọi stored procedure để sinh mã mới
        //    SqlCommand getIdCmd = new SqlCommand("GetNextMaPhieuPhat", dp.GetConnection());
        //    getIdCmd.CommandType = CommandType.StoredProcedure;

        //    string newMaPhieuPhat = "";
        //    using (SqlDataReader reader = getIdCmd.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            newMaPhieuPhat = reader.GetString(0);
        //        }
        //    }

        //    // Câu lệnh INSERT đã cập nhật đúng cột
        //    string insert = @"INSERT INTO PhieuPhat 
        //              (MaPhieuPhat, MaPhieuMuon, MaCTPhieuMuon, SoTien, LyDoPhat, NgayThanhToan, TrangThai)
        //              VALUES 
        //              (@maPhieuPhat, @maPhieuMuon, @maCTPhieuMuon, @soTien, @lyDoPhat, @ngayThanhToan, @trangThai)";

        //    SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
        //    cmd.Parameters.AddWithValue("@maPhieuPhat", newMaPhieuPhat);
        //    cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
        //    cmd.Parameters.AddWithValue("@maCTPhieuMuon", maCTPhieuMuon);
        //    cmd.Parameters.AddWithValue("@soTien", phieuPhatDTO.soTien);
        //    cmd.Parameters.AddWithValue("@lyDoPhat", phieuPhatDTO.lyDoPhat);
        //    cmd.Parameters.AddWithValue("@ngayThanhToan", phieuPhatDTO.ngayThanhToan); // kiểu DateTime
        //    cmd.Parameters.AddWithValue("@trangThai", phieuPhatDTO.trangThai);         // kiểu tinyint

        //    int n = cmd.ExecuteNonQuery();
        //    dp.Close();

        //    return n > 0;
        //}
        public bool UpdatePhieuPhat(PhieuPhatDTO phieuPhatDTO)
        {
            try
            {
                dp.Open();

                
                string selectQuery = @"
                SELECT PP.MaPhieuPhat
                FROM PhieuMuon PM
                JOIN CTPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                LEFT JOIN PhieuPhat PP ON CTPM.MaCTPhieuMuon = PP.MaCTPhieuMuon
                WHERE PM.TrangThai = 0 AND PP.TrangThai = 1
                AND CTPM.NgayThucTe IS NOT NULL
                AND PP.MaPhieuPhat = @maPhieuPhat";

                SqlCommand cmd = new SqlCommand(selectQuery, dp.GetConnection());
                cmd.Parameters.AddWithValue("@maPhieuPhat", phieuPhatDTO.maPhieuPhat);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close(); 
                    string updateQuery = @"
                                            UPDATE PhieuPhat 
                                            SET TrangThai = 0, 
                                            LyDoPhat = @lyDoPhat, 
                                            SoTien = @soTien,
                                            NgayThanhToan = @ngayThanhToan
                                            WHERE MaPhieuPhat = @maPhieuPhat";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, dp.GetConnection());
                    updateCmd.Parameters.AddWithValue("@maPhieuPhat", phieuPhatDTO.maPhieuPhat);
                    updateCmd.Parameters.AddWithValue("@lyDoPhat", phieuPhatDTO.lyDoPhat);
                    updateCmd.Parameters.AddWithValue("@soTien", phieuPhatDTO.soTien);
                    updateCmd.Parameters.AddWithValue("@ngayThanhToan", phieuPhatDTO.ngayThanhToan);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Cập nhật phiếu phạt {phieuPhatDTO.maPhieuPhat} thành công.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Cập nhật phiếu phạt {phieuPhatDTO.maPhieuPhat} thất bại.");
                        return false;
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Không tìm thấy phiếu phạt hợp lệ để cập nhật.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu phạt: " + ex.Message);
                return false;
            }
            finally
            {
                dp.Close();
            }
        }

    }

}
