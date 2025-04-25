using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienGUI.ThuThu
{
    public partial class frmTaoPhieuMuon : Form
    {
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        public frmTaoPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmTaoPhieuMuon_Load(object sender, EventArgs e)
        {
            taoCotDSDocGia();
            LoadData();
        }
        private void LoadData()
        {
            dgv_DSDocGia.DataSource = null;
            DataTable dt2 = phieuMuonBUS.GetDocGia();
            dgv_DSDocGia.DataSource = dt2;
            dgv_DSDocGia.Refresh();
        }
        private void taoCotDSDocGia()
        {
            dgv_DSDocGia.Columns.Clear();
            dgv_DSDocGia.AutoGenerateColumns = false;
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Tên Độc Giả"
            });
            dgv_DSDocGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày Sinh"
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
                HeaderText = "Số Điện Thoại"
            });
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSDocGia.Rows[e.RowIndex];
                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
            }
        }

        private void btn_TaoPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuonDTO pm = new PhieuMuonDTO();
            pm.tenDocGia = txt_HoTen.Text;
            pm.ngayLap = dtpNgaymuon.Value;
            pm.ngayHenTra = dtpNgaytradukien.Value;
            pm.soLuong = nbrSoLuong.Value.ToString(); // hoặc chuyển thành int nếu DTO dùng int

            PhieuMuonBUS bus = new PhieuMuonBUS();
            bool result = bus.ThemMoi(pm);

            if (result)
            {
                MessageBox.Show("Thêm phiếu mượn thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");

            }
        }
    }
}

