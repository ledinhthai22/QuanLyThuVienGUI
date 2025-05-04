using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyThuVienDTO;

namespace QuanLyThuVienDAO
{
    public class ThongKeDAO
    {
        DataProvider dp = new DataProvider();

        public List<ThongKeDTO> ThongKeToanBo(DateTime tuNgay, DateTime denNgay)
        {
            List<ThongKeDTO> ds = new List<ThongKeDTO>();
            string query = @"
        SELECT 
            s.TenSach, 
            COUNT(ct.MaCTPhieuMuon) AS SoLuotMuon, 
            s.SoLuong, 
            (SELECT COUNT(DISTINCT pm.MaDocGia) 
             FROM PhieuMuon pm 
             WHERE pm.NgayLap BETWEEN @tuNgay AND @denNgay) AS SoNguoiMuon
        FROM 
            CTPhieuMuon ct
        JOIN 
            Sach s ON s.MaSach = ct.MaSach
        WHERE 
            ct.NgayMuon BETWEEN @tuNgay AND @denNgay
        GROUP BY 
            s.TenSach, s.SoLuong";

            try
            {
                
                    dp.Open(); // QUAN TRỌNG: mở kết nối tại đây
                    using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
                    {
                        dp.Open();
                        cmd.Parameters.Add("@tuNgay", SqlDbType.DateTime).Value = tuNgay;
                        cmd.Parameters.Add("@denNgay", SqlDbType.DateTime).Value = denNgay;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ThongKeDTO tk = new ThongKeDTO
                                {
                                    TenSach = reader["TenSach"].ToString(),
                                    SoLuotMuon = Convert.ToInt32(reader["SoLuotMuon"]),
                                    SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                    SoNguoiMuon = Convert.ToInt32(reader["SoNguoiMuon"])
                                };
                                ds.Add(tk);
                            }
                        }
                    }
                    dp.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê dữ liệu: " + ex.Message);
            }

            return ds;
        }


    }
}
