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

namespace QuanLyThuVienGUI.admin
{
    public partial class QuanLyDocGia: Form
    {
        DocGiaBUS dgBUS = new DocGiaBUS();
        public QuanLyDocGia()
        {
            InitializeComponent();
            loadDG();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {

        }

        private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        private void loadDG()
        {
            dataGridView1.DataSource = dgBUS.LoadDSDG();

        }
    }
}
