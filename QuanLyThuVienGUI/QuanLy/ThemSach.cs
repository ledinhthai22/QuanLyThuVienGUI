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
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private bool dragging = false; 
        private Point dragCursorPoint; 
        private Point dragFormPoint;
      

        public ThemSach()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);
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
                else if (string.IsNullOrWhiteSpace(txt_MoTa.Text))
                    txt_MoTa.Focus();

                return;
            }

            
            SachDTO newSachDTO = new SachDTO
            {
                tenSach = txt_TenSach.Text.Trim(),
                tacGia = txt_TacGia.Text.Trim(),
                maTheLoai = cbo_MaTheLoai.SelectedValue.ToString(),
                namXuatBan = dtp_NamXB.Value,
                nhaXuatBan = txt_NXB.Text.Trim(),
                soLuong = Convert.ToInt32(numSoLuong.Value),
                moTa = txt_MoTa.Text.Trim(),
             
                trangThai = 1
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

        private void ThemSach_Load(object sender, EventArgs e)
        {
            loadCboTheLoai();
        }
    }
}
