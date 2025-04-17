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
            this.btn_CapNhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(147, 2);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(92, 37);
            this.btn_CapNhat.TabIndex = 34;
            this.btn_CapNhat.Text = "Cập Nhật";
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
            this.btn_Xoa.Location = new System.Drawing.Point(75, 3);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(67, 37);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
            // 
            // pn_ThongTinDocGia
            // 
            this.pn_ThongTinDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinDocGia.Controls.Add(this.dgv_DSDocGia);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_LamMoi);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_CapNhat);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Them);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Xoa);
            this.pn_ThongTinDocGia.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.pn_ThongTinDocGia.Name = "pn_ThongTinDocGia";
            this.pn_ThongTinDocGia.Size = new System.Drawing.Size(890, 615);
            this.pn_ThongTinDocGia.TabIndex = 44;
            // 
            // dgv_DSDocGia
            // 
            this.dgv_DSDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDocGia.Location = new System.Drawing.Point(-1, 43);
            this.dgv_DSDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSDocGia.Name = "dgv_DSDocGia";
            this.dgv_DSDocGia.ReadOnly = true;
            this.dgv_DSDocGia.RowHeadersWidth = 51;
            this.dgv_DSDocGia.RowTemplate.Height = 24;
            this.dgv_DSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDocGia.Size = new System.Drawing.Size(887, 571);
            this.dgv_DSDocGia.TabIndex = 48;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(778, 3);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 37);
            this.btn_TimKiem.TabIndex = 45;
            this.btn_TimKiem.Text = "Tìm kiếm";
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
            this.txt_TimKiem.Location = new System.Drawing.Point(342, 3);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(436, 37);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_LamMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(243, 2);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(95, 37);
            this.btn_LamMoi.TabIndex = 43;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(4, 3);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.pn_ThongTinDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.pn_ThongTinDocGia.ResumeLayout(false);
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
    }
}