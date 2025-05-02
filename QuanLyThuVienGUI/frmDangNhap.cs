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
        NhanVienDTO nhanVienDTO = new NhanVienDTO();
        public frmDangNhap()
        {
            InitializeComponent();
            dangNhapBUS = new DangNhapBUS();
            dangNhapDTO = new DangNhapDTO();
            lbl_Message.Visible = false;
            messageTimer = new Timer();
            messageTimer.Interval = 5000; 
            messageTimer.Tick += messageTimer_Tick;
            lbl_Message.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(kiemTraDuLieuDangNhap())
                {
                   
                    dangNhapDTO.userName = txt_Username.Text;
                    dangNhapDTO.passWord = txt_Password.Text;

                    if (dangNhapBUS.dangNhap(dangNhapDTO))
                    {
                        string hoTen = dangNhapBUS.getNameUser(dangNhapDTO);
                        string maNV = dangNhapBUS.getyMaNV(dangNhapDTO);
                        if (dangNhapBUS.getRole(dangNhapDTO) == "admin")
                        {
                            frmMain frmAdminMain = new frmMain(hoTen, "admin",maNV);
                            frmAdminMain.Show();
                            this.Hide();
                        }
                        else if (dangNhapBUS.getRole(dangNhapDTO) == "thuthu")
                        {
                            
                            frmMain frmAdminMain = new frmMain(hoTen, "thuthu",maNV);
                           
                            frmAdminMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            lbl_Message.Text = "Không có quyền truy cập";
                            lbl_Message.ForeColor = Color.Red;
                            lbl_Message.Visible = true;
                            messageTimer.Stop();
                            messageTimer.Start();
                        }
                    }
                    else
                    {
                        lbl_Message.Text = "Sai tên đăng nhập hoặc sai mật khẩu";
                        lbl_Message.ForeColor = Color.Red;
                        lbl_Message.Visible = true;
                        messageTimer.Stop();
                        messageTimer.Start();

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
            lbl_Message.Visible = false;
            messageTimer.Stop();
            // Kiểm tra tên tài khoản
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                lbl_Message.Text = "Vui lòng nhập tên tài khoản";
                lbl_Message.ForeColor = Color.Yellow;
                lbl_Message.Visible = true;
                return false;
          
            }

            string tenDangNhap = txt_Username.Text.Trim();

            // Kiểm tra độ dài tên tài khoản
            if (tenDangNhap.Length < 3)
            {
                lbl_Message.Text = "Tên đăng nhập phải trên 3 ký tự";
                lbl_Message.ForeColor = Color.Orange;
                lbl_Message.Visible = true;
              
                return false;

            }
            if (tenDangNhap.Length > 32)
            {
                lbl_Message.Text = "Tên đăng nhập không vượt quá 32 ký tự";
                lbl_Message.ForeColor = Color.Orange;
                lbl_Message.Visible = true;
               
                return false;

            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                lbl_Message.Text = "Vui lòng nhập mật khẩu";
                lbl_Message.ForeColor = Color.Orange;
                lbl_Message.Visible = true;
               
                return false;

            }

            if (txt_Password.Text.Length < 6)
            {
                lbl_Message.Text = "Mật khẩu phải có ít nhất 6 ký tự";
                lbl_Message.ForeColor = Color.Orange;
                lbl_Message.Visible = true;
              
                return false ;

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
       

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            lbl_Message.Visible = false;
            messageTimer.Stop();
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            lbl_Message.Visible = false;
            txt_Username.Focus();
            messageTimer.Stop();
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            lbl_Message.Visible = false;
            txt_Password.Focus();
            messageTimer.Stop();
        }
    }
}
