﻿namespace QuanLyThuVienGUI.CacFormNhanVien
{
    partial class frmXoaTheLoai
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
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TenTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_TenTheLoai = new System.Windows.Forms.Label();
            this.lbl_MaTheLoai = new System.Windows.Forms.Label();
            this.txt_MaTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Tab
            // 
            this.pn_Tab.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_Tab.Controls.Add(this.lbl_Title);
            this.pn_Tab.Location = new System.Drawing.Point(-1, 0);
            this.pn_Tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Tab.Name = "pn_Tab";
            this.pn_Tab.Size = new System.Drawing.Size(549, 30);
            this.pn_Tab.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(209, 4);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(127, 23);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "XÓA THỂ LOẠI";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(140, 148);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 46);
            this.btn_Xoa.TabIndex = 38;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Thoat.Location = new System.Drawing.Point(281, 148);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(89, 46);
            this.btn_Thoat.TabIndex = 39;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.txt_TenTheLoai.Location = new System.Drawing.Point(189, 86);
            this.txt_TenTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenTheLoai.Name = "txt_TenTheLoai";
            this.txt_TenTheLoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_TenTheLoai.PlaceholderText = "";
            this.txt_TenTheLoai.ReadOnly = true;
            this.txt_TenTheLoai.SelectedText = "";
            this.txt_TenTheLoai.Size = new System.Drawing.Size(264, 37);
            this.txt_TenTheLoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_TenTheLoai.TabIndex = 37;
            // 
            // lbl_TenTheLoai
            // 
            this.lbl_TenTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TenTheLoai.AutoSize = true;
            this.lbl_TenTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTheLoai.Location = new System.Drawing.Point(68, 105);
            this.lbl_TenTheLoai.Name = "lbl_TenTheLoai";
            this.lbl_TenTheLoai.Size = new System.Drawing.Size(110, 23);
            this.lbl_TenTheLoai.TabIndex = 36;
            this.lbl_TenTheLoai.Text = "Tên Thể loại:";
            // 
            // lbl_MaTheLoai
            // 
            this.lbl_MaTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_MaTheLoai.AutoSize = true;
            this.lbl_MaTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTheLoai.Location = new System.Drawing.Point(68, 60);
            this.lbl_MaTheLoai.Name = "lbl_MaTheLoai";
            this.lbl_MaTheLoai.Size = new System.Drawing.Size(112, 23);
            this.lbl_MaTheLoai.TabIndex = 40;
            this.lbl_MaTheLoai.Text = "Mã Thể Loại:";
            // 
            // txt_MaTheLoai
            // 
            this.txt_MaTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaTheLoai.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_MaTheLoai.BorderThickness = 2;
            this.txt_MaTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaTheLoai.CustomizableEdges.TopLeft = false;
            this.txt_MaTheLoai.DefaultText = "";
            this.txt_MaTheLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaTheLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaTheLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTheLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaTheLoai.FillColor = System.Drawing.SystemColors.Control;
            this.txt_MaTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txt_MaTheLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaTheLoai.Location = new System.Drawing.Point(189, 42);
            this.txt_MaTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaTheLoai.Name = "txt_MaTheLoai";
            this.txt_MaTheLoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_MaTheLoai.PlaceholderText = "";
            this.txt_MaTheLoai.ReadOnly = true;
            this.txt_MaTheLoai.SelectedText = "";
            this.txt_MaTheLoai.Size = new System.Drawing.Size(264, 37);
            this.txt_MaTheLoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_MaTheLoai.TabIndex = 41;
            // 
            // frmXoaTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 215);
            this.Controls.Add(this.lbl_MaTheLoai);
            this.Controls.Add(this.txt_MaTheLoai);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.pn_Tab);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_TenTheLoai);
            this.Controls.Add(this.txt_TenTheLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXoaTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXoaTheLoai";
            this.Load += new System.EventHandler(this.frmXoaTheLoai_Load);
            this.pn_Tab.ResumeLayout(false);
            this.pn_Tab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Tab;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_Thoat;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenTheLoai;
        private System.Windows.Forms.Label lbl_TenTheLoai;
        private System.Windows.Forms.Label lbl_MaTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaTheLoai;
    }
}