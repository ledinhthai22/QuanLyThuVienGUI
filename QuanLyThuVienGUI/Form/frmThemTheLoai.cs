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

namespace QuanLyThuVienGUI.QuanLy
{
    public partial class frmThemTheLoai: Form
    {
        TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmThemTheLoai()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.MouseUp += new MouseEventHandler(Form_MouseUp);

            // Gắn sự kiện kéo thả cho panel tiêu đề
            this.pn_Tab.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.pn_Tab.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.pn_Tab.MouseUp += new MouseEventHandler(Form_MouseUp);
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_TenTheLoai.Text))
            {
                return;
            }
            else
            {
                theLoaiDTO.tenTL = txt_TenTheLoai.Text;
                if(!theLoaiBUS.kiemTraTonTai(theLoaiDTO))
                {
                    if (theLoaiBUS.addTheLoai(theLoaiDTO))
                    {
                        MessageBox.Show("Thêm thể loại thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thể loại thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Thể loại đã tồn tại");
                }
            }    
        }

        private void txt_TenTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
