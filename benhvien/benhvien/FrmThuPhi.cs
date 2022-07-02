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

namespace benhvien
{
    public partial class FrmThuPhi : Form
    {
        benhvien1 context = new benhvien1();
        public FrmThuPhi()
        {
            InitializeComponent();
        }

        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }

        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }

        public static string So_chu(double gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod 
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();

        }
        private void FillFalcultyComboboxDichVu(List<DichVu> listdichvu)
        {
            this.cbbDichVu.DataSource = listdichvu;
            this.cbbDichVu.DisplayMember = "TenDichVu";
            this.cbbDichVu.ValueMember = "MaDichVu";

            this.cbbDonGia.DataSource = listdichvu;
            this.cbbDonGia.DisplayMember = "DonGia";
            this.cbbDonGia.ValueMember = "MaDichVu";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime kiemtra = dtPickerNgayThu.Value;
            if ((DateTime.Parse(now.ToString()) > DateTime.Parse(kiemtra.ToString())))
            {
                dtPickerNgayThu.Text = "";

            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        //gọi dữ liệu qua frm
        public void LayMaDK(TextBox MaDK)
        {
            txtmadk.Text = MaDK.Text;
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
        public void LayGioiTinhhBN(ComboBox GioiTinhBN)
        {
            cbbGioitinh.Text = GioiTinhBN.Text;

        }
        public void LayMaBacSi(ComboBox MaBacSi)
        {
            txtMaBS.Text = MaBacSi.Text;
        }
        public void LayThongTinBenh(RichTextBox ThongTinBenh)
        {
            rtttbenh.Text = ThongTinBenh.Text;
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindGrid(List<HoaDon> listHD)
        {
            dgvDSHoaDon.Rows.Clear();
            foreach (var item in listHD)
            {
                int index = dgvDSHoaDon.Rows.Add();
                dgvDSHoaDon.Rows[index].Cells[0].Value = item.MaHoaDon;
                dgvDSHoaDon.Rows[index].Cells[1].Value = item.MaBN;
                dgvDSHoaDon.Rows[index].Cells[2].Value = item.MaBS;
                dgvDSHoaDon.Rows[index].Cells[3].Value = item.NgayLap.ToString("dd-MM-yyyy");
                dgvDSHoaDon.Rows[index].Cells[4].Value = item.DichVu.TenDichVu;
                dgvDSHoaDon.Rows[index].Cells[5].Value = item.ThanhTien;
                
                
            }
        }
        private void FrmThuPhi_Load(object sender, EventArgs e)
        {    
            try
            {             
                List<DichVu> listdichvu = context.DichVus.ToList();
                List<HoaDon> listhoadon = context.HoaDons.ToList();
                BindGrid(listhoadon);
                FillFalcultyComboboxDichVu(listdichvu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Loaddgv()
        {
            List<HoaDon> listhoadon = context.HoaDons.ToList();
            BindGrid(listhoadon);
        }
        private bool check()
        {
            if (txtmabenh.Text == "" || txthoten.Text == "" || dtpNgaySinh.Text == "" || txtMaHD.Text == "" || txtmadk.Text == "" || rtttbenh.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        private int checkidSV(string tk)
        {
            int length = dgvDSHoaDon.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvDSHoaDon.Rows[i].Cells[0].Value != null)
                    if (dgvDSHoaDon.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        private void LoadFrom() // LOAD FORM VÀ TRẢ NHÁY VỀ MÃ ĐĂNG KÝ
        {
            txthoten.Clear();
            txtmabenh.Clear();
            txtMaHD.Clear();
            txtMaBS.Clear();
            txtmadk.Clear();
            rtttbenh.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkidSV(txtMaHD.Text) == -1)
                {
                    HoaDon hoadon = new HoaDon();
                    hoadon.MaHoaDon = txtMaHD.Text;
                    hoadon.MaBN = txtmabenh.Text;
                    hoadon.MaBS = txtMaBS.Text;
                    hoadon.NgayLap = dtPickerNgayThu.Value;
                    hoadon.MaDichVu = Convert.ToInt32(cbbDichVu.SelectedValue.ToString());
                    hoadon.ThanhTien = Convert.ToInt32(cbbDonGia.Text);
                    

                    context.HoaDons.AddOrUpdate(hoadon);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Hóa Đơn Thành Công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Hóa Đơn Này Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            crystalReportViewer1.Visible = true;
            ThuPhi rp = new ThuPhi();
            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            b.Value = txtmabenh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["MaBN"].ApplyCurrentValues(a);

            b.Value = txthoten.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["HoTenBN"].ApplyCurrentValues(a);

            b.Value = dtpNgaySinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["NgaySinh"].ApplyCurrentValues(a);

            b.Value = cbbGioitinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["GioiTinh"].ApplyCurrentValues(a);

            b.Value = cbbDichVu.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["TenDichVu"].ApplyCurrentValues(a);

            b.Value = cbbDonGia.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["DonGia"].ApplyCurrentValues(a);

            b.Value = cbbDonGia.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["ThanhTien"].ApplyCurrentValues(a);

            b.Value = txtMaHD.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["MaHoaDon"].ApplyCurrentValues(a);           

            string tongtien = cbbDonGia.Text.ToString();
            long tien = long.Parse(tongtien);
            So_chu(tien);

            b.Value = So_chu(tien).ToString();
            a.Add(b);
            rp.DataDefinition.ParameterFields["TongTien"].ApplyCurrentValues(a);

            crystalReportViewer1.ReportSource = rp;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;
        }

        private void dgvDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSHoaDon.CurrentRow.Selected = true;

                    txtMaHD.Text = dgvDSHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtmabenh.Text = dgvDSHoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtMaBS.Text = dgvDSHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    DateTime dt = DateTime.ParseExact(dgvDSHoaDon.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;                   
                    cbbDichVu.SelectedIndex = cbbDichVu.FindString(dgvDSHoaDon.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                    cbbDonGia.SelectedIndex = cbbDonGia.FindString(dgvDSHoaDon.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
