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
        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private SachDTO sachDTO = new SachDTO();
        private Timer selectionTimer = new Timer();


        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadSach(1);
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            selectionTimer.Interval = 3000; // 3 giây
            selectionTimer.Tick += SelectionTimer_Tick;

        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemSach thesach = new ThemSach();
            thesach.ShowDialog();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maSach = dgv_DSSach.CurrentRow.Cells[0].Value.ToString();
            sachDTO.maSach = maSach;
            if (dgv_DSSach.SelectedRows.Count == 0)
            {
                return;
            }
            if (sachBUS.deleteSach(sachDTO))
            {
                MessageBox.Show("Xóa Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSach(1);
                
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void loadSach(int trangThai)
        {
            dgv_DSSach.DataSource = null;
            sachDTO.trangThai = trangThai;
            DataTable dt = sachBUS.getSach(sachDTO);
            dgv_DSSach.DataSource = dt;
            dgv_DSSach.ClearSelection();
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

        private void dgv_DSSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
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
            selectionTimer.Stop(); // chỉ gọi 1 lần
            dgv_DSSach.ClearSelection(); // bỏ chọn dòng
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }

        private void frmQuanLySach_Shown(object sender, EventArgs e)
        {
            dgv_DSSach.ClearSelection();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadSach(1);
        }
    }
}
