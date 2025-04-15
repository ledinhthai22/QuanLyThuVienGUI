using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyNhanVien: Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NhanVienDTO nhanVienDTO = new NhanVienDTO();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            loadNV(1);
        }
        private void loadNV(int trangThai)
        {

            dataGridView1.DataSource = nhanVienBUS.getNhanVien(nhanVienDTO);
        }

     
    }
}
