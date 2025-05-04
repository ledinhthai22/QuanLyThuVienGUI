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
        public List<PhieuPhatDTO> loadDSPPAll()
        {
            return phieuPhatDAO.loadDSPPAll();
        }
        //public bool CreatePhieuPhat(PhieuPhatDTO phieuPhatDTO,string maphieumuon,string mactphieumuon)
        //{
        //    return PhieuPhatDAO.CreatePhieuPhat(phieuPhatDTO,maphieumuon,mactphieumuon);
        //}
        public bool UpdatePhieuPhat(PhieuPhatDTO phieuPhatDTO)
        {
            return phieuPhatDAO.UpdatePhieuPhat(phieuPhatDTO);
        }
    }
}
