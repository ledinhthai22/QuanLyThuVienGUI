namespace QuanLyThuVienGUI
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.PnLoad = new Guna.UI2.WinForms.Guna2Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtQLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrowingManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnReadersManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenremanagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.picIconNav = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFullScreen = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinius = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconNav)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnLoad
            // 
            this.PnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnLoad.BorderColor = System.Drawing.Color.Gray;
            this.PnLoad.BorderRadius = 15;
            this.PnLoad.Location = new System.Drawing.Point(201, 21);
            this.PnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.PnLoad.Name = "PnLoad";
            this.PnLoad.Size = new System.Drawing.Size(889, 614);
            this.PnLoad.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(39, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.btnBorrowingManagement);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.txtQLNhanVien);
            this.panel2.Controls.Add(this.btnReadersManagement);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnGenremanagement);
            this.panel2.Controls.Add(this.btnBookManagement);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.picIconNav);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 635);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::QuanLyThuVienGUI.Properties.Resources.statistics_32px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(-1, 380);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(202, 50);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Thống kê";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextFormatNoPrefix = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtQLNhanVien
            // 
            this.txtQLNhanVien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtQLNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQLNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtQLNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtQLNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtQLNhanVien.FillColor = System.Drawing.Color.LightSeaGreen;
            this.txtQLNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.txtQLNhanVien.Image = global::QuanLyThuVienGUI.Properties.Resources.User;
            this.txtQLNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQLNhanVien.Location = new System.Drawing.Point(-1, 326);
            this.txtQLNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtQLNhanVien.Name = "txtQLNhanVien";
            this.txtQLNhanVien.Size = new System.Drawing.Size(202, 50);
            this.txtQLNhanVien.TabIndex = 10;
            this.txtQLNhanVien.Text = "Nhân viên";
            this.txtQLNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQLNhanVien.TextFormatNoPrefix = true;
            // 
            // btnBorrowingManagement
            // 
            this.btnBorrowingManagement.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBorrowingManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowingManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowingManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowingManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrowingManagement.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBorrowingManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrowingManagement.ForeColor = System.Drawing.Color.White;
            this.btnBorrowingManagement.Image = global::QuanLyThuVienGUI.Properties.Resources.borrow_book;
            this.btnBorrowingManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowingManagement.Location = new System.Drawing.Point(-1, 110);
            this.btnBorrowingManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrowingManagement.Name = "btnBorrowingManagement";
            this.btnBorrowingManagement.Size = new System.Drawing.Size(201, 50);
            this.btnBorrowingManagement.TabIndex = 9;
            this.btnBorrowingManagement.Text = "Quản lý mượn trả";
            this.btnBorrowingManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowingManagement.TextFormatNoPrefix = true;
            // 
            // btnReadersManagement
            // 
            this.btnReadersManagement.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnReadersManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReadersManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReadersManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReadersManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReadersManagement.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnReadersManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReadersManagement.ForeColor = System.Drawing.Color.White;
            this.btnReadersManagement.Image = global::QuanLyThuVienGUI.Properties.Resources.reader;
            this.btnReadersManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReadersManagement.Location = new System.Drawing.Point(1, 272);
            this.btnReadersManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadersManagement.Name = "btnReadersManagement";
            this.btnReadersManagement.Size = new System.Drawing.Size(199, 50);
            this.btnReadersManagement.TabIndex = 8;
            this.btnReadersManagement.Text = "Quản lý độc giả";
            this.btnReadersManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReadersManagement.TextFormatNoPrefix = true;
            this.btnReadersManagement.Click += new System.EventHandler(this.btnReadersManagement_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::QuanLyThuVienGUI.Properties.Resources.exit;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(-1, 586);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextFormatNoPrefix = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccount.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::QuanLyThuVienGUI.Properties.Resources.settings_32px;
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.Location = new System.Drawing.Point(-1, 535);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(201, 50);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.TextFormatNoPrefix = true;
            // 
            // btnGenremanagement
            // 
            this.btnGenremanagement.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnGenremanagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenremanagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenremanagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenremanagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenremanagement.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenremanagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenremanagement.ForeColor = System.Drawing.Color.White;
            this.btnGenremanagement.Image = global::QuanLyThuVienGUI.Properties.Resources.categoryBook;
            this.btnGenremanagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenremanagement.Location = new System.Drawing.Point(1, 218);
            this.btnGenremanagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenremanagement.Name = "btnGenremanagement";
            this.btnGenremanagement.Size = new System.Drawing.Size(198, 50);
            this.btnGenremanagement.TabIndex = 4;
            this.btnGenremanagement.Text = "Quản lý thể loại";
            this.btnGenremanagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenremanagement.TextFormatNoPrefix = true;
            this.btnGenremanagement.Click += new System.EventHandler(this.btnGenremanagement_Click);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBookManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookManagement.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBookManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookManagement.ForeColor = System.Drawing.Color.White;
            this.btnBookManagement.Image = global::QuanLyThuVienGUI.Properties.Resources.manage_book;
            this.btnBookManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookManagement.Location = new System.Drawing.Point(0, 164);
            this.btnBookManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Size = new System.Drawing.Size(199, 50);
            this.btnBookManagement.TabIndex = 3;
            this.btnBookManagement.Text = "Quản lý sách";
            this.btnBookManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookManagement.TextFormatNoPrefix = true;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // btnHome
            // 
            this.btnHome.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyThuVienGUI.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(-1, 56);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextFormatNoPrefix = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picIconNav
            // 
            this.picIconNav.Image = global::QuanLyThuVienGUI.Properties.Resources.User;
            this.picIconNav.Location = new System.Drawing.Point(3, 25);
            this.picIconNav.Name = "picIconNav";
            this.picIconNav.Size = new System.Drawing.Size(30, 29);
            this.picIconNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconNav.TabIndex = 0;
            this.picIconNav.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFullScreen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinius);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 23);
            this.panel1.TabIndex = 4;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreen.BackgroundImage = global::QuanLyThuVienGUI.Properties.Resources.maximize_button_32px;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFullScreen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFullScreen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFullScreen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFullScreen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFullScreen.FillColor = System.Drawing.Color.Transparent;
            this.btnFullScreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFullScreen.ForeColor = System.Drawing.Color.White;
            this.btnFullScreen.Location = new System.Drawing.Point(1036, -1);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(25, 23);
            this.btnFullScreen.TabIndex = 12;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN SÁCH";
            // 
            // btnMinius
            // 
            this.btnMinius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinius.BackColor = System.Drawing.Color.Transparent;
            this.btnMinius.BackgroundImage = global::QuanLyThuVienGUI.Properties.Resources.minus;
            this.btnMinius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinius.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinius.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinius.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinius.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinius.FillColor = System.Drawing.Color.Transparent;
            this.btnMinius.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinius.ForeColor = System.Drawing.Color.White;
            this.btnMinius.Location = new System.Drawing.Point(1009, 0);
            this.btnMinius.Name = "btnMinius";
            this.btnMinius.Size = new System.Drawing.Size(25, 23);
            this.btnMinius.TabIndex = 10;
            this.btnMinius.Click += new System.EventHandler(this.btnMinius_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::QuanLyThuVienGUI.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1062, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnLoad);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconNav)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnLoad;
        private System.Windows.Forms.PictureBox picIconNav;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnBookManagement;
        private Guna.UI2.WinForms.Guna2Button btnGenremanagement;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnReadersManagement;
        private Guna.UI2.WinForms.Guna2Button btnBorrowingManagement;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button txtQLNhanVien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnFullScreen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnMinius;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}