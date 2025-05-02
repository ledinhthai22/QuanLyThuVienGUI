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
    public class CTPhieuMuonDAO
    {
        static DataProvider dp = new DataProvider();
        
        public static bool createCThieuMuon(CTPhieuMuonDTO ctPhieuMuonDTO)
        {


            dp.Open();
            SqlCommand getIdCmd = new SqlCommand("GetNextMaCTPhieuMuon", dp.GetConnection());
            getIdCmd.CommandType = CommandType.StoredProcedure;

            string newCTMaPhieuMuon = "";
            using (SqlDataReader reader = getIdCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    newCTMaPhieuMuon = reader.GetString(0);
                }
            }
            DateTime ngayTra;
            if (!DateTime.TryParse(ctPhieuMuonDTO.ngayTra.ToString(), out ngayTra) ||
                ngayTra < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngayTra > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngayTra = DateTime.Now;
            }
            DateTime ngayMuon;
            if (!DateTime.TryParse(ctPhieuMuonDTO.ngayMuon.ToString(), out ngayMuon) ||
                ngayMuon < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue ||
                ngayMuon > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
            {
                ngayMuon = DateTime.Now;
            }

            string insert = "INSERT INTO CTPhieuMuon (MaCTPhieuMuon, MaPhieuMuon, MaSach, NgayMuon, NgayTra, NgayThucTe) " +
                  "VALUES (@maCTPhieuMuon, @maPhieuMuon, @maSach, @ngayMuon, @ngayTra, NULL)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maCTPhieuMuon", newCTMaPhieuMuon);
            cmd.Parameters.AddWithValue("@maPhieuMuon", ctPhieuMuonDTO.maPhieuMuon);
            cmd.Parameters.AddWithValue("@maSach", ctPhieuMuonDTO.maSach);
            cmd.Parameters.AddWithValue("@ngayMuon", ngayMuon);
            cmd.Parameters.AddWithValue("@ngayTra", ngayTra);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0;
        }

    }
}
