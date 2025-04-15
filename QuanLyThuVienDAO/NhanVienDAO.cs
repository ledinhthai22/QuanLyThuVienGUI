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
    public class NhanVienDAO
    {

        private DataProvider dp = new DataProvider();
        public DataTable getNhanVien(NhanVienDTO nhanVienDTO)
        {
            string query;

            if (nhanVienDTO.trangThai == 1)
                query = "SELECT * FROM NhanVien WHERE TrangThai = 1";
            else
                query = "SELECT * FROM NhanVien WHERE TrangThai = 0";

            SqlCommand cmd = new SqlCommand(query, dp.GetConnection());

            if (nhanVienDTO.trangThai != 1)
                cmd.Parameters.AddWithValue("@TrangThai", nhanVienDTO.trangThai);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
    }
}
