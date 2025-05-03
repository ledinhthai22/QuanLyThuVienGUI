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
        private void btn_PhieuPhat_Click(object sender, EventArgs e)
        {

            pn_Thongtin.Controls.Clear();
            ucPhieuPhat ucPhieuPhat = new ucPhieuPhat(this, manv);
            ucPhieuPhat.Dock = DockStyle.Fill;
            pn_Thongtin.Controls.Add(ucPhieuPhat);
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
        private List<PhieuMuonDTO> loadDSPMDangMuon()
        {
            try
            {
                List<PhieuMuonDTO> dsPhieuMuon = phieuMuonBUS.loadDSPMDangMuon();

                if (dsPhieuMuon == null || dsPhieuMuon.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachPhieuMuon = dsPhieuMuon;
                    dgv_LoadDuLieu.DataSource = null;
                    dgv_LoadDuLieu.DataSource = danhSachPhieuMuon;
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();

                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachPhieuMuon;
        }
        private List<PhieuMuonDTO> loadDSPMDaTra()
        {
            try
            {
                List<PhieuMuonDTO> dsPhieuMuon = phieuMuonBUS.loadDSPMDaTra();

                if (dsPhieuMuon == null || dsPhieuMuon.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachPhieuMuon = dsPhieuMuon;
                    dgv_LoadDuLieu.DataSource = null;
                    dgv_LoadDuLieu.DataSource = danhSachPhieuMuon;
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();

                    }));

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
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();
                        
                    }));
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
            loadDSPMDangMuon(); 
        }
       
        private void cbo_LocTheoDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();

            if (luaChon == "DS Phiếu mượn đang mượn")
            {
                taoCotDgvPhieuMuon();
                loadDSPMDangMuon();
            }
            else if(luaChon == "DS Phiếu mượn đã Trả")
            {
                taoCotDgvPhieuMuon();
                loadDSPMDaTra();
            }
            else if (luaChon == "DS phiếu phạt ")
            {
                taoCotDgvPhieuPhat();
                loadDSPP();
            }
        }

        private void dgv_LoadDuLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();
            if (luaChon == "DS Phiếu mượn đang mượn")
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
                      
                    }
                }
                
            }
            if( luaChon == "DS Phiếu mượn đã Trả")
            {
                if (dgv_LoadDuLieu.Columns[e.ColumnIndex].Name == "TrangThai")
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
            }
            if (luaChon == "DS phiếu phạt ")
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();
            if (luaChon == "DS Phiếu mượn đang mượn")
            {
                string keyword = txt_TimKiem.Text.Trim();
                List<PhieuMuonDTO> dsPhieuMuon = danhSachPhieuMuon.Where(pm => pm.maPhieuMuon.Contains(keyword)
                                                                            || pm.maNhanVien.Contains(keyword)
                                                                            || pm.hoTenDocGia.Contains(keyword)).ToList();
                if (dsPhieuMuon.Count > 0)
                {
                    dgv_LoadDuLieu.DataSource = dsPhieuMuon;
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();

                    }));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn nào với mã: " + keyword);
                    loadDSPMDangMuon();
                }
            }
            else if (luaChon == "DS phiếu phạt ")
            {
                string keyword = txt_TimKiem.Text.Trim();
                List<PhieuPhatDTO> dsPhieuPhat = phieuPhatBUS.loadDSPPAll().Where(pp => pp.maPhieuPhat.Contains(keyword)
                                                                                     || pp.hoTenDocGia.Contains(keyword)
                                                                                     ).ToList();
                if (dsPhieuPhat.Count > 0)
                {
                    dgv_LoadDuLieu.DataSource = dsPhieuPhat;
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();

                    }));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu phạt nào với mã: " + keyword);
                    loadDSPP();
                }
            }
            else if (luaChon == "DS Phiếu mượn đã Trả")
            {
                string keyword = txt_TimKiem.Text.Trim();
                List<PhieuMuonDTO> dsPhieuMuon = danhSachPhieuMuon.Where(pm => pm.maPhieuMuon.Contains(keyword)
                                                                            || pm.maNhanVien.Contains(keyword)
                                                                            || pm.hoTenDocGia.Contains(keyword)).ToList();
                if (dsPhieuMuon.Count > 0)
                {
                    dgv_LoadDuLieu.DataSource = dsPhieuMuon;
                    this.BeginInvoke(new Action(() =>
                    {
                        dgv_LoadDuLieu.ClearSelection();
                    }));
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn nào với mã: " + keyword);
                    loadDSPMDaTra();
                }
            }    
                txt_TimKiem.Clear();
        }

        private void txt_LamMoi_Click(object sender, EventArgs e)
        {
            string luaChon = cbo_LocTheoDanhSach.SelectedItem.ToString();
            if (luaChon == "DS Phiếu mượn đang mượn")
            {
                txt_TimKiem.Clear();
                loadDSPMDangMuon();
                this.BeginInvoke(new Action(() =>
                {
                    dgv_LoadDuLieu.ClearSelection();

                }));
            }
            else if (luaChon == "DS Phiếu mượn đã Trả")
            {
                txt_TimKiem.Clear();
                taoCotDgvPhieuMuon();
                loadDSPMDaTra();
            }
            else if (luaChon == "DS phiếu phạt ")
            {
                txt_TimKiem.Clear();
                taoCotDgvPhieuPhat();
                loadDSPP();
            }
        }

        
    }
}

