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
        public DataTable getAllTheLoai()
        {
            return theLoaiDAO.getAllTheLoai();
        }
        public bool kiemTraTonTai(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.kiemTraTonTai(theLoaiDTO);
        }
        public bool addTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.addTheLoai(theLoaiDTO);
        }
        public bool deleteTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.deleteTheLoai(theLoaiDTO);
        }
        public DataTable getTheLoaiByMaTL(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.getTheLoaiByMaTL(theLoaiDTO);
        }
        //public DataTable getTheLoaiByTenTL(TheLoaiDTO theLoaiDTO)
        //{
        //    return theLoaiDAO.getTheLoaiByTenTL(theLoaiDTO);
        //}
        public bool kiemTraRangBuoc(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.kiemTraRangBuoc(theLoaiDTO);
        }
        public bool updateTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return theLoaiDAO.updateTheLoai(theLoaiDTO);
        }
        public DataTable timKiemTheLoai(string tuKhoa)
        {
            return theLoaiDAO.TimKiemTheLoai(tuKhoa);
        }
    }
}
