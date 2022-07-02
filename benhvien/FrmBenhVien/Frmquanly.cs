using benhvien.model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benhvien
{
    public partial class Frmquanly : Form
    {
        bool thoat = true;
        benhvien1 context = new benhvien1();
        public Frmquanly()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hàm chuyển paner
        /// </summary>
        private Form cuurentFormChild;
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void OpenChildForm(Form childForm)
        {
            if (cuurentFormChild != null)
            {
                cuurentFormChild.Close();
            }
            cuurentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// button trang chue quản lý tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntaikhoan_Click(object sender, EventArgs e)
        {
            if (cuurentFormChild != null)
            {

                cuurentFormChild.Close();
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyBS());
 
        }
        private void btnbenhnhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyBN());
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new quanlytaikhoan());
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frmtrang_chu());
        }
        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất tài khoản ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                thoat = false;
                this.Close();
                Frmdangnhap a = new Frmdangnhap();
                a.Show();
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frmxetnghiem());
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThuoc_ThietBi());
        }
        private void btntrangchu_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
        string id = "";
        private void Frmquanly_Load(object sender, EventArgs e)
        {
            //phanquyen();
            
        }
        /*string taikhoan = "", matkhau = "", maNhom = "";
        public Frmquanly(string Taikhoan, string Matkhau, string MaNhom)
        {
            InitializeComponent();
            this.taikhoan = Taikhoan;
            this.matkhau = Matkhau;
            this.maNhom = MaNhom;
        }
        List<string> list_detail;
        private Boolean checkper(string code)
        {
            Boolean check = false;
            foreach (string item in list_detail)
            { if (item == code) { check = true; } }
            return check;
        }
        void phanquyen()
        {
            if (["MaNhom"].ToString() == "False")
            {
                id = ["TenNhom"].ToString();
            }
            //if(Quyen.VT == 1)
            if (checkper("N2") == true)
            {
                //btntrangchu.Enabled = btnbacsi.Enabled = btnbenhnhan.Enabled = btntaikhoan.Enabled = BtnDakhoa.Enabled = btnthuocvattu.Enabled = BtnXetnghiem.Enabled = true;
                //btntrangchu.Enabled = btntaikhoan.Enabled = btnbacsi.Enabled = btnbenhnhan.Enabled = btnthuocvattu.Enabled = true;
                BtnDakhoa.Enabled = BtnXetnghiem.Enabled = false;
            }
            else if(checkper("N3") == true)
            {
                btnbacsi.Enabled = btnbenhnhan.Enabled = btntaikhoan.Enabled = btnthuocvattu.Enabled = false;
                //btntrangchu.Enabled = BtnXetnghiem.Enabled = BtnDakhoa.Enabled = true;
            } 
        }*/
    }
}
