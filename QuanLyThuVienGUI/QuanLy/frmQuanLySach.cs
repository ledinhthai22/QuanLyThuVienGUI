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
        private string tenFileAnh = "";

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadSach(1);
        }

       

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemSach thesach = new ThemSach();
            thesach.ShowDialog();
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
                
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            
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

        private void pnframeInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_TacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TenSach_Click(object sender, EventArgs e)
        {

        }

        private void txt_NXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TacGia_Click(object sender, EventArgs e)
        {

        }

        private void lblPublisher_Click(object sender, EventArgs e)
        {

        }
    }
}
