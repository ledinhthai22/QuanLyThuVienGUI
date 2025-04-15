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
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private SachBUS sachBUS = new SachBUS();
        private string maSachHienTai;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmCapNhatSach(string maSach, string tenSach, string tacGia, string nhaXB, string maTheLoai, DateTime namXB, int soLuong, string moTa)
        {
            InitializeComponent();
            maSachHienTai = maSach;

            txt_TenSach.Text = tenSach;
            txt_TacGia.Text = tacGia;
            txt_NXB.Text = nhaXB;
            dtp_NamXB.Value = namXB;
            numSoLuong.Value = soLuong;
            txt_MoTa.Text = moTa;
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);

            LoadTheLoaiComboBox(maTheLoai);
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



        private void LoadTheLoaiComboBox(string selectedMaTheLoai = null)
        {
            try
            {
                DataTable dtTheLoai = theLoaiBUS.getAllTheLoai();

                if (dtTheLoai != null && dtTheLoai.Rows.Count > 0)
                {
                    cbo_MaTheLoai.DataSource = dtTheLoai;
                    cbo_MaTheLoai.DisplayMember = "TenTheLoai";
                    cbo_MaTheLoai.ValueMember = "MaTheLoai";

                    if (!string.IsNullOrEmpty(selectedMaTheLoai) && cbo_MaTheLoai.Items.Count > 0)
                    {
                        cbo_MaTheLoai.SelectedValue = selectedMaTheLoai;

                        if (cbo_MaTheLoai.SelectedValue == null)
                            cbo_MaTheLoai.SelectedIndex = 0;
                    }
                    else
                    {
                        cbo_MaTheLoai.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu thể loại để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbo_MaTheLoai.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu thể loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_MaTheLoai.Enabled = false;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenSach.Text) || string.IsNullOrWhiteSpace(txt_TacGia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbo_MaTheLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SachDTO sachDTO = new SachDTO
            {
                maSach = maSachHienTai,
                tenSach = txt_TenSach.Text,
                tacGia = txt_TacGia.Text,
                nhaXuatBan = txt_NXB.Text,
                maTheLoai = cbo_MaTheLoai.SelectedValue.ToString(),
                namXuatBan = dtp_NamXB.Value,
                soLuong = (int)numSoLuong.Value,
                moTa = txt_MoTa.Text,
            };

            try
            {
                if (sachBUS.updateSach(sachDTO))
                {
                    MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2NumericUpDown nudSoLuong = (Guna.UI2.WinForms.Guna2NumericUpDown)sender;

            if (nudSoLuong.Value < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuong.Value = 1;
            }
            else if (nudSoLuong.Value > 99)
            {
                MessageBox.Show("Số lượng phải nhỏ hơn 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuong.Value = 99;
            }
        }
    }
}
