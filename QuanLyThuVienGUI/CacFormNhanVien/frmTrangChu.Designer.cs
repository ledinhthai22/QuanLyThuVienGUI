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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grp_ = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(297, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(99, 8);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(108, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THỐNG KÊ";
            // 
            // grp_
            // 
            this.grp_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grp_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grp_.Location = new System.Drawing.Point(12, 64);
            this.grp_.Name = "grp_";
            this.grp_.Size = new System.Drawing.Size(430, 170);
            this.grp_.TabIndex = 1;
            this.grp_.Text = "guna2GroupBox1";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(448, 64);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(429, 170);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "guna2GroupBox2";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.chart1);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 240);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(865, 362);
            this.guna2GroupBox3.TabIndex = 2;
            this.guna2GroupBox3.Text = "guna2GroupBox3";
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 54);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(486, 305);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.grp_);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTrangChu";
            this.Text = "frmQuanLyThongKe";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2GroupBox grp_;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}