using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class ThongKeDAO
    {
        DataProvider dp = new DataProvider();
        public List<ThongKeDTO> thongKeNguoiMuonTheoNgay()
        {
            List<ThongKeDTO> danhSach = new List<ThongKeDTO>();
            string query = "SELECT CONVERT(DATE, NgayLap) AS Ngay, COUNT(DISTINCT MaDocGia) AS SoNguoiMuon " +
                           "FROM PhieuMuon GROUP BY CONVERT(DATE, NgayLap) ORDER BY Ngay";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
            dp.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ThongKeDTO tk = new ThongKeDTO()
                {
                    NgayMuon = reader.GetDateTime(0),
                    SoNguoiMuon = reader.GetInt32(1)
                };
                danhSach.Add(tk);
            }

            dp.Close();
            return danhSach;
        }
    }
}
