using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

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
            
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
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

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
