namespace QuanLyThuVienGUI.admin
{
    partial class frmQuanLyDocGia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDocGia));
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_ThongTinDocGia = new System.Windows.Forms.Panel();
            this.btnKhoiPhuc = new Guna.UI2.WinForms.Guna2Button();
            this.cbo_TrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblThemThongTin = new System.Windows.Forms.Label();
            this.rad_TimTheoSDT = new System.Windows.Forms.RadioButton();
            this.rad_TimTheoHoTen = new System.Windows.Forms.RadioButton();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TaoMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_DSDocGia = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pn_ThongTinDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(428, 134);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(73, 37);
            this.btn_Sua.TabIndex = 34;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(348, 134);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 37);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DiaChi.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_DiaChi.BorderThickness = 2;
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.DefaultText = "";
            this.txt_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.FillColor = System.Drawing.SystemColors.Control;
            this.txt_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(540, 6);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(191, 30);
            this.txt_DiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_DiaChi.TabIndex = 31;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_HoTen.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_HoTen.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_HoTen.BorderThickness = 2;
            this.txt_HoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTen.DefaultText = "";
            this.txt_HoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_HoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_HoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTen.FillColor = System.Drawing.SystemColors.Control;
            this.txt_HoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTen.Location = new System.Drawing.Point(223, 6);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(189, 30);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 28;
            this.txt_HoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HoTen_KeyPress);
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(485, 20);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(58, 19);
            this.lbl_DiaChi.TabIndex = 27;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(157, 82);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(69, 19);
            this.lbl_GioiTinh.TabIndex = 26;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(149, 49);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(79, 19);
            this.lbl_NgaySinh.TabIndex = 25;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(166, 20);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(60, 19);
            this.lbl_HoTen.TabIndex = 24;
            this.lbl_HoTen.Text = "Họ Tên:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaySinh.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(226, 46);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(189, 27);
            this.dtpNgaySinh.TabIndex = 36;
            this.dtpNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 3, 19, 10, 25, 14, 821);
            // 
            // rad_Nam
            // 
            this.rad_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Location = new System.Drawing.Point(225, 85);
            this.rad_Nam.Margin = new System.Windows.Forms.Padding(2);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(47, 17);
            this.rad_Nam.TabIndex = 37;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // rad_Nu
            // 
            this.rad_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(276, 84);
            this.rad_Nu.Margin = new System.Windows.Forms.Padding(2);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(39, 17);
            this.rad_Nu.TabIndex = 38;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(442, 55);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(101, 19);
            this.lbl_SoDienThoai.TabIndex = 39;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SoDienThoai.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_SoDienThoai.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_SoDienThoai.BorderThickness = 2;
            this.txt_SoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoDienThoai.DefaultText = "";
            this.txt_SoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoDienThoai.FillColor = System.Drawing.SystemColors.Control;
            this.txt_SoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.txt_SoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(540, 41);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_SoDienThoai.PlaceholderText = "";
            this.txt_SoDienThoai.SelectedText = "";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(191, 30);
            this.txt_SoDienThoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoDienThoai.TabIndex = 40;
            this.txt_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDienThoai_KeyPress);
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(494, 91);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 19);
            this.lbl_Email.TabIndex = 41;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Email.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_Email.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Email.BorderThickness = 2;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FillColor = System.Drawing.SystemColors.Control;
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(540, 76);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(191, 30);
            this.txt_Email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Email.TabIndex = 42;
            // 
            // pn_ThongTinDocGia
            // 
            this.pn_ThongTinDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinDocGia.Controls.Add(this.rad_TimTheoSDT);
            this.pn_ThongTinDocGia.Controls.Add(this.btnKhoiPhuc);
            this.pn_ThongTinDocGia.Controls.Add(this.rad_TimTheoHoTen);
            this.pn_ThongTinDocGia.Controls.Add(this.cbo_TrangThai);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.lblThemThongTin);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TaoMoi);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_Email);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_HoTen);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_Email);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_SoDienThoai);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_SoDienThoai);
            this.pn_ThongTinDocGia.Controls.Add(this.rad_Nu);
            this.pn_ThongTinDocGia.Controls.Add(this.rad_Nam);
            this.pn_ThongTinDocGia.Controls.Add(this.dtpNgaySinh);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Sua);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Them);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Xoa);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_DiaChi);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_DiaChi);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_GioiTinh);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_NgaySinh);
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_HoTen);
            this.pn_ThongTinDocGia.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.pn_ThongTinDocGia.Name = "pn_ThongTinDocGia";
            this.pn_ThongTinDocGia.Size = new System.Drawing.Size(874, 239);
            this.pn_ThongTinDocGia.TabIndex = 44;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKhoiPhuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoiPhuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoiPhuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoiPhuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoiPhuc.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(648, 133);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(97, 37);
            this.btnKhoiPhuc.TabIndex = 48;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
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
            this.cbo_TrangThai.Location = new System.Drawing.Point(513, 134);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(130, 36);
            this.cbo_TrangThai.TabIndex = 47;
            this.cbo_TrangThai.SelectedIndexChanged += new System.EventHandler(this.cbo_TrangThai_SelectedIndexChanged);
            // 
            // lblThemThongTin
            // 
            this.lblThemThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThemThongTin.AutoSize = true;
            this.lblThemThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemThongTin.Location = new System.Drawing.Point(179, 19);
            this.lblThemThongTin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemThongTin.Name = "lblThemThongTin";
            this.lblThemThongTin.Size = new System.Drawing.Size(0, 19);
            this.lblThemThongTin.TabIndex = 44;
            // 
            // rad_TimTheoSDT
            // 
            this.rad_TimTheoSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_TimTheoSDT.AutoSize = true;
            this.rad_TimTheoSDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimTheoSDT.Location = new System.Drawing.Point(147, 209);
            this.rad_TimTheoSDT.Margin = new System.Windows.Forms.Padding(2);
            this.rad_TimTheoSDT.Name = "rad_TimTheoSDT";
            this.rad_TimTheoSDT.Size = new System.Drawing.Size(179, 23);
            this.rad_TimTheoSDT.TabIndex = 47;
            this.rad_TimTheoSDT.TabStop = true;
            this.rad_TimTheoSDT.Text = "Tìm kiếm số điện thoại";
            this.rad_TimTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rad_TimTheoHoTen
            // 
            this.rad_TimTheoHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_TimTheoHoTen.AutoSize = true;
            this.rad_TimTheoHoTen.Checked = true;
            this.rad_TimTheoHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_TimTheoHoTen.Location = new System.Drawing.Point(45, 182);
            this.rad_TimTheoHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.rad_TimTheoHoTen.Name = "rad_TimTheoHoTen";
            this.rad_TimTheoHoTen.Size = new System.Drawing.Size(135, 23);
            this.rad_TimTheoHoTen.TabIndex = 46;
            this.rad_TimTheoHoTen.TabStop = true;
            this.rad_TimTheoHoTen.Text = "Tìm kiếm họ tên";
            this.rad_TimTheoHoTen.UseVisualStyleBackColor = true;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(778, 197);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 39);
            this.btn_TimKiem.TabIndex = 45;
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
            this.txt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiem.Location = new System.Drawing.Point(446, 197);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(332, 39);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TimKiem_KeyPress_1);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TaoMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TaoMoi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoMoi.Location = new System.Drawing.Point(158, 134);
            this.btn_TaoMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(105, 37);
            this.btn_TaoMoi.TabIndex = 43;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(270, 134);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_DSDocGia
            // 
            this.dgv_DSDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDocGia.Location = new System.Drawing.Point(-2, 237);
            this.dgv_DSDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSDocGia.Name = "dgv_DSDocGia";
            this.dgv_DSDocGia.ReadOnly = true;
            this.dgv_DSDocGia.RowHeadersWidth = 51;
            this.dgv_DSDocGia.RowTemplate.Height = 24;
            this.dgv_DSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDocGia.Size = new System.Drawing.Size(875, 353);
            this.dgv_DSDocGia.TabIndex = 47;
            this.dgv_DSDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSDocGia_CellClick);
            this.dgv_DSDocGia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSDocGia_CellFormatting);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_32px.png");
            this.imageList1.Images.SetKeyName(1, "edit_32px.png");
            this.imageList1.Images.SetKeyName(2, "replace_32px.png");
            this.imageList1.Images.SetKeyName(3, "trash_32px.png");
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 590);
            this.Controls.Add(this.dgv_DSDocGia);
            this.Controls.Add(this.pn_ThongTinDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.pn_ThongTinDocGia.ResumeLayout(false);
            this.pn_ThongTinDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private System.Windows.Forms.Panel pn_ThongTinDocGia;
        private System.Windows.Forms.Label lblThemThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private System.Windows.Forms.RadioButton rad_TimTheoSDT;
        private System.Windows.Forms.RadioButton rad_TimTheoHoTen;
        private System.Windows.Forms.DataGridView dgv_DSDocGia;
        private Guna.UI2.WinForms.Guna2Button btn_TaoMoi;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_TrangThai;
        private Guna.UI2.WinForms.Guna2Button btnKhoiPhuc;
        private System.Windows.Forms.ImageList imageList1;
    }
}