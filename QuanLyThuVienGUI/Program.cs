using System;
using System.Windows.Forms;
using QuanLyThuVienGUI.QuanLy;

namespace QuanLyThuVienGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string tenNV = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(tenNV));
        }
    }
}
