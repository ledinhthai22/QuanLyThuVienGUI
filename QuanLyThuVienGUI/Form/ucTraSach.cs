using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI
{
    public partial class ucTraSach : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        SachBUS sachBUS = new SachBUS();
        List<DocGiaDTO> danhSachDocGia = new List<DocGiaDTO>();
        List<SachDTO> danhSachSach = new List<SachDTO>();
        List<PhieuMuonDTO> danhSachPhieuMuon = new List<PhieuMuonDTO>();
        List<CTPhieuMuonDTO> danhSachCTPhieuMuon = new List<CTPhieuMuonDTO>();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        CTPhieuMuonBUS ctPhieuMuonBUS = new CTPhieuMuonBUS(); // Thêm đối tượng CTPhieuMuon BUS
        private string maNV;
        public ucTraSach(admin.frmQuanLyMuonTra parent, string maNV)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.maNV = maNV;
            
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            parentForm.ShowDefaultView();
        }
        private List<PhieuMuonDTO> loadDSPhieuMuonvaCTPhieuMuon()
        {
            try
            {
                List<PhieuMuonDTO> dsPhieuMuon = phieuMuonBUS.loadDanhSachPhieuMuonVaCTPhieuMuon();

                if (dsPhieuMuon == null || dsPhieuMuon.Count == 0)
                {
                    MessageBox.Show("Không có sách để hiển thị.");
                }
                else
                {
                    danhSachPhieuMuon = dsPhieuMuon;
                    dgv_PhieuMuon.DataSource = null;
                    dgv_PhieuMuon.DataSource = danhSachPhieuMuon;

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
            dgv_PhieuMuon.Columns.Clear();
            dgv_PhieuMuon.AutoGenerateColumns = false;

            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuMuon",
                DataPropertyName = "MaPhieuMuon",
                HeaderText = "Mã phiếu mượn"
            });

            //dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "MaNhanVien",
            //    DataPropertyName = "MaNhanVien",
            //    HeaderText = "Mã nhân viên"
            //});
            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaDocGia",
                DataPropertyName = "MaDocGia",
                HeaderText = "Mã độc giả"
            });
            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTenDocGia",
                DataPropertyName = "HoTenDocGia",
                HeaderText = "Họ tên độc giả"
            });
            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayLap",
                DataPropertyName = "NgayLap",
                HeaderText = "Ngày Lập"
            });

            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayTra",
                DataPropertyName = "NgayTra",
                HeaderText = "Ngày trả"
            });
            //dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "NgayThucTe",
            //    DataPropertyName = "NgayThucTe",
            //    HeaderText = "Ngày trả thực tế"
            //});

            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuongSach",
                DataPropertyName = "SoLuongSach",
                HeaderText = "Số lượng sách"
            });

            dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TrangThai",
                DataPropertyName = "TrangThai",
                HeaderText = "Trạng thái"
            });
        }
        private List<CTPhieuMuonDTO> loadCTPhieuMuon()
        {
            try
            {
                List<CTPhieuMuonDTO> dsCTPhieuMuon = ctPhieuMuonBUS.GetDanhSachDangMuonTheoMaDocGia(txt_maDocGia.Text);

                if (dsCTPhieuMuon == null || dsCTPhieuMuon.Count == 0)
                {
                    
                }
                else
                {
                    danhSachCTPhieuMuon = dsCTPhieuMuon;
                    dgv_CTphieuMuon.DataSource = null;
                    dgv_CTphieuMuon.DataSource = danhSachCTPhieuMuon;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách sách: " + ex.Message);
            }
            return danhSachCTPhieuMuon;
        }
        private void taoCotDgvCTPhieuMuon()
        {
            dgv_CTphieuMuon.Columns.Clear();
            dgv_CTphieuMuon.AutoGenerateColumns = false;

            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaCTPhieuMuon",
                DataPropertyName = "MaCTPhieuMuon",
                HeaderText = "Mã chi tiết phiếu mượn"
            });
            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaPhieuMuon",
                DataPropertyName = "MaPhieuMuon",
                HeaderText = "Mã phiếu mượn"
            });

            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                DataPropertyName = "MaSach",
                HeaderText = "Mã sách",
                Visible = false
            });
           
            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });
            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayMuon",
                DataPropertyName = "NgayMuon",
                HeaderText = "Ngày Lập"
            });

            dgv_CTphieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayTra",
                DataPropertyName = "NgayTra",
                HeaderText = "Ngày trả"
            });
            //dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "",
            //    DataPropertyName = "SoLuongSach",
            //    HeaderText = "Số lượng sách"
            //});

            //dgv_PhieuMuon.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "TrangThai",
            //    DataPropertyName = "TrangThai",
            //    HeaderText = "Trạng thái"
            //});
        }
        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            if (dgv_PhieuMuon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn để trả.");
                return;
            }

            DataGridViewRow selectedRow = dgv_PhieuMuon.SelectedRows[0];
            string maPhieuMuon = selectedRow.Cells["MaPhieuMuon"].Value?.ToString();

            if (string.IsNullOrEmpty(maPhieuMuon))
            {
                MessageBox.Show("Không tìm thấy mã phiếu mượn.");
                return;
            }

            DateTime ngayThucTe = dtp_ngayThucTeTra.Value.Date;

            getDuLieu(phieuMuonDTO);
            bool trasachthanhcong = phieuMuonBUS.traSach(phieuMuonDTO);

            
            if (trasachthanhcong)
            {
                List<string> maSachList = ctPhieuMuonBUS.LayDanhSachMaSachDaMuon(maPhieuMuon);

                if (maSachList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách đã mượn trong phiếu này.");
                    return;
                }

                
                bool Trasach = true;
                foreach (string maSach in maSachList)
                {
                    bool traSachTC = sachBUS.updateSachSauKhiTra(maSach);
                    if (!traSachTC)
                    {
                        Trasach = false;
                    }
                }

                if (Trasach)
                {
                    MessageBox.Show("Trả sách thành công.");
                    restForm();
                    if (DateTime.Now < dtp_ngayThucTeTra.MinDate || DateTime.Now > dtp_ngayThucTeTra.MaxDate)
                    {
                        dtp_ngayThucTeTra.Value = dtp_ngayThucTeTra.MinDate;
                    }
                    else
                    {
                        dtp_ngayThucTeTra.Value = DateTime.Now;
                    }

                    txt_GhiChu.Text = "";
                    dgv_PhieuMuon.ClearSelection();


                }
                else
                {
                    MessageBox.Show("Có lỗi khi trả sách. Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Không thể cập nhật trạng thái phiếu mượn. Vui lòng kiểm tra lại.");
            }
        }


        private void ucTraSach_Load(object sender, EventArgs e)
        {
            taoCotDgvPhieuMuon();
            loadDSPhieuMuonvaCTPhieuMuon();
            taoCotDgvCTPhieuMuon();
            
        }
        private void TinhSoNgayTre()
        {
            try
            {
                
                DateTime ngayTra = dtp_NgayTra.Value.Date;
                DateTime ngayThucTe = dtp_ngayThucTeTra.Value.Date;

                int soNgayTre = (ngayThucTe - ngayTra).Days;

                if (soNgayTre <= 0)
                {
                    txt_SoNgayTre.Text = "0";
                }
                else
                {
                    txt_GhiChu.Text = soNgayTre.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính ngày trễ: " + ex.Message);
            }
        }




        private void dgv_PhieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_PhieuMuon.Columns[e.ColumnIndex].Name == "TrangThai")
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
            if (dgv_PhieuMuon.Columns[e.ColumnIndex].Name == "NgayLap" || dgv_PhieuMuon.Columns[e.ColumnIndex].Name == "NgayTra")
            {
                if (e.Value != null)
                {
                    DateTime dateValue = Convert.ToDateTime(e.Value);
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                }
            }
        }

        private void dgv_CTphieuMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_CTphieuMuon.Columns[e.ColumnIndex].Name == "NgayLap" || dgv_CTphieuMuon.Columns[e.ColumnIndex].Name == "NgayTra")
            {
                if (e.Value != null)
                {
                    DateTime dateValue = Convert.ToDateTime(e.Value);
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                }
            }
        }
        private void restForm()
        {
            dgv_CTphieuMuon.DataSource = null;
            dgv_CTphieuMuon.DataSource = null;
            loadDSPhieuMuonvaCTPhieuMuon();
            loadCTPhieuMuon();
            txt_HoTen.Text = "";
            txt_maDocGia.Text = "";
            txt_SoLuongSach.Text = "";
            dtp_NgayMuon.Value = DateTime.Now;
            dtp_NgayTra.Value = DateTime.Now;
        }
        private void getDuLieu(PhieuMuonDTO phieuMuonDTO)
        {
            phieuMuonDTO.maPhieuMuon = dgv_PhieuMuon.CurrentRow.Cells["MaPhieuMuon"].Value.ToString();
            phieuMuonDTO.maDocGia = txt_maDocGia.Text;
            phieuMuonDTO.hoTenDocGia = txt_HoTen.Text;
            phieuMuonDTO.ngayLap = dtp_NgayMuon.Value;
            phieuMuonDTO.ngayTra = dtp_NgayTra.Value;
            phieuMuonDTO.ngayTraThucTe = dtp_ngayThucTeTra.Value;
            phieuMuonDTO.soLuongSach = Convert.ToInt32(txt_SoLuongSach.Text);
            phieuMuonDTO.ghiChu = txt_GhiChu.Text;
            phieuMuonDTO.trangThai = 1; // Trạng thái đang mượn
        }
        private void dgv_PhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_PhieuMuon.Rows[e.RowIndex];

                txt_maDocGia.Text = row.Cells["MaDocGia"].Value?.ToString();
                txt_HoTen.Text = row.Cells["HoTenDocGia"].Value?.ToString();
                dtp_NgayMuon.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
                dtp_NgayTra.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                txt_SoLuongSach.Text = row.Cells["Soluongsach"].Value?.ToString();

                // Gọi hàm load chi tiết sách đang mượn
                loadCTPhieuMuon();
                // Tính số ngày trễ
              
                TinhSoNgayTre();
            }
        }

        private void btn_TimKiemSach_Click(object sender, EventArgs e)
        {
            
           
                string keyword = txt_TKPhieuMuon.Text.Trim();
                List<PhieuMuonDTO> dsPhieuMuon = danhSachPhieuMuon.Where(pm => pm.maPhieuMuon.Contains(keyword)
                                                                            || pm.maDocGia.Contains(keyword)
                                                                            || pm.hoTenDocGia.Contains(keyword)).ToList();
                if (dsPhieuMuon.Count > 0)
                {
                    dgv_PhieuMuon.DataSource = dsPhieuMuon;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn nào với mã: " + keyword);
                    loadCTPhieuMuon();
                }
                txt_TKPhieuMuon.Clear();
        }
    }
}
