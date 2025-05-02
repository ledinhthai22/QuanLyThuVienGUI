namespace QuanLyThuVienGUI
{
    partial class frmXoaDocGia
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
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.lblThemThongTin = new System.Windows.Forms.Label();
            this.pn_Tab = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_MaDocGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MaDocGia = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thoat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(244, 362);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(89, 46);
            this.btn_Thoat.TabIndex = 77;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblThemThongTin
            // 
            this.lblThemThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThemThongTin.AutoSize = true;
            this.lblThemThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemThongTin.Location = new System.Drawing.Point(75, 102);
            this.lblThemThongTin.Name = "lblThemThongTin";
            this.lblThemThongTin.Size = new System.Drawing.Size(0, 23);
            this.lblThemThongTin.TabIndex = 75;
            // 
            // pn_Tab
            // 
            this.pn_Tab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Tab.Controls.Add(this.lbl_Title);
            this.pn_Tab.Location = new System.Drawing.Point(-1, 0);
            this.pn_Tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Tab.Name = "pn_Tab";
            this.pn_Tab.Size = new System.Drawing.Size(448, 30);
            this.pn_Tab.TabIndex = 62;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(163, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(122, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "XÓA ĐỘC GIẢ";
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
            this.txt_Email.Location = new System.Drawing.Point(140, 250);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(255, 37);
            this.txt_Email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Email.TabIndex = 74;
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
            this.txt_HoTen.Location = new System.Drawing.Point(143, 86);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(252, 37);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 67;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(65, 106);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(70, 23);
            this.lbl_HoTen.TabIndex = 63;
            this.lbl_HoTen.Text = "Họ Tên:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(75, 267);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(59, 23);
            this.lbl_Email.TabIndex = 73;
            this.lbl_Email.Text = "Email:";
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
            this.txt_SoDienThoai.Location = new System.Drawing.Point(140, 212);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_SoDienThoai.PlaceholderText = "";
            this.txt_SoDienThoai.ReadOnly = true;
            this.txt_SoDienThoai.SelectedText = "";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(255, 37);
            this.txt_SoDienThoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoDienThoai.TabIndex = 72;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(51, 181);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(85, 23);
            this.lbl_GioiTinh.TabIndex = 65;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(5, 224);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(121, 23);
            this.lbl_SoDienThoai.TabIndex = 71;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // rad_Nu
            // 
            this.rad_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Enabled = false;
            this.rad_Nu.Location = new System.Drawing.Point(211, 185);
            this.rad_Nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 70;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
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
            this.txt_DiaChi.Location = new System.Drawing.Point(140, 294);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(255, 39);
            this.txt_DiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_DiaChi.TabIndex = 61;
            // 
            // rad_Nam
            // 
            this.rad_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Checked = true;
            this.rad_Nam.Enabled = false;
            this.rad_Nam.Location = new System.Drawing.Point(148, 185);
            this.rad_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 69;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaySinh.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(143, 137);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(252, 33);
            this.dtpNgaySinh.TabIndex = 68;
            this.dtpNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 3, 19, 10, 25, 14, 821);
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(41, 139);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(94, 23);
            this.lbl_NgaySinh.TabIndex = 64;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(63, 310);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(70, 23);
            this.lbl_DiaChi.TabIndex = 66;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaDocGia.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_MaDocGia.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_MaDocGia.BorderThickness = 2;
            this.txt_MaDocGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDocGia.DefaultText = "";
            this.txt_MaDocGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaDocGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaDocGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaDocGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaDocGia.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MaDocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaDocGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaDocGia.ForeColor = System.Drawing.Color.Black;
            this.txt_MaDocGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaDocGia.Location = new System.Drawing.Point(143, 46);
            this.txt_MaDocGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_MaDocGia.PlaceholderText = "";
            this.txt_MaDocGia.ReadOnly = true;
            this.txt_MaDocGia.SelectedText = "";
            this.txt_MaDocGia.Size = new System.Drawing.Size(252, 37);
            this.txt_MaDocGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MaDocGia.TabIndex = 79;
            // 
            // lbl_MaDocGia
            // 
            this.lbl_MaDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaDocGia.AutoSize = true;
            this.lbl_MaDocGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDocGia.Location = new System.Drawing.Point(29, 59);
            this.lbl_MaDocGia.Name = "lbl_MaDocGia";
            this.lbl_MaDocGia.Size = new System.Drawing.Size(104, 23);
            this.lbl_MaDocGia.TabIndex = 78;
            this.lbl_MaDocGia.Text = "Mã độc giả:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(121, 362);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_Xoa.TabIndex = 76;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frmXoaDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 425);
            this.Controls.Add(this.txt_MaDocGia);
            this.Controls.Add(this.lbl_MaDocGia);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lblThemThongTin);
            this.Controls.Add(this.pn_Tab);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_DiaChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXoaDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXoaDocGia";
            this.Load += new System.EventHandler(this.frmXoaDocGia_Load);
            this.pn_Tab.ResumeLayout(false);
            this.pn_Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Thoat;
        private System.Windows.Forms.Label lblThemThongTin;
        private System.Windows.Forms.Panel pn_Tab;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.RadioButton rad_Nu;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private System.Windows.Forms.RadioButton rad_Nam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_DiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaDocGia;
        private System.Windows.Forms.Label lbl_MaDocGia;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
    }
}