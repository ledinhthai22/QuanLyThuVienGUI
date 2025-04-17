using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.QuanLy;


namespace QuanLyThuVienGUI.admin
{
    public partial class frmQuanLyTheLoai : Form
    {

     
        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {

        }

 
       
        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            frmThemTheLoai themTheLoai = new frmThemTheLoai();
            themTheLoai.ShowDialog();
        }

      
    }
}