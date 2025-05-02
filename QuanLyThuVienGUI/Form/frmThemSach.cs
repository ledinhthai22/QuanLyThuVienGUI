using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        SachDTO sachDTO = new SachDTO();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmThemSach()
        {
            InitializeComponent();
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            this.pn_Tab.MouseDown += Form_MouseDown;
            this.pn_Tab.MouseMove += Form_MouseMove;
            this.pn_Tab.MouseUp += Form_MouseUp;
            numSoLuong.Minimum = 1;
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            loadCboTL();
        }

        private void loadCboTL()
        {
            List<TheLoaiDTO> dsTheLoai = theLoaiBUS.loadTheLoai();
            if (dsTheLoai != null && dsTheLoai.Count > 0)
            {
                cbo_MaTheLoai.DataSource = dsTheLoai;
                cbo_MaTheLoai.DisplayMember = "TenTL";
                cbo_MaTheLoai.ValueMember = "MaTL";
                cbo_MaTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo_MaTheLoai.MaxDropDownItems = dsTheLoai.Count > 8 ? 8 : dsTheLoai.Count;
                cbo_MaTheLoai.IntegralHeight = false;
                cbo_MaTheLoai.MaxDropDownItems = 8;
            }
            else
            {
                cbo_MaTheLoai.DataSource = null;
            }
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
            this.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTraNhapLieu())
            {
                getDuLieu();

                if (sachBUS.kiemTraTonTai(sachDTO))
                {
                    MessageBox.Show("Tên sách đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (sachBUS.addSach(sachDTO))
                    {
                        MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void getDuLieu()
        {
            sachDTO.tenSach = txt_TenSach.Text.Trim();
            sachDTO.tacGia = txt_TacGia.Text.Trim();
            sachDTO.moTa = txt_MoTa.Text.Trim();
            sachDTO.soLuong = (int)numSoLuong.Value;
            sachDTO.nhaXuatBan = txt_NXB.Text.Trim();
            sachDTO.namXuatBan = dtp_NamXB.Value;
            sachDTO.nhaCungCap = txt_NhaCungCap.Text.Trim();

            if (cbo_MaTheLoai.SelectedValue != null)
            {
                sachDTO.maTheLoai = cbo_MaTheLoai.SelectedValue.ToString();
            }
        }

        private bool kiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txt_TenSach.Text) ||
                string.IsNullOrWhiteSpace(txt_TacGia.Text) ||
                string.IsNullOrWhiteSpace(txt_NXB.Text) ||
                string.IsNullOrWhiteSpace(txt_NhaCungCap.Text) ||
                string.IsNullOrWhiteSpace(txt_MoTa.Text) ||
                cbo_MaTheLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txt_TenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_TacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKyTuChu(e);
        }

        private void txt_NXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKyTuChu(e);
        }

        private void txt_NhaCungCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            kiemTraKyTuChu(e);
        }

        private void txt_MoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void kiemTraKyTuChu(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
