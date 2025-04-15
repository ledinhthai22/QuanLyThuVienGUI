using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.admin;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI
{
    public partial class frmQuanLySach : Form
    {
        private System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private SachDTO sachDTO = new SachDTO();
        private Timer selectionTimer = new Timer();
        private TheLoaiDTO theLoaiDTO = new TheLoaiDTO();

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadSach();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            selectionTimer.Interval = 3000;
            selectionTimer.Tick += SelectionTimer_Tick;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemSach thesach = new ThemSach();
            thesach.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgv_DSSach.SelectedRows[0];

            if (selectedRow.IsNewRow || selectedRow.Cells["MaSach"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["MaSach"].Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn một dòng hợp lệ để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSach = selectedRow.Cells["MaSach"].Value.ToString();
            sachDTO.maSach = maSach;

            if (sachBUS.kiemTraRangBuoc(sachDTO))
            {
                MessageBox.Show("Không thể xóa sách vì sách đang được mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            if (sachBUS.deleteSach(sachDTO))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSach();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_DSSach.SelectedRows[0];
                string maSach = row.Cells["MaSach"].Value.ToString();
                string tenSach = row.Cells["TenSach"].Value.ToString();
                string tacGia = row.Cells["TacGia"].Value.ToString();
                string nhaXB = row.Cells["NhaXuatBan"].Value.ToString();
                DateTime namXB = Convert.ToDateTime(row.Cells["NamXuatBan"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                string moTa = row.Cells["MoTa"].Value.ToString();
            

                string maTheLoai = row.Cells["MaTheLoai"].Value.ToString(); // Lấy MaTheLoai từ DataGridView

                frmCapNhatSach capNhatForm = new frmCapNhatSach(maSach, tenSach, tacGia, nhaXB, maTheLoai, namXB, soLuong, moTa);

                if (capNhatForm.ShowDialog() == DialogResult.OK)
                {
                    loadSach();
                }
            }
        }

        private void loadSach()
        {
            dgv_DSSach.DataSource = null;
            DataTable dt = sachBUS.getSach(sachDTO);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string maTheLoai = row["MaTheLoai"].ToString(); // Lấy MaTheLoai từ bảng Sach
                    theLoaiDTO.maTL = maTheLoai;
                    DataTable theLoaiTable = theLoaiBUS.getTheLoaiByMaTL(theLoaiDTO);

                    if (theLoaiTable.Rows.Count > 0)
                    {
                        row["MaTheLoai"] = theLoaiTable.Rows[0]["TenTheLoai"].ToString(); // Hiển thị tên thể loại
                                                                                          // Không cần gán vào MaTheLoaiGoc nữa vì cột này không tồn tại trong bảng Sach
                    }
                    else
                    {
                        // Nếu không tìm thấy thể loại, vẫn giữ nguyên MaTheLoai gốc và hiển thị "Không xác định"
                        row["MaTheLoai"] = "Không xác định";
                    }
                }

                dgv_DSSach.DataSource = dt;
                dgv_DSSach.ClearSelection();
            }
            else
            {
                MessageBox.Show("Không thể tải dữ liệu sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DSSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                var row = dgv_DSSach.SelectedRows[0];

                if (row.Cells["TenSach"] != null && row.Cells["TenSach"].Value != null)
                {
                    string tenSach = row.Cells["TenSach"].Value.ToString();
                    toolTip.Show("Đang chọn: " + tenSach, dgv_DSSach, 2000);
                }

                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;

                selectionTimer.Stop();
                selectionTimer.Start();
            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
            }

        }

        private void SelectionTimer_Tick(object sender, EventArgs e)
        {
            selectionTimer.Stop();
            dgv_DSSach.ClearSelection();
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void frmQuanLySach_Shown(object sender, EventArgs e)
        {
            dgv_DSSach.ClearSelection();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadSach();
        }

        private void taoCotDataGridView()
        {
            dgv_DSSach.Columns.Clear();
            dgv_DSSach.AutoGenerateColumns = false;

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaSach", DataPropertyName = "MaSach", HeaderText = "Mã Sách" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSach", DataPropertyName = "TenSach", HeaderText = "Tên Sách" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TacGia", DataPropertyName = "TacGia", HeaderText = "Tác Giả" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhaXuatBan", DataPropertyName = "NhaXuatBan", HeaderText = "Nhà Xuất bản" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaTheLoai", DataPropertyName = "MaTheLoai", HeaderText = "Thể Loại" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NamXuatBan", DataPropertyName = "NamXuatBan", HeaderText = "Năm Xuất Bản" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", DataPropertyName = "SoLuong", HeaderText = "Số Lượng" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", DataPropertyName = "MoTa", HeaderText = "Mô tả" });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", DataPropertyName = "TrangThai", HeaderText = "Trạng Thái" });
            // Không cần cột MaTheLoaiGoc nữa
        }

        private void dgv_DSSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgv_DSSach.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
                {
                    string trangThai = e.Value.ToString();
                    if (trangThai == "1")
                    {
                        e.Value = "Còn sách";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (trangThai == "0")
                    {
                        e.Value = "Hết sách";
                        e.CellStyle.ForeColor = Color.Red;
                    }

                    e.FormattingApplied = true;
                }
            }
            catch (FormatException)
            {
                // Bạn có thể log hoặc bỏ qua để không hiện dialog lỗi
                e.FormattingApplied = false;
            }
           
        }

        private void dgv_DSSach_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}