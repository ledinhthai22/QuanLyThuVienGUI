using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class PhieuPhatBUS
    {
        PhieuPhatDAO phieuPhatDAO = new PhieuPhatDAO();
        public List<PhieuPhatDTO> loadDSPP()
        {
            return phieuPhatDAO.loadDSPP();
        }
    }
}
