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

namespace QuanLyThuVienGUI
{
    public partial class ucPhieuPhat : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        private string maNV;
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
        PhieuPhatBUS phieuPhatBUS = new PhieuPhatBUS();
        List<PhieuMuonDTO> danhSachPhieuMuon = new List<PhieuMuonDTO>();
        List<PhieuPhatDTO> danhSachPhieuPhat;
        public ucPhieuPhat(admin.frmQuanLyMuonTra parent, string maNV)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.maNV = maNV;
            //txt_MaPhieuMuon = phieuPhatDTO.maPhieuPhat;
        }
        private List<PhieuMuonDTO> loadDSPM()
        {
            try
            {
                List<PhieuMuonDTO> dsPhieuMuon = phieuMuonBUS.loadDSPMDaTraDeThanhToan();

                if (dsPhieuMuon == null || dsPhieuMuon.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachPhieuMuon = dsPhieuMuon;
                    dgv_DSPhieuMuon.DataSource = null;
                    dgv_DSPhieuMuon.DataSource = danhSachPhieuMuon;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachPhieuMuon;
        }
       
        private void taoCotDgvPhieuMuon()
        {
            dgv_DSPhieuMuon.Columns.Clear();
            dgv_DSPhieuMuon.AutoGenerateColumns = false;

            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maPhieuMuon",
                DataPropertyName = "maPhieuMuon",
                HeaderText = "Mã phiếu mượn"
            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maCTPhieuMuon",
                DataPropertyName = "maCTPhieuMuon",
                HeaderText = "Mã chi tiết phiếu mượn",

            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maPhieuPhat",
                DataPropertyName = "maPhieuPhat",
                HeaderText = "phiếu phạt",
        

            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maNhanVien",
                DataPropertyName = "maNhanVien",
                HeaderText = "Mã nhân viên",
               

            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "maDocGia",
                DataPropertyName = "maDocGia",
                HeaderText = "Mã độc giả"
            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "hoTenDocGia",
                DataPropertyName = "hoTenDocGia",
                HeaderText = "Họ tên độc giả"
            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ngayLap",
                DataPropertyName = "ngayLap",
                HeaderText = "Ngày Lập"
            });

            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ngayTra",
                DataPropertyName = "ngayTra",
                HeaderText = "Ngày trả"
            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ngayTraThucTe",
                DataPropertyName = "ngayTraThucTe",
                HeaderText = "Ngày trả thực tế"
            });
            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ghiChu",
                DataPropertyName = "ghiChu",
                HeaderText = "GhiChu"
            });

            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "soLuongSach",
                DataPropertyName = "soLuongSach",
                HeaderText = "số lượng sách"
            });

            dgv_DSPhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "trangThai",
                DataPropertyName = "trangThai",
                HeaderText = "Trạng thái"
            });
        }

        private void ucPhieuPhat_Load(object sender, EventArgs e)
        {
            taoCotDgvPhieuMuon();
            loadDSPM();
            
        }


        private void txt_Thoat_Click(object sender, EventArgs e)
        {
            parentForm.ShowDefaultView();
        }
        private void tinhNgayTre()
        {
            DateTime ngayTra = dtp_NgayTra.Value;
            DateTime ngayHienTai = dtp_ngayThucTeTra.Value; 

            int soNgayTre = (ngayHienTai - ngayTra).Days;

            if (soNgayTre > 0)
            {
                txt_SoNgayTre.Text = soNgayTre.ToString(); 
            }
            else
            {
                txt_SoNgayTre.Text = "0";
            }
        }
        private void kiemTraLyDoPhat()
        {
            txt_TienHuSach.Text = chk_HuSach.Checked ? "20000" : "0";
            txt_TienMatSach.Text = chk_MatSach.Checked ? "50000" : "0";

        }
        private void tinhSoTienPhat()
        {
            float soNgayTre = float.Parse(txt_SoNgayTre.Text);
            float soTienPhat = 0;
            if (soNgayTre > 0)
            {
                soTienPhat = soNgayTre * 5000; // hoặc giá trị bạn muốn
                txt_TienTreHan.Text = soTienPhat.ToString();
            }
            else
            {
                txt_TienTreHan.Text = "0";
            }
        }
        private void tinhTongTienPhat()
        {
            float huSach = float.Parse(txt_TienHuSach.Text);
            float matSach = float.Parse(txt_TienMatSach.Text);
            float treHan = float.Parse(txt_TienTreHan.Text);
            float tong = huSach + matSach + treHan;

            txt_TongTien.Text = tong.ToString(); // Thêm textbox tổng tiền nếu cần
        }
        private void dgv_DSPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["HoTenDocGia"].Value == null)
                return;

            try
            {
                txt_MaPhieuMuon.Text = dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value.ToString();
                txt_HoTen.Text = dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["HoTenDocGia"].Value.ToString();
                txt_maDocGia.Text = dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["MaDocGia"].Value.ToString();
                dtp_NgayMuon.Value = DateTime.Parse(dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["NgayLap"].Value.ToString());
                dtp_NgayTra.Value = DateTime.Parse(dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["NgayTra"].Value.ToString());

                string ghiChu = dgv_DSPhieuMuon.Rows[e.RowIndex].Cells["ghiChu"].Value?.ToString() ?? "";
                ghiChu = ghiChu.ToLower();
                chk_HuSach.Checked = ghiChu.Contains("hư sách");
                chk_MatSach.Checked = ghiChu.Contains("mất sách");

                tinhNgayTre();
                kiemTraLyDoPhat();
                tinhSoTienPhat();
                tinhTongTienPhat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý dòng được chọn: " + ex.Message);
            }
        }

        private void dgv_DSPhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSPhieuMuon.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = Convert.ToInt32(e.Value);
                    if (trangThai == 0)
                    {
                        e.Value = "Đã trả";
                    }
                }
            }
            if (dgv_DSPhieuMuon.Columns[e.ColumnIndex].Name == "NgayLap" || dgv_DSPhieuMuon.Columns[e.ColumnIndex].Name == "NgayTra")
            {
                if (e.Value != null)
                {
                    DateTime dateValue = Convert.ToDateTime(e.Value);
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                }
            }



        }

        private void chk_MatSach_CheckedChanged(object sender, EventArgs e)
        {
            kiemTraLyDoPhat();
        }

        private void chk_HuSach_CheckedChanged(object sender, EventArgs e)
        {
            kiemTraLyDoPhat();
        }
        private void getDuLieu()
        {
            phieuPhatDTO.maDocGia = txt_maDocGia.Text;
            phieuPhatDTO.hoTenDocGia = txt_HoTen.Text;
            phieuPhatDTO.maPhieuMuon= txt_MaPhieuMuon.Text;
            List<string> lyDoList = new List<string>();
            if (chk_MatSach.Checked) lyDoList.Add("Mất sách");
            if (chk_HuSach.Checked) lyDoList.Add("Hư sách");

            phieuPhatDTO.lyDoPhat = string.Join(", ", lyDoList);
            phieuPhatDTO.maPhieuPhat = dgv_DSPhieuMuon.CurrentRow.Cells["MaPhieuPhat"].Value.ToString();
            phieuPhatDTO.lyDoPhat = phieuPhatDTO.lyDoPhat.Trim();
            phieuPhatDTO.soTien = int.Parse(txt_TongTien.Text);
            phieuPhatDTO.ngayThanhToan = dtp_ngayThucTeTra.Value;
            phieuPhatDTO.maCTPhieuMuon = dgv_DSPhieuMuon.CurrentRow.Cells["MaCTPhieuMuon"].Value.ToString();
        }

        private void btn_TaoPhieuPhat_Click(object sender, EventArgs e)
        {
            if (dgv_DSPhieuMuon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn để tạo phiếu phạt.");
                return;
            }
            if (string.IsNullOrEmpty(txt_maDocGia.Text) || string.IsNullOrEmpty(txt_HoTen.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả để tạo phiếu phạt.");
                return;
            }
            getDuLieu();
            
            if (phieuPhatBUS.UpdatePhieuPhat(phieuPhatDTO))
            {
                MessageBox.Show("Tạo phiếu phạt thành công");
                loadDSPM();
            }
            else
            {
                MessageBox.Show("Tạo phiếu phạt thất bại");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
       
            try
            {
                string keyword = txt_TimKiem.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {

                    List<PhieuPhatDTO> danhsachtimkiem = TimKiemPhieuPhat(keyword);


                    if (danhsachtimkiem.Any())
                    {

                        dgv_DSPhieuMuon.DataSource = null;
                        taoCotDgvPhieuMuon();
                        dgv_DSPhieuMuon.DataSource = danhsachtimkiem;
                       
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả khớp với từ khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDSPM();
                    }
                    txt_TimKiem.Clear();

                    dgv_DSPhieuMuon.ClearSelection();
                }
                else
                {
                    loadDSPM();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                loadDSPM();
            }
        }
        
        public List<PhieuPhatDTO> TimKiemPhieuPhat(string keyword)
        {
            var danhSach = phieuPhatBUS.loadDSPPAll();
            keyword = keyword.ToLower();

            return danhSach.Where(pp =>
                (!string.IsNullOrEmpty(pp.maPhieuPhat) && pp.maPhieuPhat.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(pp.hoTenDocGia) && pp.hoTenDocGia.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(pp.maPhieuMuon) && pp.maPhieuMuon.ToLower().Contains(keyword))
            ).ToList();
        }
    }
}
