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
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        public List<PhieuMuonDTO> loadDSPMDangMuon()
        {
            string select = "SELECT * FROM PhieuMuon WHERE TrangThai = 1";
            try
            {
                SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuMuon.Clear();

                while (dr.Read())
                {
                    PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
                    phieuMuonDTO.MaPhieuMuon = dr["MaPhieuMuon"].ToString();
                    phieuMuonDTO.MaDocGia = dr["MaDocGia"].ToString();
                    phieuMuonDTO.HoTenDocGia = dr["HoTenDocGia"].ToString();
                    phieuMuonDTO.MaNhanVien = dr["MaNhanVien"].ToString();
                    phieuMuonDTO.NgayLap = dr["NgayLap"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayLap"]);
                    phieuMuonDTO.NgayTra = dr["NgayTra"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayTra"]);
                    phieuMuonDTO.SoLuongSach = Convert.ToInt32(dr["SoLuongSach"]);
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


        public List<PhieuMuonDTO> loadDSPMDaTra()
        {
            string query = @"SELECT PM.MaPhieuMuon, 
                            PM.MaDocGia, 
                            PM.HoTenDocGia, 
                            PM.MaNhanVien, 
                            PM.NgayLap, 
                            PM.NgayTra, 
                            PM.SoLuongSach, 
                            PM.TrangThai, 
                            PM.GhiChu,
                            CTPM.MaCTPhieuMuon, 
                            CTPM.NgayThucTe
                            FROM PhieuMuon PM
                            JOIN CTPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                            WHERE PM.TrangThai = 0 AND CTPM.TrangThai = 0
                            AND CTPM.NgayThucTe IS NOT NULL";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuMuon.Clear();

                while (dr.Read())
                {
                    PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO
                    {
                        MaPhieuMuon = dr["MaPhieuMuon"].ToString(),
                        MaCTPhieuMuon = dr["MaCTPhieuMuon"].ToString(),
                        MaDocGia = dr["MaDocGia"].ToString(),
                        HoTenDocGia = dr["HoTenDocGia"].ToString(),
                        MaNhanVien = dr["MaNhanVien"].ToString(),
                        NgayLap = dr["NgayLap"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayLap"]),
                        NgayTra = dr["NgayTra"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayTra"]),
                        NgayTraThucTe = dr["NgayThucTe"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayThucTe"]),
                        GhiChu = dr["GhiChu"].ToString(),
                        SoLuongSach = Convert.ToInt32(dr["SoLuongSach"]),
                        TrangThaiPhieuMuon = Convert.ToInt32(dr["TrangThai"])
                    };
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
        public List<PhieuMuonDTO> loadDSPMDaTraDeThanhToan()
        {
            string query = @"
                            SELECT 
                            PM.MaPhieuMuon, 
                            PM.MaDocGia, 
                            PM.HoTenDocGia, 
                            PM.MaNhanVien, 
                            PM.NgayLap, 
                            PM.NgayTra, 
                            PM.SoLuongSach, 
                            PM.TrangThai AS TrangThaiPhieuMuon, 
                            PM.GhiChu,
                            CTPM.MaCTPhieuMuon, 
                            CTPM.NgayThucTe,
                            PP.MaPhieuPhat,
                            PP.TrangThai AS TrangThaiPhieuPhat
                            FROM PhieuMuon PM
                            JOIN CTPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                            LEFT JOIN PhieuPhat PP ON CTPM.MaCTPhieuMuon = PP.MaCTPhieuMuon
                            WHERE PM.TrangThai = 0 AND PP.TrangThai = 1
                            AND CTPM.NgayThucTe IS NOT NULL";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuMuon.Clear();

                while (dr.Read())
                {
                    PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO
                    {
                        MaPhieuMuon = dr["MaPhieuMuon"].ToString(),
                        MaCTPhieuMuon = dr["MaCTPhieuMuon"].ToString(),
                        MaDocGia = dr["MaDocGia"].ToString(),
                        HoTenDocGia = dr["HoTenDocGia"].ToString(),
                        MaNhanVien = dr["MaNhanVien"].ToString(),
                        NgayLap = dr["NgayLap"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayLap"]),
                        NgayTra = dr["NgayTra"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayTra"]),
                        NgayTraThucTe = dr["NgayThucTe"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayThucTe"]),
                        GhiChu = dr["GhiChu"].ToString(),
                        SoLuongSach = Convert.ToInt32(dr["SoLuongSach"]),
                        TrangThaiPhieuMuon = Convert.ToInt32(dr["TrangThaiPhieuMuon"]),
                        MaPhieuPhat = dr["MaPhieuPhat"].ToString(),
                        TrangThaiPhieuPhat = dr["TrangThaiPhieuPhat"] == DBNull.Value ? -1 : Convert.ToInt32(dr["TrangThaiPhieuPhat"]) // Trạng thái phiếu phạt có thể NULL
                    };
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


        public List<PhieuMuonDTO> loadDanhSachPhieuMuonVaCTPhieuMuon()
        {
            string select = @"SELECT PM.MaPhieuMuon, PM.MaDocGia, PM.HoTenDocGia, PM.MaNhanVien,
                              PM.NgayLap, PM.NgayTra, CTPM.NgayThucTe, PM.TrangThai,
                              COUNT(CTPM.MaSach) AS SoLuongSach
                              FROM PhieuMuon PM
                              JOIN CTPhieuMuon CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                              WHERE PM.TrangThai = 1
                              GROUP BY PM.MaPhieuMuon, PM.MaDocGia, PM.HoTenDocGia, PM.MaNhanVien,
                              PM.NgayLap, PM.NgayTra, CTPM.NgayThucTe, PM.TrangThai";

            try
            {
                listPhieuMuon.Clear();

                
                    dp.Open();
                    using (SqlCommand cmd = new SqlCommand(select, dp.GetConnection()))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO
                            {
                                MaPhieuMuon = dr["MaPhieuMuon"].ToString(),
                                MaDocGia = dr["MaDocGia"].ToString(),
                                HoTenDocGia = dr["HoTenDocGia"].ToString(),
                                MaNhanVien = dr["MaNhanVien"].ToString(),
                                NgayLap = dr["NgayLap"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayLap"]),
                                NgayTra = dr["NgayTra"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayTra"]),
                                NgayTraThucTe = dr["NgayThucTe"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayThucTe"]),
                                SoLuongSach = Convert.ToInt32(dr["SoLuongSach"]),
                                TrangThaiPhieuMuon = Convert.ToInt32(dr["TrangThai"])
                            };

                            listPhieuMuon.Add(phieuMuonDTO);
                        }
                    }
                

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
                if (!DateTime.TryParse(phieuMuonDTO.NgayTra.ToString(), out ngayTra) ||
                    ngayTra < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                    ngayTra > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                {
                    ngayTra = DateTime.Now;
                }

                DateTime ngayLap;
                if (!DateTime.TryParse(phieuMuonDTO.NgayLap.ToString(), out ngayLap) ||
                    ngayLap < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                    ngayLap > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                {
                    ngayLap = DateTime.Now;
                }

                string insert = "INSERT INTO PhieuMuon (MaPhieuMuon, MaDocGia, MaNhanVien, HoTenDocGia, NgayLap, NgayTra, SoLuongSach, TrangThai) " +
                                "VALUES (@maPhieuMuon, @maDocGia, @maNhanVien, @hoTenDocGia, @ngayLap, @ngayTra, @soLuongSach, 1)";
                SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
                cmd.Parameters.AddWithValue("@maPhieuMuon", newMaPhieuMuon);
                cmd.Parameters.AddWithValue("@maDocGia", phieuMuonDTO.MaDocGia);
                cmd.Parameters.AddWithValue("@maNhanVien", phieuMuonDTO.MaNhanVien);
                cmd.Parameters.AddWithValue("@hoTenDocGia", phieuMuonDTO.HoTenDocGia);
                cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                cmd.Parameters.AddWithValue("@ngayTra", ngayTra);
                cmd.Parameters.AddWithValue("@soLuongSach", phieuMuonDTO.SoLuongSach);
                int n = cmd.ExecuteNonQuery();
                dp.Close();

                // Trả về mã phiếu mượn nếu thêm thành công, nếu không thì trả về chuỗi rỗng
                return n > 0 ? newMaPhieuMuon : "";
           
          
        }
        
        public static bool traSach(PhieuMuonDTO phieuMuonDTO)
        {
            string updateCTPhieuMuon = "UPDATE CTPhieuMuon SET NgayThucTe = @ngayThucTe, TrangThai = 0 WHERE MaPhieuMuon = @maPhieuMuon";
            string updatePhieuMuon = "UPDATE PhieuMuon SET TrangThai = 0 ,GhiChu = @ghiChu WHERE MaPhieuMuon = @maPhieuMuon";
           

            try
            {
                dp.Open();

                // Cập nhật CTPhieuMuon
                SqlCommand cmdCT = new SqlCommand(updateCTPhieuMuon, dp.GetConnection());
                cmdCT.Parameters.AddWithValue("@maPhieuMuon", phieuMuonDTO.MaPhieuMuon);
                cmdCT.Parameters.AddWithValue("@ngayThucTe", phieuMuonDTO.NgayTraThucTe);
                int result1 = cmdCT.ExecuteNonQuery();

                // Cập nhật PhieuMuon
                SqlCommand cmdPM = new SqlCommand(updatePhieuMuon, dp.GetConnection());
                cmdPM.Parameters.AddWithValue("@maPhieuMuon", phieuMuonDTO.MaPhieuMuon);
                cmdPM.Parameters.AddWithValue("@ghiChu",phieuMuonDTO.GhiChu);
                int result2 = cmdPM.ExecuteNonQuery();
                CreatePhieuPhat(new PhieuPhatDTO(), phieuMuonDTO.MaPhieuMuon, phieuMuonDTO.MaCTPhieuMuon);

                // Trả về true nếu cả hai cập nhật đều thành công
                return result1 > 0 && result2 > 0 ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật trạng thái trả sách: " + ex.Message);
                return false;
            }
            finally
            {
                dp.Close();
            }
        }
        public static bool CreatePhieuPhat(PhieuPhatDTO phieuPhatDTO, string maPhieuMuon, string maCTPhieuMuon)
        {
            dp.Open();

            // Gọi stored procedure để sinh mã mới
            SqlCommand getIdCmd = new SqlCommand("GetNextMaPhieuPhat", dp.GetConnection());
            getIdCmd.CommandType = CommandType.StoredProcedure;

            string newMaPhieuPhat = "";
            using (SqlDataReader reader = getIdCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    newMaPhieuPhat = reader.GetString(0);
                }
            }

            // Câu lệnh INSERT đã cập nhật đúng cột
            string insert = @"INSERT INTO PhieuPhat 
                      (MaPhieuPhat, MaPhieuMuon, MaCTPhieuMuon, SoTien, LyDoPhat, NgayThanhToan, TrangThai)
                      VALUES 
                      (@maPhieuPhat, @maPhieuMuon, @maCTPhieuMuon, null, null, null, 1)";

            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maPhieuPhat", newMaPhieuPhat);
            cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
            cmd.Parameters.AddWithValue("@maCTPhieuMuon", maCTPhieuMuon);
            // kiểu DateTime
                

            int n = cmd.ExecuteNonQuery();
            dp.Close();

            return n > 0;
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