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
                dgv_DSNhanVien.DataSource = nhanVienBUS.LoadDSNV();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
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
            taoCotDataGridView();
            huychontimer = new Timer();
            huychontimer.Interval = 3000; 
            huychontimer.Tick += huychontimer_Tick;
            dgv_DSNhanVien.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void getDuLieu()
        {
            nhanVienDTO.maNV = dgv_DSNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
            nhanVienDTO.tenNV = dgv_DSNhanVien.SelectedRows[0].Cells["TenNV"].Value.ToString();
            nhanVienDTO.chucVu = dgv_DSNhanVien.SelectedRows[0].Cells["ChucVu"].Value.ToString();
            nhanVienDTO.diaChi = dgv_DSNhanVien.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            nhanVienDTO.SDT = dgv_DSNhanVien.SelectedRows[0].Cells["SDT"].Value.ToString();
            nhanVienDTO.ngaySinh = DateTime.Parse(dgv_DSNhanVien.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
            nhanVienDTO.luong = float.Parse(dgv_DSNhanVien.SelectedRows[0].Cells["Luong"].Value.ToString());
            nhanVienDTO.userName = dgv_DSNhanVien.SelectedRows[0].Cells["UserName"].Value.ToString();
            nhanVienDTO.password = dgv_DSNhanVien.SelectedRows[0].Cells["PassWord"].Value.ToString();
            nhanVienDTO.trangThai = int.Parse(dgv_DSNhanVien.SelectedRows[0].Cells["TrangThai"].Value.ToString());
            nhanVienDTO.ngayTao = DateTime.Parse(dgv_DSNhanVien.SelectedRows[0].Cells["NgayTao"].Value.ToString());
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //string maNV = dgv_DSNhanVien.SelectedRows[0].Cells["MaNV"].Value.ToString();
            //getDuLieu();
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    if(nhanVienBUS.kiemTraNhanVienChoMuonSach(nhanVienDTO))
            //    {
            //        MessageBox.Show("Nhân viên này đang có sách mượn, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        if (nhanVienBUS.deleteNV(maNV))
            //        {
            //            MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            loadDSNV();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            if (dgv_DSNhanVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgv_DSNhanVien.SelectedRows[0].Index;
                string maNV = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string tenNV = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string chucVu = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[2].Value.ToString();
                string diaChi = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[5].Value.ToString();
                string sdt = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[4].Value.ToString();
                DateTime ngaySinh = DateTime.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[3].Value.ToString());
                Double luong = double.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[6].Value.ToString());
                string userName = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[7].Value.ToString();
                string passWord = dgv_DSNhanVien.Rows[selectedRowIndex].Cells[8].Value.ToString();
                int trangThai = int.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[9].Value.ToString());
                DateTime ngayTao = DateTime.Parse(dgv_DSNhanVien.Rows[selectedRowIndex].Cells[10].Value.ToString());
                nhanVienDTO.maNV = maNV;
                nhanVienDTO.tenNV = tenNV;
                nhanVienDTO.chucVu = chucVu;
                nhanVienDTO.diaChi = diaChi;
                nhanVienDTO.SDT = sdt;
                nhanVienDTO.ngaySinh = ngaySinh;
                nhanVienDTO.luong = luong;
                nhanVienDTO.userName = userName;
                nhanVienDTO.password = passWord;
                nhanVienDTO.trangThai = trangThai;
                nhanVienDTO.ngayTao = ngayTao;
                frmXoaNhanVien xoaNV = new frmXoaNhanVien(nhanVienDTO);
                xoaNV.ShowDialog();
            }
        }
    }
}
