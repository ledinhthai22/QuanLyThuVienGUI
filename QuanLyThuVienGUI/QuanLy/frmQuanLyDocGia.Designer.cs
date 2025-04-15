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
            this.pn_ThongTinDocGia = new System.Windows.Forms.Panel();
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
            this.btn_Sua.Location = new System.Drawing.Point(191, 2);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(97, 46);
            this.btn_Sua.TabIndex = 34;
            this.btn_Sua.Text = "Sửa";
  
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
            this.btn_Xoa.Location = new System.Drawing.Point(96, 2);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_Xoa.TabIndex = 33;
            this.btn_Xoa.Text = "Xóa";
 
            // 
            // pn_ThongTinDocGia
            // 
            this.pn_ThongTinDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_ThongTinDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.txt_TimKiem);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_TaoMoi);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Sua);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Them);
            this.pn_ThongTinDocGia.Controls.Add(this.btn_Xoa);
            this.pn_ThongTinDocGia.Location = new System.Drawing.Point(0, 0);
            this.pn_ThongTinDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_ThongTinDocGia.Name = "pn_ThongTinDocGia";
            this.pn_ThongTinDocGia.Size = new System.Drawing.Size(1165, 294);
            this.pn_ThongTinDocGia.TabIndex = 44;
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
            this.btn_TimKiem.Location = new System.Drawing.Point(1037, 2);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(125, 48);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(458, 2);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm kiếm";
            this.txt_TimKiem.SelectedText = "";
            this.txt_TimKiem.Size = new System.Drawing.Size(580, 48);
            this.txt_TimKiem.TabIndex = 0;

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
            this.btn_TaoMoi.Location = new System.Drawing.Point(299, 2);
            this.btn_TaoMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(140, 46);
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
            this.btn_Them.Location = new System.Drawing.Point(1, 1);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 46);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";

            // 
            // dgv_DSDocGia
            // 
            this.dgv_DSDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDocGia.Location = new System.Drawing.Point(-3, 53);
            this.dgv_DSDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSDocGia.Name = "dgv_DSDocGia";
            this.dgv_DSDocGia.ReadOnly = true;
            this.dgv_DSDocGia.RowHeadersWidth = 51;
            this.dgv_DSDocGia.RowTemplate.Height = 24;
            this.dgv_DSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDocGia.Size = new System.Drawing.Size(1167, 673);
            this.dgv_DSDocGia.TabIndex = 47;
        
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 726);
            this.Controls.Add(this.dgv_DSDocGia);
            this.Controls.Add(this.pn_ThongTinDocGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDocGia";
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            this.pn_ThongTinDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.Panel pn_ThongTinDocGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DSDocGia;
        private Guna.UI2.WinForms.Guna2Button btn_TaoMoi;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private System.Windows.Forms.ImageList imageList1;
    }
}