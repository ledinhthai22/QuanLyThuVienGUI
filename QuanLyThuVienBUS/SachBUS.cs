using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public DataTable getSach(SachDTO sachDTO)
        {
            return sachDAO.getSach(sachDTO);
        }
        public bool addSach(SachDTO sachDTO)
        {
            return sachDAO.addSach(sachDTO);
        }
        public bool deleteSach(SachDTO sachDTO)
        {
            return sachDAO.deleteSach(sachDTO);
        }
        public bool kiemTraTonTai(SachDTO sachDTO)
        {
            return sachDAO.kiemTraTonTai(sachDTO);
        }
    }
}
