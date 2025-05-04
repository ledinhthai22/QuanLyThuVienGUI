using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVienBUS;
using QuanLyThuVienDTO;

namespace QuanLyThuVienGUI
{
    public partial class ucPhieuPhat : UserControl
    {
        private admin.frmQuanLyMuonTra parentForm;
        private string maNV;
        PhieuMuonDTO phieuMuonDTO = new PhieuMuonDTO();
        PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
        PhieuPhatBUS phieuPhatBUS = new PhieuPhatBUS();
        List<PhieuMuonDTO> danhSachPhieuMuon = new List<PhieuMuonDTO>();
        public ucPhieuPhat(admin.frmQuanLyMuonTra parent, string maNV)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.maNV = maNV;
        }

        private void ucPhieuPhat_Load(object sender, EventArgs e)
        {
           
            
            
            
        }
       
       
    }
}
