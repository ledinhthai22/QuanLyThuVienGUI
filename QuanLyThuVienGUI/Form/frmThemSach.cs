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
using Microsoft.SqlServer.Management.HadrModel;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        SachDTO sachDTO = new SachDTO();
        private bool dragging = false; 
        private Point dragCursorPoint; 
        private Point dragFormPoint;
      

        public frmThemSach()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);
            numSoLuong.Minimum = 1;
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
        private void loadCboTL()
        {
            List<TheLoaiDTO> dsTheLoai = theLoaiBUS.loadTheLoai(); // giả sử bạn có hàm này trong TheLoaiBUS
            cbo_MaTheLoai.DataSource = dsTheLoai;
            cbo_MaTheLoai.DisplayMember = "TenTL";
            cbo_MaTheLoai.ValueMember = "MaTL";
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
            getDuLieu();
            if(string.IsNullOrWhiteSpace(txt_TenSach.Text)
                || string.IsNullOrWhiteSpace(txt_TacGia.Text)
                || string.IsNullOrWhiteSpace(txt_NXB.Text)
                || string.IsNullOrWhiteSpace(txt_MoTa.Text)
                || dtp_NamXB.Value == null)
            {
                return;
            }
            if (sachBUS.addSach(sachDTO))
            {
                MessageBox.Show("Thêm sách thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void getDuLieu()
        {
            sachDTO.tenSach = txt_TenSach.Text;
            sachDTO.tacGia = txt_TacGia.Text;
            sachDTO.moTa = txt_MoTa.Text;
            sachDTO.soLuong = (int)numSoLuong.Value;
            sachDTO.nhaXuatBan = txt_NXB.Text;
            sachDTO.namXuatBan = dtp_NamXB.Value;
            sachDTO.maTheLoai = cbo_MaTheLoai.SelectedValue.ToString(); 
        }


        private void frmThemSach_Load(object sender, EventArgs e)
        {
            loadCboTL();
            
        }
    }
}
