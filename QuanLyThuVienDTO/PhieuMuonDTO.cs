using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class PhieuMuonDTO
    {
        public string MaPhieuMuon { get; set; }
        public string MaCTPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string HoTenDocGia { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime NgayTra { get; set; }
        public DateTime NgayTraThucTe { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongSach { get; set; }
        public int TrangThaiPhieuMuon { get; set; }
        public string MaPhieuPhat { get; set; }
        public int TrangThaiPhieuPhat { get; set; }
        public int trangThai { get; set; }
    }
}
