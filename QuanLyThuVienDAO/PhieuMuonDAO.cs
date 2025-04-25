using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class PhieuMuonDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable getPhieuMuon()
        {
            DataTable dt = new DataTable();
            string select = "SELECT * FROM PhieuMuon join DocGia on PhieuMuon.MaDocGia = DocGia.MaDocGia";
            using (SqlDataAdapter da = new SqlDataAdapter(select, dp.GetConnection()))
            {
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable getDSDocGia() 
        {
            DataTable dt = new DataTable();
            string select = "SELECT * FROM DocGia";
            using (SqlDataAdapter da = new SqlDataAdapter(select, dp.GetConnection()))
            {
                da.Fill(dt);
            }
            return dt;
        }
        public bool addPhieuMuon(PhieuMuonDTO phieuMuonDTO)
        {
            string insert = "INSERT INTO PhieuMuon (SoLuongSach, NgayLap, NgayHenTra) " +
                "VALUES (@SoLuongSach, @NgayLap, @NgayHenTra)";

            using (SqlConnection conn = dp.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@SoLuongSach", phieuMuonDTO.soLuong);
                    cmd.Parameters.AddWithValue("@NgayLap", phieuMuonDTO.ngayLap.Date);
                    cmd.Parameters.AddWithValue("@NgayHenTra", phieuMuonDTO.ngayHenTra.Date);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }

        }


    }
}
