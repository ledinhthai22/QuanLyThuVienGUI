namespace QuanLyThuVienGUI.admin
{
    partial class frmQuanLyTheLoai
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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_XoaTL = new Guna.UI2.WinForms.Guna2Button();
            this.btn_LamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ThemTL = new Guna.UI2.WinForms.Guna2Button();
            this.btn_CapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TimKiemTL = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TimKiemTL = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_ThongTinTL = new System.Windows.Forms.Panel();
            this.dgv_DanhSachTL = new System.Windows.Forms.DataGridView();
            this.huychontimer = new System.Windows.Forms.Timer(this.components);
            this.pn_ThongTinTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTL)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.CustomizableEdges.TopLeft = false;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(375, -233);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(198, 30);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 28;
            // 
            // btn_XoaTL
            // 
            this.btn_XoaTL.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_XoaTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XoaTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XoaTL.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_XoaTL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_XoaTL.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTL.Location = new System.Drawing.Point(74, 2);
            this.btn_XoaTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XoaTL.Name = "btn_XoaTL";
            this.btn_XoaTL.Size = new System.Drawing.Size(67, 37);
            this.btn_XoaTL.TabIndex = 30;
            this.btn_XoaTL.Text = "Xóa";
            this.btn_XoaTL.Click += new System.EventHandler(this.btn_XoaTL_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(237, 2);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(85, 37);
            this.btn_LamMoi.TabIndex = 32;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ThemTL
            // 
            this.btn_ThemTL.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThemTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThemTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThemTL.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThemTL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ThemTL.ForeColor = System.Drawing.Color.White;
            this.btn_ThemTL.Location = new System.Drawing.Point(3, 2);
            this.btn_ThemTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThemTL.Name = "btn_ThemTL";
            this.btn_ThemTL.Size = new System.Drawing.Size(67, 37);
            this.btn_ThemTL.TabIndex = 29;
            this.btn_ThemTL.Text = "Thêm";
            this.btn_ThemTL.Click += new System.EventHandler(this.btn_ThemTL_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(145, 2);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(88, 37);
            this.btn_CapNhat.TabIndex = 31;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_TimKiemTL
            // 
            this.btn_TimKiemTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiemTL.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiemTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiemTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiemTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiemTL.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_TimKiemTL.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiemTL.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiemTL.Location = new System.Drawing.Point(788, 2);
            this.btn_TimKiemTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TimKiemTL.Name = "btn_TimKiemTL";
            this.btn_TimKiemTL.Size = new System.Drawing.Size(98, 37);
            this.btn_TimKiemTL.TabIndex = 47;
            this.btn_TimKiemTL.Text = "Tìm kiếm";
            this.btn_TimKiemTL.Click += new System.EventHandler(this.btn_TimKiemTL_Click);
            // 
            // txt_TimKiemTL
            // 
            this.txt_TimKiemTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiemTL.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TimKiemTL.BorderThickness = 2;
            this.txt_TimKiemTL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemTL.DefaultText = "";
            this.txt_TimKiemTL.DisabledState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiemTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemTL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemTL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemTL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemTL.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txt_TimKiemTL.Location = new System.Drawing.Point(326, 2);
            this.txt_TimKiemTL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TimKiemTL.Name = "txt_TimKiemTL";
            this.txt_TimKiemTL.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiemTL.SelectedText = "";
            this.txt_TimKiemTL.Size = new System.Drawing.Size(463, 37);
            this.txt_TimKiemTL.TabIndex = 46;
            // 
            // pn_ThongTinTL
            // 
            this.pn_ThongTinTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinTL.Controls.Add(this.dgv_DanhSachTL);
            this.pn_ThongTinTL.Controls.Add(this.txt_TimKiemTL);
            this.pn_ThongTinTL.Controls.Add(this.btn_TimKiemTL);
            this.pn_ThongTinTL.Controls.Add(this.btn_CapNhat);
            this.pn_ThongTinTL.Controls.Add(this.btn_ThemTL);
            this.pn_ThongTinTL.Controls.Add(this.btn_LamMoi);
            this.pn_ThongTinTL.Controls.Add(this.btn_XoaTL);
            this.pn_ThongTinTL.Controls.Add(this.guna2TextBox1);
            this.pn_ThongTinTL.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinTL.Name = "pn_ThongTinTL";
            this.pn_ThongTinTL.Size = new System.Drawing.Size(891, 614);
            this.pn_ThongTinTL.TabIndex = 0;
            // 
            // dgv_DanhSachTL
            // 
            this.dgv_DanhSachTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachTL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachTL.Location = new System.Drawing.Point(0, 41);
            this.dgv_DanhSachTL.MultiSelect = false;
            this.dgv_DanhSachTL.Name = "dgv_DanhSachTL";
            this.dgv_DanhSachTL.ReadOnly = true;
            this.dgv_DanhSachTL.RowHeadersWidth = 51;
            this.dgv_DanhSachTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachTL.Size = new System.Drawing.Size(889, 572);
            this.dgv_DanhSachTL.TabIndex = 48;
            this.dgv_DanhSachTL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachTL_CellContentClick);
            this.dgv_DanhSachTL.SelectionChanged += new System.EventHandler(this.dgv_DanhSachTL_SelectionChanged);
            // 
            // huychontimer
            // 
            // 
            // frmQuanLyTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.pn_ThongTinTL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyTheLoai";
            this.Text = "QuanLyTheLoai";
            this.Load += new System.EventHandler(this.QuanLyTheLoai_Load);
            this.pn_ThongTinTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_XoaTL;
        private Guna.UI2.WinForms.Guna2Button btn_LamMoi;
        private Guna.UI2.WinForms.Guna2Button btn_ThemTL;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhat;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiemTL;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemTL;
        private System.Windows.Forms.Panel pn_ThongTinTL;
        private System.Windows.Forms.DataGridView dgv_DanhSachTL;
        private System.Windows.Forms.Timer huychontimer;
    }
}