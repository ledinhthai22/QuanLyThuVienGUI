namespace QuanLyThuVienGUI.QuanLy
{
    partial class frmThemTheLoai
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
            this.txt_TenTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenTheLoai = new System.Windows.Forms.Label();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Tab
            // 
            this.pn_Tab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Tab.Controls.Add(this.lbl_Title);
            this.pn_Tab.Location = new System.Drawing.Point(-1, 0);
            this.pn_Tab.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Tab.Name = "pn_Tab";
            this.pn_Tab.Size = new System.Drawing.Size(365, 24);
            this.pn_Tab.TabIndex = 3;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(113, 2);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(114, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THÊM THỂ LOẠI";
            // 
            // txt_TenTheLoai
            // 
            this.txt_TenTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenTheLoai.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_TenTheLoai.BorderThickness = 2;
            this.txt_TenTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenTheLoai.CustomizableEdges.TopLeft = false;
            this.txt_TenTheLoai.DefaultText = "";
            this.txt_TenTheLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTheLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenTheLoai.FillColor = System.Drawing.SystemColors.Control;
            this.txt_TenTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txt_TenTheLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenTheLoai.Location = new System.Drawing.Point(118, 44);
            this.txt_TenTheLoai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TenTheLoai.Name = "txt_TenTheLoai";
            this.txt_TenTheLoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TenTheLoai.PlaceholderText = "";
            this.txt_TenTheLoai.SelectedText = "";
            this.txt_TenTheLoai.Size = new System.Drawing.Size(198, 30);
            this.txt_TenTheLoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TenTheLoai.TabIndex = 15;
            // 
            // lbl_TenTheLoai
            // 
            this.lbl_TenTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenTheLoai.AutoSize = true;
            this.lbl_TenTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTheLoai.Location = new System.Drawing.Point(27, 59);
            this.lbl_TenTheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenTheLoai.Name = "lbl_TenTheLoai";
            this.lbl_TenTheLoai.Size = new System.Drawing.Size(93, 19);
            this.lbl_TenTheLoai.TabIndex = 14;
            this.lbl_TenTheLoai.Text = "Tên Thể loại:";
            this.lbl_TenTheLoai.Click += new System.EventHandler(this.lbl_TenTheLoai_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(81, 94);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(67, 37);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Thoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thoat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(187, 94);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(67, 37);
            this.btn_Thoat.TabIndex = 35;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frmThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 146);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_TenTheLoai);
            this.Controls.Add(this.lbl_TenTheLoai);
            this.Controls.Add(this.pn_Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemTheLoat";
            this.pn_Tab.ResumeLayout(false);
            this.pn_Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Tab;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTheLoai;
        private System.Windows.Forms.Label lbl_TenTheLoai;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Thoat;
    }
}