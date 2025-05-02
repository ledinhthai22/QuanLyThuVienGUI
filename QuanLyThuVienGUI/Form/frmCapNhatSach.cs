using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmCapNhatSach : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        SachBUS sachBUS = new SachBUS();
        private SachDTO selectedSach;
        TheLoaiBUS theLoai = new TheLoaiBUS();

        public frmCapNhatSach(SachDTO sachDTO)
        {
            InitializeComponent();


            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);


            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);

            cboTheLoai();
            this.selectedSach = sachDTO;

            txt_MaSach.Text = selectedSach.maSach;
            txt_TenSach.Text = selectedSach.tenSach;
            txt_TacGia.Text = selectedSach.tacGia;
            txt_MoTa.Text = selectedSach.moTa;
            txt_NXB.Text = selectedSach.nhaXuatBan;
            dtp_NamXB.Value = selectedSach.namXuatBan;
            numSoLuong.Value = selectedSach.soLuong;
            txt_NhaCungCap.Text = selectedSach.nhaCungCap;

            // Gán mã thể loại cho ComboBox
            cbo_MaTheLoai.SelectedValue = selectedSach.maTheLoai;
        }

        private void cboTheLoai()
        {
            cbo_MaTheLoai.DataSource = theLoai.loadTheLoai();
            cbo_MaTheLoai.DisplayMember = "TenTL";
            cbo_MaTheLoai.ValueMember = "MaTL";
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

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            if (selectedSach.tenSach != txt_TenSach.Text)
            {
                // Tạo 1 biến tạm để kiểm tra tên mới
                SachDTO sachTam = new SachDTO();
                sachTam.tenSach = txt_TenSach.Text;

                if (sachBUS.kiemTraTonTai(sachTam))
                {
                    MessageBox.Show("Tên sách bạn đang muốn cập nhật đã trùng với sách đã có trong danh sách!");
                    return;
                }
            }

        
            getDuLieu(selectedSach);

            try
            {
                if (sachBUS.updateSach(selectedSach))
                {
                    MessageBox.Show("Cập nhật sách thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void getDuLieu(SachDTO s)
        {
            s.maSach = txt_MaSach.Text;
            s.tenSach = txt_TenSach.Text;
            s.tacGia = txt_TacGia.Text;
            s.moTa = txt_MoTa.Text;
            s.soLuong = (int)numSoLuong.Value;
            s.namXuatBan = dtp_NamXB.Value;
            s.nhaCungCap = txt_NhaCungCap.Text;
            s.nhaXuatBan = txt_NXB.Text;
            s.maTheLoai = cbo_MaTheLoai.SelectedValue.ToString();
            s.trangThai = TinhTrangThai(s.soLuong);
        }

        private int TinhTrangThai(int soLuong)
        {
            return soLuong > 0 ? 1 : 0;
        }
    }
}
