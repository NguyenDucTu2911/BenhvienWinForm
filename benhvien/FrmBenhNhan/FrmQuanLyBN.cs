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
using benhvien.model;
using System.Globalization;

namespace benhvien
{
    public partial class FrmQuanLyBN : Form
    {
        benhvien1 context = new benhvien1();
        public FrmQuanLyBN()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load form
        /// </summary>
        /// <param name="listbenhnhan"></param>
        private void LoadFrom()
        {
            txtmabenh.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtdantoc.Clear();
            txtquoctich.Clear();
            //txtngay.Clear();
            txtnghe.Clear();
            txtbhyt.Clear();
            txtGhChu.Clear();
            txtmabenh.Focus();
        }
        private void Loaddgv()
        {
            List<DSbenhnhan> benhnhan = context.DSbenhnhans.ToList();
            BindGrid(benhnhan);
        }
        private void FrmQuanLyBN_Load(object sender, EventArgs e)
        {
            cbbGioitinh.Text = "Nam";
            cbbDoiTuong.Text = "Miễn Phí";
            cbbPhongKham.Text = "Đa Khoa";
            try
            {
                List<DSbenhnhan> listbenhnhan = context.DSbenhnhans.ToList();
                BindGrid(listbenhnhan);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<DSbenhnhan> listbenhnhan)
        {
            dgvbenhnhan2.Rows.Clear();
            foreach (var item in listbenhnhan)
            {
                int index = dgvbenhnhan2.Rows.Add();
                dgvbenhnhan2.Rows[index].Cells[0].Value = item.MaBN;
                dgvbenhnhan2.Rows[index].Cells[1].Value = item.HoTen;
                dgvbenhnhan2.Rows[index].Cells[2].Value = item.NgaySinh.ToString("dd-MM-yyyy");
                dgvbenhnhan2.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvbenhnhan2.Rows[index].Cells[4].Value = item.DiaChi;
                dgvbenhnhan2.Rows[index].Cells[5].Value = item.DanToc;
                dgvbenhnhan2.Rows[index].Cells[6].Value = item.QuocTich;
                dgvbenhnhan2.Rows[index].Cells[7].Value = item.NgheNghiep;
                dgvbenhnhan2.Rows[index].Cells[8].Value = item.DoiTuong;
                dgvbenhnhan2.Rows[index].Cells[9].Value = item.SoBHYT;
                dgvbenhnhan2.Rows[index].Cells[10].Value = item.GiaTriBHYT.ToString("dd-MM-yyyy");
                dgvbenhnhan2.Rows[index].Cells[11].Value = item.PhongKham;
                dgvbenhnhan2.Rows[index].Cells[12].Value = item.GhiChu;
            }
        }
        /// <summary>
        /// hàm check thông tin nhập
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        private int checkidSV(string tk)
        {
            int length = dgvbenhnhan2.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvbenhnhan2.Rows[i].Cells[0].Value != null)
                    if (dgvbenhnhan2.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        private bool check()
        {
            if (txtmabenh.Text == "" || txthoten.Text == "" || cbbGioitinh.Text == "" || txtdiachi.Text == "" || txtdantoc.Text == "" || txtquoctich.Text == "" || dtpNgaySinh.Text == "" || txtnghe.Text == "" || cbbDoiTuong.Text == "" || txtbhyt.Text == "" || dtpGiaTriBHYT.Text == "" || cbbPhongKham.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtmabenh.TextLength < 5)
            {
                MessageBox.Show("Mã Bệnh Nhân Phải Có 5 Ký Tự Trở Nên Mới Tính !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// hàm sự kiên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvbenhnhan2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvbenhnhan2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvbenhnhan2.CurrentRow.Selected = true;

                    txtmabenh.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txthoten.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cbbGioitinh.SelectedIndex = cbbGioitinh.FindString(dgvbenhnhan2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    txtdiachi.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtdantoc.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    txtquoctich.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                    DateTime dt = DateTime.ParseExact(dgvbenhnhan2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;
                    txtnghe.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    cbbDoiTuong.SelectedIndex = cbbDoiTuong.FindString(dgvbenhnhan2.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                    txtbhyt.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    DateTime da = DateTime.ParseExact(dgvbenhnhan2.Rows[e.RowIndex].Cells[10].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpGiaTriBHYT.Value = da;
                    cbbPhongKham.SelectedIndex = cbbPhongKham.FindString(dgvbenhnhan2.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
                    txtGhChu.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// button quản lý bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkidSV(txtmabenh.Text) == -1)
                {

                    DSbenhnhan newsDSbenhnhan = new DSbenhnhan();
                    newsDSbenhnhan.MaBN = txtmabenh.Text;
                    newsDSbenhnhan.HoTen = txthoten.Text;
                    newsDSbenhnhan.GioiTinh = cbbGioitinh.Text;
                    newsDSbenhnhan.DiaChi = txtdiachi.Text;
                    newsDSbenhnhan.DanToc = txtdantoc.Text;
                    newsDSbenhnhan.QuocTich = txtquoctich.Text;
                    newsDSbenhnhan.NgaySinh = dtpNgaySinh.Value;
                    newsDSbenhnhan.NgheNghiep = txtnghe.Text;
                    newsDSbenhnhan.DoiTuong = cbbDoiTuong.Text;
                    newsDSbenhnhan.SoBHYT = txtbhyt.Text;
                    newsDSbenhnhan.GiaTriBHYT = dtpGiaTriBHYT.Value;
                    newsDSbenhnhan.PhongKham = cbbPhongKham.Text;
                    newsDSbenhnhan.GhiChu = txtGhChu.Text;
                    context.DSbenhnhans.AddOrUpdate(newsDSbenhnhan);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Bệnh Nhân Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Mã Bệnh Này Đã Tồn tại !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DSbenhnhan dbUpdate = context.DSbenhnhans.FirstOrDefault(x => x.MaBN == txtmabenh.Text);
            if (dbUpdate != null)
            {
                DSbenhnhan newsDSbenhnhan = new DSbenhnhan();
                newsDSbenhnhan.MaBN = txtmabenh.Text;
                newsDSbenhnhan.HoTen = txthoten.Text;
                newsDSbenhnhan.GioiTinh = cbbGioitinh.Text;
                newsDSbenhnhan.DiaChi = txtdiachi.Text;
                newsDSbenhnhan.DanToc = txtdantoc.Text;
                newsDSbenhnhan.QuocTich = txtquoctich.Text;
                newsDSbenhnhan.NgaySinh = dtpNgaySinh.Value;
                newsDSbenhnhan.NgheNghiep = txtnghe.Text;
                newsDSbenhnhan.DoiTuong = cbbDoiTuong.Text;
                newsDSbenhnhan.SoBHYT = txtbhyt.Text;
                newsDSbenhnhan.GiaTriBHYT = dtpGiaTriBHYT.Value;
                newsDSbenhnhan.PhongKham = cbbPhongKham.Text;
                newsDSbenhnhan.GhiChu = txtGhChu.Text;
                context.DSbenhnhans.AddOrUpdate(newsDSbenhnhan);
                context.SaveChanges();

                LoadFrom();
                Loaddgv();

                MessageBox.Show("Cập Nhật Bệnh Nhân Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Không Sửa Được Thông Tin !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Delete = checkidSV(txtmabenh.Text);
                DSbenhnhan dbDelete = context.DSbenhnhans.FirstOrDefault(x => x.MaBN == txtmabenh.Text);

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
                        context.DSbenhnhans.Remove(dbDelete);
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
        private void btnthongke_Click(object sender, EventArgs e)
        {
            Frmbenhnhan BN = new Frmbenhnhan();
            BN.Show();
        }
    }
}
