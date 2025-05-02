using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI.admin
{
    public partial class frmTrangChu : Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        SachDTO SachDTO = new SachDTO();
        DataProvider dp;
        public frmTrangChu()
        {
            InitializeComponent();
        }



        private void loadThongKeChart()
        {
            List<ThongKeDTO> danhSach = thongKeBUS.layThongKeNguoiMuonTheoNgay();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();

            // Thiết lập vùng biểu đồ
            ChartArea chartArea = new ChartArea("ChartArea1");
            chart1.ChartAreas.Add(chartArea);

            chartArea.BackColor = Color.White;
            chartArea.BorderColor = Color.LightGray;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            chartArea.AxisX.Title = "Ngày mượn";
            chartArea.AxisY.Title = "Số người mượn";

            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);

            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.Interval = 1;

            // Tạo series
            Series series = new Series("Số người mượn");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.Color = Color.DodgerBlue;
            series.BorderWidth = 2;
            series.Font = new Font("Segoe UI", 9);

            foreach (var item in danhSach)
            {
                series.Points.AddXY(item.NgayMuon.ToString("dd/MM/yyyy"), item.SoNguoiMuon);
            }

            chart1.Series.Add(series);

            // Thêm tiêu đề
            Title title = new Title("Thống kê số người mượn theo ngày", Docking.Top, new Font("Segoe UI", 12, FontStyle.Bold), Color.Black);
            chart1.Titles.Add(title);

            // Hiển thị label giá trị trên mỗi cột
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.Black;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            loadThongKeChart();
        }
    }
}
