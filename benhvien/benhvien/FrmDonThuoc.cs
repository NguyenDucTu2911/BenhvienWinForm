using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using benhvien.model;

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
            dt.Lan = Convert.ToInt32(txtDonThuoc_SoLanUongNho.Text);
            dt.MoiLan = Convert.ToInt32(txtDonThuoc_MoiLan.Text);
            dt.Lieu = cbbMoilan.Text;
            dt.ThoiDiemSuDung = txtDonThuoc_ThoiDiemSuDung.Text;

            return dt;
        }
        //Ham kiem tra thong tin nhap lieu truoc khi luu thong tin
        public bool KiemTraNhapLieuDonThuoc()
        {
            if (txtMaDonThuoc.Text == "" || txtDonThuoc_ThoiDiemSuDung.Text == "" || txtDonThuoc_SoLuong.Text == "" ||
                txtDonThuoc_SoLanUongNho.Text == "" || txtDonThuoc_MoiLan.Text == "")
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

            dt.Rows.Add("Viên");
            dt.Rows.Add("Giọt");

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

            dt.Rows.Add("Uống");
            dt.Rows.Add("Nhỏ");

            //cach su dung thuoc
            cbbNgayLan.DataSource = dt;
            cbbNgayLan.DisplayMember = "STT";
            cbbNgayLan.ValueMember = "UongNho";
        }
        public void ThemThuocMoi()
        {
            txtDonThuoc_SoLuong.Text = "";
            txtDonThuoc_SoLanUongNho.Text = "";
            txtDonThuoc_ThoiDiemSuDung.Text = "";
            txtDonThuoc_MoiLan.Text = "";

            cbbNgayLan.Text = "";
            cbbMoilan.Text = "";
            cbbNhomThuoc.Text = "";
            cbbTenThuoc.Text = "";
        }
        private void BindGrid(List<Thuoc> listthuoc)
        {
            dgvDSThuoc.Rows.Clear();
            foreach (var item in listthuoc)
            {
                int index = dgvDSThuoc.Rows.Add();
                dgvDSThuoc.Rows[index].Cells[0].Value = cbbMaThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[1].Value = cbbNhomThuoc.Text;
                dgvDSThuoc.Rows[index].Cells[2].Value = cbbTenThuoc.Text;

                dgvDSThuoc.Rows[index].Cells[3].Value = txtDonThuoc_SoLuong.Text;

                dgvDSThuoc.Rows[index].Cells[4].Value = txtDonThuoc_ThoiDiemSuDung.Text;

            }
        }
        private void capnhatthongtin(int selectedrow)
        {
            dgvDSThuoc.Rows[selectedrow].Cells[0].Value = cbbMaThuoc.Text;
            dgvDSThuoc.Rows[selectedrow].Cells[1].Value = cbbNhomThuoc.Text;
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
            cbbMaThuoc.Enabled = false;
            LoadComboboxUongNho();
            LoadComboboxVienGiot();
            List<Thuoc> list = context.Thuocs.ToList();
            //BindGrid(list);
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

        }
        private void FillFalcultyComboboxTenThuioc(List<Thuoc> listthuoc)
        {
            this.cbbTenThuoc.DataSource = listthuoc;
            this.cbbTenThuoc.DisplayMember = "TenThuoc";
            this.cbbTenThuoc.ValueMember = "MaThuoc";

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
            DONTHUOC dt1 = LayThongTinDonThuoc();
            //DONTHUOC dt2 = LayThongTinChiTietThuoc();
           /* if (DonThuocBN.checkit(txtMaDonThuoc.Text))
            {
                DonThuocBN.CapNhapDonThuoc(dt);
                MessageBox.Show("Cập nhật thông tin đơn thuốc bệnh nhân {" + txtmabenh.Text + "} thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DonThuocBN.LuuThongTinDonThuoc(dt))
                {
                    MessageBox.Show("Lưu thông tin đơn thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lưu thông tin đơn thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void btnIn_Click_1(object sender, EventArgs e)
        {

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
