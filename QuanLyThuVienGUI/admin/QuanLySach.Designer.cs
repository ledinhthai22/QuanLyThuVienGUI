namespace QuanLyThuVienGUI
{
    partial class QuanLySach
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
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditBook = new Guna.UI2.WinForms.Guna2Button();
            this.picHinhAnhSach = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnChoiceImage = new Guna.UI2.WinForms.Guna2Button();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblYearofpublication = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategoryCode = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblQuanlity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpNamXB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnframeInformation = new System.Windows.Forms.Panel();
            this.cbMaTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.radTimKiemTheLoai = new System.Windows.Forms.RadioButton();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.radTenSach = new System.Windows.Forms.RadioButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhSach)).BeginInit();
            this.pnframeInformation.SuspendLayout();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBook.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(41, 633);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(89, 46);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveBook.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBook.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBook.Location = new System.Drawing.Point(168, 633);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(89, 46);
            this.btnRemoveBook.TabIndex = 21;
            this.btnRemoveBook.Text = "Xóa";
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditBook.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditBook.ForeColor = System.Drawing.Color.White;
            this.btnEditBook.Location = new System.Drawing.Point(304, 633);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(89, 46);
            this.btnEditBook.TabIndex = 22;
            this.btnEditBook.Text = "Sửa";
            // 
            // picHinhAnhSach
            // 
            this.picHinhAnhSach.ImageRotate = 0F;
            this.picHinhAnhSach.Location = new System.Drawing.Point(4, 4);
            this.picHinhAnhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHinhAnhSach.Name = "picHinhAnhSach";
            this.picHinhAnhSach.Size = new System.Drawing.Size(145, 146);
            this.picHinhAnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnhSach.TabIndex = 24;
            this.picHinhAnhSach.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(159, 706);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 46);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Tạo mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnChoiceImage
            // 
            this.btnChoiceImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoiceImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoiceImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoiceImage.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnChoiceImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceImage.ForeColor = System.Drawing.Color.White;
            this.btnChoiceImage.Location = new System.Drawing.Point(203, 62);
            this.btnChoiceImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChoiceImage.Name = "btnChoiceImage";
            this.btnChoiceImage.Size = new System.Drawing.Size(131, 42);
            this.btnChoiceImage.TabIndex = 28;
            this.btnChoiceImage.Text = "Chọn ảnh";
            this.btnChoiceImage.Click += new System.EventHandler(this.btnChoiceImage_Click);
            // 
            // lblNameBook
            // 
            this.lblNameBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBook.Location = new System.Drawing.Point(43, 165);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(81, 23);
            this.lblNameBook.TabIndex = 0;
            this.lblNameBook.Text = "Tên sách:";
            // 
            // lblYearofpublication
            // 
            this.lblYearofpublication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYearofpublication.AutoSize = true;
            this.lblYearofpublication.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearofpublication.Location = new System.Drawing.Point(-3, 346);
            this.lblYearofpublication.Name = "lblYearofpublication";
            this.lblYearofpublication.Size = new System.Drawing.Size(128, 23);
            this.lblYearofpublication.TabIndex = 4;
            this.lblYearofpublication.Text = "Năm xuất bản:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(53, 208);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(71, 23);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // lblCategoryCode
            // 
            this.lblCategoryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoryCode.AutoSize = true;
            this.lblCategoryCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryCode.Location = new System.Drawing.Point(13, 260);
            this.lblCategoryCode.Name = "lblCategoryCode";
            this.lblCategoryCode.Size = new System.Drawing.Size(105, 23);
            this.lblCategoryCode.TabIndex = 2;
            this.lblCategoryCode.Text = "Mã thể loại:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(0, 304);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(122, 23);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Nhà xuất bản:";
            // 
            // lblQuanlity
            // 
            this.lblQuanlity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuanlity.AutoSize = true;
            this.lblQuanlity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanlity.Location = new System.Drawing.Point(37, 405);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(88, 23);
            this.lblQuanlity.TabIndex = 5;
            this.lblQuanlity.Text = "Số lượng:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(28, 455);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // dtpNamXB
            // 
            this.dtpNamXB.BackColor = System.Drawing.Color.LightGreen;
            this.dtpNamXB.Checked = true;
            this.dtpNamXB.FillColor = System.Drawing.Color.LightSeaGreen;
            this.dtpNamXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNamXB.Location = new System.Drawing.Point(144, 336);
            this.dtpNamXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNamXB.MaxDate = new System.DateTime(2025, 3, 19, 23, 24, 5, 0);
            this.dtpNamXB.MinDate = new System.DateTime(1809, 1, 1, 0, 0, 0, 0);
            this.dtpNamXB.Name = "dtpNamXB";
            this.dtpNamXB.Size = new System.Drawing.Size(261, 33);
            this.dtpNamXB.TabIndex = 10;
            this.dtpNamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNamXB.Value = new System.DateTime(2025, 3, 19, 0, 0, 0, 0);
            // 
            // txtTacGia
            // 
            this.txtTacGia.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtTacGia.BorderThickness = 2;
            this.txtTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTacGia.DefaultText = "";
            this.txtTacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTacGia.FillColor = System.Drawing.SystemColors.Control;
            this.txtTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTacGia.Location = new System.Drawing.Point(139, 196);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTacGia.PlaceholderText = "";
            this.txtTacGia.SelectedText = "";
            this.txtTacGia.Size = new System.Drawing.Size(267, 37);
            this.txtTacGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTacGia.TabIndex = 15;
            this.txtTacGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTacGia_KeyPress);
            // 
            // txtNXB
            // 
            this.txtNXB.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtNXB.BorderThickness = 2;
            this.txtNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNXB.DefaultText = "";
            this.txtNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNXB.FillColor = System.Drawing.SystemColors.Control;
            this.txtNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNXB.ForeColor = System.Drawing.Color.Black;
            this.txtNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNXB.Location = new System.Drawing.Point(139, 290);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNXB.PlaceholderText = "";
            this.txtNXB.SelectedText = "";
            this.txtNXB.Size = new System.Drawing.Size(267, 37);
            this.txtNXB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNXB.TabIndex = 17;
            this.txtNXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNXB_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtSoLuong.BorderThickness = 2;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FillColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(136, 391);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(269, 37);
            this.txtSoLuong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSoLuong.TabIndex = 18;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtTrangThai.BorderThickness = 2;
            this.txtTrangThai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrangThai.DefaultText = "";
            this.txtTrangThai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTrangThai.FillColor = System.Drawing.SystemColors.Control;
            this.txtTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrangThai.ForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTrangThai.Location = new System.Drawing.Point(136, 442);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTrangThai.PlaceholderText = "";
            this.txtTrangThai.SelectedText = "";
            this.txtTrangThai.Size = new System.Drawing.Size(269, 37);
            this.txtTrangThai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTrangThai.TabIndex = 19;
            this.txtTrangThai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrangThai_KeyPress);
            // 
            // pnframeInformation
            // 
            this.pnframeInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnframeInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnframeInformation.Controls.Add(this.txtMoTa);
            this.pnframeInformation.Controls.Add(this.label1);
            this.pnframeInformation.Controls.Add(this.cbMaTheLoai);
            this.pnframeInformation.Controls.Add(this.txtTrangThai);
            this.pnframeInformation.Controls.Add(this.btnChoiceImage);
            this.pnframeInformation.Controls.Add(this.picHinhAnhSach);
            this.pnframeInformation.Controls.Add(this.btnEditBook);
            this.pnframeInformation.Controls.Add(this.btnAddBook);
            this.pnframeInformation.Controls.Add(this.btnRefresh);
            this.pnframeInformation.Controls.Add(this.btnRemoveBook);
            this.pnframeInformation.Controls.Add(this.txtSoLuong);
            this.pnframeInformation.Controls.Add(this.txtNXB);
            this.pnframeInformation.Controls.Add(this.txtTenSach);
            this.pnframeInformation.Controls.Add(this.lblNameBook);
            this.pnframeInformation.Controls.Add(this.txtTacGia);
            this.pnframeInformation.Controls.Add(this.lblYearofpublication);
            this.pnframeInformation.Controls.Add(this.lblAuthor);
            this.pnframeInformation.Controls.Add(this.dtpNamXB);
            this.pnframeInformation.Controls.Add(this.lblCategoryCode);
            this.pnframeInformation.Controls.Add(this.lblStatus);
            this.pnframeInformation.Controls.Add(this.lblPublisher);
            this.pnframeInformation.Controls.Add(this.lblQuanlity);
            this.pnframeInformation.Location = new System.Drawing.Point(0, 0);
            this.pnframeInformation.Margin = new System.Windows.Forms.Padding(4);
            this.pnframeInformation.Name = "pnframeInformation";
            this.pnframeInformation.Size = new System.Drawing.Size(430, 756);
            this.pnframeInformation.TabIndex = 32;
            // 
            // cbMaTheLoai
            // 
            this.cbMaTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbMaTheLoai.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cbMaTheLoai.BorderThickness = 2;
            this.cbMaTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaTheLoai.ItemHeight = 30;
            this.cbMaTheLoai.Location = new System.Drawing.Point(140, 247);
            this.cbMaTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaTheLoai.Name = "cbMaTheLoai";
            this.cbMaTheLoai.Size = new System.Drawing.Size(265, 36);
            this.cbMaTheLoai.TabIndex = 29;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtTenSach.BorderThickness = 2;
            this.txtTenSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSach.CustomizableEdges.TopLeft = false;
            this.txtTenSach.DefaultText = "";
            this.txtTenSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSach.FillColor = System.Drawing.SystemColors.Control;
            this.txtTenSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSach.Location = new System.Drawing.Point(140, 151);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenSach.PlaceholderText = "";
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.Size = new System.Drawing.Size(264, 37);
            this.txtTenSach.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenSach.TabIndex = 12;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            this.txtTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSach_KeyPress);
            // 
            // radTimKiemTheLoai
            // 
            this.radTimKiemTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTimKiemTheLoai.AutoSize = true;
            this.radTimKiemTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimKiemTheLoai.Location = new System.Drawing.Point(440, 48);
            this.radTimKiemTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimKiemTheLoai.Name = "radTimKiemTheLoai";
            this.radTimKiemTheLoai.Size = new System.Drawing.Size(172, 27);
            this.radTimKiemTheLoai.TabIndex = 47;
            this.radTimKiemTheLoai.Text = "Tìm kiếm thể loại";
            this.radTimKiemTheLoai.UseVisualStyleBackColor = true;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(301, 11);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(237, 23);
            this.lblTimKiem.TabIndex = 45;
            this.lblTimKiem.Text = "TÌM KIẾM THÔNG TIN SÁCH";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(551, 82);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(125, 48);
            this.guna2Button1.TabIndex = 45;
            this.guna2Button1.Text = "Tìm kiếm";
            // 
            // radTenSach
            // 
            this.radTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radTenSach.AutoSize = true;
            this.radTenSach.Checked = true;
            this.radTenSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenSach.Location = new System.Drawing.Point(216, 48);
            this.radTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTenSach.Name = "radTenSach";
            this.radTenSach.Size = new System.Drawing.Size(177, 27);
            this.radTenSach.TabIndex = 46;
            this.radTenSach.TabStop = true;
            this.radTenSach.Text = "Tìm kiếm tên sách";
            this.radTenSach.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox1.Location = new System.Drawing.Point(109, 82);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(443, 48);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSearch.Controls.Add(this.lblTimKiem);
            this.pnSearch.Controls.Add(this.radTimKiemTheLoai);
            this.pnSearch.Controls.Add(this.guna2TextBox1);
            this.pnSearch.Controls.Add(this.radTenSach);
            this.pnSearch.Controls.Add(this.guna2Button1);
            this.pnSearch.Location = new System.Drawing.Point(429, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(765, 158);
            this.pnSearch.TabIndex = 48;
            this.pnSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSearch_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 598);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Trạng thái:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.AutoSize = true;
            this.txtMoTa.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtMoTa.BorderThickness = 2;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FillColor = System.Drawing.SystemColors.Control;
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.ForeColor = System.Drawing.Color.Black;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(135, 510);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(271, 100);
            this.txtMoTa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMoTa.TabIndex = 31;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnframeInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLySach";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnhSach)).EndInit();
            this.pnframeInformation.ResumeLayout(false);
            this.pnframeInformation.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2Button btnRemoveBook;
        private Guna.UI2.WinForms.Guna2Button btnEditBook;
        private Guna.UI2.WinForms.Guna2PictureBox picHinhAnhSach;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnChoiceImage;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblYearofpublication;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCategoryCode;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblQuanlity;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNamXB;
        private Guna.UI2.WinForms.Guna2TextBox txtTacGia;
        private Guna.UI2.WinForms.Guna2TextBox txtNXB;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private System.Windows.Forms.Panel pnframeInformation;
        private System.Windows.Forms.RadioButton radTimKiemTheLoai;
        private System.Windows.Forms.Label lblTimKiem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RadioButton radTenSach;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSach;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
    }
}