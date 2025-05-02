using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
using QuanLyThuVienGUI.admin;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;
using System.Drawing.Text;

namespace QuanLyThuVienGUI
{
    public partial class frmMain : Form
    {
        
        public DangNhapBUS dangNhapBUS;
        public DangNhapDTO dangNhapDTO;
        // Biến hỗ trợ kéo thả form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private string chucVu;
        public string maNV;

        // Windows API để hỗ trợ kéo form
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

    
        public frmMain(string tenNV,string chucVu,string maNV)
        {
            InitializeComponent();
            LoadFormIntoPanel(new frmTrangChu());
            lbl_Ten.Text = tenNV;
            this.chucVu = chucVu;
            this.maNV = maNV;

            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);
       
            this.pn_ControlTab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_ControlTab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_ControlTab.MouseUp += new MouseEventHandler(Form_MouseUp);
            
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

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.ShowDialog();
        }

        private void LoadFormIntoPanel(Form form)
        {
            
            Pn_LoadFrm.SuspendLayout();
            Pn_LoadFrm.Controls.Clear(); 
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Pn_LoadFrm.Controls.Add(form);
            form.Show();
            Pn_LoadFrm.ResumeLayout();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmQuanLySach());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmTrangChu());
        }

        private void btn_QLDocGia_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmQuanLyDocGia());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btn_QLTheLoai_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmQuanLyTheLoai());
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            if (string.Equals(chucVu, "thuthu", StringComparison.OrdinalIgnoreCase))
            {
                btn_QLSach.Visible = false;
                btn_QLTheLoai.Visible = false;
                btn_QLNhanVien.Visible = false;
                btn_QLDocGia.Visible = false;
            }
        }

        private void btn_QLNhanVien_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmQuanLyNhanVien());
        }
        private void btn_QLMuonTra_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new frmQuanLyMuonTra(maNV));
        }
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        public void LoadChildForm(Form form)
        {
            LoadFormIntoPanel(form); 
        }

        private void btnMinius_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}