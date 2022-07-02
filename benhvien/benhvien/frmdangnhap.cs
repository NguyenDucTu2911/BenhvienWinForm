using benhvien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benhvien
{
    public partial class Frmdangnhap : Form
    {
        private SqlConnection Con = null;
        benhvien1 context = new benhvien1();
        
        MD5 md = MD5.Create();
        public Frmdangnhap()
        {
            InitializeComponent();
            txtmatkhau.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// button đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-FFMK4QE;Initial Catalog=benhvien;Integrated Security=True";
            Con.Open();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtmatkhau.Text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = md.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string select = "select * from dstaikhoan where TaiKhoan = '" + txttaikhoan.Text + "' and Matkhau = '" + txtmatkhau.Text + "'";
            SqlCommand cmd = new SqlCommand(select, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Read();
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "Thông báo !");

                Frmquanly a = new Frmquanly();
                a.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("SAI TÀI KHOẢN HOẶC MẬT KHẨU VUI LÒNG NHẬP LẠI !", "CẢNH BÁO !");

            }
        }
        /// <summary>
        /// check ẩn hiện mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtmatkhau_IconRightClick_1(object sender, EventArgs e)
        {
            if (txtmatkhau.UseSystemPasswordChar)
            {
                txtmatkhau.UseSystemPasswordChar = false;
                txtmatkhau.IconRight = Properties.Resources.icons8_eye_50;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true;
                txtmatkhau.IconRight = Properties.Resources.icons8_eye_50;
            }
        }  
    }
}
