using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVienDTO
{
    public class PhieuMuonDTO
    {
        public string maPhieumuon { get; set; }
        public string tenDocGia { get; set; }
        public string maDocgia { get; set; }
        public DateTime ngayLap { get; set; }
        public DateTime ngayHenTra { get; set; }
        public string soLuong { get; set; }
        public int trangThai { get; set; }

        public DataTable GetPhieuMuon(PhieuMuonDTO phieuMuonDTO)
        {
            throw new NotImplementedException();
        }

    }
}