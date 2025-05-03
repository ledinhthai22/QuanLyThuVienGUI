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

namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyMuonTra : Form
    {
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
        PhieuPhatBUS phieuPhatBUS = new PhieuPhatBUS();
        List<PhieuMuonDTO> danhSachPhieuMuon = new List<PhieuMuonDTO>();
        public string manv;
  
        public frmQuanLyMuonTra(string maNV)
        {
            this.manv = maNV;
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgv_LoadDuLieu, new object[] { true });

        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {
          
            pn_Thongtin.Controls.Clear();
            ucMuonSach ucMuonTra = new ucMuonSach(this,manv);
            ucMuonTra.Dock = DockStyle.Fill;
            pn_Thongtin.Controls.Add(ucMuonTra);
        }

        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            pn_Thongtin.Controls.Clear();
            ucTraSach ucTra = new ucTraSach(this,manv);
            ucTra.Dock = DockStyle.Fill;
            pn_Thongtin.Controls.Add(ucTra);
        }

        public void ShowDefaultView()
        {
            pn_Thongtin.Controls.Clear(); 
            frmQuanLyMuonTra frmMuonTra = new frmQuanLyMuonTra(manv); 
            frmMuonTra.TopLevel = false;
            frmMuonTra.FormBorderStyle = FormBorderStyle.None; 
            frmMuonTra.Dock = DockStyle.Fill; 
            pn_Thongtin.Controls.Add(frmMuonTra);
            frmMuonTra.Show(); 
        }
        private List<PhieuMuonDTO> loadDSPM()
        {
            try
            {
                List<PhieuMuonDTO> dsPhieuMuon = phieuMuonBUS.loadDSPM();

                if (dsPhieuMuon == null || dsPhieuMuon.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachPhieuMuon = dsPhieuMuon;
                    dgv_LoadDuLieu.DataSource = null;
                    dgv_LoadDuLieu.DataSource = danhSachPhieuMuon;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachPhieuMuon;
        }
        private void loadDSPP()
        {
            try
            {
                List<PhieuPhatDTO> danhSachPhieuPhat = phieuPhatBUS.loadDSPPAll(); // Gọi từ BUS
                if (danhSachPhieuPhat == null || danhSachPhieuPhat.Count == 0)
                {
                    MessageBox.Show("Không có phiếu phạt để hiển thị.");
                }
                else
                {
                    dgv_LoadDuLieu.DataSource = null;
                    dgv_LoadDuLieu.DataSource = danhSachPhieuPhat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phiếu phạt: " + ex.Message);
            }
        }
        private void taoCotDgvPhieuMuon()
        {
            dgv_LoadDuLieu.Columns.Clear();
            dgv_LoadDuLieu.AutoGenerateColumns = false;

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuMuon",
                DataPropertyName = "MaPhieuMuon",
                HeaderText = "Mã phiếu mượn"
            });

            //dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "MaNhanVien",
            //    DataPropertyName = "MaNhanVien",
            //    HeaderText = "Mã nhân viên"
            //});
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaDocGia",
                DataPropertyName = "MaDocGia",
                HeaderText = "Mã độc giả"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTenDocGia",
                DataPropertyName = "HoTenDocGia",
                HeaderText = "Họ tên độc giả"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayLap",
                DataPropertyName = "NgayLap",
                HeaderText = "Ngày Lập"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayTra",
                DataPropertyName = "NgayTra",
                HeaderText = "Ngày trả"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuongSach",
                DataPropertyName = "SoLuongSach",
                HeaderText = "Số lượng sách"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng thái"
            });
        }
        private void taoCotDgvPhieuPhat()
        {
            dgv_LoadDuLieu.Columns.Clear();
            dgv_LoadDuLieu.AutoGenerateColumns = false;

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuPhat",
                DataPropertyName = "MaPhieuPhat",
                HeaderText = "Mã phiếu phạt"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuMuon",
                DataPropertyName = "maPhieuMuon",
                HeaderText = "Mã phiếu mượn"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaCTPhieuMuon",
                DataPropertyName = "maCTPhieuMuon",
                HeaderText = "Mã chi tiết phiếu mượn"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "hoTenDocGia",
                DataPropertyName = "hoTenDocGia",
                HeaderText = "Họ Tên"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoTien",
                DataPropertyName = "SoTien",
                HeaderText = "Số Tiền"
            });
            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LyDoPhat",
                DataPropertyName = "LyDoPhat",
                HeaderText = "Lý do phạt"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayThanhToan",
                DataPropertyName = "NgayThanhToan",
                HeaderText = "Ngày thanh toán"
            });

            dgv_LoadDuLieu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng thái"
            });
        }
        private void loadCbo()
        {
            cbo_LocTheoDanhSach.SelectedIndex = 0;
        }
        private void frmQuanLyMuonTra_Load(object sender, EventArgs e)
        {
            loadCbo();
            taoCotDgvPhieuMuon();
            loadDSPM(); 
        }
       
        private void cbo_LocTheoDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();

            if (luaChon == "Danh sách phiếu mượn")
            {
                taoCotDgvPhieuMuon();
                loadDSPM();
            }
            else if (luaChon == "Danh sách phiếu phạt")
            {
                taoCotDgvPhieuPhat();
                loadDSPP();
            }
        }

        private void dgv_LoadDuLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();
            if (luaChon == "Danh sách phiếu mượn")
            {
                if (dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "TrangThai")
                {
                    if (e.Value != null)
                    {
                        int trangThai = Convert.ToInt32(e.Value);
                        if (trangThai == 1)
                        {
                            e.Value = "Đang mượn";
                        }
                        else
                        {
                            e.Value = "Đã trả";
                        }
                    }
                }
                
            }
            if (luaChon == "Danh sách phiếu phạt")
            {
                if (dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "TrangThai")
                {
                    if (e.Value != null)
                    {
                        int trangThai = Convert.ToInt32(e.Value);
                        if (trangThai == 1)
                        {
                            e.Value = "Chưa thanh toán";
                        }
                        else
                        {
                            e.Value = "Đã thanh toán";
                        }
                    }
                }
                if (dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "SoTien" && e.Value != null)
                {
                    try
                    {
                        decimal soTien = Convert.ToDecimal(e.Value);
                        e.Value = soTien.ToString("N0") + " đ"; // Ví dụ: 10,000 đ
                        e.FormattingApplied = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            if (dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "NgayLap" || dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "NgayTra")
            {
                if (e.Value != null)
                {
                    DateTime dateValue = Convert.ToDateTime(e.Value);
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                }
            }
        }

        private void dgv_LoadDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

