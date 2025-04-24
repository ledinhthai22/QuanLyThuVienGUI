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
    public partial class frmCapNhatNhanVien : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NhanVienDTO selectedNhanVien;
        public frmCapNhatNhanVien(NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            this.selectedNhanVien = nhanVienDTO;
            txt_MaNV.Text = selectedNhanVien.maNV;
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

        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            getDuLieu(selectedNhanVien);
            if (nhanVienBUS.updateNV(selectedNhanVien))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void getDuLieu(NhanVienDTO nv)
        {
            nv.tenNV = txt_HoTen.Text;
            nv.chucVu = cbo_ChucVu.Text;
            nv.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
            nv.ngaySinh = dtpNgaySinh.Value;
            nv.SDT = txt_SoDienThoai.Text;
            nv.diaChi = txt_DiaChi.Text;
            nv.userName = txt_UserName.Text;
            nv.password = txt_PassWord.Text;
            nv.trangThai = 1;
        }
    }
}
