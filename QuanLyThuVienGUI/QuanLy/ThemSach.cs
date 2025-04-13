using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class ThemSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        SachDTO sachDTO = new SachDTO();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        private bool dragging = false; 
        private Point dragCursorPoint; 
        private Point dragFormPoint;
        private string tenFileAnh = ""; // Tên file ảnh sẽ lưu vào DB

        public ThemSach()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
            this.panel1.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
     
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenSach.Text)
                || string.IsNullOrWhiteSpace(txt_TacGia.Text)
                || string.IsNullOrWhiteSpace(txt_NXB.Text)
                || numSoLuong.Value == 0
                || pic_HinhAnhSach.Image == null
                || string.IsNullOrWhiteSpace(txt_MoTa.Text))
            {
                if (string.IsNullOrWhiteSpace(txt_TenSach.Text))
                    txt_TenSach.Focus();
                else if (string.IsNullOrWhiteSpace(txt_TacGia.Text))
                    txt_TacGia.Focus();
                else if (string.IsNullOrWhiteSpace(txt_NXB.Text))
                    txt_NXB.Focus();
                else if (numSoLuong.Value == 0)
                    numSoLuong.Focus();
                else if (pic_HinhAnhSach.Image == null)
                    pic_HinhAnhSach.Focus();
                else if (string.IsNullOrWhiteSpace(txt_MoTa.Text))
                    txt_MoTa.Focus();

                return;
            }

            // Move the instantiation of sachDTO here to avoid modifying an active statement
            SachDTO newSachDTO = new SachDTO
            {
                tenSach = txt_TenSach.Text.Trim(),
                tacGia = txt_TacGia.Text.Trim(),
                maTheLoai = cbo_MaTheLoai.SelectedValue.ToString(),
                namXuatBan = dtp_NamXB.Value,
                nhaXuatBan = txt_NXB.Text.Trim(),
                soLuong = Convert.ToInt32(numSoLuong.Value),
                moTa = txt_MoTa.Text.Trim(),
                hinhAnh = tenFileAnh,
                trangThai = 1 // Thêm sách mặc định đang hoạt động
            };

            if (!kiemTraTonTai(newSachDTO))
            {
                if (sachBUS.addSach(newSachDTO))
                {
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      

        private bool kiemTraTonTai(SachDTO sachDTO)
        {
            if (sachBUS.kiemTraTonTai(sachDTO))
            {
                MessageBox.Show("Sách đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void loadCboTheLoai()
        {
            cbo_MaTheLoai.DataSource = theLoaiBUS.getAllTheLoai();
            cbo_MaTheLoai.DisplayMember = "TenTheLoai"; // Tên cột hiển thị
            cbo_MaTheLoai.ValueMember = "MaTheLoai";   // Tên cột giá trị
        }
        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofd.FileName;
                    string fileName = Path.GetFileName(sourcePath);
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");
                    Directory.CreateDirectory(targetFolder); // đảm bảo folder tồn tại

                    string targetPath = Path.Combine(targetFolder, fileName);

                    // Nếu ảnh chưa tồn tại thì copy vào folder
                    if (!File.Exists(targetPath))
                    {
                        File.Copy(sourcePath, targetPath);
                    }

                    // Lưu lại tên file để lưu vào DB
                    tenFileAnh = fileName;

                    // Hiển thị ảnh lên PictureBox
                    pic_HinhAnhSach.Image = Image.FromFile(targetPath);
                    pic_HinhAnhSach.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            loadCboTheLoai();
        }
    }
}
