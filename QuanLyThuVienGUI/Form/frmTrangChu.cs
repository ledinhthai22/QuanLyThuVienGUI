using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.admin
{
    public partial class frmTrangChu : Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
       
       
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
         
            taoCotDgv();

        }
        private void taoCotDgv()
        {
            dgv_ThongKe.Columns.Clear(); 
            dgv_ThongKe.AutoGenerateColumns = false;
            dgv_ThongKe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });

            dgv_ThongKe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuotMuon",
                DataPropertyName = "SoLuotMuon",
                HeaderText = "Số lượt mượn"
            });

            dgv_ThongKe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoNguoiMuon",
                DataPropertyName = "SoNguoiMuon",
                HeaderText = "Số người mượn"
            });

            dgv_ThongKe.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số lượng"
            });
        }

        private List<ThongKeDTO> loadDSThongKe()
        {
            DateTime tuNgay = dtp_TuNgay.Value;
            DateTime denNgay = dtp_DenNgay.Value;
            return thongKeBUS.ThongKeToanBo(tuNgay, denNgay);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtp_TuNgay.Value;
                DateTime denNgay = dtp_DenNgay.Value;
                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                    return;
                }
                dgv_ThongKe.DataSource = null;
                dgv_ThongKe.DataSource = loadDSThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thống kê: " + ex.Message);
            }
        }

    }
}
