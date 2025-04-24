using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.CacFormNhanVien;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI.admin
{
    
    public partial class frmQuanLyNhanVien: Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        NhanVienDTO nhanVienDTO = new NhanVienDTO();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
           
        }
           
        private void loadDSNV()
        {
            try
            {
                dgv_DSNhanVien.DataSource = null;
                dgv_DSNhanVien.DataSource = nhanVienBUS.loadDSNV();
                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSNhanVien.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách thể loại: " + ex.Message);
            }
        }

        private void taoCotDataGridView()
        {
            dgv_DSNhanVien.Columns.Clear();
            dgv_DSNhanVien.AutoGenerateColumns = false;

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaNV",
                DataPropertyName = "MaNV",
                HeaderText = "Mã nhân viên"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenNV",
                DataPropertyName = "TenNV",
                HeaderText = "Tên nhân viên"
            });
            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ChucVu",
                DataPropertyName = "ChucVu",
                HeaderText = "Chức vụ"
            });
            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GioiTinh",
                DataPropertyName = "GioiTinh",
                HeaderText = "Giới tính"
            });
            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày sinh"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SDT",
                DataPropertyName = "SDT",
                HeaderText = "Số điện thoại"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                DataPropertyName = "DiaChi",
                HeaderText = "Địa chỉ"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Luong",
                DataPropertyName = "Luong",
                HeaderText = "Lương"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                DataPropertyName = "UserName",
                HeaderText = "Username"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PassWord",
                DataPropertyName = "PassWord",
                HeaderText = "Password"
            });

            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"
            });
            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayTao",
                DataPropertyName = "NgayTao",
                HeaderText = "Ngày Tạo"
            });

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNV = new frmThemNhanVien();
            frmThemNV.ShowDialog();

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadDSNV();
        }

        private void huychontimer_Tick(object sender, EventArgs e)
        {
            huychontimer.Stop();
            dgv_DSNhanVien.ClearSelection();
        }

        private void dgv_DSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
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

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadDSNV();
            dgv_DSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DSNhanVien.MultiSelect = false;
            dgv_DSNhanVien.ReadOnly = true;
            dgv_DSNhanVien.AllowUserToAddRows = false;
            dgv_DSNhanVien.AllowUserToDeleteRows = false;
            taoCotDataGridView();
            huychontimer = new Timer();
            huychontimer.Interval = 3000; 
            huychontimer.Tick += huychontimer_Tick;
            dgv_DSNhanVien.SelectionChanged += dgv_DSNhanVien_SelectionChanged;
        }
        private void getDuLieu()
        {
            int selectedRowIndex = dgv_DSNhanVien.SelectedRows[0].Index;
            string maNV = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string tenNV = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string chucVu = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[2].Value.ToString();
            string diaChi = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[6].Value.ToString();
            string sdt = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[5].Value.ToString();
            string gioiTinh = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[3].Value.ToString();
            DateTime ngaySinh = DateTime.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[4].Value.ToString());
            Double luong = double.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[7].Value.ToString());
            string userName = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[8].Value.ToString();
            string passWord = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[9].Value.ToString();
            int trangThai = int.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[10].Value.ToString());
            DateTime ngayTao = DateTime.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[11].Value.ToString());
            nhanVienDTO.maNV = maNV;
            nhanVienDTO.tenNV = tenNV;
            nhanVienDTO.chucVu = chucVu;
            nhanVienDTO.gioiTinh = gioiTinh;
            nhanVienDTO.diaChi = diaChi;
            nhanVienDTO.SDT = sdt;
            nhanVienDTO.ngaySinh = ngaySinh;
            nhanVienDTO.luong = luong;
            nhanVienDTO.userName = userName;
            nhanVienDTO.password = passWord;
            nhanVienDTO.trangThai = trangThai;
            nhanVienDTO.ngayTao = ngayTao;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaNhanVien xoaNV = new frmXoaNhanVien(nhanVienDTO);
                xoaNV.ShowDialog();
            }
        }

        private void dgv_DSNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSNhanVien.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = Convert.ToInt32(e.Value);
                    if (trangThai == 1)
                    {
                        e.Value = "Đang làm việc";
                    }
                    else
                    {
                        e.Value = "Đã nghỉ việc";
                    }
                }
            }
            if (dgv_DSNhanVien.Columns[e.ColumnIndex].Name == "Luong")
            {
                if (e.Value != null)
                {
                    double luong = Convert.ToDouble(e.Value);
                    e.Value = luong.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
                }
            }    
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatNhanVien capNhatNhanVien = new frmCapNhatNhanVien(nhanVienDTO);
                capNhatNhanVien.ShowDialog();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_TimKiem.Text.Trim(); // Giả sử bạn có một TextBox txt_TimKiem để nhập từ khóa tìm kiếm

                if (!string.IsNullOrEmpty(keyword))
                {
                    // Gọi phương thức tìm kiếm
                    List<NhanVienDTO> danhSachTimKiem = TimKiemNhanVien(keyword);

                    // Kiểm tra nếu có kết quả tìm kiếm
                    if (danhSachTimKiem.Any())
                    {
                        // Hiển thị kết quả tìm kiếm vào DataGridView
                        dgv_DSNhanVien.DataSource = null;
                        dgv_DSNhanVien.DataSource = danhSachTimKiem;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDSNV(); // Nếu không có kết quả, tải lại toàn bộ danh sách nhân viên
                    }

                    // Tự động xóa lựa chọn
                    dgv_DSNhanVien.ClearSelection();
                }
                else
                {
                    loadDSNV(); // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ danh sách nhân viên
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        public List<NhanVienDTO> TimKiemNhanVien(string keyword)
        {
            var danhSach = nhanVienBUS.loadDSNV();
            keyword = keyword.ToLower();

            return danhSach.Where(nv =>
                (!string.IsNullOrEmpty(nv.tenNV) && nv.tenNV.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.maNV) && nv.maNV.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.userName) && nv.userName.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.SDT) && nv.SDT.ToLower().Contains(keyword))
            ).ToList();
        }
    }
}
