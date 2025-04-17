using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using QuanLyThuVienGUI.admin;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI
{
    public partial class frmQuanLySach : Form
    {
       
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frmThemSach themSach = new frmThemSach();
            themSach.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
           
        }
    }
}