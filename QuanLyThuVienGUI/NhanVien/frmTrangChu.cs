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
            lbl_SLTheLoai.Text = thongKeBUS.soLuongTheLoai(theLoaiDTO).ToString();
            lbl_SoLuongSach.Text = thongKeBUS.soLuongSach(SachDTO).ToString();
            lbl_SLTacGia.Text = thongKeBUS.soLuongTacGia(SachDTO).ToString();
            lbl_SLNxb.Text = thongKeBUS.soLuongNXB(SachDTO).ToString();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
