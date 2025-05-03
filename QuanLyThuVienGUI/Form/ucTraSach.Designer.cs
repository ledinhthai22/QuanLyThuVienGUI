namespace QuanLyThuVienGUI
{
    partial class ucTraSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_DanhSachDangMuon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_CTphieuMuon = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TraSach = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TKPhieuMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TimKiemSach = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.txt_maDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MaDocGia = new System.Windows.Forms.Label();
            this.dtp_NgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_NgayMuon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NgayBatDauMuon = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.lbl_TenDocGia = new System.Windows.Forms.Label();
            this.dtp_ngayThucTeTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_NgayTraThucTe = new System.Windows.Forms.Label();
            this.txt_GhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SoLuongSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SoLuongSach = new System.Windows.Forms.Label();
            this.lbl_GhiChu = new System.Windows.Forms.Label();
            this.txt_SoNgayTre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_DanhSachDangMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTphieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_DanhSachDangMuon
            // 
            this.grp_DanhSachDangMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_DanhSachDangMuon.Controls.Add(this.dgv_CTphieuMuon);
            this.grp_DanhSachDangMuon.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.grp_DanhSachDangMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_DanhSachDangMuon.ForeColor = System.Drawing.Color.Black;
            this.grp_DanhSachDangMuon.Location = new System.Drawing.Point(720, 5);
            this.grp_DanhSachDangMuon.Name = "grp_DanhSachDangMuon";
            this.grp_DanhSachDangMuon.Size = new System.Drawing.Size(462, 311);
            this.grp_DanhSachDangMuon.TabIndex = 13;
            this.grp_DanhSachDangMuon.Text = "Danh Sách Đang mượn";
            // 
            // dgv_CTphieuMuon
            // 
            this.dgv_CTphieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CTphieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTphieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTphieuMuon.Location = new System.Drawing.Point(3, 43);
            this.dgv_CTphieuMuon.Name = "dgv_CTphieuMuon";
            this.dgv_CTphieuMuon.ReadOnly = true;
            this.dgv_CTphieuMuon.RowHeadersWidth = 51;
            this.dgv_CTphieuMuon.RowTemplate.Height = 24;
            this.dgv_CTphieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CTphieuMuon.Size = new System.Drawing.Size(456, 268);
            this.dgv_CTphieuMuon.TabIndex = 0;
            this.dgv_CTphieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CTphieuMuon_CellFormatting);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thoat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(468, 259);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(151, 48);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TraSach
            // 
            this.btn_TraSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TraSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TraSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TraSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TraSach.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TraSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TraSach.ForeColor = System.Drawing.Color.White;
            this.btn_TraSach.Location = new System.Drawing.Point(260, 259);
            this.btn_TraSach.Name = "btn_TraSach";
            this.btn_TraSach.Size = new System.Drawing.Size(151, 48);
            this.btn_TraSach.TabIndex = 15;
            this.btn_TraSach.Text = "Trả sách";
            this.btn_TraSach.Click += new System.EventHandler(this.btn_TraSach_Click);
            // 
            // txt_TKPhieuMuon
            // 
            this.txt_TKPhieuMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TKPhieuMuon.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TKPhieuMuon.BorderThickness = 2;
            this.txt_TKPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TKPhieuMuon.DefaultText = "";
            this.txt_TKPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TKPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TKPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TKPhieuMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TKPhieuMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TKPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TKPhieuMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TKPhieuMuon.Location = new System.Drawing.Point(688, 336);
            this.txt_TKPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TKPhieuMuon.Name = "txt_TKPhieuMuon";
            this.txt_TKPhieuMuon.PlaceholderText = "Tìm kiếm sách";
            this.txt_TKPhieuMuon.SelectedText = "";
            this.txt_TKPhieuMuon.Size = new System.Drawing.Size(383, 48);
            this.txt_TKPhieuMuon.TabIndex = 6;
            // 
            // btn_TimKiemSach
            // 
            this.btn_TimKiemSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiemSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemSach.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiemSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemSach.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemSach.Location = new System.Drawing.Point(1071, 336);
            this.btn_TimKiemSach.Name = "btn_TimKiemSach";
            this.btn_TimKiemSach.Size = new System.Drawing.Size(111, 48);
            this.btn_TimKiemSach.TabIndex = 7;
            this.btn_TimKiemSach.Text = "Tìm kiếm";
            this.btn_TimKiemSach.Click += new System.EventHandler(this.btn_TimKiemSach_Click);
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(0, 391);
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.ReadOnly = true;
            this.dgv_PhieuMuon.RowHeadersWidth = 51;
            this.dgv_PhieuMuon.RowTemplate.Height = 24;
            this.dgv_PhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(1182, 362);
            this.dgv_PhieuMuon.TabIndex = 16;
            this.dgv_PhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuMuon_CellClick);
            this.dgv_PhieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_PhieuMuon_CellFormatting);
            // 
            // txt_maDocGia
            // 
            this.txt_maDocGia.BackColor = System.Drawing.Color.White;
            this.txt_maDocGia.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_maDocGia.BorderThickness = 2;
            this.txt_maDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maDocGia.DefaultText = "";
            this.txt_maDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_maDocGia.ForeColor = System.Drawing.Color.Black;
            this.txt_maDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maDocGia.Location = new System.Drawing.Point(150, 4);
            this.txt_maDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maDocGia.Name = "txt_maDocGia";
            this.txt_maDocGia.PlaceholderText = "";
            this.txt_maDocGia.ReadOnly = true;
            this.txt_maDocGia.SelectedText = "";
            this.txt_maDocGia.Size = new System.Drawing.Size(204, 41);
            this.txt_maDocGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_maDocGia.TabIndex = 51;
            // 
            // lbl_MaDocGia
            // 
            this.lbl_MaDocGia.AutoSize = true;
            this.lbl_MaDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDocGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaDocGia.Location = new System.Drawing.Point(51, 26);
            this.lbl_MaDocGia.Name = "lbl_MaDocGia";
            this.lbl_MaDocGia.Size = new System.Drawing.Size(104, 23);
            this.lbl_MaDocGia.TabIndex = 50;
            this.lbl_MaDocGia.Text = "Mã độc giả:";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Checked = true;
            this.dtp_NgayTra.Enabled = false;
            this.dtp_NgayTra.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NgayTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayTra.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTra.Location = new System.Drawing.Point(150, 146);
            this.dtp_NgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(204, 31);
            this.dtp_NgayTra.TabIndex = 48;
            this.dtp_NgayTra.Value = new System.DateTime(2025, 5, 1, 18, 50, 42, 612);
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtp_NgayMuon.Checked = true;
            this.dtp_NgayMuon.Enabled = false;
            this.dtp_NgayMuon.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NgayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayMuon.ForeColor = System.Drawing.Color.Black;
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(150, 102);
            this.dtp_NgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(204, 31);
            this.dtp_NgayMuon.TabIndex = 47;
            this.dtp_NgayMuon.Value = new System.DateTime(2025, 5, 1, 18, 50, 42, 612);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.Color.White;
            this.txt_HoTen.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_HoTen.BorderThickness = 2;
            this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTen.DefaultText = "";
            this.txt_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTen.Location = new System.Drawing.Point(150, 50);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(204, 41);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 43;
            // 
            // lbl_NgayBatDauMuon
            // 
            this.lbl_NgayBatDauMuon.AutoSize = true;
            this.lbl_NgayBatDauMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayBatDauMuon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBatDauMuon.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayBatDauMuon.Location = new System.Drawing.Point(45, 106);
            this.lbl_NgayBatDauMuon.Name = "lbl_NgayBatDauMuon";
            this.lbl_NgayBatDauMuon.Size = new System.Drawing.Size(110, 23);
            this.lbl_NgayBatDauMuon.TabIndex = 46;
            this.lbl_NgayBatDauMuon.Text = "Ngày mượn:";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayTra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTra.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayTra.Location = new System.Drawing.Point(69, 150);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(85, 23);
            this.lbl_NgayTra.TabIndex = 45;
            this.lbl_NgayTra.Text = "Ngày trả:";
            // 
            // lbl_TenDocGia
            // 
            this.lbl_TenDocGia.AutoSize = true;
            this.lbl_TenDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDocGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_TenDocGia.Location = new System.Drawing.Point(85, 71);
            this.lbl_TenDocGia.Name = "lbl_TenDocGia";
            this.lbl_TenDocGia.Size = new System.Drawing.Size(69, 23);
            this.lbl_TenDocGia.TabIndex = 44;
            this.lbl_TenDocGia.Text = "Họ tên:";
            // 
            // dtp_ngayThucTeTra
            // 
            this.dtp_ngayThucTeTra.Checked = true;
            this.dtp_ngayThucTeTra.Enabled = false;
            this.dtp_ngayThucTeTra.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_ngayThucTeTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayThucTeTra.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngayThucTeTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayThucTeTra.Location = new System.Drawing.Point(150, 190);
            this.dtp_ngayThucTeTra.MaxDate = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            this.dtp_ngayThucTeTra.MinDate = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            this.dtp_ngayThucTeTra.Name = "dtp_ngayThucTeTra";
            this.dtp_ngayThucTeTra.Size = new System.Drawing.Size(204, 31);
            this.dtp_ngayThucTeTra.TabIndex = 53;
            this.dtp_ngayThucTeTra.Value = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            // 
            // lbl_NgayTraThucTe
            // 
            this.lbl_NgayTraThucTe.AutoSize = true;
            this.lbl_NgayTraThucTe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayTraThucTe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTraThucTe.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayTraThucTe.Location = new System.Drawing.Point(6, 195);
            this.lbl_NgayTraThucTe.Name = "lbl_NgayTraThucTe";
            this.lbl_NgayTraThucTe.Size = new System.Drawing.Size(147, 23);
            this.lbl_NgayTraThucTe.TabIndex = 52;
            this.lbl_NgayTraThucTe.Text = "Ngày trả thực tế:";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.BackColor = System.Drawing.Color.White;
            this.txt_GhiChu.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_GhiChu.BorderThickness = 2;
            this.txt_GhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GhiChu.DefaultText = "";
            this.txt_GhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_GhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_GhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_GhiChu.ForeColor = System.Drawing.Color.Black;
            this.txt_GhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GhiChu.Location = new System.Drawing.Point(487, 104);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.PlaceholderText = "";
            this.txt_GhiChu.SelectedText = "";
            this.txt_GhiChu.Size = new System.Drawing.Size(227, 41);
            this.txt_GhiChu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_GhiChu.TabIndex = 54;
            // 
            // txt_SoLuongSach
            // 
            this.txt_SoLuongSach.BackColor = System.Drawing.Color.White;
            this.txt_SoLuongSach.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_SoLuongSach.BorderThickness = 2;
            this.txt_SoLuongSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuongSach.DefaultText = "";
            this.txt_SoLuongSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoLuongSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoLuongSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuongSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuongSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuongSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoLuongSach.ForeColor = System.Drawing.Color.Black;
            this.txt_SoLuongSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuongSach.Location = new System.Drawing.Point(487, 57);
            this.txt_SoLuongSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuongSach.Name = "txt_SoLuongSach";
            this.txt_SoLuongSach.PlaceholderText = "";
            this.txt_SoLuongSach.ReadOnly = true;
            this.txt_SoLuongSach.SelectedText = "";
            this.txt_SoLuongSach.Size = new System.Drawing.Size(227, 41);
            this.txt_SoLuongSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoLuongSach.TabIndex = 56;
            // 
            // lbl_SoLuongSach
            // 
            this.lbl_SoLuongSach.AutoSize = true;
            this.lbl_SoLuongSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoLuongSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuongSach.ForeColor = System.Drawing.Color.Black;
            this.lbl_SoLuongSach.Location = new System.Drawing.Point(365, 80);
            this.lbl_SoLuongSach.Name = "lbl_SoLuongSach";
            this.lbl_SoLuongSach.Size = new System.Drawing.Size(127, 23);
            this.lbl_SoLuongSach.TabIndex = 57;
            this.lbl_SoLuongSach.Text = "Số lượng sách:";
            // 
            // lbl_GhiChu
            // 
            this.lbl_GhiChu.AutoSize = true;
            this.lbl_GhiChu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GhiChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GhiChu.ForeColor = System.Drawing.Color.Black;
            this.lbl_GhiChu.Location = new System.Drawing.Point(417, 127);
            this.lbl_GhiChu.Name = "lbl_GhiChu";
            this.lbl_GhiChu.Size = new System.Drawing.Size(75, 23);
            this.lbl_GhiChu.TabIndex = 55;
            this.lbl_GhiChu.Text = "Ghi chú:";
            // 
            // txt_SoNgayTre
            // 
            this.txt_SoNgayTre.BackColor = System.Drawing.Color.White;
            this.txt_SoNgayTre.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_SoNgayTre.BorderThickness = 2;
            this.txt_SoNgayTre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoNgayTre.DefaultText = "";
            this.txt_SoNgayTre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoNgayTre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoNgayTre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoNgayTre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoNgayTre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoNgayTre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoNgayTre.ForeColor = System.Drawing.Color.Black;
            this.txt_SoNgayTre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoNgayTre.Location = new System.Drawing.Point(487, 8);
            this.txt_SoNgayTre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoNgayTre.Name = "txt_SoNgayTre";
            this.txt_SoNgayTre.PlaceholderText = "";
            this.txt_SoNgayTre.ReadOnly = true;
            this.txt_SoNgayTre.SelectedText = "";
            this.txt_SoNgayTre.Size = new System.Drawing.Size(227, 41);
            this.txt_SoNgayTre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoNgayTre.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(385, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Số ngày trễ:";
            // 
            // ucTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_SoNgayTre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SoLuongSach);
            this.Controls.Add(this.lbl_SoLuongSach);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.dtp_ngayThucTeTra);
            this.Controls.Add(this.lbl_NgayTraThucTe);
            this.Controls.Add(this.txt_maDocGia);
            this.Controls.Add(this.lbl_MaDocGia);
            this.Controls.Add(this.dgv_PhieuMuon);
            this.Controls.Add(this.txt_TKPhieuMuon);
            this.Controls.Add(this.dtp_NgayTra);
            this.Controls.Add(this.grp_DanhSachDangMuon);
            this.Controls.Add(this.dtp_NgayMuon);
            this.Controls.Add(this.btn_TimKiemSach);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_NgayBatDauMuon);
            this.Controls.Add(this.btn_TraSach);
            this.Controls.Add(this.lbl_NgayTra);
            this.Controls.Add(this.lbl_TenDocGia);
            this.Controls.Add(this.lbl_GhiChu);
            this.Name = "ucTraSach";
            this.Size = new System.Drawing.Size(1185, 756);
            this.Load += new System.EventHandler(this.ucTraSach_Load);
            this.grp_DanhSachDangMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTphieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grp_DanhSachDangMuon;
        private Guna.UI2.WinForms.Guna2Button btn_Thoat;
        private Guna.UI2.WinForms.Guna2Button btn_TraSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TKPhieuMuon;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemSach;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private System.Windows.Forms.DataGridView dgv_CTphieuMuon;
        private Guna.UI2.WinForms.Guna2TextBox txt_maDocGia;
        private System.Windows.Forms.Label lbl_MaDocGia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayTra;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayMuon;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_NgayBatDauMuon;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.Label lbl_TenDocGia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayThucTeTra;
        private System.Windows.Forms.Label lbl_NgayTraThucTe;
        private Guna.UI2.WinForms.Guna2TextBox txt_GhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoLuongSach;
        private System.Windows.Forms.Label lbl_SoLuongSach;
        private System.Windows.Forms.Label lbl_GhiChu;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoNgayTre;
        private System.Windows.Forms.Label label1;
    }
}
