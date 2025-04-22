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
        public DataTable LoadDSDG()
        {
            string select = "SELECT * FROM Docgia WHERE Trangthai = 1 ";
            SqlCommand cmd = new SqlCommand(select, dp.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
    }
}
