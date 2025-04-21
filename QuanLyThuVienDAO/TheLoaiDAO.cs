using System;
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
    public class TheLoaiDAO
    {
        public static DataProvider dp = new DataProvider();
        public static List<TheLoaiDTO> listTheLoai = new List<TheLoaiDTO>();
        public List<TheLoaiDTO> loadTheLoai()
        {
            string query = "SELECT * FROM TheLoai";
            try
            {
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                SqlDataReader dr = cmd.ExecuteReader();
                listTheLoai.Clear();
                while (dr.Read())
                {
                    TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
                    theLoaiDTO.maTL = dr["MaTheLoai"].ToString();
                    theLoaiDTO.tenTL = dr["TenTheLoai"].ToString();
                    listTheLoai.Add(theLoaiDTO);
                    
                }
                dp.Close();
                return listTheLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thể loại: " + ex.Message);
                return null;
            }
        }
        public static bool addTheLoai(TheLoaiDTO theLoaiDTO)
        {
            string newMaTheLoai = "";
            dp.Open();
            using (SqlCommand getIdCmd = new SqlCommand("GetNextMaTheLoai", dp.GetConnection()))
            {
                getIdCmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = getIdCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        newMaTheLoai = reader.GetString(0);
                    }
                }
            }
            string insert = "INSERT INTO TheLoai (MaTheLoai, TenTheLoai) VALUES(@maTL, @tenTL)";
            SqlCommand cmd = new SqlCommand(insert, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maTL", newMaTheLoai);
            cmd.Parameters.AddWithValue("@tenTL", theLoaiDTO.tenTL);
            int n = cmd.ExecuteNonQuery();
            dp.Close();
            return n > 0; 
        }
        public static bool deleteTheLoai(string maTL)
        {
            string delete = "DELETE FROM TheLoai WHERE MaTheLoai = @maTL";
            SqlCommand cmd = new SqlCommand(delete, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maTL", maTL);
            int n = cmd.ExecuteNonQuery();
            return n > 0;
        }
        public static bool updateTheLoai(TheLoaiDTO theLoaiDTO)
        {
            string update = "UPDATE TheLoai SET TenTheLoai = @tenTL WHERE MaTheLoai = @maTL";
            SqlCommand cmd = new SqlCommand(update, dp.GetConnection());
            cmd.Parameters.AddWithValue("@maTL", theLoaiDTO.maTL);
            cmd.Parameters.AddWithValue("@tenTL", theLoaiDTO.tenTL);
            int n = cmd.ExecuteNonQuery();
            return n > 0;
        }
        public static bool kiemTraTheLoaiDangDuocSuDung(TheLoaiDTO theLoaiDTO)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE MaTheLoai = @maTL";
            try
            {
                dp.Open(); 
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                cmd.Parameters.AddWithValue("@maTL", theLoaiDTO.maTL);

                int count = (int)cmd.ExecuteScalar(); 
                dp.Close(); 
                return count > 0;
            }
            catch (Exception ex)
            {
                dp.Close(); 
                MessageBox.Show("Lỗi kiểm tra thể loại đang được sử dụng: " + ex.Message);
                return false;
            }
        }


        public static bool kiemTraTonTai(TheLoaiDTO theLoaiDTO)
        {
            string query = "SELECT COUNT(*) FROM TheLoai WHERE TenTheLoai = @tenTL";
            try
            {
                dp.Open(); 
                SqlCommand cmd = new SqlCommand(query, dp.GetConnection());
                cmd.Parameters.AddWithValue("@tenTL", theLoaiDTO.tenTL);
                int count = (int)cmd.ExecuteScalar(); 
                dp.Close(); 
                return count > 0;
            }
            catch (Exception ex)
            {
                dp.Close();
                MessageBox.Show("Lỗi khi kiểm tra thể loại tồn tại: " + ex.Message);
                return false;
            }
        }
    }
}

