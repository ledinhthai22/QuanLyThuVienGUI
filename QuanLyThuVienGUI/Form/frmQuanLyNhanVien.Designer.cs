namespace QuanLyThuVienGUI.admin
{
    partial class frmQuanLyNhanVien
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
            this.pn_ThongTinNhap = new System.Windows.Forms.Panel();
            this.dgv_DSNhanVien = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.huychontimer = new System.Windows.Forms.Timer(this.components);
            this.pn_ThongTinNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_ThongTinNhap
            // 
            this.pn_ThongTinNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinNhap.BackColor = System.Drawing.SystemColors.Control;
            this.pn_ThongTinNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinNhap.Controls.Add(this.dgv_DSNhanVien);
            this.pn_ThongTinNhap.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinNhap.Controls.Add(this.txt_TimKiem);
            this.pn_ThongTinNhap.Controls.Add(this.btn_LamMoi);
            this.pn_ThongTinNhap.Controls.Add(this.btn_CapNhat);
            this.pn_ThongTinNhap.Controls.Add(this.btn_Xoa);
            this.pn_ThongTinNhap.Controls.Add(this.btn_Them);
            this.pn_ThongTinNhap.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_ThongTinNhap.Name = "pn_ThongTinNhap";
            this.pn_ThongTinNhap.Size = new System.Drawing.Size(889, 615);
            this.pn_ThongTinNhap.TabIndex = 0;
            // 
            // dgv_DSNhanVien
            // 
            this.dgv_DSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSNhanVien.Location = new System.Drawing.Point(1, 44);
            this.dgv_DSNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DSNhanVien.MultiSelect = false;
            this.dgv_DSNhanVien.Name = "dgv_DSNhanVien";
            this.dgv_DSNhanVien.ReadOnly = true;
            this.dgv_DSNhanVien.RowHeadersWidth = 51;
            this.dgv_DSNhanVien.RowTemplate.Height = 24;
            this.dgv_DSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSNhanVien.Size = new System.Drawing.Size(888, 570);
            this.dgv_DSNhanVien.TabIndex = 67;
            this.dgv_DSNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSNhanVien_CellFormatting);
            this.dgv_DSNhanVien.SelectionChanged += new System.EventHandler(this.dgv_DSNhanVien_SelectionChanged);
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
            this.btn_TimKiem.Location = new System.Drawing.Point(788, 2);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(98, 39);
            this.btn_TimKiem.TabIndex = 66;
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
            this.txt_TimKiem.Location = new System.Drawing.Point(341, 2);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(447, 39);
            this.txt_TimKiem.TabIndex = 48;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(242, 3);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(95, 37);
            this.btn_LamMoi.TabIndex = 65;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(146, 3);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(92, 37);
            this.btn_CapNhat.TabIndex = 57;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(74, 3);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 37);
            this.btn_Xoa.TabIndex = 56;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(2, 3);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 55;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // huychontimer
            // 
            this.huychontimer.Interval = 3000;

            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.pn_ThongTinNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "frmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.pn_ThongTinNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_ThongTinNhap;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DSNhanVien;
        private System.Windows.Forms.Timer huychontimer;
    }
}