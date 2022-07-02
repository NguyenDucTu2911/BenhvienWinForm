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
    public partial class Frmxetnghiem : Form
    {
        benhvien1 context = new benhvien1();
        public Frmxetnghiem()
        {
            InitializeComponent();
        } 
        /// <summary>
        /// load Form
        /// </summary>
        /// <param name="listxetnghiem"></param>
        private void Frmxetnghiem_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;
            cbbYeuCauXN.Text = "Siêu âm";
            List<DSbacsi> listBS = context.DSbacsis.ToList();
            List<xetnghiem> listxetnghiem = context.xetnghiems.ToList();
            List<DSbenhnhan> listbenhnhan = context.DSbenhnhans.ToList();
            List<DsXetNghiem> listxetnghiem1 = context.DsXetNghiems.ToList();
            BindGrid(listbenhnhan);
            BindGrid(listxetnghiem);
            FillFalcultyComboboxBS(listBS);
            FillFalcultyComboboxxetngiem(listxetnghiem1);
        }
        //LOAD FORM VÀ ĐƯA NHÁY VỀ  SO DK
        private void LoadFrom() 
        {
            txtSODK.Clear();
            txtHoten.Clear();
            txtMaBN.Clear();
            richTextChuanDaon.Clear();
            richTextYauCau.Clear();
            txtSODK.Focus();
        }
        private void Loaddgv()
        {
            List<xetnghiem> listxetnghiem = context.xetnghiems.ToList();
            BindGrid(listxetnghiem);
        }
        // LOAD DỮ LIÊU LÊ DATAGIRLVIEW
        private void BindGrid(List<xetnghiem> listxetnghiem) 
        {
            dgvXetNghiem.Rows.Clear();
            foreach (var item in listxetnghiem)
            {
                int index = dgvXetNghiem.Rows.Add();
                dgvXetNghiem.Rows[index].Cells[0].Value = item.SoDangKy;
                dgvXetNghiem.Rows[index].Cells[1].Value = item.MaBN;
                dgvXetNghiem.Rows[index].Cells[2].Value = item.HoTen;
                dgvXetNghiem.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvXetNghiem.Rows[index].Cells[4].Value = item.NgaySinh.ToString("dd-MM-yyyy");
                dgvXetNghiem.Rows[index].Cells[5].Value = item.MaBS;
                dgvXetNghiem.Rows[index].Cells[6].Value = item.HoTenBS;
                dgvXetNghiem.Rows[index].Cells[7].Value = item.YeuCauXetNghiem;
                dgvXetNghiem.Rows[index].Cells[8].Value = item.ChuanDoan;
                dgvXetNghiem.Rows[index].Cells[9].Value = item.YeuCau;

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
        /// Check Điền Kiện
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        // CHECK SỐ ĐĂNG KÝ 
        private int checkidSV(string tk) 
        {
            int length = dgvXetNghiem.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvXetNghiem.Rows[i].Cells[0].Value != null)
                    if (dgvXetNghiem.Rows[i].Cells[0].Value.ToString() == tk)
                        return i;
            }
            return -1;
        }
        //CHECK THÔNG TIN NHẬP 
        private bool check() 
        {
            if (txtSODK.Text == "" || txtMaBN.Text == "" || richTextChuanDaon.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtMaBN.TextLength < 5)
            {
                MessageBox.Show("Mã Bệnh Nhân Phải Có 5 Ký Tự Trở Nên Mới Tính !", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// button xét nghiệm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnxuat_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            crystalReportViewer1.Visible = true;

           
            KetQuaXetNghiem rp = new KetQuaXetNghiem();

            ParameterValues a = new ParameterValues();
            ParameterDiscreteValue b = new ParameterDiscreteValue();
            b.Value = txtSODK.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["Madangky"].ApplyCurrentValues(a);

            b.Value = txtHoten.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["hotenbenhnhan"].ApplyCurrentValues(a);

            b.Value = dtpNgaySinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["ngaysinh"].ApplyCurrentValues(a);

            b.Value = cbbGioitinh.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["gioitinh"].ApplyCurrentValues(a);

            b.Value = cbbTenBS.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["hotenbs"].ApplyCurrentValues(a);

            b.Value = richTextYauCau.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["yeucauxetnghiem"].ApplyCurrentValues(a);

            b.Value = cbbYeuCauXN.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["tenxetnghiem"].ApplyCurrentValues(a);

            b.Value = richTextChuanDaon.Text;
            a.Add(b);
            rp.DataDefinition.ParameterFields["ketquaxetnghiem"].ApplyCurrentValues(a);

           

            crystalReportViewer1.ReportSource = rp;
        }
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (checkidSV(txtSODK.Text) != -1)
            {
                xetnghiem tempi = new xetnghiem();
                tempi.HoTen = txtHoten.Text;
                tempi.GioiTinh = cbbGioitinh.Text;
                tempi.NgaySinh = dtpNgaySinh.Value;
                tempi.MaBS = cbbMaBS.Text;
                tempi.HoTenBS = cbbTenBS.Text;
                tempi.SoDangKy = Convert.ToInt32(txtSODK.Text);
                tempi.MaBN = txtMaBN.Text;
                tempi.YeuCauXetNghiem = cbbYeuCauXN.Text;
                tempi.ChuanDoan = richTextChuanDaon.Text;
                tempi.YeuCau = richTextYauCau.Text;

                context.xetnghiems.AddOrUpdate(tempi);
                context.SaveChanges();

                LoadFrom();
                Loaddgv();

                MessageBox.Show("Cập Thông Tin Xét Ngiệm Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không Thể Chỉnh Sửa Thông Tin", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check())
            {
                if (checkidSV(txtSODK.Text) == -1)
                {
                    
                    xetnghiem tempi = new xetnghiem();
                    tempi.HoTen = txtHoten.Text;
                    tempi.GioiTinh = cbbGioitinh.Text;
                    tempi.NgaySinh = dtpNgaySinh.Value;
                    tempi.MaBS = cbbMaBS.Text;
                    tempi.HoTenBS = cbbTenBS.Text;
                    tempi.SoDangKy = Convert.ToInt32(txtSODK.Text);
                    tempi.MaBN = txtMaBN.Text;
                    tempi.YeuCauXetNghiem = cbbYeuCauXN.Text;
                    tempi.ChuanDoan = richTextChuanDaon.Text;
                    tempi.YeuCau = richTextYauCau.Text;

                    context.xetnghiems.AddOrUpdate(tempi);
                    context.SaveChanges();

                    LoadFrom();
                    Loaddgv();

                    MessageBox.Show("Thêm Thông Tin Xét Ngiệm Thành Công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Số Đăng Ký Đã tồn tại", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                int Delete = Convert.ToInt32(txtSODK.Text);
                xetnghiem dbDelete = context.xetnghiems.FirstOrDefault(x => x.SoDangKy == Delete);
                if (dbDelete == null)
                {
                    throw new Exception("Không Tìm Thấy Thông Tin Cần Xóa");
                }
                else
                {
                    DialogResult dw = MessageBox.Show("Bạn Muốn Xóa Thông Tin", "THÔNG BÁO", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dw == DialogResult.Yes)
                    {
                        context.xetnghiems.Remove(dbDelete);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thông Tin Thành Công", "THÔNG BÁO");
                        LoadFrom();
                        Loaddgv();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không Tìm Thấy Thông Tin Cần Xóa", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            crystalReportViewer1.Visible = false;
        }
        /// <summary>
        /// load cbb
        /// </summary>
        /// <param name="listBN"></param>
        private void LayThongTinSoBoBenhAn(List<DSbenhnhan> listBN)
        {
            DSbenhnhan ba = new DSbenhnhan();
            ba.MaBN = txtMaBN.Text;
        }
        private void FillFalcultyComboboxxetngiem(List<DsXetNghiem> listxetnghiem1)
        {
            this.cbbYeuCauXN.DataSource = listxetnghiem1;
            this.cbbYeuCauXN.DisplayMember = "TenXn";
            this.cbbYeuCauXN.ValueMember = "Maxn";
            
        }
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
        /// Các Sự Kiện
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

                    txtMaBN.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtHoten.Text = dgvbenhnhan2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
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
        private void dgvXetNghiem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvXetNghiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvXetNghiem.CurrentRow.Selected = true;
                    txtSODK.Text = dgvXetNghiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtMaBN.Text = dgvXetNghiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtHoten.Text = dgvXetNghiem.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    cbbGioitinh.SelectedIndex = cbbGioitinh.FindString(dgvXetNghiem.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                    DateTime dt = DateTime.ParseExact(dgvXetNghiem.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = dt;
                    cbbMaBS.SelectedIndex = cbbMaBS.FindString(dgvXetNghiem.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    cbbTenBS.SelectedIndex = cbbTenBS.FindString(dgvXetNghiem.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                    cbbYeuCauXN.SelectedIndex = cbbYeuCauXN.FindString(dgvXetNghiem.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                    richTextChuanDaon.Text = dgvXetNghiem.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                    richTextYauCau.Text = dgvXetNghiem.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// Hàm Tìm Kiếm
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
