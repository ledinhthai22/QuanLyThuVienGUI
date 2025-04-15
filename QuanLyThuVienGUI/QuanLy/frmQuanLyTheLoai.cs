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


namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyTheLoai : Form
    {

        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            taoCotDataGridView();
            LoadData();
        }

        private void LoadData()
        {

            dgv_DanhSachTL.DataSource = null; // Xóa dữ liệu cũ

            DataTable dt = theLoaiBUS.getAllTheLoai(); // Lấy dữ liệu mới từ DB
            dgv_DanhSachTL.DataSource = dt; // Gán lại dữ liệu cho DataGridView

            dgv_DanhSachTL.Refresh(); // Làm mới giao diện hiển thị
        }

        //private void btn_ThemTL_Click(object sender, EventArgs e)
        //{
        //    theLoaiDTO.tenTL = txt_TenTheLoai.Text;
        //    if (!kiemTraDuLieuNhap())
        //    {
        //        return;
        //    }
        //    if (kiemTraTonTai())
        //    {
        //        MessageBox.Show("Thể loại đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    if (theLoaiBUS.addTheLoai(theLoaiDTO))
        //    {
        //        MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadData();
        //        TuDongLamMoi();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Thêm thể loại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //private void btn_XoaTL_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_TenTheLoai.Text))
        //    {
        //        MessageBox.Show("Vui lòng chọn một thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    if (dgv_DanhSachTL.SelectedRows.Count > 0)
        //    {
        //        int selectedIndex = dgv_DanhSachTL.SelectedRows[0].Index;
        //        if (selectedIndex >= 0 && selectedIndex < dgv_DanhSachTL.Rows.Count)
        //        {
        //            string maTheLoai = dgv_DanhSachTL.Rows[selectedIndex].Cells[0].Value.ToString();
        //            theLoaiDTO.maTL = maTheLoai;

        //            if (!kiemTraRangBuoc())
        //            {
        //                if (theLoaiBUS.deleteTheLoai(theLoaiDTO))
        //                {
        //                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    LoadData();
        //                    TuDongLamMoi();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thể loại này đang được sử dụng, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn một thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}





        //private bool kiemTraDuLieuNhap()
        //{
        //    string tenTheLoai = txt_TenTheLoai.Text;

        //    if (string.IsNullOrWhiteSpace(tenTheLoai))
        //    {
        //        MessageBox.Show("Tên thể loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    if (tenTheLoai.Length > 255)
        //    {
        //        MessageBox.Show("Tên thể loại không được quá 255 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    string kytu = @"^[\p{L}\s]+$";
        //    if (!Regex.IsMatch(tenTheLoai, kytu))
        //    {
        //        MessageBox.Show("Tên thể loại chỉ được chứa chữ cái và khoảng trắng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    return true;
        //}
        //private bool kiemTraRangBuoc()
        //{
        //    bool kiemTra = theLoaiBUS.kiemTraRangBuoc(theLoaiDTO);
        //    if (kiemTra)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //private bool kiemTraTonTai()
        //{
        //    bool kiemtra = theLoaiBUS.kiemTraTonTai(theLoaiDTO);
        //    if (kiemtra)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //private void dgv_DanhSachTL_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachTL.Rows.Count)
        //    {
        //        DataGridViewRow row = dgv_DanhSachTL.Rows[e.RowIndex];

        //        if (row.Cells[1].Value != null)
        //        {
        //            txt_TenTheLoai.Text = row.Cells[1].Value.ToString();
        //        }
        //        else
        //        {
        //            txt_TenTheLoai.Text = string.Empty;
        //        }
        //    }
        //}
        //private void txt_TenTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
        //    {
        //        MessageBox.Show("Tên thể loại không thể chứa số hoặc ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        e.Handled = true;
        //    }
        //}


        //private void TuDongLamMoi()
        //{
        //    txt_TenTheLoai.Clear();
        //    dgv_DanhSachTL.ClearSelection();
        //}


        //private void btn_TimKiemTL_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_TimKiemTL.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên thể loại để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string tenTheLoai = txt_TimKiemTL.Text.Trim();
        //    DataTable dt = theLoaiBUS.timKiemTheLoai(tenTheLoai);

        //    if (dt.Rows.Count > 0)
        //    {
        //        dgv_DanhSachTL.DataSource = dt;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tìm thấy thể loại nào phù hợp!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        dgv_DanhSachTL.DataSource = null; // hoặc giữ nguyên danh sách cũ tùy yêu cầu
        //    }
        //}
        private void taoCotDataGridView()
        {
            dgv_DanhSachTL.Columns.Clear();
            dgv_DanhSachTL.AutoGenerateColumns = false;

            dgv_DanhSachTL.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaTheLoai",
                DataPropertyName = "MaTheLoai",
                HeaderText = "Mã thể loại"
            });

            dgv_DanhSachTL.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                DataPropertyName = "TenTheLoai",
                HeaderText = "Tên thể loại"
            });
        }

        //    private void btn_CapNhat_Click(object sender, EventArgs e)
        //    {
        //        txt_TenTheLoai.Clear();
        //        dgv_DanhSachTL.ClearSelection();
        //        txt_TimKiemTL.Clear();
        //        LoadData();
        //    }

        //    private void btn_CapNhat_Click_1(object sender, EventArgs e)
        //    {
        //        if (dgv_DanhSachTL.SelectedRows.Count > 0)
        //        {
        //            txt_TenTheLoai.Text.Trim();
        //            int selectedIndex = dgv_DanhSachTL.SelectedRows[0].Index;
        //            if (selectedIndex >= 0 && selectedIndex < dgv_DanhSachTL.Rows.Count)
        //            {
        //                if (string.IsNullOrWhiteSpace(txt_TenTheLoai.Text))
        //                {
        //                    MessageBox.Show("Tên thể loại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return;
        //                }
        //                theLoaiDTO.maTL = dgv_DanhSachTL.Rows[selectedIndex].Cells[0].Value.ToString();
        //                string tenMoi = txt_TenTheLoai.Text.Trim();
        //                theLoaiDTO.tenTL = tenMoi;

        //                // Kiểm tra xem tên mới đã tồn tại chưa
        //                TheLoaiDTO tempDTO = new TheLoaiDTO { tenTL = tenMoi };
        //                if (theLoaiBUS.kiemTraTonTai(tempDTO))
        //                {
        //                    MessageBox.Show("Thể loại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return;
        //                }

        //                // Cập nhật thể loại
        //                if (theLoaiBUS.updateTheLoai(theLoaiDTO))
        //                {
        //                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    LoadData(); // Load lại DataGridView
        //                    TuDongLamMoi(); // Xóa input sau khi cập nhật
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Cập nhật thể loại thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Vui lòng chọn một thể loại để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //}
    }
}