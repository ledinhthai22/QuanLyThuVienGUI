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
            this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.pn_ThongTinDocGia = new System.Windows.Forms.Panel();
            this.lbl_SoTrang = new System.Windows.Forms.Label();
            this.btn_TrangSau = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TrangTruoc = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_DSDocGia = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.pn_ThongTinDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(195, 4);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(123, 46);
            this.btn_CapNhat.TabIndex = 34;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(100, 4);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // pn_ThongTinDocGia
            // 
            this.pn_ThongTinDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinDocGia.Controls.Add(this.lbl_SoTrang);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TrangSau);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TrangTruoc);
            this.pn_ThongTinDocGia.Controls.Add(this.dgv_DSDocGia);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_LamMoi);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_CapNhat);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Them);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Xoa);
            this.pn_ThongTinDocGia.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_ThongTinDocGia.Name = "pn_ThongTinDocGia";
            this.pn_ThongTinDocGia.Size = new System.Drawing.Size(1186, 756);
            this.pn_ThongTinDocGia.TabIndex = 44;
            this.pn_ThongTinDocGia.Resize += new System.EventHandler(this.pn_ThongTinDocGia_Resize);
            // 
            // lbl_SoTrang
            // 
            this.lbl_SoTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_SoTrang.AutoSize = true;
            this.lbl_SoTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTrang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_SoTrang.Location = new System.Drawing.Point(570, 723);
            this.lbl_SoTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTrang.Name = "lbl_SoTrang";
            this.lbl_SoTrang.Size = new System.Drawing.Size(56, 23);
            this.lbl_SoTrang.TabIndex = 54;
            this.lbl_SoTrang.Text = "Trang";
            // 
            // btn_TrangSau
            // 
            this.btn_TrangSau.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TrangSau.CustomImages.Image = global::QuanLyThuVienGUI.Properties.Resources.chevron_right_32px;
            this.btn_TrangSau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangSau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangSau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TrangSau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TrangSau.FillColor = System.Drawing.Color.Transparent;
            this.btn_TrangSau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TrangSau.ForeColor = System.Drawing.Color.White;
            this.btn_TrangSau.Location = new System.Drawing.Point(618, 715);
            this.btn_TrangSau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrangSau.Name = "btn_TrangSau";
            this.btn_TrangSau.Size = new System.Drawing.Size(33, 41);
            this.btn_TrangSau.TabIndex = 53;
            this.btn_TrangSau.Click += new System.EventHandler(this.btn_TrangSau_Click);
            // 
            // btn_TrangTruoc
            // 
            this.btn_TrangTruoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_TrangTruoc.CustomImages.Image = global::QuanLyThuVienGUI.Properties.Resources.chevron_left_32px;
            this.btn_TrangTruoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangTruoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangTruoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TrangTruoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TrangTruoc.FillColor = System.Drawing.Color.Transparent;
            this.btn_TrangTruoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TrangTruoc.ForeColor = System.Drawing.Color.White;
            this.btn_TrangTruoc.Location = new System.Drawing.Point(534, 715);
            this.btn_TrangTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrangTruoc.Name = "btn_TrangTruoc";
            this.btn_TrangTruoc.Size = new System.Drawing.Size(33, 41);
            this.btn_TrangTruoc.TabIndex = 52;
            this.btn_TrangTruoc.Click += new System.EventHandler(this.btn_TrangTruoc_Click);
            // 
            // dgv_DSDocGia
            // 
            this.dgv_DSDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDocGia.Location = new System.Drawing.Point(-1, 53);
            this.dgv_DSDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSDocGia.Name = "dgv_DSDocGia";
            this.dgv_DSDocGia.ReadOnly = true;
            this.dgv_DSDocGia.RowHeadersWidth = 51;
            this.dgv_DSDocGia.RowTemplate.Height = 24;
            this.dgv_DSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDocGia.Size = new System.Drawing.Size(1183, 656);
            this.dgv_DSDocGia.TabIndex = 48;
            this.dgv_DSDocGia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSDocGia_CellFormatting);
            this.dgv_DSDocGia.SelectionChanged += new System.EventHandler(this.dgv_DSDocGia_SelectionChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(1037, 4);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(140, 46);
            this.btn_TimKiem.TabIndex = 45;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txt_TimKiem.Location = new System.Drawing.Point(456, 4);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(581, 46);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(324, 4);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(127, 46);
            this.btn_LamMoi.TabIndex = 43;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(5, 4);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 46);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 756);
            this.Controls.Add(this.pn_ThongTinDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.Panel pn_ThongTinDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DSDocGia;
        private System.Windows.Forms.Label lbl_SoTrang;
        private Guna.UI2.WinForms.Guna2Button btn_TrangSau;
        private Guna.UI2.WinForms.Guna2Button btn_TrangTruoc;
    }
}