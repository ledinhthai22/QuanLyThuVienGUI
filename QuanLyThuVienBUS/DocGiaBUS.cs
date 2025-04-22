using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVienDAO;
using QuanLyThuVienDTO;

namespace QuanLyThuVienBUS
{
    public class DocGiaBUS
    {
        DocGiaDAO docgiaDAO = new DocGiaDAO();
        public DataTable LoadDSDG()
        {
            return docgiaDAO.LoadDSDG();
        }
        //public bool addDocGia(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.addDocGia(docGiaDTO);
        //}
        //public bool deleteDocGia(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.deleteDocGia(docGiaDTO);
        //}
        //public bool khoiPhucDocGia(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.khoiPhucSauKhiXoaMen(docGiaDTO);
        //}
        //public DataTable timKiemTheoSoDienThoai(DocGiaDTO docGiaDTO)
        //{
        //   return docgiaDAO.timKiemTheoSoDienThoai(docGiaDTO);
        //}
        //public DataTable timKiemTheoHoTen(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.timKiemTheoHoTen(docGiaDTO);
        //}
        //public bool updateDocGia(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.updateDocGia(docGiaDTO);
        //}
        //public bool kiemTraTonTai(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.kiemTraTonTai(docGiaDTO);
        //}
        //public bool kiemTraRangBuoc(DocGiaDTO docGiaDTO)
        //{
        //    return docgiaDAO.kiemTraRangBuoc(docGiaDTO);
        //}
    }
}
