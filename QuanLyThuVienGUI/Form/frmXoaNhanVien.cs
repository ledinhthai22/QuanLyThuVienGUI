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

namespace QuanLyThuVienGUI.CacFormNhanVien
{
    public partial class frmXoaNhanVien : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NhanVienDTO selectedNhanVien;
        public frmXoaNhanVien(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            this.selectedNhanVien = nhanVienDTO;
            txt_HoTen.Text = selectedNhanVien.tenNV;
            cbo_ChucVu.Text = selectedNhanVien.chucVu;
            txt_DiaChi.Text = selectedNhanVien.diaChi;
          
            if (selectedNhanVien.gioiTinh == "Nam")
            {
                rad_Nam.Checked = true;
            }
            else
            {
                rad_Nu.Checked = true;
            }
            txt_SoDienThoai.Text = selectedNhanVien.SDT;
            dtpNgaySinh.Value = selectedNhanVien.ngaySinh;
            txt_UserName.Text = selectedNhanVien.userName;
            txt_PassWord.Text = selectedNhanVien.password;
            txt_MaNV.Text = selectedNhanVien.maNV;

            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void frmXoaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               
                    if (nhanVienBUS.deleteNV(selectedNhanVien.maNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
              
            }
        }
    }
}
