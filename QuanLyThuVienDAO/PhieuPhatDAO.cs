using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;
using System.Windows.Forms;

namespace QuanLyThuVienDAO
{
    public class PhieuPhatDAO
    {
        private static DataProvider dp = new DataProvider();
        private List<PhieuPhatDTO> listPhieuPhat= new List<PhieuPhatDTO>();
        public List<PhieuPhatDTO> loadDSPPAll()
        {
            string select = "SELECT MaPhieuPhat, pm.MaPhieuMuon, MaCTPhieuMuon, dg.HoTen, SoTien, LyDoPhat, NgayThanhToan, pp.TrangThai " +
                "FROM PhieuPhat pp " +
                "JOIN PhieuMuon pm ON pp.MaPhieuMuon = pm.MaPhieuMuon " +
                "JOIN DocGia dg ON pm.MaDocGia = dg.MaDocGia";

            try
            {
                SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listPhieuPhat.Clear();

                while (dr.Read())
                {
                    PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
                    phieuPhatDTO.maPhieuPhat = dr["MaPhieuPhat"].ToString();
                    phieuPhatDTO.maPhieuMuon = dr["MaPhieuMuon"].ToString();
                    phieuPhatDTO.mactPhieuMuon = dr["MaCTPhieuMuon"].ToString();
                    phieuPhatDTO.hoTenDocGia = dr["HoTen"].ToString();
                    phieuPhatDTO.soTien = Convert.ToInt32(dr["SoTien"]);
                    phieuPhatDTO.lyDoPhat = dr["LyDoPhat"].ToString();
                    phieuPhatDTO.ngayThanhToan = dr["NgayThanhToan"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["NgayThanhToan"]);
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
    }
}
