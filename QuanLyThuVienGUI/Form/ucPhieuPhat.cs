using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienGUI
{
    public partial class ucPhieuPhat : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        private string maNV;
       
        public ucPhieuPhat(admin.frmQuanLyMuonTra parent, string maNV)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.maNV = maNV;
        }

        private void ucPhieuPhat_Load(object sender, EventArgs e)
        {

        }


        private void txt_Thoat_Click(object sender, EventArgs e)
        {
            parentForm.ShowDefaultView();
        }
    }
}
