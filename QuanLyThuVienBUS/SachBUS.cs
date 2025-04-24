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
        public DataTable loadSach()
        {
            return sachDAO.loadSach();
        }
        public bool addSach(SachDTO sachDTO)
        {
            return SachDAO.addSach(sachDTO);
        }

        public bool kiemTraTonTai(SachDTO sachDTO)
        {
            return SachDAO.kiemTraTonTai(sachDTO);
        }
    }
}
