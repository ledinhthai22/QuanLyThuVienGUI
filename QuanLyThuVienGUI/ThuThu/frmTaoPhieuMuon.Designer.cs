namespace QuanLyThuVienGUI.ThuThu
{
    partial class frmTaoPhieuMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DSDocGia = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TaoPhieuMuon = new Guna.UI2.WinForms.Guna2Button();
            this.nbrSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.dtpNgaytradukien = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_Ngaytradukien = new System.Windows.Forms.Label();
            this.dtpNgaymuon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_Ngaymuon = new System.Windows.Forms.Label();
            this.lblThemThongTin = new System.Windows.Forms.Label();
            this.txt_HoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenDocGia = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DSDocGia);
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(37, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 308);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Độc Giả";
            // 
            // dgv_DSDocGia
            // 
            this.dgv_DSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDocGia.Location = new System.Drawing.Point(17, 68);
            this.dgv_DSDocGia.Name = "dgv_DSDocGia";
            this.dgv_DSDocGia.RowHeadersWidth = 51;
            this.dgv_DSDocGia.RowTemplate.Height = 24;
            this.dgv_DSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDocGia.Size = new System.Drawing.Size(519, 229);
            this.dgv_DSDocGia.TabIndex = 80;
            this.dgv_DSDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSDocGia_CellClick);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(17, 22);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(399, 39);
            this.txt_TimKiem.TabIndex = 78;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(422, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 39);
            this.btnTimKiem.TabIndex = 79;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // btn_TaoPhieuMuon
            // 
            this.btn_TaoPhieuMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_TaoPhieuMuon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoPhieuMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaoPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaoPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaoPhieuMuon.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TaoPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPhieuMuon.Location = new System.Drawing.Point(215, 194);
            this.btn_TaoPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaoPhieuMuon.Name = "btn_TaoPhieuMuon";
            this.btn_TaoPhieuMuon.Size = new System.Drawing.Size(140, 46);
            this.btn_TaoPhieuMuon.TabIndex = 97;
            this.btn_TaoPhieuMuon.Text = "Tạo phiếu";
            this.btn_TaoPhieuMuon.Click += new System.EventHandler(this.btn_TaoPhieuMuon_Click);
            // 
            // nbrSoLuong
            // 
            this.nbrSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.nbrSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbrSoLuong.Location = new System.Drawing.Point(248, 62);
            this.nbrSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbrSoLuong.Name = "nbrSoLuong";
            this.nbrSoLuong.Size = new System.Drawing.Size(258, 36);
            this.nbrSoLuong.TabIndex = 95;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(62, 75);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(180, 23);
            this.lbl_SoLuong.TabIndex = 94;
            this.lbl_SoLuong.Text = "Số lượng sách mượn:";
            // 
            // dtpNgaytradukien
            // 
            this.dtpNgaytradukien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaytradukien.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaytradukien.Checked = true;
            this.dtpNgaytradukien.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaytradukien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaytradukien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytradukien.Location = new System.Drawing.Point(248, 147);
            this.dtpNgaytradukien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaytradukien.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaytradukien.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaytradukien.Name = "dtpNgaytradukien";
            this.dtpNgaytradukien.Size = new System.Drawing.Size(252, 33);
            this.dtpNgaytradukien.TabIndex = 93;
            this.dtpNgaytradukien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaytradukien.Value = new System.DateTime(2025, 3, 19, 10, 25, 14, 821);
            // 
            // lbl_Ngaytradukien
            // 
            this.lbl_Ngaytradukien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Ngaytradukien.AutoSize = true;
            this.lbl_Ngaytradukien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaytradukien.Location = new System.Drawing.Point(91, 157);
            this.lbl_Ngaytradukien.Name = "lbl_Ngaytradukien";
            this.lbl_Ngaytradukien.Size = new System.Drawing.Size(151, 23);
            this.lbl_Ngaytradukien.TabIndex = 92;
            this.lbl_Ngaytradukien.Text = "Ngày trả dự kiến:";
            // 
            // dtpNgaymuon
            // 
            this.dtpNgaymuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaymuon.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaymuon.Checked = true;
            this.dtpNgaymuon.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpNgaymuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaymuon.Location = new System.Drawing.Point(248, 104);
            this.dtpNgaymuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaymuon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaymuon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaymuon.Name = "dtpNgaymuon";
            this.dtpNgaymuon.Size = new System.Drawing.Size(252, 33);
            this.dtpNgaymuon.TabIndex = 91;
            this.dtpNgaymuon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaymuon.Value = new System.DateTime(2025, 3, 19, 10, 25, 14, 821);
            // 
            // lbl_Ngaymuon
            // 
            this.lbl_Ngaymuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Ngaymuon.AutoSize = true;
            this.lbl_Ngaymuon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaymuon.Location = new System.Drawing.Point(132, 114);
            this.lbl_Ngaymuon.Name = "lbl_Ngaymuon";
            this.lbl_Ngaymuon.Size = new System.Drawing.Size(110, 23);
            this.lbl_Ngaymuon.TabIndex = 90;
            this.lbl_Ngaymuon.Text = "Ngày mượn:";
            // 
            // lblThemThongTin
            // 
            this.lblThemThongTin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThemThongTin.AutoSize = true;
            this.lblThemThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemThongTin.Location = new System.Drawing.Point(98, 32);
            this.lblThemThongTin.Name = "lblThemThongTin";
            this.lblThemThongTin.Size = new System.Drawing.Size(0, 23);
            this.lblThemThongTin.TabIndex = 89;
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
            this.txt_HoTen.Location = new System.Drawing.Point(248, 17);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.SelectedText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(252, 37);
            this.txt_HoTen.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_HoTen.TabIndex = 88;
            // 
            // lbl_TenDocGia
            // 
            this.lbl_TenDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenDocGia.AutoSize = true;
            this.lbl_TenDocGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDocGia.Location = new System.Drawing.Point(136, 31);
            this.lbl_TenDocGia.Name = "lbl_TenDocGia";
            this.lbl_TenDocGia.Size = new System.Drawing.Size(106, 23);
            this.lbl_TenDocGia.TabIndex = 87;
            this.lbl_TenDocGia.Text = "Tên độc giả:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(375, 194);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 46);
            this.btnHuy.TabIndex = 99;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmTaoPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 575);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TaoPhieuMuon);
            this.Controls.Add(this.nbrSoLuong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.dtpNgaytradukien);
            this.Controls.Add(this.lbl_Ngaytradukien);
            this.Controls.Add(this.dtpNgaymuon);
            this.Controls.Add(this.lbl_Ngaymuon);
            this.Controls.Add(this.lblThemThongTin);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.lbl_TenDocGia);
            this.Name = "frmTaoPhieuMuon";
            this.Text = "frmTaoPhieuMuon";
            this.Load += new System.EventHandler(this.frmTaoPhieuMuon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_TaoPhieuMuon;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbrSoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaytradukien;
        private System.Windows.Forms.Label lbl_Ngaytradukien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaymuon;
        private System.Windows.Forms.Label lbl_Ngaymuon;
        private System.Windows.Forms.Label lblThemThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_TenDocGia;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}