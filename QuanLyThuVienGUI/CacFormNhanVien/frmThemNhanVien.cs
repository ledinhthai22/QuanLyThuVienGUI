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

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemNhanVien: Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NhanVienDTO nhanVienDTO = new NhanVienDTO();
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;
        public frmThemNhanVien()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
               cbo_ChucVu.SelectedIndex == -1 ||
               dtpNgaySinh.Value == null ||
               string.IsNullOrWhiteSpace(txt_SoDienThoai.Text) ||
               string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
               string.IsNullOrWhiteSpace(txt_Luong.Text) ||
               string.IsNullOrWhiteSpace(txt_UserName.Text) ||
               string.IsNullOrWhiteSpace(txt_PassWord.Text))
            {
                return;
            }
            else
            {
                GanDuLieu();
                if (nhanVienBUS.kiemTraTonTai(nhanVienDTO))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (nhanVienBUS.addNV(nhanVienDTO))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void GanDuLieu()
        {
            nhanVienDTO.tenNV = txt_HoTen.Text;
            nhanVienDTO.chucVu = cbo_ChucVu.Text;
            if (rad_Nam.Checked)
            {
                nhanVienDTO.gioiTinh = "Nam";
            }
            else if (rad_Nu.Checked)
            {
                nhanVienDTO.gioiTinh = "Nữ";
            }
            nhanVienDTO.ngaySinh = dtpNgaySinh.Value;
            nhanVienDTO.SDT = txt_SoDienThoai.Text;
            nhanVienDTO.diaChi = txt_DiaChi.Text;
            nhanVienDTO.luong = float.Parse(txt_Luong.Text);
            nhanVienDTO.userName = txt_UserName.Text;
            nhanVienDTO.password = txt_PassWord.Text;
            nhanVienDTO.trangThai = 1;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
