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

namespace QuanLyThuVienGUI
{
    public partial class frmXoaDocGia : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
       
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        private DocGiaDTO selectedDocGia;
        public frmXoaDocGia(DocGiaDTO docGiaDTO)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
            this.selectedDocGia = docGiaDTO;
            txt_MaDocGia.Text = selectedDocGia.maDocGia;
            txt_HoTen.Text = selectedDocGia.hoTen;
            txt_Email.Text = selectedDocGia.email;
            txt_DiaChi.Text =selectedDocGia.diaChi;
            txt_SoDienThoai.Text =selectedDocGia.soDienThoai;
            if (selectedDocGia.gioiTinh == "Nam")
            {
                rad_Nam.Checked = true;
            }
            else
            {
                rad_Nu.Checked = true;
            }
            dtpNgaySinh.Value = selectedDocGia.ngaySinh;

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

        private void frmXoaDocGia_Load(object sender, EventArgs e)
        {
            txt_MaDocGia.SelectionStart = txt_MaDocGia.Text.Length;
            txt_HoTen.SelectionStart = txt_HoTen.Text.Length;
            txt_Email.SelectionStart = txt_Email.Text.Length;
            txt_DiaChi.SelectionStart = txt_DiaChi.Text.Length;
            txt_SoDienThoai.SelectionStart = txt_SoDienThoai.Text.Length;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                if (docGiaBUS.deleteDocGia(selectedDocGia.maDocGia))
                {
                    MessageBox.Show("Xóa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
