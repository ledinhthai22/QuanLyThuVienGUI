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
        public bool addDocGia(DocGiaDTO docGiaDTO)
        {
            return DocGiaDAO.addDocGia(docGiaDTO);
        }
    }
}
