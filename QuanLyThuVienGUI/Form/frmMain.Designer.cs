namespace QuanLyThuVienGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Pn_LoadFrm = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.pn_NavB = new System.Windows.Forms.Panel();
            this.pn_ControlTab = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Max = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Min = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLMuonTra = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLDocGia = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLTheLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_QLSach = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            this.pn_NavB.SuspendLayout();
            this.pn_ControlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Pn_LoadFrm
            // 
            this.Pn_LoadFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pn_LoadFrm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pn_LoadFrm.BorderColor = System.Drawing.Color.Gray;
            this.Pn_LoadFrm.BorderRadius = 15;
            this.Pn_LoadFrm.Location = new System.Drawing.Point(265, 28);
            this.Pn_LoadFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pn_LoadFrm.Name = "Pn_LoadFrm";
            this.Pn_LoadFrm.Size = new System.Drawing.Size(1185, 756);
            this.Pn_LoadFrm.TabIndex = 3;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.ForeColor = System.Drawing.Color.White;
            this.lbl_Ten.Location = new System.Drawing.Point(52, 37);
            this.lbl_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(57, 23);
            this.lbl_Ten.TabIndex = 1;
            this.lbl_Ten.Text = "Name";
            // 
            // pn_NavB
            // 
            this.pn_NavB.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_NavB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_NavB.Controls.Add(this.btn_TimKiem);
            this.pn_NavB.Controls.Add(this.btn_QLMuonTra);
            this.pn_NavB.Controls.Add(this.btn_QLNhanVien);
            this.pn_NavB.Controls.Add(this.btn_QLDocGia);
            this.pn_NavB.Controls.Add(this.btn_DangXuat);
            this.pn_NavB.Controls.Add(this.btn_QLTheLoai);
            this.pn_NavB.Controls.Add(this.btn_QLSach);
            this.pn_NavB.Controls.Add(this.btn_TrangChu);
            this.pn_NavB.Controls.Add(this.lbl_Ten);
            this.pn_NavB.Controls.Add(this.pic_Icon);
            this.pn_NavB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_NavB.Location = new System.Drawing.Point(0, 0);
            this.pn_NavB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_NavB.Name = "pn_NavB";
            this.pn_NavB.Size = new System.Drawing.Size(266, 782);
            this.pn_NavB.TabIndex = 1;
            // 
            // pn_ControlTab
            // 
            this.pn_ControlTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ControlTab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_ControlTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ControlTab.Controls.Add(this.btn_Max);
            this.pn_ControlTab.Controls.Add(this.lbl_Title);
            this.pn_ControlTab.Controls.Add(this.btn_Min);
            this.pn_ControlTab.Controls.Add(this.btn_Close);
            this.pn_ControlTab.Location = new System.Drawing.Point(0, 0);
            this.pn_ControlTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_ControlTab.Name = "pn_ControlTab";
            this.pn_ControlTab.Size = new System.Drawing.Size(1453, 28);
            this.pn_ControlTab.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 2);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(311, 23);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN SÁCH";
            // 
            // btn_Max
            // 
            this.btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max.BackColor = System.Drawing.Color.Transparent;
            this.btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Max.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Max.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Max.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Max.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Max.FillColor = System.Drawing.Color.Transparent;
            this.btn_Max.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Max.ForeColor = System.Drawing.Color.White;
            this.btn_Max.Image = global::QuanLyThuVienGUI.Properties.Resources.maximize_button_32px;
            this.btn_Max.Location = new System.Drawing.Point(1381, -1);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(33, 28);
            this.btn_Max.TabIndex = 12;
            this.btn_Max.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.BackColor = System.Drawing.Color.Transparent;
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Min.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Min.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Min.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Min.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Min.FillColor = System.Drawing.Color.Transparent;
            this.btn_Min.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Min.ForeColor = System.Drawing.Color.White;
            this.btn_Min.Image = global::QuanLyThuVienGUI.Properties.Resources.minus;
            this.btn_Min.Location = new System.Drawing.Point(1345, 0);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(33, 28);
            this.btn_Min.TabIndex = 10;
            this.btn_Min.Click += new System.EventHandler(this.btnMinius_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::QuanLyThuVienGUI.Properties.Resources.multiply_32px;
            this.btn_Close.Location = new System.Drawing.Point(1416, -1);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(33, 28);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Image = global::QuanLyThuVienGUI.Properties.Resources.Search1;
            this.btn_TimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TimKiem.Location = new System.Drawing.Point(-2, 73);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(268, 62);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TimKiem.TextFormatNoPrefix = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_QLMuonTra
            // 
            this.btn_QLMuonTra.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLMuonTra.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_QLMuonTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLMuonTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLMuonTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLMuonTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLMuonTra.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLMuonTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_QLMuonTra.ForeColor = System.Drawing.Color.White;
            this.btn_QLMuonTra.Image = global::QuanLyThuVienGUI.Properties.Resources.borrow_book_32px;
            this.btn_QLMuonTra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLMuonTra.Location = new System.Drawing.Point(-1, 132);
            this.btn_QLMuonTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLMuonTra.Name = "btn_QLMuonTra";
            this.btn_QLMuonTra.Size = new System.Drawing.Size(267, 62);
            this.btn_QLMuonTra.TabIndex = 9;
            this.btn_QLMuonTra.Text = "Quản lý mượn trả";
            this.btn_QLMuonTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLMuonTra.TextFormatNoPrefix = true;
            this.btn_QLMuonTra.Click += new System.EventHandler(this.btn_QLMuonTra_Click);
            // 
            // btn_QLNhanVien
            // 
            this.btn_QLNhanVien.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLNhanVien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_QLNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLNhanVien.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_QLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_QLNhanVien.Image = global::QuanLyThuVienGUI.Properties.Resources.staff_32px;
            this.btn_QLNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLNhanVien.Location = new System.Drawing.Point(-3, 265);
            this.btn_QLNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLNhanVien.Name = "btn_QLNhanVien";
            this.btn_QLNhanVien.Size = new System.Drawing.Size(269, 62);
            this.btn_QLNhanVien.TabIndex = 10;
            this.btn_QLNhanVien.Text = "Quản lý nhân viên";
            this.btn_QLNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLNhanVien.TextFormatNoPrefix = true;
            this.btn_QLNhanVien.Click += new System.EventHandler(this.btn_QLNhanVien_Click);
            // 
            // btn_QLDocGia
            // 
            this.btn_QLDocGia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLDocGia.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_QLDocGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLDocGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLDocGia.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLDocGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_QLDocGia.ForeColor = System.Drawing.Color.White;
            this.btn_QLDocGia.Image = global::QuanLyThuVienGUI.Properties.Resources.reading_32px;
            this.btn_QLDocGia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLDocGia.Location = new System.Drawing.Point(-1, 198);
            this.btn_QLDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLDocGia.Name = "btn_QLDocGia";
            this.btn_QLDocGia.Size = new System.Drawing.Size(268, 62);
            this.btn_QLDocGia.TabIndex = 8;
            this.btn_QLDocGia.Text = "Quản lý độc giả";
            this.btn_QLDocGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLDocGia.TextFormatNoPrefix = true;
            this.btn_QLDocGia.Click += new System.EventHandler(this.btn_QLDocGia_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DangXuat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_DangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangXuat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_DangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Image = global::QuanLyThuVienGUI.Properties.Resources.exit;
            this.btn_DangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DangXuat.Location = new System.Drawing.Point(-1, 720);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(268, 62);
            this.btn_DangXuat.TabIndex = 7;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_DangXuat.TextFormatNoPrefix = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btn_QLTheLoai
            // 
            this.btn_QLTheLoai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLTheLoai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_QLTheLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTheLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLTheLoai.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_QLTheLoai.ForeColor = System.Drawing.Color.White;
            this.btn_QLTheLoai.Image = global::QuanLyThuVienGUI.Properties.Resources.sorting_32px1;
            this.btn_QLTheLoai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLTheLoai.Location = new System.Drawing.Point(0, 394);
            this.btn_QLTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLTheLoai.Name = "btn_QLTheLoai";
            this.btn_QLTheLoai.Size = new System.Drawing.Size(268, 62);
            this.btn_QLTheLoai.TabIndex = 4;
            this.btn_QLTheLoai.Text = "Quản lý thể loại";
            this.btn_QLTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLTheLoai.TextFormatNoPrefix = true;
            this.btn_QLTheLoai.Click += new System.EventHandler(this.btn_QLTheLoai_Click);
            // 
            // btn_QLSach
            // 
            this.btn_QLSach.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLSach.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_QLSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_QLSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_QLSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_QLSach.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_QLSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_QLSach.ForeColor = System.Drawing.Color.White;
            this.btn_QLSach.Image = global::QuanLyThuVienGUI.Properties.Resources.book_32px;
            this.btn_QLSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLSach.Location = new System.Drawing.Point(-1, 331);
            this.btn_QLSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QLSach.Name = "btn_QLSach";
            this.btn_QLSach.Size = new System.Drawing.Size(265, 62);
            this.btn_QLSach.TabIndex = 3;
            this.btn_QLSach.Text = "Quản lý sách";
            this.btn_QLSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_QLSach.TextFormatNoPrefix = true;
            this.btn_QLSach.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TrangChu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_TrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TrangChu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TrangChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.Image = global::QuanLyThuVienGUI.Properties.Resources.home_32px;
            this.btn_TrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TrangChu.Location = new System.Drawing.Point(-1, 69);
            this.btn_TrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(268, 62);
            this.btn_TrangChu.TabIndex = 2;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TrangChu.TextFormatNoPrefix = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pic_Icon
            // 
            this.pic_Icon.Image = global::QuanLyThuVienGUI.Properties.Resources.User;
            this.pic_Icon.Location = new System.Drawing.Point(4, 31);
            this.pic_Icon.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(40, 36);
            this.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Icon.TabIndex = 0;
            this.pic_Icon.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 782);
            this.Controls.Add(this.pn_ControlTab);
            this.Controls.Add(this.Pn_LoadFrm);
            this.Controls.Add(this.pn_NavB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.pn_NavB.ResumeLayout(false);
            this.pn_NavB.PerformLayout();
            this.pn_ControlTab.ResumeLayout(false);
            this.pn_ControlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Pn_LoadFrm;
        private System.Windows.Forms.PictureBox pic_Icon;
        private System.Windows.Forms.Label lbl_Ten;
        private Guna.UI2.WinForms.Guna2Button btn_TrangChu;
        private Guna.UI2.WinForms.Guna2Button btn_QLSach;
        private Guna.UI2.WinForms.Guna2Button btn_QLTheLoai;
        private Guna.UI2.WinForms.Guna2Button btn_DangXuat;
        private Guna.UI2.WinForms.Guna2Button btn_QLDocGia;
        private Guna.UI2.WinForms.Guna2Button btn_QLMuonTra;
        private System.Windows.Forms.Panel pn_NavB;
        private Guna.UI2.WinForms.Guna2Button btn_QLNhanVien;
        private System.Windows.Forms.Panel pn_ControlTab;
        private Guna.UI2.WinForms.Guna2Button btn_Max;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2Button btn_Min;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
    }
}