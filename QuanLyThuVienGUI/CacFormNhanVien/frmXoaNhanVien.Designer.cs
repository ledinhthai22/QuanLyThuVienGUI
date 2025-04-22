namespace QuanLyThuVienGUI.CacFormNhanVien
{
    partial class frmXoaNhanVien
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
            this.cbo_ChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Tab = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_PassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.txt_Luong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.txt_MaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.pn_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbo_ChucVu.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cbo_ChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChucVu.Enabled = false;
            this.cbo_ChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_ChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_ChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_ChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_ChucVu.ItemHeight = 30;
            this.cbo_ChucVu.Items.AddRange(new object[] {
            "admin",
            "thuthu"});
            this.cbo_ChucVu.Location = new System.Drawing.Point(142, 130);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(254, 36);
            this.cbo_ChucVu.TabIndex = 137;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(240, 456);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(97, 46);
            this.btn_Huy.TabIndex = 136;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(113, 456);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(97, 46);
            this.btn_Xoa.TabIndex = 135;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // pn_Tab
            // 
            this.pn_Tab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Tab.Controls.Add(this.lbl_Title);
            this.pn_Tab.Location = new System.Drawing.Point(-2, 0);
            this.pn_Tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Tab.Name = "pn_Tab";
            this.pn_Tab.Size = new System.Drawing.Size(440, 30);
            this.pn_Tab.TabIndex = 134;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(152, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(145, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "XÓA NHÂN VIÊN";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_PassWord.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_PassWord.BorderThickness = 2;
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PassWord.DefaultText = "";
            this.txt_PassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_PassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_PassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_PassWord.FillColor = System.Drawing.SystemColors.Control;
            this.txt_PassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PassWord.ForeColor = System.Drawing.Color.Black;
            this.txt_PassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_PassWord.Location = new System.Drawing.Point(141, 362);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_PassWord.PlaceholderText = "";
            this.txt_PassWord.ReadOnly = true;
            this.txt_PassWord.SelectedText = "";
            this.txt_PassWord.Size = new System.Drawing.Size(253, 37);
            this.txt_PassWord.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_PassWord.TabIndex = 133;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(46, 378);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(91, 23);
            this.lbl_MatKhau.TabIndex = 132;
            this.lbl_MatKhau.Text = "Mật khẩu:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_UserName.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_UserName.BorderThickness = 2;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.DefaultText = "";
            this.txt_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName.FillColor = System.Drawing.SystemColors.Control;
            this.txt_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_UserName.ForeColor = System.Drawing.Color.Black;
            this.txt_UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName.Location = new System.Drawing.Point(142, 321);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_UserName.PlaceholderText = "";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.Size = new System.Drawing.Size(252, 37);
            this.txt_UserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_UserName.TabIndex = 131;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(19, 335);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(122, 23);
            this.lbl_UserName.TabIndex = 130;
            this.lbl_UserName.Text = "Tên tài khoản:";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChucVu.Location = new System.Drawing.Point(61, 134);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(79, 23);
            this.lbl_ChucVu.TabIndex = 129;
            this.lbl_ChucVu.Text = "Chức vụ:";
            // 
            // txt_Luong
            // 
            this.txt_Luong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Luong.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Luong.BorderThickness = 2;
            this.txt_Luong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Luong.DefaultText = "";
            this.txt_Luong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Luong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Luong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Luong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Luong.FillColor = System.Drawing.SystemColors.Control;
            this.txt_Luong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Luong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Luong.ForeColor = System.Drawing.Color.Black;
            this.txt_Luong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Luong.Location = new System.Drawing.Point(139, 401);
            this.txt_Luong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Luong.Name = "txt_Luong";
            this.txt_Luong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Luong.PlaceholderText = "";
            this.txt_Luong.ReadOnly = true;
            this.txt_Luong.SelectedText = "";
            this.txt_Luong.Size = new System.Drawing.Size(255, 37);
            this.txt_Luong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Luong.TabIndex = 128;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txt_HoTen.Location = new System.Drawing.Point(140, 79);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(252, 37);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 120;
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Luong.Location = new System.Drawing.Point(68, 415);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(67, 23);
            this.lbl_Luong.TabIndex = 127;
            this.lbl_Luong.Text = "Lương:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txt_SoDienThoai.Location = new System.Drawing.Point(142, 239);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_SoDienThoai.PlaceholderText = "";
            this.txt_SoDienThoai.ReadOnly = true;
            this.txt_SoDienThoai.SelectedText = "";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(251, 37);
            this.txt_SoDienThoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_SoDienThoai.TabIndex = 126;
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(19, 253);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(121, 23);
            this.lbl_SoDienThoai.TabIndex = 125;
            this.lbl_SoDienThoai.Text = "Số điện thoại:";
            // 
            // rad_Nu
            // 
            this.rad_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Enabled = false;
            this.rad_Nu.Location = new System.Drawing.Point(216, 171);
            this.rad_Nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(45, 20);
            this.rad_Nu.TabIndex = 124;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Enabled = false;
            this.rad_Nam.Location = new System.Drawing.Point(153, 173);
            this.rad_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(57, 20);
            this.rad_Nam.TabIndex = 123;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(144, 203);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(252, 33);
            this.dtpNgaySinh.TabIndex = 122;
            this.dtpNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 3, 19, 10, 25, 14, 821);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txt_DiaChi.Location = new System.Drawing.Point(142, 283);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(253, 37);
            this.txt_DiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_DiaChi.TabIndex = 121;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(69, 297);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(70, 23);
            this.lbl_DiaChi.TabIndex = 119;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(56, 170);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(85, 23);
            this.lbl_GioiTinh.TabIndex = 118;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(72, 95);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(70, 23);
            this.lbl_HoTen.TabIndex = 116;
            this.lbl_HoTen.Text = "Họ Tên:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(47, 210);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(94, 23);
            this.lbl_NgaySinh.TabIndex = 117;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaNV.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_MaNV.BorderThickness = 2;
            this.txt_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.DefaultText = "";
            this.txt_MaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNV.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNV.ForeColor = System.Drawing.Color.Black;
            this.txt_MaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNV.Location = new System.Drawing.Point(140, 34);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_MaNV.PlaceholderText = "";
            this.txt_MaNV.ReadOnly = true;
            this.txt_MaNV.SelectedText = "";
            this.txt_MaNV.Size = new System.Drawing.Size(252, 37);
            this.txt_MaNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MaNV.TabIndex = 139;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(16, 53);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(125, 23);
            this.lbl_MaNV.TabIndex = 138;
            this.lbl_MaNV.Text = "Mã Nhân viên:";
            // 
            // frmXoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 510);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.cbo_ChucVu);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.pn_Tab);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_ChucVu);
            this.Controls.Add(this.txt_Luong);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_Luong);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.rad_Nu);
            this.Controls.Add(this.rad_Nam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.lbl_NgaySinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXoaNhanVien";
            this.Text = "frmXoaNhanVien";
            this.Load += new System.EventHandler(this.frmXoaNhanVien_Load);
            this.pn_Tab.ResumeLayout(false);
            this.pn_Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbo_ChucVu;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.Panel pn_Tab;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2TextBox txt_PassWord;
        private System.Windows.Forms.Label lbl_MatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_ChucVu;
        private Guna.UI2.WinForms.Guna2TextBox txt_Luong;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_Luong;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNV;
        private System.Windows.Forms.Label lbl_MaNV;
    }
}