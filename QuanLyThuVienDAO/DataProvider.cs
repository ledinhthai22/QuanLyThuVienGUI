using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVienDAO
{
    public class DataProvider
    {
        private string strconn = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True;TrustServerCertificate=True";
        protected SqlConnection conn;
        public DataProvider()
        {
           
            conn = new SqlConnection(strconn);
           
        }
        public SqlConnection GetConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
