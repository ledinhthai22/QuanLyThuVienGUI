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
        private Timer huyChonTimer;

        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            loadDSTheLoai();

            // Khởi tạo Timer
            huyChonTimer = new Timer();
            huyChonTimer.Interval = 3000; // 3 giây
            huyChonTimer.Tick += huychontimer_Tick;

            this.BeginInvoke(new Action(() =>
            {
                dgv_DanhSachTL.ClearSelection();
                btn_XoaTL.Enabled = false;
                btn_CapNhat.Enabled = false;
            }));

            // Gắn sự kiện SelectionChanged
            dgv_DanhSachTL.SelectionChanged += dgv_DanhSachTL_SelectionChanged;
        }

        private void loadDSTheLoai()
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

             
                this.BeginInvoke(new Action(() =>
                {
                    dgv_DanhSachTL.ClearSelection();
                    btn_XoaTL.Enabled = false;
                    btn_CapNhat.Enabled = false;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách thể loại: " + ex.Message);
            }
        }


        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            frmThemTheLoai themTheLoai = new frmThemTheLoai();
            themTheLoai.ShowDialog();
        }

        private void dgv_DanhSachTL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                btn_XoaTL.Enabled = true;
                btn_CapNhat.Enabled = true;

                // Reset timer nếu chọn dòng mới
                huychontimer.Stop();
                huychontimer.Start();
            }
            else
            {
                btn_XoaTL.Enabled = false;
                btn_CapNhat.Enabled = false;
            }
        }
        private void huychontimer_Tick(object sender, EventArgs e)
        {
            huychontimer.Stop();
            dgv_DanhSachTL.ClearSelection();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            loadDSTheLoai();
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgv_DanhSachTL.SelectedRows[0].Index;
                string maTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string tenTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[1].Value.ToString();
                TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
                theLoaiDTO.maTL = maTL;
                theLoaiDTO.tenTL = tenTL;
                frmXoaTheLoai xoaTheLoai = new frmXoaTheLoai(theLoaiDTO);
                xoaTheLoai.ShowDialog();
            }
           
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            if (dgv_DanhSachTL.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgv_DanhSachTL.SelectedRows[0].Index;
                string maTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string tenTL = dgv_DanhSachTL.Rows[selectedRowIndex].Cells[1].Value.ToString();
                TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
                theLoaiDTO.maTL = maTL;
                theLoaiDTO.tenTL = tenTL;
                frmCapNhatTheLoai capNhatTheLoai = new frmCapNhatTheLoai(theLoaiDTO);
                capNhatTheLoai.ShowDialog();
            }
        }

        private void btn_TimKiemTL_Click(object sender, EventArgs e)
        {
            string keyWord = txt_TimKiemTL.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyWord))
            {
                return;
            }

            List<TheLoaiDTO> dsTheLoai = theLoaiBUS.loadTheLoai();

            var ketQua = dsTheLoai
                .Where(tl => tl.tenTL != null && tl.tenTL.ToLower().Contains(keyWord))
                .ToList();

            dgv_DanhSachTL.DataSource = null;
            dgv_DanhSachTL.DataSource = ketQua;

            dgv_DanhSachTL.Columns[0].HeaderText = "Mã thể loại";
            dgv_DanhSachTL.Columns[1].HeaderText = "Tên thể loại";

            this.BeginInvoke(new Action(() =>
            {
                dgv_DanhSachTL.ClearSelection();
                btn_XoaTL.Enabled = false;
                btn_CapNhat.Enabled = false;
            }));
        }

        private void dgv_DanhSachTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
