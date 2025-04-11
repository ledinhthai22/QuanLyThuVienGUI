using System;

public class DataProvider
{
    private string strcon = @"Data Source=LEDINHTHAI;Initial Catalog=QuanLyThuVien;Integrated Security=True;TrustServerCertificate=True";
    protected SqlConnection conn;
    public DataProvider()
	{
		try
		{
			conn = new SqlConnection(strcon);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
    public void openConn()
    {
        conn.Open();
    }
    public void closeConn()
    {
        conn.Close();
    }
    public SqlConnection getConnection()
    {
        return conn;
    }
}
