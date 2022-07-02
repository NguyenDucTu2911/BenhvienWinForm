using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using benhvien.model;

namespace benhvien
{
    public partial class quanlytaikhoan : Form
    {
        benhvien1 context = new benhvien1();
        MD5 md5 = MD5.Create();
        public quanlytaikhoan()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load form
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        // load form và chuột về tài khoản
        private void LoadFrom() 
        {
            txttk.Clear();
            txtmk.Clear();
            txttk.Focus();
        }
        private void quanlytaikhoan_Load(object sender, EventArgs e)
        {
            //cbbmabs.Text = "Nam";
            cbbmanhom.Enabled = false;
            cbbmanhom.Text = "giám Đốc";
            List<nhomnguoidung> listtaikhoan = context.nhomnguoidungs.ToList();
            List<dstaikhoan> listdanhsach = context.dstaikhoans.ToList();
            FillFalcultyComboboxKhoa(listtaikhoan);
            BindGrid(listdanhsach);
        }
        //load danh sách lên datagirlview
        private void BindGrid(List<dstaikhoan> listdanhsach) 
        {
            datataikhoan.Rows.Clear();
            foreach (var item in listdanhsach)
            {
                int index = datataikhoan.Rows.Add();
                datataikhoan.Rows[index].Cells[0].Value = item.MaNhom;
                datataikhoan.Rows[index].Cells[1].Value = item.nhomnguoidung.TenNhom;
                datataikhoan.Rows[index].Cells[2].Value = item.HoTen;
                datataikhoan.Rows[index].Cells[3].Value = item.ChucVu; 
                datataikhoan.Rows[index].Cells[4].Value = item.Taikhoan;
                datataikhoan.Rows[index].Cells[5].Value = item.Matkhau;
            }
            lblTong.Text = $" Số Tài Khoản: { datataikhoan.RowCount }";
        }
        //load lại danh sách
        private void Loaddgv() 
        {
            List<dstaikhoan> taikhoan = context.dstaikhoans.ToList();
            BindGrid(taikhoan);
        }
        private void FillFalcultyComboboxKhoa(List<nhomnguoidung> listtaikhoan)
        {
            this.cbbmanhom.DataSource = listtaikhoan;
            this.cbbmanhom.DisplayMember = "MaNhom";
            this.cbbmanhom.ValueMember = "TenNhom";

            this.txttennhom.DataSource = listtaikhoan;
            this.txttennhom.DisplayMember = "TenNhom";
            this.txttennhom.ValueMember = "MaNhom";
        }
        /// <summary>
        /// sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datataikhoan_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datataikhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    datataikhoan.CurrentRow.Selected = true;

                    cbbmanhom.Text = datataikhoan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txttennhom.Text = datataikhoan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txthoten.Text = datataikhoan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtchucvu.Text = datataikhoan.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txttk.Text = datataikhoan.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtmk.Text = datataikhoan.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// hàm check điều kiện
        /// </summary>
        /// <returns></returns>
        //check thông tin 
        private bool check() 
        {
            if (txttk.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtmk.TextLength < 5)
            {
                MessageBox.Show("Mật khẩu Phải lớn hơn 5 ký tự", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //check xem Tài khoản có trùng hay không
        private int checkid(string tk) 
        {
            int length = datataikhoan.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (datataikhoan.Rows[i].Cells[4].Value != null)
                    if (datataikhoan.Rows[i].Cells[4].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        /// <summary>
        /// các button 
        /// </summary>
        
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkid(txttk.Text) == -1)
                {

                    dstaikhoan newstaikhoan = new dstaikhoan();
                    newstaikhoan.HoTen = txthoten.Text;
                    newstaikhoan.ChucVu = txtchucvu.Text;
                    newstaikhoan.MaNhom = cbbmanhom.Text;
                    newstaikhoan.Taikhoan = txttk.Text;
                    newstaikhoan.Matkhau = txtmk.Text;
                    byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtmk.Text);
                    byte[] Hash = md5.ComputeHash(inputstr);
                    StringBuilder sBuilder = new StringBuilder();
                    for (int i = 0; i < Hash.Length; i++)
                    {
                        sBuilder.Append(Hash[i].ToString("x2"));
                    }
                    newstaikhoan.Matkhau = sBuilder.ToString();
                    context.dstaikhoans.AddOrUpdate(newstaikhoan);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Tạo Tài Khoản Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Tài Khoản Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                dstaikhoan dbUpdate = context.dstaikhoans.FirstOrDefault(p => p.Taikhoan == txttk.Text);
                if (dbUpdate != null)
                {
                    dstaikhoan newstaikhoan = new dstaikhoan();
                    newstaikhoan.HoTen = txthoten.Text;
                    newstaikhoan.ChucVu = txtchucvu.Text;
                    newstaikhoan.MaNhom = cbbmanhom.Text;
                    newstaikhoan.Taikhoan = txttk.Text;
                    newstaikhoan.Matkhau = txtmk.Text;
                    byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtmk.Text);
                    byte[] Hash = md5.ComputeHash(inputstr);
                    StringBuilder sBuilder = new StringBuilder();
                    for (int i = 0; i < Hash.Length; i++)
                    {
                        sBuilder.Append(Hash[i].ToString("x2"));
                    }
                    newstaikhoan.Matkhau = sBuilder.ToString();
                    context.dstaikhoans.AddOrUpdate(newstaikhoan);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();
                    MessageBox.Show($"Sửa tài khoản thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Tài khoản đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                int Delete = checkid(txttk.Text);
                dstaikhoan dbDelete = context.dstaikhoans.FirstOrDefault(p => p.Taikhoan == txttk.Text);
                if (Delete == -1)
                {
                    throw new Exception("Không Tìm Thấy Tài khoản Cần Xóa");
                }
                else
                { 
                    DialogResult dw = MessageBox.Show("Bạn Muốn Xóa Thông Tin ?", "THÔNG BÁO", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dw == DialogResult.Yes)
                    {
                        context.dstaikhoans.Remove(dbDelete);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thông Tin Thành Công", "THÔNG BÁO");
                        LoadFrom();
                        Loaddgv();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienMatKhau_Click_2(object sender, EventArgs e)
        {
            if (txtmk.UseSystemPasswordChar)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// hàm tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttim_TextChanged_2(object sender, EventArgs e)
        {
            List<dstaikhoan> listdanhsach = context.dstaikhoans.ToList();
            if (txttim.Text.Length > 1)
            {
                var listTim = listdanhsach = listdanhsach.Where(p => p.Taikhoan.ToLower().Contains(txttim.Text.ToLower())
                || p.HoTen.ToLower().Contains(txttim.Text.ToLower()) || p.MaNhom.ToLower().Contains(txttim.Text.ToLower())
                || p.nhomnguoidung.TenNhom.ToLower().Contains(txttim.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {
                    BindGrid(listTim);
                }
                lblTong.Text = $" Số Tài Khoản: { datataikhoan.RowCount }";

            }
            else
            {
                BindGrid(listdanhsach);
            }
        }
    }
}
