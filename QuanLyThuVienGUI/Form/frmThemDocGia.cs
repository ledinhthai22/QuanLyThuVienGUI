using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemDocGia: Form
    {   
        DocGiaDTO docGiaDTO = new DocGiaDTO();
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool dragging = false;
        public frmThemDocGia()
        {
            InitializeComponent();
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

        private void btn_Thoat_Click(object sender, EventArgs e)
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

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
             e.KeyChar != '@' &&
             e.KeyChar != '.' &&
             e.KeyChar != '-' &&
             e.KeyChar != '_' &&
            !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_Email.Text))
            {
              return;
            }
            else
            {
                if (!IsValidEmail(txt_Email.Text))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Email.Focus();
                }
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
        private void getDuLieu()
        {
            docGiaDTO.hoTen = txt_HoTen.Text;
            docGiaDTO.ngaySinh = dtpNgaySinh.Value;
            docGiaDTO.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
            docGiaDTO.diaChi = txt_DiaChi.Text;
            docGiaDTO.email = txt_Email.Text;
            docGiaDTO.soDienThoai = txt_SoDienThoai.Text;
            docGiaDTO.TrangThai = 1;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            getDuLieu();
            if (docGiaBUS.addDocGia(docGiaDTO))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }    
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-14);


            dtpNgaySinh.MinDate = DateTime.Now.AddYears(-60);
        }
    }
}
