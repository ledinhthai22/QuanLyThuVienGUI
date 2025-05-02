
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private int SoLuongTrang = 26;
        private int TrangHienTai = 1;
        private int TongTrang = 1;
        private bool dangPhanTrang = true;
        private const int nguongRong = 758;
        private List<SachDTO> danhSachSach = new List<SachDTO>();

        public frmQuanLySach()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgv_DSSach, new object[] { true });
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemSach themSach = new frmThemSach();
            themSach.ShowDialog();
            loadDSSach();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaSach xoaSach = new frmXoaSach(sachDTO);
                xoaSach.ShowDialog();
                dgv_DSSach.ClearSelection();
                loadDSSach();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatSach capNhatSach = new frmCapNhatSach(sachDTO);
                capNhatSach.ShowDialog();
                dgv_DSSach.ClearSelection();
                loadDSSach();
            }
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            danhSachSach = loadDSSach();
            txt_TimKiem.Clear();
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
            btn_TrangSau.Visible = true;
            btn_TrangTruoc.Visible = true;
            lbl_SoTrang.Visible = true;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_TimKiem.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {

                    List<SachDTO> danhSachTimKiem = TimKiemSach(keyword);


                    if (danhSachTimKiem.Any())
                    {

                        dgv_DSSach.DataSource = null;
                        dgv_DSSach.DataSource = danhSachTimKiem;
                        if(dgv_DSSach.Rows.Count < 26)
                        {
                            btn_TrangSau.Visible = false;
                            btn_TrangTruoc.Visible = false;
                            lbl_SoTrang.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDSSach();
                    }


                    dgv_DSSach.ClearSelection();
                }
                else
                {
                    loadDSSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
        public List<SachDTO> TimKiemSach(string keyword)
        {
            var danhSach = sachBUS.loadSach();
            keyword = keyword.ToLower();

            return danhSach.Where(sach =>
                (!string.IsNullOrEmpty(sach.tenSach) && sach.tenSach.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(sach.maSach) && sach.maSach.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(sach.tenTheLoai) && sach.tenTheLoai.ToLower().Contains(keyword))
            ).ToList();
        }
        private List<SachDTO> loadDSSach()
        {
            try
            {
                List<SachDTO> dsSach = sachBUS.loadSach();

                if (dsSach == null || dsSach.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachSach = dsSach;
                    dgv_DSSach.DataSource = null;
                    dgv_DSSach.DataSource = danhSachSach;
                    tinhTongTrang();
                    TrangHienTai = 1; 
                    LoadTrang(); 
                }

                this.BeginInvoke(new Action(() =>
                {
                    dgv_DSSach.ClearSelection();
                    btn_Xoa.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachSach;
        }

        private void capNhatSoLuongTrang()
        {
            int chieuCaoHeader = dgv_DSSach.ColumnHeadersHeight;
            int chieuCaoRow = dgv_DSSach.RowTemplate.Height;
            int chieuCaoHienThi = dgv_DSSach.ClientSize.Height - chieuCaoHeader;
            SoLuongTrang = chieuCaoHienThi / chieuCaoRow;
            if (SoLuongTrang <= 0)
            {
                SoLuongTrang = 1;
            }
        }

        private void LoadTrang()
        {
            if (danhSachSach == null || danhSachSach.Count == 0)
            {
                danhSachSach = loadDSSach();
            }

            if (!dangPhanTrang)
            {
                dgv_DSSach.DataSource = danhSachSach;
                lbl_SoTrang.Text = "";
                btn_TrangSau.Visible = false;
                btn_TrangTruoc.Visible = false;
                return;
            }

            int skip = (TrangHienTai - 1) * SoLuongTrang;
            var duLieuTrang = danhSachSach.Skip(skip).Take(SoLuongTrang).ToList();
            dgv_DSSach.DataSource = duLieuTrang;
            lbl_SoTrang.Text = $"{TrangHienTai}/{TongTrang}";
            btn_TrangSau.Enabled = TrangHienTai < TongTrang;
            btn_TrangTruoc.Enabled = TrangHienTai > 1;
        }

        private void tinhTongTrang()
        {
            if (danhSachSach == null || danhSachSach.Count <= SoLuongTrang)
            {
                dangPhanTrang = false;
                TongTrang = 1;
            }
            else
            {
                dangPhanTrang = true;
                TongTrang = (int)Math.Ceiling((double)danhSachSach.Count / SoLuongTrang);
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
                Visible = false
            });
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            loadDSSach();
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
                    e.Value = "Đã mượn hết";
                }
            }
        }

       
        private void dgv_DSSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSSach.SelectedRows.Count > 0)
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

       
        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            if (TrangHienTai > 1)
            {
                TrangHienTai--;
                LoadTrang();
                dgv_DSSach.ClearSelection();
            }
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            if (TrangHienTai < TongTrang)
            {
                TrangHienTai++;
                LoadTrang();
                dgv_DSSach.ClearSelection();
            }
        }

        private void pnframeInformation_Resize(object sender, EventArgs e)
        {
            if (danhSachSach == null || danhSachSach.Count == 0)
            {
                danhSachSach = loadDSSach();
            }

            if (pnframeInformation.Width > nguongRong)
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
