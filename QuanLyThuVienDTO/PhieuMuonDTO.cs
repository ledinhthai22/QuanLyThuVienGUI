using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class PhieuMuonDTO
    {
        public string maPhieuMuon { get; set; }
        public string maDocGia {  get; set; }
        public string maNhanVien { get; set; }
        public string hoTenDocGia { get; set; }
        public DateTime ngayLap { get; set; }
        public DateTime ngayTra { get; set; }
        public int soLuongSach {  get; set; }
        public int trangThai { get; set; }
    }
}
