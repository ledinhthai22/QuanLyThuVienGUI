namespace QuanLyThuVienGUI.QuanLy
{
    partial class frmThemSach
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
            this.pn_Tab = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbo_MaTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_NXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txt_TenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.txt_TacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.dtp_NamXB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCategoryCode = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_NamXB = new System.Windows.Forms.Label();
            this.txt_MoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Tab
            // 
            this.pn_Tab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Tab.Controls.Add(this.lbl_Title);
            this.pn_Tab.Location = new System.Drawing.Point(0, 0);
            this.pn_Tab.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Tab.Name = "pn_Tab";
            this.pn_Tab.Size = new System.Drawing.Size(330, 24);
            this.pn_Tab.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(119, 2);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(90, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THÊM SÁCH";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSoLuong.FillColor = System.Drawing.Color.DodgerBlue;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSoLuong.Location = new System.Drawing.Point(103, 211);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(202, 24);
            this.numSoLuong.TabIndex = 44;
            this.numSoLuong.UpDownButtonFillColor = System.Drawing.Color.DodgerBlue;
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
            this.cbo_MaTheLoai.Location = new System.Drawing.Point(103, 64);
            this.cbo_MaTheLoai.Name = "cbo_MaTheLoai";
            this.cbo_MaTheLoai.Size = new System.Drawing.Size(201, 36);
            this.cbo_MaTheLoai.TabIndex = 43;
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
            this.txt_NXB.Location = new System.Drawing.Point(104, 104);
            this.txt_NXB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_NXB.Name = "txt_NXB";
            this.txt_NXB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_NXB.PlaceholderText = "";
            this.txt_NXB.SelectedText = "";
            this.txt_NXB.Size = new System.Drawing.Size(200, 30);
            this.txt_NXB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_NXB.TabIndex = 42;
            this.txt_NXB.TextChanged += new System.EventHandler(this.txt_NXB_TextChanged);
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(12, 117);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(95, 17);
            this.lblPublisher.TabIndex = 36;
            this.lblPublisher.Text = "Nhà xuất bản:";
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
            this.txt_TenSach.Location = new System.Drawing.Point(104, 30);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TenSach.PlaceholderText = "";
            this.txt_TenSach.SelectedText = "";
            this.txt_TenSach.Size = new System.Drawing.Size(200, 28);
            this.txt_TenSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TenSach.TabIndex = 40;
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSach.Location = new System.Drawing.Point(42, 43);
            this.lbl_TenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(65, 17);
            this.lbl_TenSach.TabIndex = 33;
            this.lbl_TenSach.Text = "Tên sách:";
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
            this.txt_TacGia.Location = new System.Drawing.Point(104, 145);
            this.txt_TacGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TacGia.PlaceholderText = "";
            this.txt_TacGia.SelectedText = "";
            this.txt_TacGia.Size = new System.Drawing.Size(200, 29);
            this.txt_TacGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TacGia.TabIndex = 41;
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TacGia.Location = new System.Drawing.Point(53, 159);
            this.lbl_TacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(55, 17);
            this.lbl_TacGia.TabIndex = 34;
            this.lbl_TacGia.Text = "Tác giả:";
            // 
            // dtp_NamXB
            // 
            this.dtp_NamXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NamXB.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NamXB.Checked = true;
            this.dtp_NamXB.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_NamXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NamXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NamXB.Location = new System.Drawing.Point(104, 179);
            this.dtp_NamXB.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NamXB.MaxDate = new System.DateTime(2025, 3, 19, 23, 24, 5, 0);
            this.dtp_NamXB.MinDate = new System.DateTime(1809, 1, 1, 0, 0, 0, 0);
            this.dtp_NamXB.Name = "dtp_NamXB";
            this.dtp_NamXB.Size = new System.Drawing.Size(202, 27);
            this.dtp_NamXB.TabIndex = 39;
            this.dtp_NamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_NamXB.Value = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            // 
            // lblCategoryCode
            // 
            this.lblCategoryCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategoryCode.AutoSize = true;
            this.lblCategoryCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryCode.Location = new System.Drawing.Point(48, 72);
            this.lblCategoryCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryCode.Name = "lblCategoryCode";
            this.lblCategoryCode.Size = new System.Drawing.Size(59, 17);
            this.lblCategoryCode.TabIndex = 35;
            this.lblCategoryCode.Text = "thể loại:";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(41, 213);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(68, 17);
            this.lbl_SoLuong.TabIndex = 38;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // lbl_NamXB
            // 
            this.lbl_NamXB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NamXB.AutoSize = true;
            this.lbl_NamXB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamXB.Location = new System.Drawing.Point(9, 182);
            this.lbl_NamXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NamXB.Name = "lbl_NamXB";
            this.lbl_NamXB.Size = new System.Drawing.Size(99, 17);
            this.lbl_NamXB.TabIndex = 37;
            this.lbl_NamXB.Text = "Năm xuất bản:";
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
            this.txt_MoTa.Location = new System.Drawing.Point(103, 241);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_MoTa.PlaceholderText = "";
            this.txt_MoTa.SelectedText = "";
            this.txt_MoTa.Size = new System.Drawing.Size(205, 73);
            this.txt_MoTa.TabIndex = 46;
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(59, 241);
            this.lbl_MoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(48, 17);
            this.lbl_MoTa.TabIndex = 45;
            this.lbl_MoTa.Text = "Mô tả:";
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
            this.btn_Them.Location = new System.Drawing.Point(84, 335);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 48;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(194, 335);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(67, 37);
            this.btn_Huy.TabIndex = 49;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frmThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 394);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.cbo_MaTheLoai);
            this.Controls.Add(this.txt_NXB);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.lbl_TenSach);
            this.Controls.Add(this.txt_TacGia);
            this.Controls.Add(this.lbl_TacGia);
            this.Controls.Add(this.dtp_NamXB);
            this.Controls.Add(this.lblCategoryCode);
            this.Controls.Add(this.lbl_NamXB);
            this.Controls.Add(this.pn_Tab);
            this.Controls.Add(this.lbl_SoLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSach";
            this.pn_Tab.ResumeLayout(false);
            this.pn_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Tab;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_MaTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_NXB;
        private System.Windows.Forms.Label lblPublisher;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenSach;
        private System.Windows.Forms.Label lbl_TenSach;
        private Guna.UI2.WinForms.Guna2TextBox txt_TacGia;
        private System.Windows.Forms.Label lbl_TacGia;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_NamXB;
        private System.Windows.Forms.Label lblCategoryCode;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_NamXB;
        private Guna.UI2.WinForms.Guna2TextBox txt_MoTa;
        private System.Windows.Forms.Label lbl_MoTa;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
    }
}