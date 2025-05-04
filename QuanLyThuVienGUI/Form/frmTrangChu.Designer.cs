namespace QuanLyThuVienGUI.admin
{
    partial class frmTrangChu
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
            this.btn_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_DenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_TuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TuNgay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKe.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongKe.Location = new System.Drawing.Point(719, 50);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(135, 29);
            this.btn_ThongKe.TabIndex = 12;
            this.btn_ThongKe.Text = "Xem thống kê";
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DenNgay.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_DenNgay.Checked = true;
            this.dtp_DenNgay.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_DenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DenNgay.ForeColor = System.Drawing.Color.Black;
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DenNgay.Location = new System.Drawing.Point(480, 50);
            this.dtp_DenNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_DenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(174, 29);
            this.dtp_DenNgay.TabIndex = 8;
            this.dtp_DenNgay.Value = new System.DateTime(2025, 5, 2, 22, 16, 22, 482);
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_TuNgay.BorderColor = System.Drawing.Color.Transparent;
            this.dtp_TuNgay.Checked = true;
            this.dtp_TuNgay.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtp_TuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_TuNgay.ForeColor = System.Drawing.Color.Black;
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_TuNgay.Location = new System.Drawing.Point(219, 50);
            this.dtp_TuNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_TuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_TuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(174, 29);
            this.dtp_TuNgay.TabIndex = 7;
            this.dtp_TuNgay.Value = new System.DateTime(2025, 5, 2, 22, 16, 22, 482);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đến ngày:";
            // 
            // lbl_TuNgay
            // 
            this.lbl_TuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TuNgay.AutoSize = true;
            this.lbl_TuNgay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TuNgay.Location = new System.Drawing.Point(148, 54);
            this.lbl_TuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TuNgay.Name = "lbl_TuNgay";
            this.lbl_TuNgay.Size = new System.Drawing.Size(67, 19);
            this.lbl_TuNgay.TabIndex = 9;
            this.lbl_TuNgay.Text = "Từ ngày:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(320, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 31);
            this.panel1.TabIndex = 13;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(79, 5);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(90, 21);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THỐNG KÊ";
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.AllowUserToAddRows = false;
            this.dgv_ThongKe.AllowUserToDeleteRows = false;
            this.dgv_ThongKe.AllowUserToOrderColumns = true;
            this.dgv_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Location = new System.Drawing.Point(1, 97);
            this.dgv_ThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.RowHeadersWidth = 51;
            this.dgv_ThongKe.RowTemplate.Height = 24;
            this.dgv_ThongKe.Size = new System.Drawing.Size(887, 519);
            this.dgv_ThongKe.TabIndex = 14;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.dgv_ThongKe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.dtp_DenNgay);
            this.Controls.Add(this.dtp_TuNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTrangChu";
            this.Text = "frmQuanLyThongKe";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_ThongKe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_DenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TuNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
    }
}