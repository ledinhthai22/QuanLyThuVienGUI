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

    public class DocGiaDAO
    {

        DataProvider dp = new DataProvider();
        public DataTable GetDocGiaTheoTrangThai(DocGiaDTO docGiaDTO)
        {
            string query;

            if (docGiaDTO.TrangThai == 1)
                query = "SELECT * FROM DocGia WHERE TrangThai = 1";
            else
                query = "SELECT * FROM DocGia WHERE TrangThai = 0";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());

            if (docGiaDTO.TrangThai != 1)
                cmd.Parameters.AddWithValue("@TrangThai", docGiaDTO.TrangThai);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }

        public bool addDocGia(DocGiaDTO docGiaDTO)
        {
            string insert = "insert into DocGia(HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,Email,TrangThai)" +
                            "VALUES(@hoTen, @ngaySinh, @gioiTinh, @diaChi, @soDienThoai, @email,@trangThai)";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(insert, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@hoTen", docGiaDTO.hoTen);
                cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = docGiaDTO.ngaySinh.Date;
                string gioiTinh = docGiaDTO.gioiTinh;
                if (gioiTinh.Length > 10)
                {
                    throw new ArgumentException("GioiTinh value is too long.");
                }
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);

                cmd.Parameters.AddWithValue("@diaChi", docGiaDTO.diaChi);
                cmd.Parameters.AddWithValue("@soDienThoai", docGiaDTO.soDienThoai);
                cmd.Parameters.AddWithValue("@email", docGiaDTO.email);
                cmd.Parameters.AddWithValue("@trangThai", docGiaDTO.TrangThai);

                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }

        }

        public bool deleteDocGia(DocGiaDTO docGiaDTO)
        {
            string delete = "update DocGia SET TrangThai = 0 WHERE MaDocGia = @maDocGia";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(delete, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maDocGia", docGiaDTO.maDG);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }

        public bool updateDocGia(DocGiaDTO docGiaDTO)
        {
            string update = "update DocGia SET HoTen = @hoTen, NgaySinh = @ngaySinh, GioiTinh = @gioiTinh, DiaChi = @diaChi, SoDienThoai = @soDienThoai, Email = @email WHERE MaDocGia = @maDocGia";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(update, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maDocGia", docGiaDTO.maDG);
                cmd.Parameters.AddWithValue("@hoTen", docGiaDTO.hoTen);
                cmd.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = docGiaDTO.ngaySinh.Date;
                cmd.Parameters.AddWithValue("@gioiTinh", docGiaDTO.gioiTinh);
                cmd.Parameters.AddWithValue("@diaChi", docGiaDTO.diaChi);
                cmd.Parameters.AddWithValue("@soDienThoai", docGiaDTO.soDienThoai);
                cmd.Parameters.AddWithValue("@email", docGiaDTO.email);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }
        public bool khoiPhucSauKhiXoaMen(DocGiaDTO docGiaDTO)
        {
            string update = "update DocGia SET TrangThai = 1 WHERE MaDocGia = @maDocGia";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(update, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maDocGia", docGiaDTO.maDG);
                int n = cmd.ExecuteNonQuery();
                dp.Close();
                return n > 0;
            }
        }
        public DataTable timKiemTheoHoTen(DocGiaDTO docGiaDTO)
        {
            string query = "SELECT * FROM DocGia WHERE HoTen LIKE @keyWord";

            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyWord", "%" + docGiaDTO.hoTen + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dp.Close();
                return dt;
            }
        }

        public DataTable timKiemTheoSoDienThoai(DocGiaDTO docGiaDTO)
        {
            string query = "SELECT * FROM DocGia WHERE SoDienThoai LIKE @keyWord";

            dp.Open();
            using (SqlCommand cmd = new SqlCommand(query, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@keyWord", "%" + docGiaDTO.soDienThoai + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dp.Close();
                return dt;
            }
        }


        public bool kiemTraTonTai(DocGiaDTO docGiaDTO)
        {
            string select = "SELECT COUNT(*) FROM DocGia WHERE HoTen = @hoTen";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(select, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@hoTen", docGiaDTO.hoTen);

                int count = (int)cmd.ExecuteScalar();
                dp.Close();
                return count > 0;
            }
        }
        public bool kiemTraRangBuoc(DocGiaDTO docGiaDTO)
        {
            string select = "SELECT COUNT(*) FROM  PhieuMuon  WHERE MaDocGia = @maDG";
            dp.Open();
            using (SqlCommand cmd = new SqlCommand(select, dp.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@maDG", docGiaDTO.maDG);
                int count = (int)cmd.ExecuteScalar();

                dp.Close();
                return count > 0;
            }
        }

    }
}
