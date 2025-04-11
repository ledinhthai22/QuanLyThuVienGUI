using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;


namespace QuanLyThuVienGUI
{
    public partial class QuanLySach : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoai = new TheLoaiBUS();
        
        public QuanLySach()
        {
            InitializeComponent();
            
            
            loadDSS();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            SachDTO sachDTO = new SachDTO();
            sachDTO.tenSach = txtTenSach.Text;
            sachDTO.tacGia = txtTacGia.Text;
            sachDTO.maTheLoai = cbMaTheLoai.SelectedIndex + 1;
            sachDTO.namXuatBan = dtpNamXB.Value;
            sachDTO.nhaXuatBan = txtNXB.Text;
            sachDTO.soLuong = int.Parse(txtSoLuong.Text);
            sachDTO.trangThai = txtTrangThai.Text;
            sachDTO.moTa = txtMoTa.Text;
            sachBUS.themSach(sachDTO);
            loadDSS();
        }


        private void btnRemoveBook_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
        private void txtNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (txtNXB.Text.Length > 50 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (txtSoLuong.Text.Length > 1 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (txtTrangThai.Text.Length > 20 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNXB.Clear();
            cbMaTheLoai.Text = string.Empty;
            txtTrangThai.Clear();
            txtSoLuong.Clear();
            picHinhAnhSach.Image = null;
        }

        private void btnChoiceImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "chọn ảnh";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picHinhAnhSach.ImageLocation = ofd.FileName;
            }    
        }
        private void loadDSS()
        {
            dataGridView1.DataSource = sachBUS.loadDSS();
        }

        private void pnSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            cbMaTheLoai.DataSource = theLoai.layTheLoai();
            cbMaTheLoai.ValueMember= "MaTheLoai";
            cbMaTheLoai.DisplayMember = "TenTheLoai";

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtTenSach.Text = row.Cells[1].Value.ToString(); 
        }
    }
}
