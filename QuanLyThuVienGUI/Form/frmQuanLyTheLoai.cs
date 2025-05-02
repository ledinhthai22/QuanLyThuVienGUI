using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.CacFormNhanVien;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyTheLoai : Form
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        private int SoLuongTrang = 25;
        private int TrangHienTai = 1;
        private int TongTrang = 1;
        private bool dangPhanTrang = true;
        private const int nguongRong = 758;
        private List<TheLoaiDTO> danhSachTL = new List<TheLoaiDTO>();

        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            danhSachTL = loadDSTheLoai();
            capNhatSoLuongTrang();
            this.BeginInvoke(new Action(() =>
            {
                dgv_DanhSachTL.ClearSelection();
                btn_XoaTL.Enabled = false;
                btn_CapNhat.Enabled = false;
            }));

            dgv_DanhSachTL.SelectionChanged += dgv_DanhSachTL_SelectionChanged;
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
           
        }
        private void capNhatSoLuongTrang()
        {
            int chieuCaoHeader = dgv_DanhSachTL.ColumnHeadersHeight;
            int chieuCaoRow = dgv_DanhSachTL.RowTemplate.Height;

            int chieuCaoDatagrid = (dgv_DanhSachTL.Height - chieuCaoHeader)+1;

            SoLuongTrang = chieuCaoDatagrid / chieuCaoRow;

            if (SoLuongTrang <= 0)
            {
                SoLuongTrang = 1;
            }
        }

        private void LoadTrang()
        {
            if (danhSachTL == null || danhSachTL.Count == 0)
            {
                danhSachTL = loadDSTheLoai();
            }

            if (!dangPhanTrang)
            {
                dgv_DanhSachTL.DataSource = danhSachTL;
                lbl_SoTrang.Text = "";
                btn_TrangSau.Visible = false;
                btn_TrangTruoc.Visible = false;
                return;
            }

            int skip = (TrangHienTai - 1) * SoLuongTrang;
            var duLieuTrang = danhSachTL.Skip(skip).Take(SoLuongTrang).ToList();
            dgv_DanhSachTL.DataSource = duLieuTrang;
            lbl_SoTrang.Text = $"{TrangHienTai}/{TongTrang}";
            btn_TrangSau.Visible = true;
            btn_TrangTruoc.Visible = true;
        }

        private void tinhTongTrang()
        {
            if (danhSachTL == null || danhSachTL.Count <= SoLuongTrang)
            {
                dangPhanTrang = false;
                TongTrang = 1;
            }
            else
            {
                dangPhanTrang = true;
                TongTrang = (int)Math.Ceiling((double)danhSachTL.Count / SoLuongTrang);
            }
        }

        private List<TheLoaiDTO> loadDSTheLoai()
        {
            try
            {
                List<TheLoaiDTO> dsTheLoai = theLoaiBUS.loadTheLoai();

                if (dsTheLoai == null || dsTheLoai.Count == 0)
                {
                    MessageBox.Show("Không có thể loại nào để hiển thị.");
                }
                else
                {
                    dgv_DanhSachTL.DataSource = null;
                    dgv_DanhSachTL.DataSource = dsTheLoai;
                }

                dgv_DanhSachTL.Columns[0].HeaderText = "Mã thể loại";
                dgv_DanhSachTL.Columns[1].HeaderText = "Tên thể loại";

                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_DanhSachTL.ClearSelection();
                        btn_XoaTL.Enabled = false;
                        btn_CapNhat.Enabled = false;
                    }));
                }
                else
                {
                    dgv_DanhSachTL.ClearSelection();
                    btn_XoaTL.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }
    
                return dsTheLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách thể loại: " + ex.Message);
                return new List<TheLoaiDTO>();
            }
        }

        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            frmThemTheLoai themTheLoai = new frmThemTheLoai();
            themTheLoai.ShowDialog();
            danhSachTL = loadDSTheLoai();
            capNhatSoLuongTrang();
            tinhTongTrang();
            LoadTrang();
        }

        private void dgv_DanhSachTL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                btn_XoaTL.Enabled = true;
                btn_CapNhat.Enabled = true;
            }
            else
            {
                btn_XoaTL.Enabled = false;
                btn_CapNhat.Enabled = false;
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            danhSachTL = loadDSTheLoai();
            txt_TimKiemTL.Clear();
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
        }

        private void getDuLieu()
        {
            int selectedRowIndex = dgv_DanhSachTL.SelectedRows[0].Index;
            string maTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string tenTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[1].Value.ToString();
            theLoaiDTO.maTL = maTL;
            theLoaiDTO.tenTL = tenTL;
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmXoaTheLoai xoaTheLoai = new frmXoaTheLoai(theLoaiDTO);
                xoaTheLoai.ShowDialog();
                danhSachTL = loadDSTheLoai();
                LoadTrang();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                getDuLieu();
                frmCapNhatTheLoai capNhatTheLoai = new frmCapNhatTheLoai(theLoaiDTO);
                capNhatTheLoai.ShowDialog();
                danhSachTL = loadDSTheLoai();
                LoadTrang();
            }
        }

        private void btn_TimKiemTL_Click(object sender, EventArgs e)
        {
            string keyWord = txt_TimKiemTL.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyWord))
            {
                danhSachTL = loadDSTheLoai(); // nếu tìm rỗng thì reload lại danh sách ban đầu
                tinhTongTrang();
                TrangHienTai = 1;
                LoadTrang();
                // xóa ô tìm kiếm
                return;
            }

            var ketQua = theLoaiBUS.loadTheLoai()
                .Where(tl => tl.tenTL != null && tl.tenTL.ToLower().Contains(keyWord))
                .ToList();

            danhSachTL = ketQua; // <<< cập nhật danh sách mới sau tìm kiếm
            txt_TimKiemTL.Clear();
            tinhTongTrang();
            TrangHienTai = 1;
            LoadTrang();
        }

        private void dgv_DanhSachTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            if (TrangHienTai > 1)
            {
                TrangHienTai--;
                LoadTrang();
                dgv_DanhSachTL.ClearSelection();
            }
        }

        private void btn_TrangSau_Click(object sender, EventArgs e)
        {
            if (TrangHienTai < TongTrang)
            {
                TrangHienTai++;
                LoadTrang();
                dgv_DanhSachTL.ClearSelection();
            }
        }

        private void pn_ThongTinTL_Resize(object sender, EventArgs e)
        {

            if (danhSachTL == null || danhSachTL.Count == 0)
            {
                danhSachTL = loadDSTheLoai();
            }

            if (pn_ThongTinTL.Width > nguongRong)
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
