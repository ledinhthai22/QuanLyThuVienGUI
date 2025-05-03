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
        CTPhieuMuonDAO CTPhieuMuonDAO = new CTPhieuMuonDAO();
        public  List<CTPhieuMuonDTO> GetDanhSachDangMuonTheoMaDocGia(string maDocGia)
        {
            return CTPhieuMuonDAO.GetDanhSachDangMuonTheoMaDocGia(maDocGia);
        }
        public List<string> LayDanhSachMaSachDaMuon(string maPhieuMuon)
        {
            return CTPhieuMuonDAO.LayDanhSachMaSachDaMuon(maPhieuMuon);
        }
        public bool createCTPhieuMuon(CTPhieuMuonDTO phieuMuonDTO)
        {
            return CTPhieuMuonDAO.createCThieuMuon(phieuMuonDTO);
        }
    }
}
