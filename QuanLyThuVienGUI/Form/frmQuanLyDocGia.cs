using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.CacFormNhanVien;
using QuanLyThuVienGUI.QuanLy;

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
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDS();
            taoCotDataGridView();
            dgv_DSDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DSDocGia.MultiSelect = false;
            dgv_DSDocGia.ReadOnly = true;
            dgv_DSDocGia.AllowUserToAddRows = false;
            dgv_DSDocGia.AllowUserToDeleteRows = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDocGia = new frmThemDocGia();
            frmThemDocGia.ShowDialog();
        }
        private void LoadDS()
        {
            try
            {
                dgv_DSDocGia.DataSource = null;
                dgv_DSDocGia.DataSource = docGiaBUS.LoadDSDG();
                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSDocGia.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách độc giả: " + ex.Message);
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

        private void dgv_DSDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                if (trangThai == "1")
                {
                    e.Value = "Đang hoạt động";
                }
                else if (trangThai == "0")
                {
                    e.Value = "Ngừng hoạt động";
                }
            }
        }

        private void dgv_DSDocGia_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = true;
                btn_CapNhat.Enabled = true;


                huychontimer.Stop();
                huychontimer.Start();
            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_CapNhat.Enabled = false;
            }
        }

        private void huychontimer_Tick(object sender, EventArgs e)
        {
            huychontimer.Stop();
            dgv_DSDocGia.ClearSelection();
        }
        private void getDuLieu()
        {
            int selectedRowIndex = dgv_DSDocGia.SelectedRows[0].Index;
            string maDG = dgv_DSDocGia.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string hoTen = dgv_DSDocGia.Rows[selectedRowIndex].Cells[1].Value.ToString();
            DateTime ngaySinh = DateTime.Parse(dgv_DSDocGia.Rows[selectedRowIndex].Cells[2].Value.ToString());
            string gioiTinh = dgv_DSDocGia.Rows[selectedRowIndex].Cells[3].Value.ToString();
            
            string diaChi = dgv_DSDocGia.Rows[selectedRowIndex].Cells[4].Value.ToString();
            string SDT = dgv_DSDocGia.Rows[selectedRowIndex].Cells[5].Value.ToString();
            string Email = dgv_DSDocGia.Rows[selectedRowIndex].Cells[6].Value.ToString();
            int trangThai = int.Parse(dgv_DSDocGia.Rows[selectedRowIndex].Cells[7].Value.ToString());
    
            docGiaDTO.maDG = maDG;
            docGiaDTO.hoTen = hoTen;
            docGiaDTO.ngaySinh = ngaySinh;
            docGiaDTO.gioiTinh = gioiTinh;
            docGiaDTO.diaChi = diaChi;
            docGiaDTO.email = Email;
            docGiaDTO.soDienThoai = SDT;
            docGiaDTO.ngaySinh = ngaySinh;
           
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaDocGia xoaDG = new frmXoaDocGia(docGiaDTO);
                xoaDG.ShowDialog();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatDocGia capNhatDG = new frmCapNhatDocGia(docGiaDTO);
                capNhatDG.ShowDialog();
            }
        }
    }
}
