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
    public partial class frmTrangChu: Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        SachDTO SachDTO = new SachDTO();
        public frmTrangChu()
        {
            InitializeComponent();
          
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.Sach' table. You can move, or remove it, as needed.
        

        }
    }
}
