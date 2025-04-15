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
        //private void btn_Them_Click(object sender, EventArgs e)
        //{
        //    if (!kiemTraDuLieuNhap()) return;

        //    docGiaDTO.hoTen = txt_HoTen.Text;
        //    docGiaDTO.ngaySinh = dtpNgaySinh.Value;
        //    docGiaDTO.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
        //    docGiaDTO.diaChi = txt_DiaChi.Text;
        //    docGiaDTO.soDienThoai = txt_SoDienThoai.Text;
        //    docGiaDTO.email = txt_Email.Text;

        //    if (docGiaBUS.kiemTraTonTai(docGiaDTO))
        //    {
        //        MessageBox.Show("Độc giả đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (docGiaBUS.addDocGia(docGiaDTO))
        //    {
        //        MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        loadDG(1);
        //        tuDongLamMoi();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void btn_Xoa_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
        //    {
        //        MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (dgv_DSDocGia.CurrentRow != null)
        //    {
        //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.No) return;

        //       string maDG = dgv_DSDocGia.CurrentRow.Cells[0].Value.ToString();
        //        docGiaDTO.maDG = maDG;

        //        if (docGiaBUS.kiemTraRangBuoc(docGiaDTO))
        //        {
        //            MessageBox.Show("Không thể xóa độc giả vì đang có sách mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        if (docGiaBUS.deleteDocGia(docGiaDTO))
        //        {
        //            MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            loadDG(1);
        //            tuDongLamMoi();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Xóa độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn độc giả để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btn_Sua_Click(object sender, EventArgs e)
        //{
        //    if (dgv_DSDocGia.CurrentRow == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    if(string.IsNullOrWhiteSpace(txt_HoTen.Text))
        //    {
        //        MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }    
        //    if (!kiemTraDuLieuNhap()) return;

        //     string maDG = dgv_DSDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();
        //    docGiaDTO.maDG = maDG;
        //    docGiaDTO.hoTen = txt_HoTen.Text;
        //    docGiaDTO.ngaySinh = dtpNgaySinh.Value;
        //    docGiaDTO.gioiTinh = rad_Nam.Checked ? "Nam" : "Nữ";
        //    docGiaDTO.diaChi = txt_DiaChi.Text;
        //    docGiaDTO.soDienThoai = txt_SoDienThoai.Text;
        //    docGiaDTO.email = txt_Email.Text;

        //    if (docGiaBUS.updateDocGia(docGiaDTO))
        //    {
        //        MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        loadDG(1);
        //        tuDongLamMoi();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Cập nhật độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void btnKhoiPhuc_Click(object sender, EventArgs e)
        //{
        //    if (dgv_DSDocGia.CurrentRow == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn độc giả để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    string maDG =dgv_DSDocGia.CurrentRow.Cells[0].Value.ToString();
        //    docGiaDTO.maDG = maDG;

        //    if (docGiaBUS.khoiPhucDocGia(docGiaDTO))
        //    {
        //        MessageBox.Show("Khôi phục độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        loadDG(1);
        //        tuDongLamMoi();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Khôi phục độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void btn_TimKiem_Click(object sender, EventArgs e)
        //{
        //    if (rad_TimTheoHoTen.Checked)
        //    {
        //        if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
        //        {
        //            MessageBox.Show("Vui lòng nhập họ tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            string hoTen = txt_TimKiem.Text; 
        //            docGiaDTO.hoTen = hoTen;
        //            DataTable result = docGiaBUS.timKiemTheoHoTen(docGiaDTO); 
        //            if (result != null && result.Rows.Count > 0)
        //            {
        //                dgv_DSDocGia.DataSource = result;
        //                txt_TimKiem.Clear();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    else if (rad_TimTheoSDT.Checked)
        //    {

        //        if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
        //        {
        //            MessageBox.Show("Vui lòng nhập số điện thoại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            string soDienThoai = txt_TimKiem.Text;
        //            docGiaDTO.soDienThoai = soDienThoai;
        //            DataTable result = docGiaBUS.timKiemTheoSoDienThoai(docGiaDTO);
        //            if (result != null && result.Rows.Count > 0)
        //            {
        //                dgv_DSDocGia.DataSource = result;
        //                txt_TimKiem.Clear();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Không tìm thấy độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
   

        
      

       

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            
        }

      

        
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
           
            loadDG(1);
       
        }

      

        private void loadDG(int trangThai)
        {
            dgv_DSDocGia.DataSource = null;
            docGiaDTO.TrangThai = trangThai;
            DataTable dt = docGiaBUS.getDocGia(docGiaDTO);
            dgv_DSDocGia.DataSource = dt;
            dgv_DSDocGia.ClearSelection();
        }

       
       
        private void dgv_DSDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSDocGia.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    string trangThai = e.Value.ToString();
                    if (trangThai == "1")
                    {
                        e.Value = "Hoạt động";
                        e.FormattingApplied = true;
                    }
                    else if (trangThai == "0")
                    {
                        e.Value = "Ngưng hoạt động";
                        e.FormattingApplied = true;
                    }
                }
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

        
    }
}
