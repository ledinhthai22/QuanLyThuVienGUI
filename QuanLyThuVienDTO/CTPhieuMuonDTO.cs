using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class CTPhieuMuonDTO
    {
        public string maCTPhieuMuon { get; set; }
        public string maPhieuMuon { get; set; } 
        public string maSach {  get; set; }
        public string tenSach { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayTra {  get; set; }
        public DateTime ngayThucTe { get; set; }
        public string ghiChu { get; set; }
    }
}
