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
    public partial class ucCapNhatPhieuMuon : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        SachBUS sachBUS = new SachBUS();
        List<DocGiaDTO> danhSachDocGia = new List<DocGiaDTO>();
        List<SachDTO> danhSachSach = new List<SachDTO>();
        List<SachDTO> danhSachSachMuon = new List<SachDTO>();
        List<CTPhieuMuonDTO> danhSachCTPhieuMuon = new List<CTPhieuMuonDTO>();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        CTPhieuMuonBUS ctPhieuMuonBUS = new CTPhieuMuonBUS(); // Thêm đối tượng CTPhieuMuon BUS
        private string maNV;
        PhieuMuonDTO selectedPM ;
        public ucCapNhatPhieuMuon(admin.frmQuanLyMuonTra parent, string maNV,PhieuMuonDTO phieuMuonDTO)
        {
            InitializeComponent();
            this.selectedPM = phieuMuonDTO;
            this.parentForm = parent;
            this.maNV = maNV;
            txt_MaPhieuMuon.Text = selectedPM.maPhieuMuon;
            txt_maDocGia.Text = selectedPM.maDocGia;
            txt_HoTen.Text = selectedPM.hoTenDocGia;
            dtp_NgayMuon.Value = selectedPM.ngayLap;
            dtp_NgayTra.Value = selectedPM.ngayTra;
            txt_SoLuongSach.Text = selectedPM.soLuongSach.ToString();



        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
           parentForm.ShowDefaultView();
        }

     
        private void dgv_DSS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (danhSachSachMuon.Count >= 3)
            {
                MessageBox.Show("Mỗi phiếu mượn chỉ được mượn tối đa 3 cuốn sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_DSS.CurrentRow != null)
            {
                string maSach = dgv_DSS.CurrentRow.Cells["MaSach"].Value.ToString();

                SachDTO sachDuocChon = danhSachSach.FirstOrDefault(s => s.maSach == maSach);
                if (sachDuocChon != null)
                {

                    int soLuongDaChon = danhSachSachMuon.Count(s => s.maSach == maSach);

                    if (soLuongDaChon >= sachDuocChon.soLuong)
                    {
                        MessageBox.Show($"Sách \"{sachDuocChon.tenSach}\" chỉ còn {sachDuocChon.soLuong} cuốn, bạn đã chọn đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sachDuocChon.trangThai.ToString().Trim().ToLower() != "có sẵn" && sachDuocChon.trangThai.ToString().Trim().ToLower() != "1")
                    {
                        MessageBox.Show("Sách này không có sẵn để mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sachDuocChon.soLuong <= 0)
                    {
                        MessageBox.Show("Sách này đã hết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    danhSachSachMuon.Add(sachDuocChon);

                    dgv_DSSachMuon.DataSource = null;
                    dgv_DSSachMuon.DataSource = danhSachSachMuon;
                    txt_SoLuongSach.Text = danhSachSachMuon.Count.ToString();
                }
            }

            dgv_DSSachMuon.ClearSelection();
            dgv_DSS.ClearSelection();

        }

        private List<SachDTO> loadDSSachMuon()
        {
            try
            {
                List<SachDTO> dsSach = sachBUS.loadSachMuon();

                if (dsSach == null || dsSach.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachSach = dsSach;
                    dgv_DSS.DataSource = null;
                    dgv_DSS.DataSource = danhSachSach;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachSach;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSSachMuon.CurrentRow != null)
            {
                string maSach = dgv_DSSachMuon.CurrentRow.Cells["maSach"].Value.ToString();


                SachDTO sachCanXoa = danhSachSachMuon.FirstOrDefault(s => s.maSach == maSach);
                if (sachCanXoa != null)
                {
                    danhSachSachMuon.Remove(sachCanXoa);


                    dgv_DSSachMuon.DataSource = null;
                    dgv_DSSachMuon.DataSource = danhSachSachMuon;


                    txt_SoLuongSach.Text = danhSachSachMuon.Count.ToString();
                }
            }
            dgv_DSSachMuon.ClearSelection();
            dgv_DSS.ClearSelection();
        }
       
        private void taoCotDgvSach()
        {
            dgv_DSS.Columns.Clear();
            dgv_DSS.AutoGenerateColumns = false;

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                DataPropertyName = "MaSach",
                HeaderText = "Mã sách"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TacGia",
                DataPropertyName = "TacGia",
                HeaderText = "Tác giả"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                DataPropertyName = "TenTheLoai",
                HeaderText = "Thể loại"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NamXuatBan",
                DataPropertyName = "NamXuatBan",
                HeaderText = "Năm xuất bản",
                Visible = false
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NhaXuatBan",
                DataPropertyName = "NhaXuatBan",
                HeaderText = "Nhà xuất bản",
                Visible = false
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NhaCungCap",
                DataPropertyName = "NhaCungCap",
                HeaderText = "Nhà cung cấp",
                Visible = false
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                DataPropertyName = "MoTa",
                HeaderText = "Mô tả"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số lượng"
            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng Thái"

            });

            dgv_DSS.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaTheLoai",
                DataPropertyName = "MaTheLoai",
                HeaderText = "Mã Thể Loại",
                Visible = false
            });
        }
        private void taoCotDgvDSSachMuon()
        {
            dgv_DSSachMuon.Columns.Clear();
            dgv_DSSachMuon.AutoGenerateColumns = false;

            dgv_DSSachMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                DataPropertyName = "MaSach",
                HeaderText = "Mã sách"
            });

            dgv_DSSachMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });

            dgv_DSSachMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TacGia",
                DataPropertyName = "TacGia",
                HeaderText = "Tác giả"
            });

            dgv_DSSachMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                DataPropertyName = "TenTheLoai",
                HeaderText = "Thể loại"
            });

        }
        private void ucCapNhatPhieuMuon_Load(object sender, EventArgs e)
        {
           
            taoCotDgvSach();
          
            dgv_DSS.ClearSelection();
            taoCotDgvDSSachMuon();
            loadDSSachMuon();
            
            this.BeginInvoke(new Action(() =>
            {
              

                dgv_DSS.ClearSelection();
                dgv_DSS.CurrentCell = null;

                dgv_DSSachMuon.ClearSelection();
                dgv_DSSachMuon.CurrentCell = null;
            }));
            dtp_NgayMuon.MinDate = DateTime.Today;
            dtp_NgayTra.MinDate = DateTime.Today.AddDays(1);
            dtp_NgayTra.MaxDate = DateTime.Today.AddDays(14);
        }
    }
}
