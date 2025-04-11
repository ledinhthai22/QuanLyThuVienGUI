using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienDTO;
using QuanLyThuVienBUS;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace QuanLyThuVienGUI.admin
{
    public partial class QuanLyTheLoai : Form
    {
  
        private TheLoaiBUS TheLoaiBUS= new TheLoaiBUS();
        public QuanLyTheLoai()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {

        }

        private void dgvLoadTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
        

        }
        private void LoadData()
        {
            dataGridView1.DataSource = TheLoaiBUS.LoadDSTL();
        }

        private void lblTenTheLoai_Click(object sender, EventArgs e)
        {

        }
    }
}
