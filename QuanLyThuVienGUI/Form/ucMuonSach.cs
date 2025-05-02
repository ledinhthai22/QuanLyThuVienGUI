using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.admin;
using TheArtOfDevHtmlRenderer.Adapters;

namespace QuanLyThuVienGUI
{
    public partial class ucMuonSach : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        SachBUS sachBUS = new SachBUS();
        List<DocGiaDTO> danhSachDocGia = new List<DocGiaDTO>();
        List<SachDTO> danhSachSach = new List<SachDTO>();
        List<SachDTO> danhSachSachMuon = new List<SachDTO>();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        CTPhieuMuonBUS ctPhieuMuonBUS = new CTPhieuMuonBUS(); // Thêm đối tượng CTPhieuMuon BUS
        public string maNV;
        public ucMuonSach(admin.frmQuanLyMuonTra parent, string maNV)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.maNV = maNV;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            parentForm.ShowDefaultView();
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

        private List<DocGiaDTO> loadDSDG()
        {
            try
            {
                List<DocGiaDTO> dsDocgia = docGiaBUS.loadDSDG();

                if (dsDocgia == null || dsDocgia.Count == 0)
                {
                    MessageBox.Show("Không có độc giả để hiển thị.");
                }
                else
                {
                    danhSachDocGia = dsDocgia;
                    dgv_DSDG.DataSource = null;
                    dgv_DSDG.DataSource = danhSachDocGia;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại danh sách độc giả: " + ex.Message);
            }
            return danhSachDocGia;
        }
        private void taoCotDgvDocGia()
        {
            dgv_DSDG.Columns.Clear();
            dgv_DSDG.AutoGenerateColumns = false;

            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaDocGia",
                DataPropertyName = "MaDocGia",
                HeaderText = "Mã độc giả"
            });

            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HoTen",
                DataPropertyName = "HoTen",
                HeaderText = "Họ tên"
            });
            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                DataPropertyName = "NgaySinh",
                HeaderText = "Ngày sinh"
            });
            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GioiTinh",
                DataPropertyName = "GioiTinh",
                HeaderText = "Giới tính"
            });
            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                DataPropertyName = "DiaChi",
                HeaderText = "Địa chỉ"
            });

            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                DataPropertyName = "SoDienThoai",
                HeaderText = "Số điện thoại"
            });

            dgv_DSDG.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email"
            });
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
        private void ucMuonSach_Load(object sender, EventArgs e)
        {
            taoCotDgvDocGia();
            loadDSDG();
            dgv_DSDG.ClearSelection();
            taoCotDgvSach();
            loadDSSachMuon();
            dgv_DSS.ClearSelection();
            taoCotDgvDSSachMuon();
            this.BeginInvoke(new Action(() =>
            {
                dgv_DSDG.ClearSelection();
                dgv_DSDG.CurrentCell = null;

                dgv_DSS.ClearSelection();
                dgv_DSS.CurrentCell = null;

                dgv_DSSachMuon.ClearSelection();
                dgv_DSSachMuon.CurrentCell = null;
            }));
            dtp_NgayMuon.MinDate = DateTime.Today;
            dtp_NgayTra.MinDate = DateTime.Today.AddDays(1); // Ngày trả ít nhất sau ngày mượn 1 ngày
            dtp_NgayTra.MaxDate = DateTime.Today.AddDays(14);
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
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSSachMuon.CurrentRow != null)
            {
                string maSach = dgv_DSSachMuon.CurrentRow.Cells["maSach"].Value.ToString();

                // Tìm sách cần xóa trong danh sách mượn
                SachDTO sachCanXoa = danhSachSachMuon.FirstOrDefault(s => s.maSach == maSach);
                if (sachCanXoa != null)
                {
                    danhSachSachMuon.Remove(sachCanXoa);

                    // Cập nhật lại DataSource
                    dgv_DSSachMuon.DataSource = null;
                    dgv_DSSachMuon.DataSource = danhSachSachMuon;

                    // Cập nhật số lượng sách mượn
                    txt_SoLuongSach.Text = danhSachSachMuon.Count.ToString();
                }
            }
            dgv_DSSachMuon.ClearSelection();
            dgv_DSS.ClearSelection();
        }

        private void dgv_DSDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_DSDG.Rows[e.RowIndex].Cells["MaDocGia"].Value != null)
            {
                DataGridViewRow row = dgv_DSDG.Rows[e.RowIndex];

                txt_maDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();

            }
        }
        private void getDuLieuPhieuMuon()
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(txt_maDocGia.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả trước khi tạo phiếu mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (danhSachSachMuon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sách để mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phieuMuonDTO.maNhanVien = maNV;
            phieuMuonDTO.ngayLap = dtp_NgayMuon.Value;
            phieuMuonDTO.ngayTra = dtp_NgayTra.Value;
            phieuMuonDTO.soLuongSach = danhSachSachMuon.Count;
            phieuMuonDTO.trangThai = 1;
            phieuMuonDTO.hoTenDocGia = txt_HoTen.Text;
            phieuMuonDTO.maDocGia = txt_maDocGia.Text;
        }

        private void btn_TaoPhieuMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachSachMuon.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sách để mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txt_maDocGia.Text))
                {
                    MessageBox.Show("Vui lòng chọn độc giả trước khi tạo phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin phiếu mượn từ giao diện
                getDuLieuPhieuMuon();

                if (string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Lỗi: Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // B1: Tạo phiếu mượn
                string maPhieuMuon = phieuMuonBUS.createPhieuMuon(phieuMuonDTO);

                if (string.IsNullOrEmpty(maPhieuMuon))
                {
                    MessageBox.Show("Có lỗi xảy ra khi tạo phiếu mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // B2: Tạo chi tiết phiếu mượn cho từng sách
                bool allCTInserted = true;
                foreach (var sach in danhSachSachMuon)
                {
                    var ct = new CTPhieuMuonDTO()
                    {
                        maPhieuMuon = maPhieuMuon,
                        maSach = sach.maSach,
                        ngayMuon = DateTime.Now,
                        ngayTra = phieuMuonDTO.ngayTra,
                        ghiChu = ""
                    };

                    bool created = ctPhieuMuonBUS.createCTPhieuMuon(ct);
                    if (!created)
                    {
                        allCTInserted = false;
                        MessageBox.Show("Lỗi khi tạo chi tiết phiếu mượn cho sách: " + sach.tenSach, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                // B3: Trừ số lượng sách
                bool updateSuccess = sachBUS.updateSachSauMuon(danhSachSachMuon.Select(s => s.maSach).ToList());

                if (allCTInserted && updateSuccess)
                {
                    MessageBox.Show("Tạo phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset giao diện
                    txt_maDocGia.Text = "";
                    txt_HoTen.Text = "";
                    txt_SoLuongSach.Text = "0";
                    danhSachSachMuon.Clear();
                    dgv_DSSachMuon.DataSource = null;
                    loadDSSachMuon();
                }
                else
                {
                    MessageBox.Show("Phiếu mượn tạo chưa hoàn tất (chi tiết hoặc cập nhật sách lỗi).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo phiếu mượn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_DSS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_DSS.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    int trangThai = Convert.ToInt32(e.Value);
                    if (trangThai == 1)
                    {
                        e.Value = "Còn sách";
                    }
                    else
                    {
                        e.Value = "hết sách";
                    }
                }
            }
        }
    }
}