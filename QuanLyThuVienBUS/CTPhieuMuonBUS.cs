using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class CTPhieuMuonBUS
    {
        public bool createCTPhieuMuon(CTPhieuMuonDTO phieuMuonDTO)
        {
            return CTPhieuMuonDAO.createCThieuMuon(phieuMuonDTO);
        }
    }
}
