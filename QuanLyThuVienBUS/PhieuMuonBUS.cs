using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class PhieuMuonBUS
    {
        private PhieuMuonDAO phieuMuonDAO = new PhieuMuonDAO();
        public List<PhieuMuonDTO> loadDSPM()
        {
            return phieuMuonDAO.loadDSPM();
        }
        public string createPhieuMuon(PhieuMuonDTO phieuMuonDTO)
        {
            return PhieuMuonDAO.createPhieuMuon(phieuMuonDTO);
        }
        public bool kiemTraMuon(string maDocGia)
        {
            return PhieuMuonDAO.kiemTraMuon(maDocGia);
        }
    }
}
