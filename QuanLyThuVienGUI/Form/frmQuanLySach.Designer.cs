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
            this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.pnframeInformation = new System.Windows.Forms.Panel();
            this.btn_TrangTruoc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TrangSau = new Guna.UI2.WinForms.Guna2Button();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_DSSach = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SoTrang = new System.Windows.Forms.Label();
            this.pnframeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(4, 2);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 46);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(99, 2);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(193, 2);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(125, 46);
            this.btn_CapNhat.TabIndex = 22;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // pnframeInformation
            // 
            this.pnframeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnframeInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnframeInformation.Controls.Add(this.btn_TrangTruoc);
            this.pnframeInformation.Controls.Add(this.btn_TrangSau);
            this.pnframeInformation.Controls.Add(this.btn_LamMoi);
            this.pnframeInformation.Controls.Add(this.dgv_DSSach);
            this.pnframeInformation.Controls.Add(this.txt_TimKiem);
            this.pnframeInformation.Controls.Add(this.btn_TimKiem);
            this.pnframeInformation.Controls.Add(this.btn_Xoa);
            this.pnframeInformation.Controls.Add(this.btn_CapNhat);
            this.pnframeInformation.Controls.Add(this.btn_Them);
            this.pnframeInformation.Controls.Add(this.lbl_SoTrang);
            this.pnframeInformation.Location = new System.Drawing.Point(0, 0);
            this.pnframeInformation.Margin = new System.Windows.Forms.Padding(4);
            this.pnframeInformation.Name = "pnframeInformation";
            this.pnframeInformation.Size = new System.Drawing.Size(1185, 758);
            this.pnframeInformation.TabIndex = 32;
            this.pnframeInformation.Resize += new System.EventHandler(this.pnframeInformation_Resize);
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
            this.btn_TrangTruoc.Location = new System.Drawing.Point(544, 718);
            this.btn_TrangTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrangTruoc.Name = "btn_TrangTruoc";
            this.btn_TrangTruoc.Size = new System.Drawing.Size(33, 36);
            this.btn_TrangTruoc.TabIndex = 52;
            this.btn_TrangTruoc.Click += new System.EventHandler(this.btn_TrangTruoc_Click);
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
            this.btn_TrangSau.Location = new System.Drawing.Point(618, 718);
            this.btn_TrangSau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TrangSau.Name = "btn_TrangSau";
            this.btn_TrangSau.Size = new System.Drawing.Size(33, 36);
            this.btn_TrangSau.TabIndex = 53;
            this.btn_TrangSau.Click += new System.EventHandler(this.btn_TrangSau_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(324, 2);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(111, 46);
            this.btn_LamMoi.TabIndex = 51;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // dgv_DSSach
            // 
            this.dgv_DSSach.AllowUserToAddRows = false;
            this.dgv_DSSach.AllowUserToDeleteRows = false;
            this.dgv_DSSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSach.Location = new System.Drawing.Point(0, 50);
            this.dgv_DSSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSSach.Name = "dgv_DSSach";
            this.dgv_DSSach.ReadOnly = true;
            this.dgv_DSSach.RowHeadersWidth = 51;
            this.dgv_DSSach.RowTemplate.Height = 24;
            this.dgv_DSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSSach.Size = new System.Drawing.Size(1184, 668);
            this.dgv_DSSach.TabIndex = 49;
            this.dgv_DSSach.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_DSSach_CellFormatting);
            this.dgv_DSSach.SelectionChanged += new System.EventHandler(this.dgv_DSSach_SelectionChanged);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(440, 1);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(616, 48);
            this.txt_TimKiem.TabIndex = 0;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(1056, 1);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(125, 48);
            this.btn_TimKiem.TabIndex = 45;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_SoTrang
            // 
            this.lbl_SoTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_SoTrang.AutoSize = true;
            this.lbl_SoTrang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTrang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_SoTrang.Location = new System.Drawing.Point(575, 724);
            this.lbl_SoTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTrang.Name = "lbl_SoTrang";
            this.lbl_SoTrang.Size = new System.Drawing.Size(56, 23);
            this.lbl_SoTrang.TabIndex = 54;
            this.lbl_SoTrang.Text = "Trang";
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 756);
            this.Controls.Add(this.pnframeInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            this.pnframeInformation.ResumeLayout(false);
            this.pnframeInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
        private System.Windows.Forms.Panel pnframeInformation;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DSSach;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private System.Windows.Forms.Label lbl_SoTrang;
        private Guna.UI2.WinForms.Guna2Button btn_TrangSau;
        private Guna.UI2.WinForms.Guna2Button btn_TrangTruoc;
    }
}