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
    public partial class frmCapNhatTheLoai: Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private TheLoaiDTO selectedTheLoai;
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public frmCapNhatTheLoai(TheLoaiDTO theLoaiDTO)
        {
            InitializeComponent();
            selectedTheLoai = theLoaiDTO;
            txt_MaTheLoai.Text = selectedTheLoai.maTL;
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

        private void btn_CapNhatTheLoai_Click(object sender, EventArgs e)
        {
            theLoaiDTO.maTL = selectedTheLoai.maTL;
            theLoaiDTO.tenTL = txt_TenTheLoai.Text.Trim();

            bool tonTai = theLoaiBUS.kiemTraTonTai(theLoaiDTO);

            // Nếu tên thể loại mới đã tồn tại (trùng với thể loại khác)
            if (tonTai)
            {
                MessageBox.Show("Tên thể loại đã tồn tại. Không thể cập nhật.");
                return;
            }

            // Cập nhật nếu tên chưa trùng
            bool capNhatThanhCong = theLoaiBUS.updateTheLoai(theLoaiDTO);

            if (capNhatThanhCong)
            {
                MessageBox.Show("Cập nhật thể loại thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
