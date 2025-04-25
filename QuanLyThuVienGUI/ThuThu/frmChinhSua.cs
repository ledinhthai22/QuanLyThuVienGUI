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
    public partial class frmChinhSua : Form
    {
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        public frmChinhSua()
        {
            InitializeComponent();
        }

        private void frmChinhSua_Load(object sender, EventArgs e)
        {
            taoCotDSMuon();
            LoadData();
        }
        private void LoadData()
        {

            dgv_DSMuon.DataSource = null;

            DataTable dt = phieuMuonBUS.GetPhieuMuon();
            dgv_DSMuon.DataSource = dt;

            dgv_DSMuon.Refresh();
        }
        private void taoCotDSMuon()
        {
            dgv_DSMuon.Columns.Clear();
            dgv_DSMuon.AutoGenerateColumns = false;


            dgv_DSMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuMuon",
                DataPropertyName = "MaPhieuMuon",
                HeaderText = "Mã Phiếu Mượn"
            });
            dgv_DSMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Tên Độc Giả"
            });
            dgv_DSMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuongSach",
                DataPropertyName = "SoLuongSach",
                HeaderText = "Số Lượng Sách Mượn"
            });
            dgv_DSMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayLap",
                DataPropertyName = "NgayLap",
                HeaderText = "Ngày Lập"
            });
            dgv_DSMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NGayHenTra",
                DataPropertyName = "NGayHenTra",
                HeaderText = "Ngày Hẹn Trả"
            });
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
