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
        SachBUS sachBUS = new SachBUS();
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemSach themSach = new frmThemSach();
            themSach.ShowDialog();
        }
        private void loadDSSach()
        {
            try
            {
                dgv_DSSach.DataSource = null;
                dgv_DSSach.DataSource = sachBUS.loadSach();
                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSSach.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_Sua.Enabled = false;
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách thể loại: " + ex.Message);
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
                HeaderText = "Mã sách"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TacGia",
                DataPropertyName = "TacGia",
                HeaderText = "Tác giả"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                DataPropertyName = "TenTheLoai",
                HeaderText = "Thể loại"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NamXuatBan",
                DataPropertyName = "NamXuatBan",
                HeaderText = "Năm xuất bản"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NhaXuatBan",
                DataPropertyName = "NhaXuatBan",
                HeaderText = "Nhà xuất bản"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số lượng"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                DataPropertyName = "MoTa",
                HeaderText = "Mô tả"
            });

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"
            });
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
           
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadDSSach();
            huychontimer = new Timer();
            huychontimer.Interval = 3000;
            huychontimer.Tick += huychontimer_Tick;
            dgv_DSSach.SelectionChanged += dgv_DSSach_SelectionChanged;
        }

        private void dgv_DSSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                if (trangThai == "1")
                {
                    e.Value = "Còn sẵn";
                }
                else if (trangThai == "0")
                {
                    e.Value = "đã mượn hết";
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadDSSach();
        }

        private void dgv_DSSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;


                huychontimer.Stop();
                huychontimer.Start();
            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
            }
        }

        private void huychontimer_Tick(object sender, EventArgs e)
        {
            huychontimer.Stop();
            dgv_DSSach.ClearSelection();
        }
    }
}