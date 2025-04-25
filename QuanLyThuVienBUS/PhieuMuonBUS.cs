using QuanLyThuVienDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAO phieumuonDAO = new PhieuMuonDAO();
        public DataTable GetPhieuMuon()
        {
            return phieumuonDAO.getPhieuMuon();
        }
        public DataTable GetDocGia()
        {
            return phieumuonDAO.getDSDocGia();
        }
        private PhieuMuonDAO dao = new PhieuMuonDAO();
        public bool ThemMoi(PhieuMuonDTO pm)
        {
            // Có thể kiểm tra logic trước khi thêm (nếu cần)
            // Ví dụ: Kiểm tra ngày hẹn trả phải sau ngày mượn
            if (pm.ngayHenTra < pm.ngayLap)
            {
                throw new ArgumentException("Ngày hẹn trả phải lớn hơn ngày mượn.");
            }

            return phieumuonDAO.addPhieuMuon(pm);
        }
    }
}
