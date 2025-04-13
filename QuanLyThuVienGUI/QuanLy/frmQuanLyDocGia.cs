using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        DocGiaDTO docGiaDTO = new DocGiaDTO();

        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!kiemTraDuLieuNhap()) return;

            docGiaDTO.hoTen = txt_HoTen.Text;
            docGiaDTO.ngaySinh = dtpNgaySinh.Value;
            docGiaDTO.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
            docGiaDTO.diaChi = txt_DiaChi.Text;
            docGiaDTO.soDienThoai = txt_SoDienThoai.Text;
            docGiaDTO.email = txt_Email.Text;

            if (docGiaBUS.kiemTraTonTai(docGiaDTO))
            {
                MessageBox.Show("Độc giả đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (docGiaBUS.addDocGia(docGiaDTO))
            {
                MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDG(1);
                tuDongLamMoi();
            }
            else
            {
                MessageBox.Show("Thêm độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_DSDocGia.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

               string maDG = dgv_DSDocGia.CurrentRow.Cells[0].Value.ToString();
                docGiaDTO.maDG = maDG;

                if (docGiaBUS.kiemTraRangBuoc(docGiaDTO))
                {
                    MessageBox.Show("Không thể xóa độc giả vì đang có sách mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (docGiaBUS.deleteDocGia(docGiaDTO))
                {
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDG(1);
                    tuDongLamMoi();
                }
                else
                {
                    MessageBox.Show("Xóa độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            if (!kiemTraDuLieuNhap()) return;

             string maDG = dgv_DSDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();
            docGiaDTO.maDG = maDG;
            docGiaDTO.hoTen = txt_HoTen.Text;
            docGiaDTO.ngaySinh = dtpNgaySinh.Value;
            docGiaDTO.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
            docGiaDTO.diaChi = txt_DiaChi.Text;
            docGiaDTO.soDienThoai = txt_SoDienThoai.Text;
            docGiaDTO.email = txt_Email.Text;

            if (docGiaBUS.updateDocGia(docGiaDTO))
            {
                MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDG(1);
                tuDongLamMoi();
            }
            else
            {
                MessageBox.Show("Cập nhật độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maDG =dgv_DSDocGia.CurrentRow.Cells[0].Value.ToString();
            docGiaDTO.maDG = maDG;

            if (docGiaBUS.khoiPhucDocGia(docGiaDTO))
            {
                MessageBox.Show("Khôi phục độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDG(1);
                tuDongLamMoi();
            }
            else
            {
                MessageBox.Show("Khôi phục độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rad_TimTheoHoTen.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string hoTen = txt_TimKiem.Text; 
                    docGiaDTO.hoTen = hoTen;
                    DataTable result = docGiaBUS.timKiemTheoHoTen(docGiaDTO); 
                    if (result != null && result.Rows.Count > 0)
                    {
                        dgv_DSDocGia.DataSource = result;
                        txt_TimKiem.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (rad_TimTheoSDT.Checked)
            {

                if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string soDienThoai = txt_TimKiem.Text;
                    docGiaDTO.soDienThoai = soDienThoai;
                    DataTable result = docGiaBUS.timKiemTheoSoDienThoai(docGiaDTO);
                    if (result != null && result.Rows.Count > 0)
                    {
                        dgv_DSDocGia.DataSource = result;
                        txt_TimKiem.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txt_HoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txt_SoDienThoai.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbo_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTrangThai = ((KeyValuePair<int, string>)cbo_TrangThai.SelectedItem).Key;
            loadDG(selectedTrangThai);
            bool isActive = selectedTrangThai == 1;
            bool isDeleted = selectedTrangThai == 0;
            btn_Xoa.Enabled = isActive;
            btn_Sua.Enabled = isActive;
            btn_Them.Enabled = isActive;
            btnKhoiPhuc.Enabled = isDeleted;
        }

        private void dgv_DSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv_DSDocGia.Rows.Count)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSDocGia.Rows[e.RowIndex];

                txt_HoTen.Text = row.Cells["HoTen"].Value?.ToString();
                dtpNgaySinh.Value = row.Cells["NgaySinh"].Value != DBNull.Value
                                     ? Convert.ToDateTime(row.Cells["NgaySinh"].Value)
                                     : DateTime.Now.AddYears(-18);

                if (row.Cells["GioiTinh"].Value?.ToString() == "Nam")
                    rad_Nam.Checked = true;
                else
                    rad_Nu.Checked = true;

                txt_DiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txt_SoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txt_Email.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            tuDongLamMoi();
        }

        private void tuDongLamMoi()
        {
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_SoDienThoai.Clear();
            txt_Email.Clear();
            txt_TimKiem.Clear();
            loadDG(1);
            dgv_DSDocGia.ClearSelection(); 
            dtpNgaySinh.Value = DateTime.Now.AddYears(-18);
            rad_Nam.Checked = true;
            cbo_TrangThai.SelectedIndex = 0;
        }

        private bool kiemTraDuLieuNhap()
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime ngaySinh = dtpNgaySinh.Value;
            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh > DateTime.Now.AddYears(-tuoi)) tuoi--; // nếu chưa tới sinh nhật trong năm nay thì trừ 1

            if (tuoi < 12)
            {
                MessageBox.Show("Độc giả phải đủ 12 tuổi trở lên để mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rad_Nam.Checked && !rad_Nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadcboTrangThai();
            loadDG(1);
            btnKhoiPhuc.Enabled = false;
        }

        private void loadcboTrangThai()
        {
            cbo_TrangThai.DisplayMember = "Value";
            cbo_TrangThai.ValueMember = "Key";
            cbo_TrangThai.Items.Add(new KeyValuePair<int, string>(1, "Tất cả"));
            cbo_TrangThai.Items.Add(new KeyValuePair<int, string>(0, "Đã xóa"));
            cbo_TrangThai.SelectedIndex = 0;
        }

        private void loadDG(int trangThai)
        {
            dgv_DSDocGia.DataSource = null;
            docGiaDTO.TrangThai = trangThai;
            DataTable dt = docGiaBUS.getDocGia(docGiaDTO);
            dgv_DSDocGia.DataSource = dt;
            dgv_DSDocGia.ClearSelection();
        }

       
        private void txt_TimKiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (rad_TimTheoHoTen.Checked)
            {
                // Prevent numbers from being entered
                if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (rad_TimTheoSDT.Checked)
            {
                // Prevent letters from being entered
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (!char.IsControl(e.KeyChar)&&txt_TimKiem.Text.Length >= 10)
                {
                    e.Handled = true;
                }           
            }
        }
        private void dgv_DSDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSDocGia.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    string trangThai = e.Value.ToString();
                    if (trangThai == "1")
                    {
                        e.Value = "Hoạt động";
                        e.FormattingApplied = true;
                    }
                    else if (trangThai == "0")
                    {
                        e.Value = "Ngưng hoạt động";
                        e.FormattingApplied = true;
                    }
                }
            }
        }
        private void taoCotDataGridView()
        {
            dgv_DSDocGia.Columns.Clear();
            dgv_DSDocGia.AutoGenerateColumns = false;

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaDocGia",
                DataPropertyName = "MaDocGia",
                HeaderText = "Mã Độc Giả"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Họ Tên"
            });
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày Sinh"
            });
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GioiTinh",
                DataPropertyName = "GioiTinh",
                HeaderText = "Giới tính"
            });
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                DataPropertyName = "DiaChi",
                HeaderText = "Địa Chỉ"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                DataPropertyName = "SoDienThoai",
                HeaderText = "Số điện Thoại"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"
            });
        }
    }
}
