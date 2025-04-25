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
    public partial class frmXoaSach : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        SachBUS sachBUS = new SachBUS();
        private SachDTO selectedSach;
        TheLoaiBUS theLoai = new TheLoaiBUS();
        public frmXoaSach(SachDTO sachDTO)
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
            cbo_MaTheLoai.Text = selectedSach.maTheLoai;
            numSoLuong.Value = selectedSach.soLuong;
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if(sachBUS.kiemTraSachDangDuocMuon(selectedSach))
                {
                    MessageBox.Show("Sách đang được mượn không thể xóa");
                }
                else
                {

                    if (sachBUS.deleteSach(selectedSach.maSach))
                    {
                        MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
