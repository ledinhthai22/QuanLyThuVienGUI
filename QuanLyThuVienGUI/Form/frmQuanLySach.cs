using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.admin;
using QuanLyThuVienGUI.CacFormNhanVien;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI
{
    public partial class frmQuanLySach : Form
    {
        SachBUS sachBUS = new SachBUS();
        SachDTO sachDTO = new SachDTO();
        TheLoaiDTO theLoai = new TheLoaiDTO();
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
                Name = "NhaCungCap",
                DataPropertyName = "NhaCungCap",
                HeaderText = "Nhà cung cấp"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                DataPropertyName = "MoTa",
                HeaderText = "Mô tả"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số lượng"
            });
           

            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"
            });
            dgv_DSSach.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaTheLoai",
                DataPropertyName = "MaTheLoai",
                HeaderText = "Mã Thể Loại",
                Visible = false // nếu không muốn hiển thị ra ngoài
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
            if (e.ColumnIndex == 9 && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                if (trangThai == "1")
                {
                    e.Value = "Còn sách";
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
        private void getDuLieu()
        {
            int selectedRowIndex = dgv_DSSach.SelectedRows[0].Index;
            string maSach = dgv_DSSach.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string tenSach = dgv_DSSach.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string tacGia = dgv_DSSach.Rows[selectedRowIndex].Cells[2].Value.ToString();
            string tenTheLoai = dgv_DSSach.Rows[selectedRowIndex].Cells[3].Value.ToString();
            DateTime namXuatBan = DateTime.Parse(dgv_DSSach.Rows[selectedRowIndex].Cells[4].Value.ToString());
            string nhaXuatBan = dgv_DSSach.Rows[selectedRowIndex].Cells[5].Value.ToString();
            string nhaCungCap = dgv_DSSach.Rows[selectedRowIndex].Cells[6].Value.ToString();
            int soLuong = int.Parse(dgv_DSSach.Rows[selectedRowIndex].Cells[8].Value.ToString());
            string moTa = dgv_DSSach.Rows[selectedRowIndex].Cells[7].Value.ToString();
            int trangThai = int.Parse(dgv_DSSach.Rows[selectedRowIndex].Cells[9].Value.ToString());
            string maTheLoai = dgv_DSSach.Rows[selectedRowIndex].Cells["MaTheLoai"].Value.ToString();
            sachDTO.maTheLoai = maTheLoai;
            sachDTO.maSach = maSach;
            sachDTO.tenSach = tenSach;
            sachDTO.nhaXuatBan = nhaXuatBan;
            sachDTO.tacGia = tacGia;
            sachDTO.moTa = moTa;
            theLoai.tenTL = tenTheLoai;
            sachDTO.namXuatBan = namXuatBan;
            sachDTO.soLuong = soLuong;
            sachDTO.trangThai = trangThai;
            sachDTO.nhaCungCap = nhaCungCap;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaSach xoaSach = new frmXoaSach(sachDTO);
                xoaSach.ShowDialog();
            }
        }
    }
}