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
    public class TheLoaiBUS
    {
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        public List<TheLoaiDTO> loadTheLoai()
        {
            return theLoaiDAO.loadTheLoai();
        }
        public bool addTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return TheLoaiDAO.addTheLoai(theLoaiDTO);
        }
        public bool deleteTheLoai(string maTL)
        {
            return TheLoaiDAO.deleteTheLoai(maTL);
        }
        public bool updateTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return TheLoaiDAO.updateTheLoai(theLoaiDTO);
        }
        public bool kiemTraTheLoaiDangDuocSuDung(TheLoaiDTO theLoaiDTO)
        {
            return TheLoaiDAO.kiemTraTheLoaiDangDuocSuDung(theLoaiDTO);
        }
        public  bool kiemTraTonTai(TheLoaiDTO theLoaiDTO)
        {
            return TheLoaiDAO.kiemTraTonTai(theLoaiDTO);
        }
    }
}
