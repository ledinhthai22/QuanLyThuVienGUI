using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private int SoLuongTrang = 26;
        private int TrangHienTai = 1;
        private int TongTrang = 1;
        private bool dangPhanTrang = true;
        private const int nguongRong = 658;
        private List<DocGiaDTO> danhSachDocGia = new List<DocGiaDTO>();
        public frmQuanLyDocGia()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgv_DSDocGia, new object[] { true });
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            loadDSDG();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            loadDSDG();
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
            loadDSDG();
        }
        private List<DocGiaDTO> loadDSDG()
        {
            try
            {
                List<DocGiaDTO> dsDocgia = docGiaBUS.loadDSDG();

                if (dsDocgia == null || dsDocgia.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachDocGia = dsDocgia;
                    dgv_DSDocGia.DataSource = null;
                    dgv_DSDocGia.DataSource = danhSachDocGia;
                    tinhTongTrang();
                    TrangHienTai = 1;
                    LoadTrang();
                }

                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSDocGia.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachDocGia;
        }
        private void capNhatSoLuongTrang()
        {
            int chieuCaoHeader = dgv_DSDocGia.ColumnHeadersHeight;
            int chieuCaoRow = dgv_DSDocGia.RowTemplate.Height;
            int chieuCaoHienThi = dgv_DSDocGia.ClientSize.Height - chieuCaoHeader;
            SoLuongTrang = chieuCaoHienThi / chieuCaoRow;
            if (SoLuongTrang <= 0)
            {
                SoLuongTrang = 1;
            }
        }

        private void LoadTrang()
        {
            if (danhSachDocGia == null || danhSachDocGia.Count == 0)
            {
                danhSachDocGia = loadDSDG();
            }

            if (!dangPhanTrang)
            {
                dgv_DSDocGia.DataSource = danhSachDocGia;
                lbl_SoTrang.Text = "";
                btn_TrangSau.Visible = false;
                btn_TrangTruoc.Visible = false;
                return;
            }

            int skip = (TrangHienTai - 1) * SoLuongTrang;
            var duLieuTrang = danhSachDocGia.Skip(skip).Take(SoLuongTrang).ToList();
            dgv_DSDocGia.DataSource = duLieuTrang;
            lbl_SoTrang.Text = $"{TrangHienTai}/{TongTrang}";
            btn_TrangSau.Enabled = TrangHienTai < TongTrang;
            btn_TrangTruoc.Enabled = TrangHienTai > 1;
        }

        private void tinhTongTrang()
        {
            if (danhSachDocGia == null || danhSachDocGia.Count <= SoLuongTrang)
            {
                dangPhanTrang = false;
                TongTrang = 1;
            }
            else
            {
                dangPhanTrang = true;
                TongTrang = (int)Math.Ceiling((double)danhSachDocGia.Count / SoLuongTrang);
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
                HeaderText = "Mã độc giả"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Họ tên"
            });
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày sinh"
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
                HeaderText = "Địa chỉ"
            });

            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                DataPropertyName = "SoDienThoai",
                HeaderText = "Số điện thoại"
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
                HeaderText = "Trạng thái"
            });
        }

        private void dgv_DSDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.Value != null)
            {
                string trangThai = e.Value.ToString();
                if (trangThai == "1")
                {
                    e.Value = "Hoạt động";
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

            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_CapNhat.Enabled = false;
            }
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
            docGiaDTO.maDocGia = maDG;
            docGiaDTO.hoTen = hoTen;
            docGiaDTO.ngaySinh = ngaySinh;
            docGiaDTO.gioiTinh = gioiTinh;
            docGiaDTO.diaChi = diaChi;
            docGiaDTO.email = Email;
            docGiaDTO.soDienThoai = SDT;
  
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaDocGia xoaDG = new frmXoaDocGia(docGiaDTO);
                xoaDG.ShowDialog();
                dgv_DSDocGia.ClearSelection();
                loadDSDG();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSDocGia.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatDocGia capNhatDG = new frmCapNhatDocGia(docGiaDTO);
                capNhatDG.ShowDialog();
                dgv_DSDocGia.ClearSelection();
                loadDSDG();
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
                    List<DocGiaDTO> danhSachTimKiem = TimKiemDocGia(keyword);

                    // Kiểm tra nếu có kết quả tìm kiếm
                    if (danhSachTimKiem.Any())
                    {
                        // Hiển thị kết quả tìm kiếm vào DataGridView
                        dgv_DSDocGia.DataSource = null;
                        dgv_DSDocGia.DataSource = danhSachTimKiem;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDSDG(); // Nếu không có kết quả, tải lại toàn bộ danh sách nhân viên
                    }

                    // Tự động xóa lựa chọn
                    dgv_DSDocGia.ClearSelection();
                }
                else
                {
                    loadDSDG(); // Nếu không có từ khóa tìm kiếm, tải lại toàn bộ danh sách nhân viên
                }

            }
            catch (Exception ex)
            {
                loadDSDG();
            }

        }
        public List<DocGiaDTO> TimKiemDocGia(string keyword)
        {
            var danhSach = docGiaBUS.loadDSDG();
            keyword = keyword.ToLower();

            return danhSach.Where(nv =>
                (!string.IsNullOrEmpty(nv.hoTen) && nv.hoTen.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.maDocGia) && nv.maDocGia.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.diaChi) && nv.diaChi.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(nv.soDienThoai) && nv.soDienThoai.Contains(keyword))
            ).ToList();
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            if (TrangHienTai < TongTrang)
            {
                TrangHienTai++;
                LoadTrang();
                dgv_DSDocGia.ClearSelection();
            }
        }

        private void pn_ThongTinDocGia_Resize(object sender, EventArgs e)
        {
            if (danhSachDocGia == null || danhSachDocGia.Count == 0)
            {
                danhSachDocGia = loadDSDG();
            }

            if (pn_ThongTinDocGia.Width > nguongRong)
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

        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            if (TrangHienTai > 1)
            {
                TrangHienTai--;
                LoadTrang();
                dgv_DSDocGia.ClearSelection();
            }
        }
    }
}
