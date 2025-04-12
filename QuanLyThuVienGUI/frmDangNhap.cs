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
using QuanLyThuVienDTO;



namespace QuanLyThuVienGUI
{
    public partial class frmDangNhap : Form
    {
        private DangNhapBUS dangNhapBUS;
        private DangNhapDTO dangNhapDTO;

        public frmDangNhap()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            dangNhapDTO = new DangNhapDTO();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraDuLieuDangNhap())
                {
                    dangNhapDTO.userName = txt_Username.Text;
                    dangNhapDTO.passWord = txt_Password.Text;

                    if (dangNhapBUS.dangNhap(dangNhapDTO)) // kiểm tra tên đăng nhập và mặt khẩu có trong database không
                    {
                        string hoTen = dangNhapBUS.getNameUser(dangNhapDTO); 

                        if (dangNhapBUS.getRole(dangNhapDTO) == "admin") // kiểm tra chức vụ của tài khoản vừa được kiểm tra đăng nhập
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                            frmAdminMain frmAdminMain = new frmAdminMain(hoTen); 
                            frmAdminMain.Show();
                            this.Hide();
                        }
                        else if (dangNhapBUS.getRole(dangNhapDTO) == "thuthu")
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Không có quyền truy cập", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên hoặc sai mật khẩu", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool kiemTraDuLieuDangNhap()
        {
            // Kiểm tra tên đăng nhập rỗng trước
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.Focus();
                return false;
            }

            // Loại bỏ khoảng trắng 2 đầu
            string tenDangNhap = txt_Username.Text.Trim();

            // Kiểm tra độ dài tên đăng nhập
            if (tenDangNhap.Length < 3)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 3 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.Focus();
                return false;
            }
            if (tenDangNhap.Length > 32)
            {
                MessageBox.Show("Tên đăng nhập không được vượt quá 32 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.Focus();
                return false;
            }

            // Kiểm tra mật khẩu rỗng
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            // Kiểm tra độ dài mật khẩu
            if (txt_Password.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            return true;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_ShowPass.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinius_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
