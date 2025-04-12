using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI
{
    public partial class frmQuanLySach : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private SachDTO sachDTO = new SachDTO();
        private string tenFileAnh = "";

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadSach(1);
            loadComboBoxTheLoai();
            loadComboboxTrangThai();
            dtp_NamXB.CustomFormat = "dd/MM/yyyy";
            

        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(targetFolder);
                    string targetPath = Path.Combine(targetFolder, fileName);

                    if (!File.Exists(targetPath))
                    {
                        File.Copy(sourcePath, targetPath);
                    }

                    tenFileAnh = fileName;
                    pic_HinhAnhSach.Image = Image.FromFile(targetPath);
                    pic_HinhAnhSach.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ganDuLieu();

            if (!kiemTraDuLieuNhap())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kiemTraTonTai())
            {
                MessageBox.Show("Sách đã có trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (sachBUS.addSach(sachDTO))
            {
                MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tuDongLamMoi();
                loadSach(1);
            }
            else
            {
                MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maSach = (int)dgv_DSSach.CurrentRow.Cells[0].Value;
            sachDTO.maSach = maSach;
            if (dgv_DSSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sachBUS.deleteSach(sachDTO))
            {
                MessageBox.Show("Xóa Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSach(1);
                tuDongLamMoi();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            tuDongLamMoi();
            loadSach(1);
        }

        private void loadSach(int trangThai)
        {

            dgv_DSSach.DataSource = null;
            sachDTO.trangThai = trangThai;
            DataTable dt = sachBUS.getSach(sachDTO);

            if (dt != null && dt.Rows.Count > 0)
            {
                dgv_DSSach.DataSource = dt;
                dgv_DSSach.ClearSelection();
            }
            else
            {
                MessageBox.Show("Không có sách nào phù hợp với trạng thái được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadComboBoxTheLoai()
        {
            cbo_MaTheLoai.DataSource = theLoaiBUS.getAllTheLoai();
            cbo_MaTheLoai.DisplayMember = "TenTheLoai";
            cbo_MaTheLoai.ValueMember = "MaTheLoai";
        }

        private void loadComboboxTrangThai()
        {
            cbo_TrangThai.DisplayMember = "Value";
            cbo_TrangThai.ValueMember = "Key";
            cbo_TrangThai.Items.Add(new KeyValuePair<int, string>(1, "Còn sách"));
            cbo_TrangThai.Items.Add(new KeyValuePair<int, string>(0, "Đã mượn hết"));
            cbo_TrangThai.SelectedIndex = 0;
        }

        private bool kiemTraDuLieuNhap()
        {
            return !(string.IsNullOrWhiteSpace(txt_TenSach.Text) ||
                     string.IsNullOrWhiteSpace(txt_TacGia.Text) ||
                     string.IsNullOrWhiteSpace(txt_NXB.Text) ||
                     cbo_MaTheLoai.SelectedValue == null ||
                     numSoLuong.Value == 0);
        }

        private void ganDuLieu()
        {
            sachDTO.tenSach = txt_TenSach.Text;
            sachDTO.tacGia = txt_TacGia.Text;
            sachDTO.namXuatBan = dtp_NamXB.Value;
            sachDTO.maTheLoai = Convert.ToInt32(cbo_MaTheLoai.SelectedValue);
            sachDTO.nhaXuatBan = txt_NXB.Text;
            sachDTO.soLuong = Convert.ToInt32(numSoLuong.Value);
            sachDTO.moTa = txt_MoTa.Text;
            sachDTO.hinhAnh = tenFileAnh;
        }

        private bool kiemTraTonTai()
        {
            sachDTO.tenSach = txt_TenSach.Text;
            int maSach = (int)dgv_DSSach.CurrentRow.Cells[0].Value;
            return sachBUS.kiemTraTonTai(sachDTO);
        }

        private void tuDongLamMoi()
        {
            txt_TenSach.Clear();
            txt_TacGia.Clear();
            dtp_NamXB.MaxDate = DateTime.Now.AddYears(1);
            dtp_NamXB.Value = DateTime.Now;
            cbo_MaTheLoai.SelectedIndex = -1;
            txt_NXB.Clear();
            txt_MoTa.Clear();
            numSoLuong.Value = 0;
            pic_HinhAnhSach.Image = null;
            tenFileAnh = "";
            dgv_DSSach.ClearSelection();
        }

        private void dgv_DSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv_DSSach.Rows.Count)
                return;

            DataGridViewRow row = dgv_DSSach.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            txt_TenSach.Text = row.Cells["TenSach"].Value.ToString();
            txt_TacGia.Text = row.Cells["TacGia"].Value.ToString();

            if (row.Cells["NamXuatBan"].Value != null && DateTime.TryParse(row.Cells["NamXuatBan"].Value.ToString(), out DateTime namXuatBan))
            {
                dtp_NamXB.Value = namXuatBan;
            }
            else
            {
                dtp_NamXB.CustomFormat = "dd/MM/yyyy";
                dtp_NamXB.Value = DateTime.Now;
            }

            if (row.Cells["MaTheLoai"].Value != null)
            {
                cbo_MaTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value.ToString();
            }

            txt_NXB.Text = row.Cells["NhaXuatBan"].Value.ToString();
            numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
            txt_MoTa.Text = row.Cells["MoTa"].Value.ToString();

            if (row.Cells["HinhAnh"].Value != null)
            {
                string fileAnh = row.Cells["HinhAnh"].Value.ToString();
                string path = Path.Combine(Application.StartupPath, "Images", fileAnh);

                if (File.Exists(path))
                {
                    pic_HinhAnhSach.Image = Image.FromFile(path);
                    pic_HinhAnhSach.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pic_HinhAnhSach.Image = null;
                }
            }
            else
            {
                pic_HinhAnhSach.Image = null;
            }
        }

      

        private void cbo_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTrangThai = ((KeyValuePair<int, string>)cbo_TrangThai.SelectedItem).Key;
            loadSach(selectedTrangThai); 
            bool isActive = selectedTrangThai == 1;
            bool isDeleted = selectedTrangThai == 0;

            btn_Them.Enabled = !isDeleted;
            btn_Xoa.Enabled = isActive;
            btn_Sua.Enabled = isActive;
            btn_KhoiPhuc.Enabled = isDeleted;
        }

        private void dgv_DSSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSSach.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    string trangThai = e.Value.ToString();
                    if (trangThai == "1")
                    {
                        e.Value = "Còn sách";

                    }
                    else if (trangThai == "0")
                    {
                        e.Value = "mượn hết";

                    }
                }
            }
        }
        private void taoCotDataGridView()
        {
            dgv_DSSach.Columns.Clear();
            dgv_DSSach.AutoGenerateColumns = false;

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                DataPropertyName = "MaSach",
                HeaderText = "Mã Sách"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên Sách"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TacGia",
                DataPropertyName = "TacGia",
                HeaderText = "Tác Giả"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NhaXuatBan",
                DataPropertyName = "NhaXuatBan",
                HeaderText = "Nhà Xuất bản"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaTheLoai",
                DataPropertyName = "MaTheLoai",
                HeaderText = "Thể Loại"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NamXuatBan",
                DataPropertyName = "NamXuatBan",
                HeaderText = "Năm Xuất Bản"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số Lượng"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                DataPropertyName = "MoTa",
                HeaderText = "Mô tả"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HinhAnh",
                DataPropertyName = "HinhAnh",
                HeaderText = "Hình ảnh"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"
            });
        }

    }
}
