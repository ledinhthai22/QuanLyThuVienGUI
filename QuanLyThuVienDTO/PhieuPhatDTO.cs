using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class PhieuPhatDTO
    {
        public string maPhieuPhat { get; set; }
        public string maPhieuMuon { get;set; }
        public string mactPhieuMuon { get; set; }
        public string hoTenDocGia { get; set; }
        public int soTien {  get; set; }
        public string lyDoPhat { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public int trangThai { get; set; } 
    }
}
