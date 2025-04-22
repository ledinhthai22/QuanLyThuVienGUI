namespace QuanLyThuVienGUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.chk_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_Minius = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Image = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Animated = true;
            this.txt_Username.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Username.BorderRadius = 20;
            this.txt_Username.BorderThickness = 2;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.Location = new System.Drawing.Point(588, 122);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.SelectedText = "";
            this.txt_Username.Size = new System.Drawing.Size(272, 35);
            this.txt_Username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Username.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderColor = System.Drawing.Color.White;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(644, 278);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(159, 41);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Animated = true;
            this.txt_Password.BorderColor = System.Drawing.Color.DodgerBlue;
            this.txt_Password.BorderRadius = 20;
            this.txt_Password.BorderThickness = 2;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.Location = new System.Drawing.Point(588, 175);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Password.PlaceholderText = "Password";
            this.txt_Password.SelectedText = "";
            this.txt_Password.Size = new System.Drawing.Size(272, 34);
            this.txt_Password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(670, 58);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(107, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "LOGIN";
            // 
            // chk_ShowPass
            // 
            this.chk_ShowPass.AutoSize = true;
            this.chk_ShowPass.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowPass.Location = new System.Drawing.Point(588, 227);
            this.chk_ShowPass.Name = "chk_ShowPass";
            this.chk_ShowPass.Size = new System.Drawing.Size(101, 23);
            this.chk_ShowPass.TabIndex = 6;
            this.chk_ShowPass.Text = "Show pass";
            this.chk_ShowPass.UseVisualStyleBackColor = true;
            this.chk_ShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btn_Minius
            // 
            this.btn_Minius.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minius.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minius.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Minius.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Minius.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Minius.FillColor = System.Drawing.Color.Transparent;
            this.btn_Minius.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minius.ForeColor = System.Drawing.Color.White;
            this.btn_Minius.Image = global::QuanLyThuVienGUI.Properties.Resources.minus;
            this.btn_Minius.Location = new System.Drawing.Point(826, 0);
            this.btn_Minius.Name = "btn_Minius";
            this.btn_Minius.Size = new System.Drawing.Size(25, 23);
            this.btn_Minius.TabIndex = 8;
            this.btn_Minius.Click += new System.EventHandler(this.btnMinius_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.Transparent;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::QuanLyThuVienGUI.Properties.Resources.multiply_32px;
            this.btn_Close.Location = new System.Drawing.Point(852, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pn_Image
            // 
            this.pn_Image.BackgroundImage = global::QuanLyThuVienGUI.Properties.Resources.background;
            this.pn_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Image.Location = new System.Drawing.Point(0, 0);
            this.pn_Image.Name = "pn_Image";
            this.pn_Image.Size = new System.Drawing.Size(571, 443);
            this.pn_Image.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 443);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Minius);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.pn_Image);
            this.Controls.Add(this.chk_ShowPass);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Image;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.CheckBox chk_ShowPass;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Button btn_Minius;
    }
}

