namespace QuanLyThuVienGUI
{
    partial class frmQuanLySach
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
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.pic_HinhAnhSach = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_TaoMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ChonHinh = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.lbl_NamXB = new System.Windows.Forms.Label();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.lblCategoryCode = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.dtp_NamXB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_TacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnframeInformation = new System.Windows.Forms.Panel();
            this.btn_KhoiPhuc = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.radTimTheoTheLoai = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.rad_TimTheoTenSach = new System.Windows.Forms.RadioButton();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_MaTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_MoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.dgv_DSSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnhSach)).BeginInit();
            this.pnframeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(598, 96);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(692, 96);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 37);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(778, 96);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(67, 37);
            this.btn_Sua.TabIndex = 22;
            this.btn_Sua.Text = "Sửa";
            // 
            // pic_HinhAnhSach
            // 
            this.pic_HinhAnhSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pic_HinhAnhSach.ImageRotate = 0F;
            this.pic_HinhAnhSach.Location = new System.Drawing.Point(3, 3);
            this.pic_HinhAnhSach.Margin = new System.Windows.Forms.Padding(2);
            this.pic_HinhAnhSach.Name = "pic_HinhAnhSach";
            this.pic_HinhAnhSach.Size = new System.Drawing.Size(109, 119);
            this.pic_HinhAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_HinhAnhSach.TabIndex = 24;
            this.pic_HinhAnhSach.TabStop = false;
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TaoMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_TaoMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoMoi.Location = new System.Drawing.Point(486, 96);
            this.btn_TaoMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(85, 37);
            this.btn_TaoMoi.TabIndex = 27;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ChonHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ChonHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ChonHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ChonHinh.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ChonHinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonHinh.ForeColor = System.Drawing.Color.White;
            this.btn_ChonHinh.Location = new System.Drawing.Point(7, 131);
            this.btn_ChonHinh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.Size = new System.Drawing.Size(98, 34);
            this.btn_ChonHinh.TabIndex = 28;
            this.btn_ChonHinh.Text = "Chọn ảnh";
            this.btn_ChonHinh.Click += new System.EventHandler(this.btn_ChonHinh_Click);
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSach.Location = new System.Drawing.Point(163, 14);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(65, 17);
            this.lbl_TenSach.TabIndex = 0;
            this.lbl_TenSach.Text = "Tên sách:";
            // 
            // lbl_NamXB
            // 
            this.lbl_NamXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NamXB.AutoSize = true;
            this.lbl_NamXB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamXB.Location = new System.Drawing.Point(128, 148);
            this.lbl_NamXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NamXB.Name = "lbl_NamXB";
            this.lbl_NamXB.Size = new System.Drawing.Size(99, 17);
            this.lbl_NamXB.TabIndex = 4;
            this.lbl_NamXB.Text = "Năm xuất bản:";
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TacGia.Location = new System.Drawing.Point(172, 49);
            this.lbl_TacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(55, 17);
            this.lbl_TacGia.TabIndex = 1;
            this.lbl_TacGia.Text = "Tác giả:";
            // 
            // lblCategoryCode
            // 
            this.lblCategoryCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryCode.AutoSize = true;
            this.lblCategoryCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryCode.Location = new System.Drawing.Point(145, 116);
            this.lblCategoryCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryCode.Name = "lblCategoryCode";
            this.lblCategoryCode.Size = new System.Drawing.Size(59, 17);
            this.lblCategoryCode.TabIndex = 2;
            this.lblCategoryCode.Text = "thể loại:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(133, 82);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(95, 17);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Nhà xuất bản:";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(159, 181);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(68, 17);
            this.lbl_SoLuong.TabIndex = 5;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // dtp_NamXB
            // 
            this.dtp_NamXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NamXB.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NamXB.Checked = true;
            this.dtp_NamXB.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NamXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NamXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NamXB.Location = new System.Drawing.Point(225, 145);
            this.dtp_NamXB.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NamXB.MaxDate = new System.DateTime(2025, 3, 19, 23, 24, 5, 0);
            this.dtp_NamXB.MinDate = new System.DateTime(1809, 1, 1, 0, 0, 0, 0);
            this.dtp_NamXB.Name = "dtp_NamXB";
            this.dtp_NamXB.Size = new System.Drawing.Size(202, 27);
            this.dtp_NamXB.TabIndex = 10;
            this.dtp_NamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_NamXB.Value = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TacGia.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TacGia.BorderThickness = 2;
            this.txt_TacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TacGia.DefaultText = "";
            this.txt_TacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TacGia.FillColor = System.Drawing.SystemColors.Control;
            this.txt_TacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TacGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TacGia.ForeColor = System.Drawing.Color.Black;
            this.txt_TacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TacGia.Location = new System.Drawing.Point(225, 35);
            this.txt_TacGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TacGia.PlaceholderText = "";
            this.txt_TacGia.SelectedText = "";
            this.txt_TacGia.Size = new System.Drawing.Size(200, 29);
            this.txt_TacGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TacGia.TabIndex = 15;
            // 
            // txt_NXB
            // 
            this.txt_NXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NXB.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_NXB.BorderThickness = 2;
            this.txt_NXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NXB.DefaultText = "";
            this.txt_NXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NXB.FillColor = System.Drawing.SystemColors.Control;
            this.txt_NXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NXB.ForeColor = System.Drawing.Color.Black;
            this.txt_NXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NXB.Location = new System.Drawing.Point(225, 69);
            this.txt_NXB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_NXB.Name = "txt_NXB";
            this.txt_NXB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_NXB.PlaceholderText = "";
            this.txt_NXB.SelectedText = "";
            this.txt_NXB.Size = new System.Drawing.Size(200, 30);
            this.txt_NXB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_NXB.TabIndex = 17;
            // 
            // pnframeInformation
            // 
            this.pnframeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnframeInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnframeInformation.Controls.Add(this.btn_KhoiPhuc);
            this.pnframeInformation.Controls.Add(this.cbo_TrangThai);
            this.pnframeInformation.Controls.Add(this.numSoLuong);
            this.pnframeInformation.Controls.Add(this.pnSearch);
            this.pnframeInformation.Controls.Add(this.cbo_MaTheLoai);
            this.pnframeInformation.Controls.Add(this.btn_TaoMoi);
            this.pnframeInformation.Controls.Add(this.btn_Xoa);
            this.pnframeInformation.Controls.Add(this.btn_ChonHinh);
            this.pnframeInformation.Controls.Add(this.txt_NXB);
            this.pnframeInformation.Controls.Add(this.btn_Sua);
            this.pnframeInformation.Controls.Add(this.lblPublisher);
            this.pnframeInformation.Controls.Add(this.btn_Them);
            this.pnframeInformation.Controls.Add(this.txt_MoTa);
            this.pnframeInformation.Controls.Add(this.pic_HinhAnhSach);
            this.pnframeInformation.Controls.Add(this.txt_TenSach);
            this.pnframeInformation.Controls.Add(this.lbl_TenSach);
            this.pnframeInformation.Controls.Add(this.txt_TacGia);
            this.pnframeInformation.Controls.Add(this.lbl_TacGia);
            this.pnframeInformation.Controls.Add(this.dtp_NamXB);
            this.pnframeInformation.Controls.Add(this.lblCategoryCode);
            this.pnframeInformation.Controls.Add(this.lbl_SoLuong);
            this.pnframeInformation.Controls.Add(this.lbl_NamXB);
            this.pnframeInformation.Controls.Add(this.lbl_MoTa);
            this.pnframeInformation.Location = new System.Drawing.Point(0, 0);
            this.pnframeInformation.Name = "pnframeInformation";
            this.pnframeInformation.Size = new System.Drawing.Size(891, 263);
            this.pnframeInformation.TabIndex = 32;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_KhoiPhuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhoiPhuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhoiPhuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KhoiPhuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KhoiPhuc.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(718, 156);
            this.btn_KhoiPhuc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(93, 29);
            this.btn_KhoiPhuc.TabIndex = 50;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbo_TrangThai.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbo_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_TrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_TrangThai.ItemHeight = 30;
            this.cbo_TrangThai.Location = new System.Drawing.Point(525, 156);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(184, 36);
            this.cbo_TrangThai.TabIndex = 49;
            this.cbo_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cbo_TrangThai_SelectedIndexChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.FillColor = System.Drawing.Color.DodgerBlue;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(225, 177);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(202, 24);
            this.numSoLuong.TabIndex = 32;
            this.numSoLuong.UpDownButtonFillColor = System.Drawing.Color.DodgerBlue;
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.Controls.Add(this.radTimTheoTheLoai);
            this.pnSearch.Controls.Add(this.txt_TimKiem);
            this.pnSearch.Controls.Add(this.rad_TimTheoTenSach);
            this.pnSearch.Controls.Add(this.btn_TimKiem);
            this.pnSearch.Location = new System.Drawing.Point(-1, 210);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(891, 49);
            this.pnSearch.TabIndex = 48;
            // 
            // radTimTheoTheLoai
            // 
            this.radTimTheoTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimTheoTheLoai.AutoSize = true;
            this.radTimTheoTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimTheoTheLoai.Location = new System.Drawing.Point(125, 26);
            this.radTimTheoTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.radTimTheoTheLoai.Name = "radTimTheoTheLoai";
            this.radTimTheoTheLoai.Size = new System.Drawing.Size(177, 23);
            this.radTimTheoTheLoai.TabIndex = 47;
            this.radTimTheoTheLoai.Text = "Tìm kiếm theo thể loại";
            this.radTimTheoTheLoai.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TimKiem.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TimKiem.BorderThickness = 2;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.DefaultText = "";
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiem.Location = new System.Drawing.Point(333, 7);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(332, 39);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // rad_TimTheoTenSach
            // 
            this.rad_TimTheoTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_TimTheoTenSach.AutoSize = true;
            this.rad_TimTheoTenSach.Checked = true;
            this.rad_TimTheoTenSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimTheoTenSach.Location = new System.Drawing.Point(125, 2);
            this.rad_TimTheoTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.rad_TimTheoTenSach.Name = "rad_TimTheoTenSach";
            this.rad_TimTheoTenSach.Size = new System.Drawing.Size(181, 23);
            this.rad_TimTheoTenSach.TabIndex = 46;
            this.rad_TimTheoTenSach.TabStop = true;
            this.rad_TimTheoTenSach.Text = "Tìm kiếm theo tên sách";
            this.rad_TimTheoTenSach.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(665, 7);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 39);
            this.btn_TimKiem.TabIndex = 45;
            this.btn_TimKiem.Text = "Tìm kiếm";
            // 
            // cbo_MaTheLoai
            // 
            this.cbo_MaTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_MaTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbo_MaTheLoai.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbo_MaTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_MaTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_MaTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_MaTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_MaTheLoai.ItemHeight = 30;
            this.cbo_MaTheLoai.Location = new System.Drawing.Point(225, 105);
            this.cbo_MaTheLoai.Name = "cbo_MaTheLoai";
            this.cbo_MaTheLoai.Size = new System.Drawing.Size(200, 36);
            this.cbo_MaTheLoai.TabIndex = 29;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MoTa.AutoSize = true;
            this.txt_MoTa.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_MoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MoTa.DefaultText = "";
            this.txt_MoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MoTa.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MoTa.ForeColor = System.Drawing.Color.Black;
            this.txt_MoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MoTa.Location = new System.Drawing.Point(486, 3);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_MoTa.PlaceholderText = "";
            this.txt_MoTa.SelectedText = "";
            this.txt_MoTa.Size = new System.Drawing.Size(358, 73);
            this.txt_MoTa.TabIndex = 31;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenSach.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TenSach.BorderThickness = 2;
            this.txt_TenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenSach.CustomizableEdges.TopLeft = false;
            this.txt_TenSach.DefaultText = "";
            this.txt_TenSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenSach.FillColor = System.Drawing.SystemColors.Control;
            this.txt_TenSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenSach.ForeColor = System.Drawing.Color.Black;
            this.txt_TenSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenSach.Location = new System.Drawing.Point(225, 1);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TenSach.PlaceholderText = "";
            this.txt_TenSach.SelectedText = "";
            this.txt_TenSach.Size = new System.Drawing.Size(200, 28);
            this.txt_TenSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TenSach.TabIndex = 12;
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(439, 5);
            this.lbl_MoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(48, 17);
            this.lbl_MoTa.TabIndex = 30;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // dgv_DSSach
            // 
            this.dgv_DSSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSach.Location = new System.Drawing.Point(1, 263);
            this.dgv_DSSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSSach.Name = "dgv_DSSach";
            this.dgv_DSSach.ReadOnly = true;
            this.dgv_DSSach.RowHeadersWidth = 51;
            this.dgv_DSSach.RowTemplate.Height = 24;
            this.dgv_DSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSach.Size = new System.Drawing.Size(891, 352);
            this.dgv_DSSach.TabIndex = 49;
            this.dgv_DSSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSSach_CellClick);
            this.dgv_DSSach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSSach_CellFormatting);
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.dgv_DSSach);
            this.Controls.Add(this.pnframeInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnhSach)).EndInit();
            this.pnframeInformation.ResumeLayout(false);
            this.pnframeInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2PictureBox pic_HinhAnhSach;
        private Guna.UI2.WinForms.Guna2Button btn_TaoMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ChonHinh;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_NamXB;
        private System.Windows.Forms.Label lbl_TacGia;
        private System.Windows.Forms.Label lblCategoryCode;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lbl_SoLuong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NamXB;
        private Guna.UI2.WinForms.Guna2TextBox txt_TacGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_NXB;
        private System.Windows.Forms.Panel pnframeInformation;
        private System.Windows.Forms.RadioButton radTimTheoTheLoai;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private System.Windows.Forms.RadioButton rad_TimTheoTenSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.DataGridView dgv_DSSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenSach;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_MaTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_MoTa;
        private System.Windows.Forms.Label lbl_MoTa;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2Button btn_KhoiPhuc;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_TrangThai;
    }
}