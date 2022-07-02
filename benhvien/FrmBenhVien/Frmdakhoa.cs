using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using benhvien.model;
using benhvien.Report;
using CrystalDecisions.Shared;
using Microsoft.Reporting.WinForms;


namespace benhvien
{
    public partial class Frmtrang_chu : Form
    {
        benhvien1 context = new benhvien1();
        FrmDonThuoc frmcon = new FrmDonThuoc();
        public Frmtrang_chu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="listdakhoa"></param>
        // LOAD FORM VÀ TRẢ NHÁY VỀ MÃ ĐĂNG KÝ
        private void LoadFrom()
        {
            txtmadk.Clear();
            rttong.Clear();
            rtbo.Clear();
            rtchuan.Clear();
            rtlam.Clear();
            rtttbenh.Clear();
            txtmadk.Focus();
        }
        //LOAD DỮ LIỆU LÊN DATAGIRLVIEW
        private void BindGrid(List<dakhoa> listdakhoa) 
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listdakhoa)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaDK;
                dataGridView1.Rows[index].Cells[1].Value = item.MaBN;
                dataGridView1.Rows[index].Cells[2].Value = item.HoTenBN;
                dataGridView1.Rows[index].Cells[3].Value = item.NgaySinh.ToString("dd-MM-yyyy");
                dataGridView1.Rows[index].Cells[4].Value = item.GioiTinh;
                dataGridView1.Rows[index].Cells[5].Value = item.MaBS;
                dataGridView1.Rows[index].Cells[6].Value = item.HoTenBS;
                dataGridView1.Rows[index].Cells[7].Value = item.ThongTinBenh;
                dataGridView1.Rows[index].Cells[8].Value = item.KhamTongThe;
                dataGridView1.Rows[index].Cells[9].Value = item.KhamTungBoPhan;
                dataGridView1.Rows[index].Cells[10].Value = item.TomTatLamSan;
                dataGridView1.Rows[index].Cells[11].Value = item.ChuanDoanNhapVien;
            }
        }
        private void Frmtrang_chu_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;

            cbbGioitinh.Text = "Nam";
            List<dakhoa> listdakhoa = context.dakhoas.ToList();
            List<DSbacsi> listBS = context.DSbacsis.ToList();
            List<DSbenhnhan> listbenhnhan = context.DSbenhnhans.ToList();
            BindGrid(listbenhnhan);
            BindGrid(listdakhoa);
            FillFalcultyComboboxBS(listBS);
        }
        private void Loaddgv()
        {
            List<dakhoa> listdakhoa = context.dakhoas.ToList();
            BindGrid(listdakhoa);
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
        /// hàm kiểm tra
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        //CHECK XEM MÃ ĐĂNG KÝ CÓ TRÙNG KHÔNG
        private int checkidSV(string tk) 
        {
            int length = dataGridView1.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        // CHECK KHI NHẬP MỚI
        private bool check()  
        {
            if (txtmabenh.Text == "" || txthoten.Text == "" || txtmadk.Text == "" || rtttbenh.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            /*else if (txtmabs.TextLength < 5)
            {
                MessageBox.Show("Mã Bác Sĩ Phải Có 5 Ký Tự Trở Nên Mới Tính !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtmabn.TextLength < 5)
            {
                MessageBox.Show("Mã Bệnh Nhân Phải Có 5 Ký Tự Trở Nên Mới Tính !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }*/
            return true;
        }
        /// <summary>
        /// cbb
        /// </summary>
        /// <param name="listbacsi"></param>
        private void FillFalcultyComboboxBS(List<DSbacsi> listbacsi)
        {
            this.cbbMaBS.DataSource = listbacsi;
            this.cbbMaBS.DisplayMember = "MaBS";
            this.cbbMaBS.ValueMember = "MaBS";

            this.cbbTenBS.DataSource = listbacsi;
            this.cbbTenBS.DisplayMember = "HoTenBS";
            this.cbbTenBS.ValueMember = "HoTenBS";
        }
        /// <summary>
        /// button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkidSV(txtmadk.Text) == -1)
                {
                    dakhoa tempi = new dakhoa();
                    tempi.MaDK = Convert.ToInt32(txtmadk.Text);
                    tempi.MaBN = txtmabenh.Text;
                    tempi.HoTenBN = txthoten.Text;
                    tempi.NgaySinh = dtpNgaySinh.Value;
                    tempi.GioiTinh = cbbGioitinh.Text;
                    tempi.MaBS = cbbMaBS.Text;
                    tempi.HoTenBS = cbbTenBS.Text;
                    tempi.ThongTinBenh = rtttbenh.Text;
                    tempi.KhamTongThe = rttong.Text;
                    tempi.KhamTungBoPhan = rtbo.Text;
                    tempi.TomTatLamSan = rtlam.Text;
                    tempi.ChuanDoanNhapVien = rtchuan.Text;
                    //tempi.Thuoc = rtthuoc.Text;

                    context.dakhoas.AddOrUpdate(tempi);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Thông Tin khám Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Số Đăng Ký Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btnxua_Click(object sender, EventArgs e)
        {
            if (checkidSV(txtmadk.Text) != -1)
            {
                dakhoa tempi = new dakhoa();
                tempi.MaDK = Convert.ToInt32(txtmadk.Text);
                tempi.MaBN = txtmabenh.Text;
                tempi.HoTenBN = txthoten.Text;
                tempi.NgaySinh = dtpNgaySinh.Value;
                tempi.GioiTinh = cbbGioitinh.Text;
                tempi.MaBS = cbbMaBS.Text;
                tempi.HoTenBS = cbbTenBS.Text;
                tempi.ThongTinBenh = rtttbenh.Text;
                tempi.KhamTongThe = rttong.Text;
                tempi.KhamTungBoPhan = rtbo.Text;
                tempi.TomTatLamSan = rtlam.Text;
                tempi.ChuanDoanNhapVien = rtchuan.Text;
                //tempi.Thuoc = rtthuoc.Text;

                context.dakhoas.AddOrUpdate(tempi);
                context.SaveChanges();

                LoadFrom();
                Loaddgv();

                MessageBox.Show("Cập nhật Thông Tin khám Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không sửa Đựơc Thông Tin ", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int delete = Convert.ToInt32(txtmadk.Text);
                dakhoa dbDelete = context.dakhoas.FirstOrDefault(p => p.MaDK == delete);
                if (dbDelete == null)
                {
                    throw new Exception("Không Tìm Thấy Thông Tin Cần Xóa");
                }
                else
                {
                    DialogResult dw = MessageBox.Show("Bạn Muốn Xóa Thông Tin ?", "THÔNG BÁO", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dw == DialogResult.Yes)
                    {
                        context.dakhoas.Remove(dbDelete);
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
        private void btnin_Click(object sender, EventArgs e)
        {
            if (txtmabenh.Text != "")
            {
                FrmDonThuoc frmThuoc = new FrmDonThuoc();
                delMaBenhNhan del = new delMaBenhNhan(frmThuoc.LayMaBenhNhan);
                del(this.txtmabenh);

                delTenBenhNhan del3 = new delTenBenhNhan(frmThuoc.LayHoTenBenhNhan);
                del3(this.txthoten);

                delNgaySinhBenhNhan del4 = new delNgaySinhBenhNhan(frmThuoc.LayNgaySinhBenhNhan);
                del4(this.dtpNgaySinh.Value);

                delGioiTinhBenhNhan del5 = new delGioiTinhBenhNhan(frmThuoc.LayGioiTinhhBenhNhan);
                del5(this.cbbGioitinh);

                delMaBacSi del1 = new delMaBacSi(frmThuoc.LayMaBacSi);
                del1(this.cbbMaBS);

                delTenBacSi del2 = new delTenBacSi(frmThuoc.LayTenBacSi);
                del2(this.cbbTenBS);
                frmThuoc.ShowDialog();
            }
            else
                MessageBox.Show("Chưa chọn bệnh nhân, bác sĩ để cấp thuốc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            crystalReportViewer1.Visible = true;

            KetQuaKham rp = new KetQuaKham();

            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            b.Value = txtmadk.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["MaDK"].ApplyCurrentValues(a);

            b.Value = txthoten.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["HoTenBN"].ApplyCurrentValues(a);

            b.Value = dtpNgaySinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["NgaySinh"].ApplyCurrentValues(a);

            b.Value = cbbGioitinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["GioiTinh"].ApplyCurrentValues(a);

            b.Value = rtttbenh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["ThongTinBenh"].ApplyCurrentValues(a);

            b.Value = cbbTenBS.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["HoTenBS"].ApplyCurrentValues(a);

            b.Value = rttong.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["KhamTongThe"].ApplyCurrentValues(a);

            b.Value = rtbo.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["KhamTungBoPhan"].ApplyCurrentValues(a);

            b.Value = rtlam.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["TomTatLamSan"].ApplyCurrentValues(a);

            b.Value = rtchuan.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["ChuanDoanNhapVien"].ApplyCurrentValues(a);

            crystalReportViewer1.ReportSource = rp;

        }
        private void btnThuPhi_Click(object sender, EventArgs e)
        {
            if (txtmabenh.Text != "")
            {
                FrmThuPhi frmThuPhi = new FrmThuPhi();
                MaDK del = new MaDK(frmThuPhi.LayMaDK);
                del(this.txtmadk);

                MaBenhNhan del1 = new MaBenhNhan(frmThuPhi.LayMaBenhNhan);
                del1(this.txtmabenh);

                TenBenhNhan del2 = new TenBenhNhan(frmThuPhi.LayHoTenBenhNhan);
                del2(this.txthoten);

                NgaySinhBenhNhan del3 = new NgaySinhBenhNhan(frmThuPhi.LayNgaySinhBenhNhan);
                del3(this.dtpNgaySinh.Value);

                GioiTinhBenhNhan del7 = new GioiTinhBenhNhan(frmThuPhi.LayGioiTinhhBN);
                del7(this.cbbGioitinh);

                MaBacSi del5 = new MaBacSi(frmThuPhi.LayMaBacSi);
                del5(this.cbbMaBS);

                ThongTinBenh del6 = new ThongTinBenh(frmThuPhi.LayThongTinBenh);
                del6(this.rtttbenh);

                frmThuPhi.ShowDialog();
            }
            else
                MessageBox.Show("Chưa chọn bệnh nhân để thanh toán hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;
        }
        /// <summary>
        /// hàm sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txtmadk.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtmabenh.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txthoten.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    DateTime dt = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;
                    cbbGioitinh.SelectedIndex = cbbGioitinh.FindString(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    cbbMaBS.SelectedIndex = cbbMaBS.FindString(dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    cbbTenBS.SelectedIndex = cbbTenBS.FindString(dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                    rtttbenh.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                    rttong.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    rtbo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                    rtlam.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                    rtchuan.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
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
                    DateTime dt = DateTime.ParseExact(dgvbenhnhan2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="madk"></param>
        // load dữ liệu lên textbox from thu phí
        public delegate void MaDK(TextBox madk);

        public delegate void MaBenhNhan(TextBox mabenhnhan);

        public delegate void TenBenhNhan(TextBox tenbenhnhan);

        public delegate void NgaySinhBenhNhan(DateTime NgaySinhbenhnhan);

        public delegate void GioiTinhBenhNhan(ComboBox gioitinhbenhnhan);

        public delegate void MaBacSi(ComboBox mabenhsi);

        public delegate void ThongTinBenh(RichTextBox ThongTinBenh);
        // load dữ liệu lên textbox, combobox
        public delegate void delMaBenhNhan(TextBox mabenhnhan);

        public delegate void delTenBenhNhan(TextBox tenbenhnhan);

        public delegate void delNgaySinhBenhNhan(DateTime NgaySinhbenhnhan);

        public delegate void delGioiTinhBenhNhan(ComboBox gioitinhbenhnhan);

        public delegate void delMaBacSi(ComboBox mabenhsi);

        public delegate void delTenBacSi(ComboBox tenbenhsi);
        /// <summary>
        /// hàm tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            List<DSbenhnhan> listdanhsach = context.DSbenhnhans.ToList();
            if (txttim.TextLength > 0)
            {
                var listTim = listdanhsach.Where(p => p.MaBN.ToLower().Contains(txttim.Text.ToLower()) || p.HoTen.ToLower().Contains(txttim.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {

                    BindGrid(listTim);
                }
            }
            else
            {

                BindGrid(listdanhsach); //LOAD LẠI BẢNG KHI KHÔNG TÌM KIẾM
            }
        }
    }
}
