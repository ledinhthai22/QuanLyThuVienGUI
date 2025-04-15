using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;



namespace QuanLyThuVienDAO
{
    public class TheLoaiDAO
    {
        DataProvider dp = new DataProvider();

        public DataTable getAllTheLoai()
        {
            DataTable dt = new DataTable();
            string select = "SELECT * FROM TheLoai";
            using (SqlDataAdapter da = new SqlDataAdapter(select, dp.GetConnection()))
            {
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable getTheLoaiByMaTL(TheLoaiDTO theLoaiDTO)
        {
            DataTable dt = new DataTable();
            string select = "SELECT TenTheLoai FROM TheLoai WHERE MaTheLoai = @maTL";
            using (SqlDataAdapter da = new SqlDataAdapter(select, dp.GetConnection()))
            {
                da.SelectCommand.Parameters.AddWithValue("@maTL", theLoaiDTO.maTL);
                da.Fill(dt);
            }
            return dt;
        }
        public bool addTheLoai(TheLoaiDTO theLoai)
        {
            SqlCommand getIdCmd = new SqlCommand("GetNextMaTheLoai", dp.GetConnection());
            getIdCmd.CommandType = CommandType.StoredProcedure;

            string newMaTheLoai = "";
            using (SqlDataReader reader = getIdCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    newMaTheLoai = reader.GetString(0);
                }
            }
            string insert = "INSERT INTO TheLoai (MaTheLoai, TenTheLoai) VALUES(@maTL,@tenTL)";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(insert, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maTL", newMaTheLoai);
                cmd.Parameters.AddWithValue("@tenTL", theLoai.tenTL);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }
        public bool deleteTheLoai(TheLoaiDTO theLoai)
        {
            string delete = "DELETE FROM TheLoai WHERE MaTheLoai = @maTL";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(delete, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maTL", theLoai.maTL);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }
        public bool updateTheLoai(TheLoaiDTO theLoai)
        {
            if (string.IsNullOrWhiteSpace(theLoai.tenTL))
            {
                return false;
            }
            string update = "UPDATE TheLoai SET TenTheLoai = @tenTL WHERE MaTheLoai = @maTL";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(update, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@tenTL", theLoai.tenTL);
                cmd.Parameters.AddWithValue("@maTL", theLoai.maTL);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }
        public DataTable TimKiemTheLoai(string keyword)
        {
            string query = "SELECT * FROM TheLoai WHERE TenTheLoai LIKE @keyword";
            SqlDataAdapter da = new SqlDataAdapter(query, dp.GetConnection());
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool kiemTraRangBuoc(TheLoaiDTO theLoaiDTO)
        {
            string query = "SELECT COUNT(*) FROM Sach WHERE MaTheLoai = @maTL";

            try
            {
                dp.Open();
                using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@maTL", theLoaiDTO.maTL);
                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra ràng buộc với bảng Sách: " + ex.Message);
            }
            finally
            {
                dp.Close();
            }
        }

        public bool kiemTraTonTai(TheLoaiDTO theLoaiDTO)
        {
            string select = "SELECT COUNT(*) FROM TheLoai WHERE TenTheLoai = @tenTL";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(select, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@tenTL", theLoaiDTO.tenTL);
                int n = (int)cmd.ExecuteScalar();
                dp.Close();
                return n > 0;
            }
        }

    }
}
