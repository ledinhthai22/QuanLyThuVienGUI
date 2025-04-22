using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.CacFormNhanVien
{
    public partial class frmXoaTheLoai : Form
    {
        private TheLoaiDTO selectedTheLoai;
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmXoaTheLoai(TheLoaiDTO theLoaiDTO)
        {
            InitializeComponent();
            selectedTheLoai = theLoaiDTO;
            txt_MaTheLoai.Text =  selectedTheLoai.maTL;
            txt_TenTheLoai.Text = selectedTheLoai.tenTL;
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thể loại này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                theLoaiDTO.maTL = selectedTheLoai.maTL;
                bool dangDuocSuDung = theLoaiBUS.kiemTraTheLoaiDangDuocSuDung(selectedTheLoai);

                if (dangDuocSuDung)
                {
                    MessageBox.Show("Thể loại này đang được sử dụng. Không thể xóa.");
                    return;
                }

                // Nếu không được sử dụng thì tiến hành xóa
                bool xoaThanhCong = theLoaiBUS.deleteTheLoai(selectedTheLoai.maTL);

                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa thể loại thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Vui lòng thử lại.");
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXoaTheLoai_Load(object sender, EventArgs e)
        {

        }
    }
}
