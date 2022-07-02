using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using benhvien.model;
using benhvien.Report;
using CrystalDecisions.Shared;
using System.Globalization;
using System.Data.SqlClient;

namespace benhvien
{
    public partial class FrmDonThuoc : Form
    {
        benhvien1 context = new benhvien1();
        private DONTHUOC DonThuocBN = new DONTHUOC();

        public FrmDonThuoc()
        {
            InitializeComponent();
        }
        //Lay thong tin don thuoc luu vao TOATHUOC
        private DONTHUOC LayThongTinDonThuoc()
        {
            DONTHUOC dt = new DONTHUOC();

            dt.MaBS = txtDonThuoc_MaBacSi.Text;
            dt.MaDonThuoc = txtMaDonThuoc.Text;
            dt.MaBS = txtDonThuoc_MaBacSi.Text;
            dt.MaBN = txtmabenh.Text;
            dt.MaBS = txtDonThuoc_MaBacSi.Text;
            dt.MaThuoc = cbbMaThuoc.Text;
            dt.NgayKeDonThuoc = Convert.ToDateTime(dateTimeNgayKe.Value.ToString());
            dt.GioTao = Convert.ToDateTime(dtPicker_GioTaoDonThuoc.Value.ToString());
            dt.LoiDan = txtDonThuoc_LoiDan.Text;
   
            return dt;
        }
        //ham lay thong tin chi tiet don thuoc
        private DONTHUOC LayThongTinChiTietThuoc()
        {
            DONTHUOC dt = new DONTHUOC();

            dt.MaDonThuoc = txtMaDonThuoc.Text;
            dt.MaThuoc = cbbMaThuoc.Text;
            //dt.MaBN = txtmabenh.Text;
            dt.SoLuong = Convert.ToInt32(txtDonThuoc_SoLuong.Text);
            dt.Ngay = cbbNgayLan.Text;
            //dt.Lan = Convert.ToInt32(txtDonThuoc_SoLanUongNho.Text);
            dt.Lieu = cbbMoilan.Text;
            dt.ThoiDiemSuDung = txtDonThuoc_ThoiDiemSuDung.Text;

            return dt;
        }
        public void ThemThuocMoi()
        {
            txtDonThuoc_SoLuong.Text = "";
            txtDonThuoc_ThoiDiemSuDung.Text = "";
            cbbNgayLan.Text = "";
            cbbMoilan.Text = "";
            cbbNhomThuoc.Text = "";
            cbbTenThuoc.Text = "";
        }
        //Ham kiem tra thong tin nhap lieu truoc khi luu thong tin
        public bool KiemTraNhapLieuDonThuoc()
        {
            if (txtMaDonThuoc.Text == "" || txtDonThuoc_ThoiDiemSuDung.Text == "" || txtDonThuoc_SoLuong.Text == "" )
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
                return true;
        }
        private int checkidSV(string tk) //CHECK XEM MÃ ĐĂNG KÝ CÓ TRÙNG KHÔNG
        {
            int length = dgvDSThuoc.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSThuoc.Rows[i].Cells[0].Value != null)
                    if (dgvDSThuoc.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        /// <summary>
        /// load form
        /// </summary>
        public void LoadComboboxVienGiot()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("VienGiot");

            dt.Rows.Add("  Viên");
            dt.Rows.Add("  Giọt");

            //Load combobox loai thuoc uong
            cbbMoilan.DataSource = dt;
            cbbMoilan.DisplayMember = "STT";
            cbbMoilan.ValueMember = "VienGiot";

        }
        public void LoadComboboxUongNho()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("UongNho");

            dt.Rows.Add("  Uống");
            dt.Rows.Add("  Nhỏ");

            //cach su dung thuoc
            cbbNgayLan.DataSource = dt;
            cbbNgayLan.DisplayMember = "STT";
            cbbNgayLan.ValueMember = "UongNho";
        }
        
        private void BindGrid(List<Thuoc> listthuoc)
        {
            dgvDSThuoc.Rows.Clear();
            foreach (var item in listthuoc)
            {
                int index = dgvDSThuoc.Rows.Add();
                dgvDSThuoc.Rows[index].Cells[1].Value = txtMaDonThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[2].Value = cbbMaThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[3].Value = cbbNhomThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[4].Value = cbbTenThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[5].Value = txtDonThuoc_SoLuong.Text;
                dgvDSThuoc.Rows[index].Cells[6].Value = txtDonThuoc_ThoiDiemSuDung.Text;
                dgvDSThuoc.Rows[index].Cells[7].Value = cbbMoilan.Text;
                dgvDSThuoc.Rows[index].Cells[8].Value = cbbNgayLan.Text;

            }
        }
        private void capnhatthongtin(int selectedrow)
        {
            dgvDSThuoc.Rows[selectedrow].Cells[0].Value = txtMaDonThuoc.Text;
            dgvDSThuoc.Rows[selectedrow].Cells[1].Value = cbbNhomThuoc.Text;
            //dgvDSThuoc.Rows[selectedrow].Cells[2].Value = cbbMaThuoc.Text;
            dgvDSThuoc.Rows[selectedrow].Cells[2].Value = cbbTenThuoc.Text;
            dgvDSThuoc.Rows[selectedrow].Cells[3].Value = txtDonThuoc_SoLuong.Text;
            dgvDSThuoc.Rows[selectedrow].Cells[4].Value = txtDonThuoc_ThoiDiemSuDung.Text;

        }
        private void Loaddgv()
        {
            List<Thuoc> listthuoc = context.Thuocs.ToList();
            BindGrid(listthuoc);
        }
        private void FrmDonThuoc_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;
            cbbMaThuoc.Enabled = false;
            LoadComboboxUongNho();
            LoadComboboxVienGiot();
            List<Thuoc> list = context.Thuocs.ToList();
            List<CT_DonThuoc> listctthuoc = context.CT_DonThuoc.ToList();
            //BindGrid(list);
            //BindGrid1(listctthuoc);
            FillFalcultyComboboxNhomThuioc(list);
            FillFalcultyComboboxTenThuioc(list);
            FillFalcultyComboboxMaThuioc(list);
        }
        /// <summary>
        /// cbb
        /// </summary>
        /// <param name="listthuoc"></param>
        private void FillFalcultyComboboxNhomThuioc(List<Thuoc> listthuoc)
        {
            this.cbbNhomThuoc.DataSource = listthuoc;
            this.cbbNhomThuoc.DisplayMember = "NhomThuoc";
            this.cbbNhomThuoc.ValueMember = "MaThuoc";

        }//cần chỉnh sửa
        private void FillFalcultyComboboxTenThuioc(List<Thuoc> listthuoc)
        {
            this.cbbTenThuoc.DataSource = listthuoc;
            this.cbbTenThuoc.DisplayMember = "TenThuoc";
            this.cbbTenThuoc.ValueMember = "MaThuoc";
            cbbTenThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbTenThuoc.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void FillFalcultyComboboxMaThuioc(List<Thuoc> listthuoc)
        {
            this.cbbMaThuoc.DataSource = listthuoc;
            this.cbbMaThuoc.DisplayMember = "MaThuoc";
            this.cbbMaThuoc.ValueMember = "TenThuoc";

        }
        
        /// <summary>
        /// các button cập nhật đươn thuốc
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (KiemTraNhapLieuDonThuoc())
            {
                if (checkidSV(cbbMaThuoc.Text) == -1)
                {
                    int selectedrow = checkidSV(cbbMaThuoc.Text);
                    if (selectedrow == -1)
                    {
                        selectedrow = dgvDSThuoc.Rows.Add();
                        capnhatthongtin(selectedrow);
                        //Loaddgv();
                        MessageBox.Show("Thêm Đơn Thuốc Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã Thuốc Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        } 
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_luu(object sender, EventArgs e)
        {
            CT_DonThuoc tb = new CT_DonThuoc();
            tb.MaDonThuoc = txtMaDonThuoc.Text;
            tb.MaThuoc = cbbMaThuoc.Text;
            tb.SoLuong = Convert.ToInt32(txtDonThuoc_SoLuong.Text);
            tb.Ngay = cbbNgayLan.Text;
            tb.Lieu = cbbMoilan.Text;
            tb.ThoiDiemSuDung = txtDonThuoc_ThoiDiemSuDung.Text;
            context.CT_DonThuoc.AddOrUpdate(tb);
            context.SaveChanges();
            MessageBox.Show("Lưu Thuốc Thành Công", "THÔNG BÁO");
        }
        private void btnIn_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            panel1.Visible = true;

            DonThuoc rp = new DonThuoc();
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            b.Value = txtDonThuoc_TenBacSi.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["HoTenBS"].ApplyCurrentValues(a);

            b.Value = txthoten.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["HoTenBN"].ApplyCurrentValues(a);

            b.Value = dtpNgaySinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["NgaySinh"].ApplyCurrentValues(a);

            b.Value = cbbGioitinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["GioiTinh"].ApplyCurrentValues(a);

            b.Value = txtDonThuoc_LoiDan.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["LoiDan"].ApplyCurrentValues(a);

            DataTable ds = new DataTable();
            ds.Columns.Add("NhomThuoc", Type.GetType("System.String"));
            ds.Columns.Add("MaThuoc", Type.GetType("System.String"));
            ds.Columns.Add("TenThuoc", Type.GetType("System.String"));
            //ds.Columns.Add("MaThuoc", Type.GetType("System.String"));
            ds.Columns.Add("SoLuong", Type.GetType("System.Int32"));
            ds.Columns.Add("ThoiDiemSuDung", Type.GetType("System.String"));
            foreach (DataGridViewRow row in dgvDSThuoc.Rows)
                ds.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value,
                    row.Cells[3].Value, row.Cells[4].Value);

            rp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rp;

            rp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rp;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrow = checkidSV(cbbMaThuoc.Text);
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
                        dgvDSThuoc.Rows.RemoveAt(selectedrow);
                        MessageBox.Show("Xóa Thông Tin Thành Công", "THÔNG BÁO");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dateTimeNgayKe_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime kiemtra = dateTimeNgayKe.Value;
            if ((DateTime.Parse(now.ToString()) > DateTime.Parse(kiemtra.ToString())))
            {
                dateTimeNgayKe.Text = "";

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDonThuoc_SoLanUongNho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtDonThuoc_MoiLan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtDonThuoc_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public void LayMaBenhNhan(TextBox MaBenhNhan)
        {
            txtmabenh.Text = MaBenhNhan.Text;
        }
        public void LayHoTenBenhNhan(TextBox TenBenhNhan)
        {
            txthoten.Text = TenBenhNhan.Text;
        }
        public void LayNgaySinhBenhNhan(DateTime NgaySinhBenhNhan)
        {
            dtpNgaySinh.Value = NgaySinhBenhNhan.Date;
        }
        public void LayGioiTinhhBenhNhan(ComboBox GioiTinhBenhNhan)
        {
            cbbGioitinh.Text = GioiTinhBenhNhan.Text;
        }
        public void LayMaBacSi(ComboBox MaBacSi)
        {
            txtDonThuoc_MaBacSi.Text = MaBacSi.Text;
        }
        public void LayTenBacSi(ComboBox TenBacSi)
        {
            txtDonThuoc_TenBacSi.Text = TenBacSi.Text;
        }

    }
}
