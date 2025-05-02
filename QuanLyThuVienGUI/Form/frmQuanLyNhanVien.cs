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
        private int SoLuongTrang = 26;
        private int TrangHienTai = 1;
        private int TongTrang = 1;
        private bool dangPhanTrang = true;
        private const int nguongRong = 658;
        private List<NhanVienDTO> danhSachNhanVien = new List<NhanVienDTO>();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgv_DSNhanVien, new object[] { true });
        }
           
      
        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNV = new frmThemNhanVien();
            frmThemNV.ShowDialog();
            loadDSNV();

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            danhSachNhanVien = loadDSNV();
            txt_TimKiem.Clear();
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatNhanVien capNhatNhanVien = new frmCapNhatNhanVien(nhanVienDTO);
                capNhatNhanVien.ShowDialog();
                dgv_DSNhanVien.ClearSelection();
                loadDSNV();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_TimKiem.Text.Trim(); 

                if (!string.IsNullOrEmpty(keyword))
                {
                   
                    List<NhanVienDTO> danhSachTimKiem = TimKiemNhanVien(keyword);

                    
                    if (danhSachTimKiem.Any())
                    {
                       
                        dgv_DSNhanVien.DataSource = null;
                        dgv_DSNhanVien.DataSource = danhSachTimKiem;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDSNV(); 
                    }

                    txt_TimKiem.Clear();
                    dgv_DSNhanVien.ClearSelection();
                }
                else
                {
                    loadDSNV(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void dgv_DSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = true;
                btn_CapNhat.Enabled = true;
            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_CapNhat.Enabled = false;
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaNhanVien xoaNV = new frmXoaNhanVien(nhanVienDTO);
                xoaNV.ShowDialog();
                dgv_DSNhanVien.ClearSelection();
                loadDSNV();
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
            dgv_DSNhanVien.SelectionChanged += dgv_DSNhanVien_SelectionChanged;
        }
        private List<NhanVienDTO> loadDSNV()
        {

            try
            {
                List<NhanVienDTO> dsNhanVien = nhanVienBUS.loadDSNV();

                if (dsNhanVien == null || dsNhanVien.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachNhanVien = dsNhanVien;
                    dgv_DSNhanVien.DataSource = null;
                    dgv_DSNhanVien.DataSource = danhSachNhanVien;
                    tinhTongTrang();
                    TrangHienTai = 1;
                    LoadTrang();
                }

                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSNhanVien.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachNhanVien;
        }
        private void LoadTrang()
        {
            if (danhSachNhanVien == null || danhSachNhanVien.Count == 0)
            {
                danhSachNhanVien = loadDSNV();
            }

            if (!dangPhanTrang)
            {
                dgv_DSNhanVien.DataSource = danhSachNhanVien;
                lbl_SoTrang.Text = "";
                btn_TrangSau.Visible = false;
                btn_TrangTruoc.Visible = false;
                return;
            }

            int skip = (TrangHienTai - 1) * SoLuongTrang;
            var duLieuTrang = danhSachNhanVien.Skip(skip).Take(SoLuongTrang).ToList();
            dgv_DSNhanVien.DataSource = duLieuTrang;
            lbl_SoTrang.Text = $"{TrangHienTai}/{TongTrang}";
            btn_TrangSau.Enabled = TrangHienTai < TongTrang;
            btn_TrangTruoc.Enabled = TrangHienTai > 1;
        }

        private void capNhatSoLuongTrang()
        {
            int chieuCaoHeader = dgv_DSNhanVien.ColumnHeadersHeight;
            int chieuCaoRow = dgv_DSNhanVien.RowTemplate.Height;
            int chieuCaoHienThi = dgv_DSNhanVien.ClientSize.Height - chieuCaoHeader;
            SoLuongTrang = chieuCaoHienThi / chieuCaoRow;
            if (SoLuongTrang <= 0)
            {
                SoLuongTrang = 1;
            }
        }

      

        private void tinhTongTrang()
        {
            if (danhSachNhanVien == null || danhSachNhanVien.Count <= SoLuongTrang)
            {
                dangPhanTrang = false;
                TongTrang = 1;
            }
            else
            {
                dangPhanTrang = true;
                TongTrang = (int)Math.Ceiling((double)danhSachNhanVien.Count / SoLuongTrang);
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
                HeaderText = "Trạng thái"
            });
            dgv_DSNhanVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayTao",
                DataPropertyName = "NgayTao",
                HeaderText = "Ngày tạo"
            });

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
            string userName = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[7].Value.ToString();
            string passWord = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[8].Value.ToString();
            int trangThai = int.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[9].Value.ToString());
            DateTime ngayTao = DateTime.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[10].Value.ToString());
            nhanVienDTO.maNV = maNV;
            nhanVienDTO.tenNV = tenNV;
            nhanVienDTO.chucVu = chucVu;
            nhanVienDTO.gioiTinh = gioiTinh;
            nhanVienDTO.diaChi = diaChi;
            nhanVienDTO.SDT = sdt;
            nhanVienDTO.ngaySinh = ngaySinh;
            nhanVienDTO.userName = userName;
            nhanVienDTO.password = passWord;
            nhanVienDTO.trangThai = trangThai;
            nhanVienDTO.ngayTao = ngayTao;
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
                        e.Value = "Hoạt động";
                    }
                    else
                    {
                        e.Value = "Ngưng hoạt động";
                    }
                }
            }
            if (dgv_DSNhanVien.Columns[e.ColumnIndex].Name == "PassWord")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
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

        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            if (TrangHienTai > 1)
            {
                TrangHienTai--;
                LoadTrang();
                dgv_DSNhanVien.ClearSelection();
            }
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            if (TrangHienTai < TongTrang)
            {
                TrangHienTai++;
                LoadTrang();
                dgv_DSNhanVien.ClearSelection();
            }
        }

        private void pn_ThongTinNhap_Resize(object sender, EventArgs e)
        {
            if (danhSachNhanVien == null || danhSachNhanVien.Count == 0)
            {
                danhSachNhanVien = loadDSNV();
            }

            if (pn_ThongTinNhap.Width > nguongRong)
            {
                dangPhanTrang = false;
            }
            else
            {
                dangPhanTrang = true;
            }

            capNhatSoLuongTrang();
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
        }
    }
}
