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
        public List<PhieuMuonDTO> loadDSPMDangMuon()
        {
            return phieuMuonDAO.loadDSPMDangMuon();
        }
        public List<PhieuMuonDTO> loadDSPMDaTra()
        {
            return phieuMuonDAO.loadDSPMDaTra();
        }
        public List<PhieuMuonDTO> loadDSPMDaTraDeThanhToan()
        {
            return phieuMuonDAO.loadDSPMDaTraDeThanhToan();
        }
        public List<PhieuMuonDTO> loadDanhSachPhieuMuonVaCTPhieuMuon()
        {
            return phieuMuonDAO.loadDanhSachPhieuMuonVaCTPhieuMuon();
        }
        public string createPhieuMuon(PhieuMuonDTO phieuMuonDTO)
        {
            return PhieuMuonDAO.createPhieuMuon(phieuMuonDTO);
        }

        public bool traSach(PhieuMuonDTO phieuMuonDTO)
        {
            return PhieuMuonDAO.traSach(phieuMuonDTO);
        }
        public bool kiemTraMuon(string maDocGia)
        {
            return PhieuMuonDAO.kiemTraMuon(maDocGia);
        }
    }
}
