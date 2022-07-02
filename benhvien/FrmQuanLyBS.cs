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
    public partial class FrmQuanLyBS : Form
    {
        benhvien1 context = new benhvien1();
        public FrmQuanLyBS()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load form
        /// </summary>
        /// <param name="listbacsi"></param>
        private void FrmQuanLyBS_Load(object sender, EventArgs e)
        {
            cbbGioiTinh.Text = "Nam";
            try
            {
                List<DSbacsi> listbs = context.DSbacsis.ToList();
                List<Khoa> listKhoa = context.Khoas.ToList();
                BindGrid(listbs);
                FillFalcultyComboboxKhoa(listKhoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFrom()
        {
            txtma.Clear();
            txthoten.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtchucvu.Clear();
            txtma.Focus();
        }
        private void Loaddgv()
        {
            List<DSbacsi> DSbacsi = context.DSbacsis.ToList();
            BindGrid(DSbacsi);
        }
        private void BindGrid(List<DSbacsi> listbs)
        {
            dgvbacsi.Rows.Clear();
            foreach (var item in listbs)
            {
                int index = dgvbacsi.Rows.Add();
                dgvbacsi.Rows[index].Cells[0].Value = item.MaBS;
                dgvbacsi.Rows[index].Cells[1].Value = item.HoTenBS;
                dgvbacsi.Rows[index].Cells[2].Value = item.GioiTinh;
                dgvbacsi.Rows[index].Cells[3].Value = item.NgaySinh.ToString("dd-MM-yyyy");
                dgvbacsi.Rows[index].Cells[4].Value = item.DiaChi;
                dgvbacsi.Rows[index].Cells[5].Value = item.SDT;
                dgvbacsi.Rows[index].Cells[6].Value = item.Khoa.TenKhoa;
                dgvbacsi.Rows[index].Cells[7].Value = item.ChucVu;
            }
        }
        //load cbb form load
        private void FillFalcultyComboboxKhoa(List<Khoa> listbacsi)
        {
            this.cbbkhoa.DataSource = listbacsi;
            this.cbbkhoa.DisplayMember = "TenKhoa";
            this.cbbkhoa.ValueMember = "KhoaID";
        }
        /// <summary>
        /// check thông tin bác sĩ
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        private int checkidSV(string tk)
        {
            int length = dgvbacsi.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvbacsi.Rows[i].Cells[0].Value != null)
                    if (dgvbacsi.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        private bool check()
        {
            if (txtma.Text == "" || txthoten.Text == "" || dtpNgaySinh.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtchucvu.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtma.TextLength < 5)
            {
                MessageBox.Show("Mã Bác Sĩ Phải Có 5 Ký Tự Trở Nên Mới Tính !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// button quản lý bác sĩ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkidSV(txtma.Text) == -1)
                {
                    DSbacsi newsDSbacsi = new DSbacsi();
                    newsDSbacsi.MaBS = txtma.Text;
                    newsDSbacsi.HoTenBS = txthoten.Text;
                    newsDSbacsi.GioiTinh = cbbGioiTinh.Text;
                    newsDSbacsi.NgaySinh = dtpNgaySinh.Value;
                    newsDSbacsi.KhoaID = Convert.ToInt32(cbbkhoa.SelectedValue.ToString());
                    newsDSbacsi.SDT = txtsdt.Text;
                    newsDSbacsi.DiaChi = txtdiachi.Text;
                    newsDSbacsi.ChucVu = txtchucvu.Text;
                    context.DSbacsis.AddOrUpdate(newsDSbacsi);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Bác Sĩ Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Mã Bác Sĩ Này Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int Delete = checkidSV(txtma.Text);
                DSbacsi dbDelete = context.DSbacsis.FirstOrDefault(x => x.MaBS == txtma.Text);
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
                        context.DSbacsis.Remove(dbDelete);
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
        private void btnsua_Click(object sender, EventArgs e)
        {
            DSbacsi dbUpdate = context.DSbacsis.FirstOrDefault(x => x.MaBS == txtma.Text);
            if (dbUpdate != null)
            {
                DSbacsi newsDSbacsi = new DSbacsi();
                newsDSbacsi.MaBS = txtma.Text;
                newsDSbacsi.HoTenBS = txthoten.Text;
                newsDSbacsi.GioiTinh = cbbGioiTinh.Text;
                newsDSbacsi.NgaySinh = dtpNgaySinh.Value;
                newsDSbacsi.KhoaID = Convert.ToInt32(cbbkhoa.SelectedValue.ToString());
                newsDSbacsi.SDT = txtsdt.Text;
                newsDSbacsi.DiaChi = txtdiachi.Text;
                newsDSbacsi.ChucVu = txtchucvu.Text;
                context.DSbacsis.AddOrUpdate(newsDSbacsi);
                context.SaveChanges();

                LoadFrom();
                Loaddgv();

                MessageBox.Show("Sửa Bác Sĩ Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không Sửa Được Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            Frmbacsi BS = new Frmbacsi();
            BS.Show();
        }
        /// <summary>
        /// hàm sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvbacsi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvbacsi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvbacsi.CurrentRow.Selected = true;

                    txtma.Text = dgvbacsi.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txthoten.Text = dgvbacsi.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cbbGioiTinh.SelectedIndex = cbbGioiTinh.FindString(dgvbacsi.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    DateTime dt = DateTime.ParseExact(dgvbacsi.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;
                    txtdiachi.Text = dgvbacsi.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtsdt.Text = dgvbacsi.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    cbbkhoa.SelectedIndex = cbbkhoa.FindString(dgvbacsi.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                    txtchucvu.Text = dgvbacsi.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
