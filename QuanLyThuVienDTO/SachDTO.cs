using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class SachDTO
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string tacGia { get; set; }
        public string maTheLoai { get; set; }
        public string nhaXuatBan { get; set; }
        public DateTime namXuatBan { get; set; }
        public int soLuong { get; set; }
        public string moTa { get; set; }
        public int trangThai { get; set; } 
        public string nhaCungCap { get; set; }
        public string tenTheLoai { get; set; }

    }
}
