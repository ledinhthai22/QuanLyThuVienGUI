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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemNhanVien: Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NhanVienDTO nv = new NhanVienDTO();
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;
        public frmThemNhanVien()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
            cbo_ChucVu.SelectedIndex = 0;
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
               string.IsNullOrWhiteSpace(txt_UserName.Text) ||
               string.IsNullOrWhiteSpace(txt_PassWord.Text))
            {
                return;
            }
            else
            {
                GanDuLieu();
                if (nhanVienBUS.kiemTraTonTai(nv))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (nhanVienBUS.addNV(nv))
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

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

          
            if (!char.IsControl(e.KeyChar) && txt_SoDienThoai.Text.Length >= 10)
            {
                e.Handled = true;
            }

        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
            !char.IsLetterOrDigit(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
            !(e.KeyChar >= 'a' && e.KeyChar <= 'z') &&
            !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') &&
            !(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true; 
            }
        }

        private void txt_PassWord_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            
            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-18);
            dtpNgaySinh.MinDate = DateTime.Now.AddYears(-60);
            txt_UserName.KeyPress += txt_UserName_KeyPress;
            txt_PassWord.KeyPress += txt_PassWord_KeyPress;
        }
    }
}
