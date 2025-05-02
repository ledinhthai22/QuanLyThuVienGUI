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
    public class PhieuMuonDAO
    {
        private static DataProvider dp = new DataProvider();
        private List<PhieuMuonDTO> listPhieuMuon = new List<PhieuMuonDTO>();
        public List<PhieuMuonDTO> loadDSPM()
        {
            string select = "SELECT * FROM PhieuMuon";
            try
            {
                SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuMuon.Clear();

                while (dr.Read())
                {
                    PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
                    phieuMuonDTO.maPhieuMuon = dr["MaPhieuMuon"].ToString();
                    phieuMuonDTO.maDocGia = dr["MaDocGia"].ToString();
                    phieuMuonDTO.hoTenDocGia = dr["HoTenDocGia"].ToString();
                    phieuMuonDTO.maNhanVien = dr["MaNhanVien"].ToString();
                    phieuMuonDTO.ngayLap = dr["NgayLap"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayLap"]);
                    phieuMuonDTO.ngayTra = dr["NgayTra"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayTra"]);
                    phieuMuonDTO.soLuongSach = Convert.ToInt32(dr["SoLuongSach"]);
                    phieuMuonDTO.trangThai = Convert.ToInt32(dr["TrangThai"]);
                    listPhieuMuon.Add(phieuMuonDTO);
                }

                dp.Close();
                return listPhieuMuon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách phiếu mượn: " + ex.Message);
                return null;
            }
        }

        // Thay đổi kiểu trả về từ bool sang string để trả về mã phiếu mượn
        public static string createPhieuMuon(PhieuMuonDTO phieuMuonDTO)
        {
          
                dp.Open();
                SqlCommand getIdCmd = new SqlCommand("GetNextMaPhieuMuon", dp.GetConnection());
                getIdCmd.CommandType = CommandType.StoredProcedure;

                string newMaPhieuMuon = "";
                using (SqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        newMaPhieuMuon = reader.GetString(0);
                    }
                }

                DateTime ngayTra;
                if (!DateTime.TryParse(phieuMuonDTO.ngayTra.ToString(), out ngayTra) ||
                    ngayTra < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                    ngayTra > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                {
                    ngayTra = DateTime.Now;
                }

                DateTime ngayLap;
                if (!DateTime.TryParse(phieuMuonDTO.ngayLap.ToString(), out ngayLap) ||
                    ngayLap < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                    ngayLap > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                {
                    ngayLap = DateTime.Now;
                }

                string insert = "INSERT INTO PhieuMuon (MaPhieuMuon, MaDocGia, MaNhanVien, HoTenDocGia, NgayLap, NgayTra, SoLuongSach, TrangThai) " +
                                "VALUES (@maPhieuMuon, @maDocGia, @maNhanVien, @hoTenDocGia, @ngayLap, @ngayTra, @soLuongSach, 1)";
                SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
                cmd.Parameters.AddWithValue("@maPhieuMuon", newMaPhieuMuon);
                cmd.Parameters.AddWithValue("@maDocGia", phieuMuonDTO.maDocGia);
                cmd.Parameters.AddWithValue("@maNhanVien", phieuMuonDTO.maNhanVien);
                cmd.Parameters.AddWithValue("@hoTenDocGia", phieuMuonDTO.hoTenDocGia);
                cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                cmd.Parameters.AddWithValue("@ngayTra", ngayTra);
                cmd.Parameters.AddWithValue("@soLuongSach", phieuMuonDTO.soLuongSach);
                int n = cmd.ExecuteNonQuery();
                dp.Close();

                // Trả về mã phiếu mượn nếu thêm thành công, nếu không thì trả về chuỗi rỗng
                return n > 0 ? newMaPhieuMuon : "";
           
          
        }
        public static bool kiemTraMuon(string maDocGia)
        {
            string select = "SELECT COUNT(*) FROM PhieuMuon WHERE MaDocGia = @maDocGia AND TrangThai = 1";
            SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maDocGia", maDocGia);

            try
            {
                dp.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                dp.Close();
            }
        }

    }
}