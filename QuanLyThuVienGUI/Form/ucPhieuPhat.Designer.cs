namespace QuanLyThuVienGUI
{
    partial class ucPhieuPhat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TaoPhieuPhat = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Thoat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_TaoPhieuPhat
            // 
            this.txt_TaoPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_TaoPhieuPhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txt_TaoPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txt_TaoPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txt_TaoPhieuPhat.FillColor = System.Drawing.Color.DodgerBlue;
            this.txt_TaoPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaoPhieuPhat.ForeColor = System.Drawing.Color.White;
            this.txt_TaoPhieuPhat.Location = new System.Drawing.Point(391, 216);
            this.txt_TaoPhieuPhat.Name = "txt_TaoPhieuPhat";
            this.txt_TaoPhieuPhat.Size = new System.Drawing.Size(180, 45);
            this.txt_TaoPhieuPhat.TabIndex = 1;
            this.txt_TaoPhieuPhat.Text = "Tạo phiếu phạt";
            // 
            // txt_Thoat
            // 
            this.txt_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txt_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txt_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txt_Thoat.FillColor = System.Drawing.Color.DodgerBlue;
            this.txt_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thoat.ForeColor = System.Drawing.Color.White;
            this.txt_Thoat.Location = new System.Drawing.Point(628, 216);
            this.txt_Thoat.Name = "txt_Thoat";
            this.txt_Thoat.Size = new System.Drawing.Size(134, 45);
            this.txt_Thoat.TabIndex = 2;
            this.txt_Thoat.Text = "Thoát";
            // 
            // ucPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Thoat);
            this.Controls.Add(this.txt_TaoPhieuPhat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucPhieuPhat";
            this.Size = new System.Drawing.Size(1185, 756);
            this.Load += new System.EventHandler(this.ucPhieuPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button txt_TaoPhieuPhat;
        private Guna.UI2.WinForms.Guna2Button txt_Thoat;
    }
}
