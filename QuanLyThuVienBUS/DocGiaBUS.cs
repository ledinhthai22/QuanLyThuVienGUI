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
        public List<DocGiaDTO> loadDSDG()
        {
            return docgiaDAO.loadDSDG();
        }
        public bool addDocGia(DocGiaDTO docGiaDTO)
        {
            return DocGiaDAO.addDocGia(docGiaDTO);
        }
        public bool deleteDocGia(string maDocGia)
        {
            return DocGiaDAO.deleteDocGia(maDocGia);
        }
        public bool updateDocGia(DocGiaDTO docGiaDTO)
        {
            return DocGiaDAO.updateDocGia(docGiaDTO);
        }
        public  bool KiemTraDocGiaTrungEmailHoacSDT(string email, string soDienThoai)
        {
            return DocGiaDAO.KiemTraDocGiaTrungEmailHoacSDT(email, soDienThoai);
        }
    }
}
