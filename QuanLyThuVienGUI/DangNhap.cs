using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLyThuVienBUS;


namespace QuanLyThuVienGUI
{
    public partial class DangNhap : Form
    {
       
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 3)
            {
                MessageBox.Show("Vui lòng nhập 3 ký tự trở lên.",
                "Cảnh Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;

            }
            else if (txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Vui lòng nhập ít hơn 20 ký tự",
                "Cảnh Báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập.",
                    "Cảnh Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.",
                    "Cảnh Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string vaitro;
            DangNhapBUS accountBUS = new DangNhapBUS();
            if(accountBUS.DangNhap(txtUsername.Text, txtPassword.Text, vaitro ="Admin"))
            {
                this.Hide();
                AdminMain adminMain = new AdminMain();
                adminMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu",
                    "Thông báo",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinius_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblTitleSystem_Click(object sender, EventArgs e)
        {

        }
    }
   
}
