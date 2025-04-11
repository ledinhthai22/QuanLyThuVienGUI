using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienGUI.admin;


namespace QuanLyThuVienGUI
{
    public partial class AdminMain : Form
    {
        
        public AdminMain()
        {
            InitializeComponent();
            LoadFormIntoPanel(new TrangChu());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
        private void LoadFormIntoPanel(Form form)
        {
            PnLoad.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PnLoad.Controls.Add(form);
            form.Show();
        }
        

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new QuanLySach());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           LoadFormIntoPanel(new TrangChu());
        }

        private void btnReadersManagement_Click(object sender, EventArgs e)
        {
           LoadFormIntoPanel(new QuanLyDocGia());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
           if(WindowState == FormWindowState.Normal)
           {
                WindowState = FormWindowState.Maximized;
           }
           else
           {
                WindowState = FormWindowState.Normal;
           }
        }

        private void btnMinius_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }

        private void btnGenremanagement_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new QuanLyTheLoai());
        }
    }
}
