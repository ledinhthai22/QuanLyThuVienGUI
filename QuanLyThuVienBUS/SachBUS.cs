using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public List<SachDTO> loadSach()
        {
             return sachDAO.loadSach();
        }
        public List<SachDTO> loadSachMuon()
        {
            return sachDAO.loadSachMuon();
        }
        public bool addSach(SachDTO sachDTO)
        {
            return SachDAO.addSach(sachDTO);
        }
        public bool deleteSach(string maSach)
        {
            return SachDAO.deteleSach(maSach);
        }
        public bool updateSach(SachDTO sachDTO)
        {
            return SachDAO.updateSach(sachDTO);
        }
        public bool kiemTraSachDangDuocMuon(SachDTO sachDTO)
        {
            return SachDAO.kiemTraSachDangDuocMuon(sachDTO);
        }
        public bool kiemTraTonTai(SachDTO sachDTO)
        {
            return SachDAO.kiemTraTonTai(sachDTO);
        }
        public bool updateSachSauMuon(List<string> danhSachMaSach)
        {
            return sachDAO.updateSachSauMuon(danhSachMaSach);
        }
    }
}
