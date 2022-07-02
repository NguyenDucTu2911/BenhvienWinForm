using benhvien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benhvien
{
    public partial class FrmThuoc_ThietBi : Form
    {
        benhvien1 context = new benhvien1();
        public FrmThuoc_ThietBi()
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
            TxtTênThuốc.Clear();
            TxtSLThuoc.Clear();
            txtdongia.Clear();
            txthangsanxuatthuoc.Clear();
            txtHnagvt.Clear();
            txtMaThuoc.Clear();
            txtMaVt.Clear();
            txtSLvt.Clear();
            txtTenvt.Clear();
            txttimthuoc.Clear();
            txttimvt.Clear();
            TxtDVT.Clear();
            TxtTênThuốc.Focus();
        }
        //load danh sách lên datagirlview
        private void BindGrid(List<Thuoc> listthuoc)
        {
            Dgvthuoc.Rows.Clear();
            foreach (var item in listthuoc)
            {
                int index = Dgvthuoc.Rows.Add();
                Dgvthuoc.Rows[index].Cells[0].Value = item.MaThuoc;
                Dgvthuoc.Rows[index].Cells[1].Value = item.TenThuoc;
                Dgvthuoc.Rows[index].Cells[2].Value = item.HangSanXuat;
                Dgvthuoc.Rows[index].Cells[3].Value = item.DonViTinh;
                Dgvthuoc.Rows[index].Cells[4].Value = item.SoLuong;
                Dgvthuoc.Rows[index].Cells[5].Value = item.DonGia;
            }
        }
        private void BindGridvt(List<VatTu> listvattu)
        {
            DgvVattu.Rows.Clear();
            foreach (var item in listvattu)
            {
                int index = DgvVattu.Rows.Add();
                DgvVattu.Rows[index].Cells[0].Value = item.MaVT;
                DgvVattu.Rows[index].Cells[1].Value = item.TenVT;
                DgvVattu.Rows[index].Cells[2].Value = item.Hang;
                DgvVattu.Rows[index].Cells[3].Value = item.SL;
            }
        }
        //load lại danh sách
        private void Loaddgv()
        {
            List<Thuoc> Thuoc = context.Thuocs.ToList();
            List<VatTu> VatTu = context.VatTus.ToList();
            
            BindGrid(Thuoc);
            BindGridvt(VatTu);
        }
        private void FrmThuoc_ThietBi_Load(object sender, EventArgs e)
        {
            List<VatTu> listvattu = context.VatTus.ToList();
            List<Thuoc> listthuoc = context.Thuocs.ToList();
            BindGrid(listthuoc);
            BindGridvt(listvattu);
        }
        /// <summary>
        /// hàm check
        /// </summary>
        /// <returns></returns>
        private bool checkvt()
        {
            if (txtMaVt.Text == "" || txtTenvt.Text == "" || txtHnagvt.Text == "" || txtSLvt.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtMaVt.TextLength < 2)
            {
                MessageBox.Show("Mã Vật Tư Phải lớn hơn 2 ký tự", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool check()
        {
            if (txtMaThuoc.Text == "" || TxtTênThuốc.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtMaThuoc.TextLength < 2)
            {
                MessageBox.Show("Mã Thuốc Phải lớn hơn 2 ký tự", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //check xem mã thuốc có trùng k
        private int checkid(string tk)
        {
            int length = Dgvthuoc.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (Dgvthuoc.Rows[i].Cells[0].Value != null)
                    if (Dgvthuoc.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        private int checkidvt(string tk)
        {
            int length = DgvVattu.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (DgvVattu.Rows[i].Cells[0].Value != null)
                    if (DgvVattu.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        /// <summary>
        /// Button Thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthemthuoc_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkid(txtMaThuoc.Text) == -1)
                {

                    Thuoc newsThuoc = new Thuoc();
                    newsThuoc.MaThuoc = txtMaThuoc.Text;
                    newsThuoc.TenThuoc = TxtTênThuốc.Text;
                    newsThuoc.SoLuong = Convert.ToInt32(TxtSLThuoc.Text);
                    newsThuoc.DonGia = Convert.ToInt32(txtdongia.Text);
                    newsThuoc.DonViTinh =TxtDVT.Text;
                    newsThuoc.HangSanXuat = txthangsanxuatthuoc.Text;
                    context.Thuocs.AddOrUpdate(newsThuoc);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Thuốc Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Thuốc Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkid(txtMaThuoc.Text) != -1)
                {

                    Thuoc newsThuoc = new Thuoc();
                    newsThuoc.MaThuoc = txtMaThuoc.Text;
                    newsThuoc.TenThuoc = TxtTênThuốc.Text;
                    newsThuoc.SoLuong = Convert.ToInt32(TxtSLThuoc.Text);
                    newsThuoc.DonGia = Convert.ToInt32(txtdongia.Text);
                    newsThuoc.DonViTinh = TxtDVT.Text;
                    newsThuoc.HangSanXuat = txthangsanxuatthuoc.Text;
                    context.Thuocs.AddOrUpdate(newsThuoc);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Sửa Thuốc Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Sửa Thuốc không Thành Công", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrow = checkid(txtMaThuoc.Text);
                if (selectedrow == -1)
                {
                    throw new Exception("Không Tìm Thấy Thông Tin Cần Xóa");
                }
                else
                {
                    DialogResult dw = MessageBox.Show("Bạn Muốn Xóa Thông Tin ?", "THÔNG BÁO", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dw == DialogResult.Yes)
                    {
                        Dgvthuoc.Rows.RemoveAt(selectedrow);
                        MessageBox.Show("Xóa Thông Tin Thành Công", "THÔNG BÁO");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        /// <summary>
        /// Button Vật Tư
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (checkvt())
            {
                if (checkidvt(txtMaVt.Text) == -1)
                {

                    VatTu newsVattu = new VatTu();
                    newsVattu.MaVT = txtMaVt.Text;
                    newsVattu.TenVT = txtTenvt.Text;
                    newsVattu.Hang = txtHnagvt.Text;
                    newsVattu.SL = Convert.ToInt32(txtSLvt.Text);
                   
                    context.VatTus.AddOrUpdate(newsVattu);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Vật tư Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Vật Tư Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnsuavt_Click(object sender, EventArgs e)
        {
            if (checkvt())
            {
                if (checkidvt(txtMaVt.Text) != -1)
                {

                    VatTu newsVattu = new VatTu();
                    newsVattu.MaVT = txtMaVt.Text;
                    newsVattu.TenVT = txtTenvt.Text;
                    newsVattu.Hang = txtHnagvt.Text;
                    newsVattu.SL = Convert.ToInt32(txtSLvt.Text);

                    context.VatTus.AddOrUpdate(newsVattu);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Sửa Vật Tư Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Mã Vật tư Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnxoavt_Click(object sender, EventArgs e)
        {
            try
            {
                int Delete = checkidvt(txtMaVt.Text);
                VatTu dbDelete = context.VatTus.FirstOrDefault(x => x.MaVT == txtMaVt.Text);

                if (Delete == -1)
                {
                    throw new Exception("Không Tìm Thấy Thông Tin Cần Xóa");
                }
                else
                {
                    DialogResult dw = MessageBox.Show("Bạn Muốn Xóa Thông Tin", "THÔNG BÁO", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dw == DialogResult.Yes)
                    {
                        context.VatTus.Remove(dbDelete);
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
        /// <summary>
        /// sự kiện thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSLThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Dgvthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Dgvthuoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Dgvthuoc.CurrentRow.Selected = true;

                    txtMaThuoc.Text = Dgvthuoc.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    TxtTênThuốc.Text = Dgvthuoc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txthangsanxuatthuoc.Text = Dgvthuoc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    TxtDVT.Text = Dgvthuoc.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    TxtSLThuoc.Text = Dgvthuoc.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtdongia.Text = Dgvthuoc.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        ///button in
        private void btnin_Click(object sender, EventArgs e)
        {
            FrmReportThuoc_VatTu a = new FrmReportThuoc_VatTu();
            a.Show();
        }
        /// <summary>
        /// sự kiện vật tư
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvVattu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvVattu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Dgvthuoc.CurrentRow.Selected = true;

                    txtMaVt.Text = DgvVattu.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenvt.Text = DgvVattu.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtHnagvt.Text = DgvVattu.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtSLvt.Text = DgvVattu.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void txtSLvt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txttimvt_TextChanged(object sender, EventArgs e)
        {
            List<VatTu> listvattu = context.VatTus.ToList();
            if (txttimvt.TextLength > 0)
            {
                var listTim = listvattu.Where(p => p.TenVT.ToLower().Contains(txttimvt.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {
                    BindGridvt(listTim);
                }
            }
            else
            {

                BindGridvt(listvattu); //LOAD LẠI BẢNG KHI KHÔNG TÌM KIẾM
            }
        }
        private void txttimthuoc_TextChanged(object sender, EventArgs e)
        {
            List<Thuoc> listThuoc = context.Thuocs.ToList();
            if (txttimthuoc.TextLength > 0)
            {
                var listTim = listThuoc.Where(p => p.TenThuoc.ToLower().Contains(txttimthuoc.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {
                    BindGrid(listTim);
                }
            }
            else
            {

                BindGrid(listThuoc); //LOAD LẠI BẢNG KHI KHÔNG TÌM KIẾM
            }
        }

        
    }
}
