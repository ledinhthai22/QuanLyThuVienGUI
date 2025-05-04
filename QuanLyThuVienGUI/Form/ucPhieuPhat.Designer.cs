namespace QuanLyThuVienGUI
{
    partial class ucPhieuPhat
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
            this.grp_DanhSachPhieuMuon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgv_DSPhieuMuon = new System.Windows.Forms.DataGridView();
            this.grp_ThongTinPhieuPhat = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_MaPhieuMuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MaPhieuMuon = new System.Windows.Forms.Label();
            this.txt_TongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TienMatSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TienHuSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TienTreHan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TaoPhieuPhat = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_HuSach = new System.Windows.Forms.Label();
            this.lbl_MatSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_MatSach = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chk_HuSach = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txt_SoNgayTre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngayThucTeTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_NgayTraThucTe = new System.Windows.Forms.Label();
            this.txt_maDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MaDocGia = new System.Windows.Forms.Label();
            this.dtp_NgayTra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_NgayMuon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_NgayBatDauMuon = new System.Windows.Forms.Label();
            this.lbl_NgayTra = new System.Windows.Forms.Label();
            this.lbl_TenDocGia = new System.Windows.Forms.Label();
            this.lbl_LyDoPhat = new System.Windows.Forms.Label();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.grp_DanhSachPhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhieuMuon)).BeginInit();
            this.grp_ThongTinPhieuPhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_DanhSachPhieuMuon
            // 
            this.grp_DanhSachPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_DanhSachPhieuMuon.Controls.Add(this.dgv_DSPhieuMuon);
            this.grp_DanhSachPhieuMuon.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.grp_DanhSachPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_DanhSachPhieuMuon.ForeColor = System.Drawing.Color.Black;
            this.grp_DanhSachPhieuMuon.Location = new System.Drawing.Point(1, 410);
            this.grp_DanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DanhSachPhieuMuon.Name = "grp_DanhSachPhieuMuon";
            this.grp_DanhSachPhieuMuon.Size = new System.Drawing.Size(1184, 346);
            this.grp_DanhSachPhieuMuon.TabIndex = 14;
            this.grp_DanhSachPhieuMuon.Text = "Danh sách phiếu mượn";
            // 
            // dgv_DSPhieuMuon
            // 
            this.dgv_DSPhieuMuon.AllowUserToAddRows = false;
            this.dgv_DSPhieuMuon.AllowUserToDeleteRows = false;
            this.dgv_DSPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhieuMuon.Location = new System.Drawing.Point(1, 43);
            this.dgv_DSPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSPhieuMuon.Name = "dgv_DSPhieuMuon";
            this.dgv_DSPhieuMuon.ReadOnly = true;
            this.dgv_DSPhieuMuon.RowHeadersWidth = 51;
            this.dgv_DSPhieuMuon.RowTemplate.Height = 24;
            this.dgv_DSPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSPhieuMuon.Size = new System.Drawing.Size(1178, 300);
            this.dgv_DSPhieuMuon.TabIndex = 0;
            this.dgv_DSPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPhieuMuon_CellClick);
            this.dgv_DSPhieuMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSPhieuMuon_CellFormatting);
            // 
            // grp_ThongTinPhieuPhat
            // 
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_MaPhieuMuon);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_MaPhieuMuon);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_TongTien);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_TienMatSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_TienHuSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_TienTreHan);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.btn_TaoPhieuPhat);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_Thoat);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_TongTien);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_HuSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_MatSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.label1);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.chk_MatSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.chk_HuSach);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_SoNgayTre);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.label2);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.dtp_ngayThucTeTra);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_NgayTraThucTe);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_maDocGia);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_MaDocGia);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.dtp_NgayTra);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.dtp_NgayMuon);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.txt_HoTen);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_NgayBatDauMuon);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_NgayTra);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_TenDocGia);
            this.grp_ThongTinPhieuPhat.Controls.Add(this.lbl_LyDoPhat);
            this.grp_ThongTinPhieuPhat.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.grp_ThongTinPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_ThongTinPhieuPhat.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTinPhieuPhat.Location = new System.Drawing.Point(1, 1);
            this.grp_ThongTinPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_ThongTinPhieuPhat.Name = "grp_ThongTinPhieuPhat";
            this.grp_ThongTinPhieuPhat.Size = new System.Drawing.Size(1183, 347);
            this.grp_ThongTinPhieuPhat.TabIndex = 16;
            this.grp_ThongTinPhieuPhat.Text = "Thông tin phiếu phạt";
            // 
            // txt_MaPhieuMuon
            // 
            this.txt_MaPhieuMuon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_MaPhieuMuon.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_MaPhieuMuon.BorderThickness = 2;
            this.txt_MaPhieuMuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaPhieuMuon.DefaultText = "";
            this.txt_MaPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaPhieuMuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaPhieuMuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaPhieuMuon.ForeColor = System.Drawing.Color.Black;
            this.txt_MaPhieuMuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaPhieuMuon.Location = new System.Drawing.Point(141, 48);
            this.txt_MaPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaPhieuMuon.Name = "txt_MaPhieuMuon";
            this.txt_MaPhieuMuon.PlaceholderText = "";
            this.txt_MaPhieuMuon.ReadOnly = true;
            this.txt_MaPhieuMuon.SelectedText = "";
            this.txt_MaPhieuMuon.Size = new System.Drawing.Size(239, 41);
            this.txt_MaPhieuMuon.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MaPhieuMuon.TabIndex = 133;
            // 
            // lbl_MaPhieuMuon
            // 
            this.lbl_MaPhieuMuon.AutoSize = true;
            this.lbl_MaPhieuMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaPhieuMuon.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaPhieuMuon.Location = new System.Drawing.Point(4, 70);
            this.lbl_MaPhieuMuon.Name = "lbl_MaPhieuMuon";
            this.lbl_MaPhieuMuon.Size = new System.Drawing.Size(143, 23);
            this.lbl_MaPhieuMuon.TabIndex = 132;
            this.lbl_MaPhieuMuon.Text = "Mã phiếu mượn:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TongTien.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TongTien.BorderThickness = 2;
            this.txt_TongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongTien.DefaultText = "";
            this.txt_TongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TongTien.ForeColor = System.Drawing.Color.Black;
            this.txt_TongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongTien.Location = new System.Drawing.Point(903, 135);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.PlaceholderText = "";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.SelectedText = "";
            this.txt_TongTien.Size = new System.Drawing.Size(255, 41);
            this.txt_TongTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TongTien.TabIndex = 126;
            // 
            // txt_TienMatSach
            // 
            this.txt_TienMatSach.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TienMatSach.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TienMatSach.BorderThickness = 2;
            this.txt_TienMatSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TienMatSach.DefaultText = "";
            this.txt_TienMatSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TienMatSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TienMatSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienMatSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienMatSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienMatSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TienMatSach.ForeColor = System.Drawing.Color.Black;
            this.txt_TienMatSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienMatSach.Location = new System.Drawing.Point(903, 87);
            this.txt_TienMatSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TienMatSach.Name = "txt_TienMatSach";
            this.txt_TienMatSach.PlaceholderText = "";
            this.txt_TienMatSach.ReadOnly = true;
            this.txt_TienMatSach.SelectedText = "";
            this.txt_TienMatSach.Size = new System.Drawing.Size(255, 41);
            this.txt_TienMatSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TienMatSach.TabIndex = 125;
            // 
            // txt_TienHuSach
            // 
            this.txt_TienHuSach.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TienHuSach.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TienHuSach.BorderThickness = 2;
            this.txt_TienHuSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TienHuSach.DefaultText = "";
            this.txt_TienHuSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TienHuSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TienHuSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienHuSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienHuSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienHuSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TienHuSach.ForeColor = System.Drawing.Color.Black;
            this.txt_TienHuSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienHuSach.Location = new System.Drawing.Point(903, 44);
            this.txt_TienHuSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TienHuSach.Name = "txt_TienHuSach";
            this.txt_TienHuSach.PlaceholderText = "";
            this.txt_TienHuSach.ReadOnly = true;
            this.txt_TienHuSach.SelectedText = "";
            this.txt_TienHuSach.Size = new System.Drawing.Size(251, 41);
            this.txt_TienHuSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TienHuSach.TabIndex = 124;
            // 
            // txt_TienTreHan
            // 
            this.txt_TienTreHan.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TienTreHan.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TienTreHan.BorderThickness = 2;
            this.txt_TienTreHan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TienTreHan.DefaultText = "";
            this.txt_TienTreHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TienTreHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TienTreHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienTreHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TienTreHan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienTreHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TienTreHan.ForeColor = System.Drawing.Color.Black;
            this.txt_TienTreHan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TienTreHan.Location = new System.Drawing.Point(545, 188);
            this.txt_TienTreHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TienTreHan.Name = "txt_TienTreHan";
            this.txt_TienTreHan.PlaceholderText = "";
            this.txt_TienTreHan.ReadOnly = true;
            this.txt_TienTreHan.SelectedText = "";
            this.txt_TienTreHan.Size = new System.Drawing.Size(235, 41);
            this.txt_TienTreHan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TienTreHan.TabIndex = 123;
            // 
            // btn_TaoPhieuPhat
            // 
            this.btn_TaoPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoPhieuPhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoPhieuPhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuPhat.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPhieuPhat.Location = new System.Drawing.Point(793, 271);
            this.btn_TaoPhieuPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaoPhieuPhat.Name = "btn_TaoPhieuPhat";
            this.btn_TaoPhieuPhat.Size = new System.Drawing.Size(180, 46);
            this.btn_TaoPhieuPhat.TabIndex = 122;
            this.btn_TaoPhieuPhat.Text = "Tạo phiếu phạt";
            this.btn_TaoPhieuPhat.Click += new System.EventHandler(this.btn_TaoPhieuPhat_Click);
            // 
            // txt_Thoat
            // 
            this.txt_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txt_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txt_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txt_Thoat.FillColor = System.Drawing.Color.DodgerBlue;
            this.txt_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thoat.ForeColor = System.Drawing.Color.White;
            this.txt_Thoat.Location = new System.Drawing.Point(1013, 271);
            this.txt_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Thoat.Name = "txt_Thoat";
            this.txt_Thoat.Size = new System.Drawing.Size(115, 46);
            this.txt_Thoat.TabIndex = 121;
            this.txt_Thoat.Text = "Thoát";
            this.txt_Thoat.Click += new System.EventHandler(this.txt_Thoat_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongTien.Location = new System.Drawing.Point(813, 159);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(95, 23);
            this.lbl_TongTien.TabIndex = 130;
            this.lbl_TongTien.Text = "Tổng Tiền:";
            // 
            // lbl_HuSach
            // 
            this.lbl_HuSach.AutoSize = true;
            this.lbl_HuSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HuSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HuSach.ForeColor = System.Drawing.Color.Black;
            this.lbl_HuSach.Location = new System.Drawing.Point(829, 66);
            this.lbl_HuSach.Name = "lbl_HuSach";
            this.lbl_HuSach.Size = new System.Drawing.Size(78, 23);
            this.lbl_HuSach.TabIndex = 128;
            this.lbl_HuSach.Text = "Hư sách:";
            // 
            // lbl_MatSach
            // 
            this.lbl_MatSach.AutoSize = true;
            this.lbl_MatSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MatSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatSach.ForeColor = System.Drawing.Color.Black;
            this.lbl_MatSach.Location = new System.Drawing.Point(821, 110);
            this.lbl_MatSach.Name = "lbl_MatSach";
            this.lbl_MatSach.Size = new System.Drawing.Size(86, 23);
            this.lbl_MatSach.TabIndex = 129;
            this.lbl_MatSach.Text = "Mất sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(475, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "Trễ hạn:";
            // 
            // chk_MatSach
            // 
            this.chk_MatSach.AutoSize = true;
            this.chk_MatSach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_MatSach.CheckedState.BorderRadius = 0;
            this.chk_MatSach.CheckedState.BorderThickness = 0;
            this.chk_MatSach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_MatSach.Location = new System.Drawing.Point(652, 153);
            this.chk_MatSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_MatSach.Name = "chk_MatSach";
            this.chk_MatSach.Size = new System.Drawing.Size(90, 24);
            this.chk_MatSach.TabIndex = 107;
            this.chk_MatSach.Text = "Mất sách";
            this.chk_MatSach.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_MatSach.UncheckedState.BorderRadius = 0;
            this.chk_MatSach.UncheckedState.BorderThickness = 0;
            this.chk_MatSach.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_MatSach.CheckedChanged += new System.EventHandler(this.chk_MatSach_CheckedChanged);
            // 
            // chk_HuSach
            // 
            this.chk_HuSach.AutoSize = true;
            this.chk_HuSach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_HuSach.CheckedState.BorderRadius = 0;
            this.chk_HuSach.CheckedState.BorderThickness = 0;
            this.chk_HuSach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chk_HuSach.Location = new System.Drawing.Point(555, 153);
            this.chk_HuSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_HuSach.Name = "chk_HuSach";
            this.chk_HuSach.Size = new System.Drawing.Size(84, 24);
            this.chk_HuSach.TabIndex = 106;
            this.chk_HuSach.Text = "Hư sách";
            this.chk_HuSach.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chk_HuSach.UncheckedState.BorderRadius = 0;
            this.chk_HuSach.UncheckedState.BorderThickness = 0;
            this.chk_HuSach.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txt_SoNgayTre
            // 
            this.txt_SoNgayTre.BackColor = System.Drawing.SystemColors.Control;
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
            this.txt_SoNgayTre.Location = new System.Drawing.Point(545, 95);
            this.txt_SoNgayTre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoNgayTre.Name = "txt_SoNgayTre";
            this.txt_SoNgayTre.PlaceholderText = "";
            this.txt_SoNgayTre.ReadOnly = true;
            this.txt_SoNgayTre.SelectedText = "";
            this.txt_SoNgayTre.Size = new System.Drawing.Size(235, 41);
            this.txt_SoNgayTre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoNgayTre.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(443, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 105;
            this.label2.Text = "Số ngày trễ:";
            // 
            // dtp_ngayThucTeTra
            // 
            this.dtp_ngayThucTeTra.Checked = true;
            this.dtp_ngayThucTeTra.Enabled = false;
            this.dtp_ngayThucTeTra.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_ngayThucTeTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayThucTeTra.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngayThucTeTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayThucTeTra.Location = new System.Drawing.Point(545, 57);
            this.dtp_ngayThucTeTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngayThucTeTra.MaxDate = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            this.dtp_ngayThucTeTra.MinDate = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            this.dtp_ngayThucTeTra.Name = "dtp_ngayThucTeTra";
            this.dtp_ngayThucTeTra.Size = new System.Drawing.Size(235, 31);
            this.dtp_ngayThucTeTra.TabIndex = 102;
            this.dtp_ngayThucTeTra.Value = new System.DateTime(2025, 5, 3, 0, 0, 0, 0);
            // 
            // lbl_NgayTraThucTe
            // 
            this.lbl_NgayTraThucTe.AutoSize = true;
            this.lbl_NgayTraThucTe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayTraThucTe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTraThucTe.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayTraThucTe.Location = new System.Drawing.Point(401, 62);
            this.lbl_NgayTraThucTe.Name = "lbl_NgayTraThucTe";
            this.lbl_NgayTraThucTe.Size = new System.Drawing.Size(147, 23);
            this.lbl_NgayTraThucTe.TabIndex = 101;
            this.lbl_NgayTraThucTe.Text = "Ngày trả thực tế:";
            // 
            // txt_maDocGia
            // 
            this.txt_maDocGia.BackColor = System.Drawing.SystemColors.Control;
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
            this.txt_maDocGia.Location = new System.Drawing.Point(141, 90);
            this.txt_maDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maDocGia.Name = "txt_maDocGia";
            this.txt_maDocGia.PlaceholderText = "";
            this.txt_maDocGia.ReadOnly = true;
            this.txt_maDocGia.SelectedText = "";
            this.txt_maDocGia.Size = new System.Drawing.Size(239, 41);
            this.txt_maDocGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_maDocGia.TabIndex = 100;
            // 
            // lbl_MaDocGia
            // 
            this.lbl_MaDocGia.AutoSize = true;
            this.lbl_MaDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDocGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaDocGia.Location = new System.Drawing.Point(42, 111);
            this.lbl_MaDocGia.Name = "lbl_MaDocGia";
            this.lbl_MaDocGia.Size = new System.Drawing.Size(104, 23);
            this.lbl_MaDocGia.TabIndex = 99;
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
            this.dtp_NgayTra.Location = new System.Drawing.Point(141, 231);
            this.dtp_NgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayTra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayTra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(239, 31);
            this.dtp_NgayTra.TabIndex = 98;
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
            this.dtp_NgayMuon.Location = new System.Drawing.Point(141, 187);
            this.dtp_NgayMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayMuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_NgayMuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(239, 31);
            this.dtp_NgayMuon.TabIndex = 97;
            this.dtp_NgayMuon.Value = new System.DateTime(2025, 5, 1, 18, 50, 42, 612);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.Color.Transparent;
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
            this.txt_HoTen.Location = new System.Drawing.Point(141, 135);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(239, 41);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 93;
            // 
            // lbl_NgayBatDauMuon
            // 
            this.lbl_NgayBatDauMuon.AutoSize = true;
            this.lbl_NgayBatDauMuon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayBatDauMuon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBatDauMuon.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayBatDauMuon.Location = new System.Drawing.Point(36, 191);
            this.lbl_NgayBatDauMuon.Name = "lbl_NgayBatDauMuon";
            this.lbl_NgayBatDauMuon.Size = new System.Drawing.Size(110, 23);
            this.lbl_NgayBatDauMuon.TabIndex = 96;
            this.lbl_NgayBatDauMuon.Text = "Ngày mượn:";
            // 
            // lbl_NgayTra
            // 
            this.lbl_NgayTra.AutoSize = true;
            this.lbl_NgayTra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NgayTra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayTra.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgayTra.Location = new System.Drawing.Point(60, 235);
            this.lbl_NgayTra.Name = "lbl_NgayTra";
            this.lbl_NgayTra.Size = new System.Drawing.Size(85, 23);
            this.lbl_NgayTra.TabIndex = 95;
            this.lbl_NgayTra.Text = "Ngày trả:";
            // 
            // lbl_TenDocGia
            // 
            this.lbl_TenDocGia.AutoSize = true;
            this.lbl_TenDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TenDocGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDocGia.ForeColor = System.Drawing.Color.Black;
            this.lbl_TenDocGia.Location = new System.Drawing.Point(76, 156);
            this.lbl_TenDocGia.Name = "lbl_TenDocGia";
            this.lbl_TenDocGia.Size = new System.Drawing.Size(69, 23);
            this.lbl_TenDocGia.TabIndex = 94;
            this.lbl_TenDocGia.Text = "Họ tên:";
            // 
            // lbl_LyDoPhat
            // 
            this.lbl_LyDoPhat.AutoSize = true;
            this.lbl_LyDoPhat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LyDoPhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LyDoPhat.ForeColor = System.Drawing.Color.Black;
            this.lbl_LyDoPhat.Location = new System.Drawing.Point(451, 154);
            this.lbl_LyDoPhat.Name = "lbl_LyDoPhat";
            this.lbl_LyDoPhat.Size = new System.Drawing.Size(101, 23);
            this.lbl_LyDoPhat.TabIndex = 103;
            this.lbl_LyDoPhat.Text = "Lý do phạt:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(1053, 354);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(128, 49);
            this.btn_TimKiem.TabIndex = 135;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TimKiem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TimKiem.BorderThickness = 2;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(479, 354);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm phiếu mượn";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(577, 49);
            this.txt_TimKiem.TabIndex = 134;
            // 
            // ucPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.grp_ThongTinPhieuPhat);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.grp_DanhSachPhieuMuon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucPhieuPhat";
            this.Size = new System.Drawing.Size(1185, 756);
            this.Load += new System.EventHandler(this.ucPhieuPhat_Load);
            this.grp_DanhSachPhieuMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhieuMuon)).EndInit();
            this.grp_ThongTinPhieuPhat.ResumeLayout(false);
            this.grp_ThongTinPhieuPhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grp_DanhSachPhieuMuon;
        private Guna.UI2.WinForms.Guna2GroupBox grp_ThongTinPhieuPhat;
        private Guna.UI2.WinForms.Guna2CheckBox chk_MatSach;
        private Guna.UI2.WinForms.Guna2CheckBox chk_HuSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoNgayTre;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayThucTeTra;
        private System.Windows.Forms.Label lbl_NgayTraThucTe;
        private Guna.UI2.WinForms.Guna2TextBox txt_maDocGia;
        private System.Windows.Forms.Label lbl_MaDocGia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayTra;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NgayMuon;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_NgayBatDauMuon;
        private System.Windows.Forms.Label lbl_NgayTra;
        private System.Windows.Forms.Label lbl_TenDocGia;
        private System.Windows.Forms.Label lbl_LyDoPhat;
        private Guna.UI2.WinForms.Guna2TextBox txt_TongTien;
        private Guna.UI2.WinForms.Guna2TextBox txt_TienMatSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TienHuSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TienTreHan;
        private Guna.UI2.WinForms.Guna2Button btn_TaoPhieuPhat;
        private Guna.UI2.WinForms.Guna2Button txt_Thoat;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_HuSach;
        private System.Windows.Forms.Label lbl_MatSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DSPhieuMuon;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaPhieuMuon;
        private System.Windows.Forms.Label lbl_MaPhieuMuon;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
    }
}
