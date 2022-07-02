using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using benhvien.model;
namespace benhvien
{
    public partial class Frmbenhnhan : Form
    {
        benhvien1 context = new benhvien1();
        public Frmbenhnhan()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  load form
        /// </summary>
        /// <param name="listbenhnhan"></param>
        /// 
        private void Frmbenhnhan_Load(object sender, EventArgs e)
        {
            comboBoxbn.Text = "Miễn phí";
            comboBoxbn.Enabled = false;
            btnthongke.Enabled = false;
            btnIn.Enabled = false;
            try
            {
                List<DSbenhnhan> istbenhnhan = context.DSbenhnhans.ToList();
                BindGrid(istbenhnhan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<DSbenhnhan> listbenhnhan) 
        {
            dgvbenhnhan.Rows.Clear();
            foreach (var item in listbenhnhan)
            {
                int index = dgvbenhnhan.Rows.Add();
                dgvbenhnhan.Rows[index].Cells[0].Value = item.MaBN;
                dgvbenhnhan.Rows[index].Cells[1].Value = item.HoTen;
                dgvbenhnhan.Rows[index].Cells[2].Value = item.NgaySinh.ToString("dd-MM-yyyy");
                dgvbenhnhan.Rows[index].Cells[3].Value = item.GioiTinh;
                dgvbenhnhan.Rows[index].Cells[4].Value = item.DiaChi;
                dgvbenhnhan.Rows[index].Cells[5].Value = item.DanToc;
                dgvbenhnhan.Rows[index].Cells[6].Value = item.QuocTich;
                dgvbenhnhan.Rows[index].Cells[7].Value = item.NgheNghiep;
                dgvbenhnhan.Rows[index].Cells[8].Value = item.DoiTuong;
                dgvbenhnhan.Rows[index].Cells[9].Value = item.SoBHYT;
                dgvbenhnhan.Rows[index].Cells[10].Value = item.GiaTriBHYT.ToString("dd-MM-yyyy");
                dgvbenhnhan.Rows[index].Cells[11].Value = item.PhongKham;
                dgvbenhnhan.Rows[index].Cells[12].Value = item.GhiChu;
            }
            lblTong.Text = $"Số Bệnh Nhân: { dgvbenhnhan.RowCount }";
        }
        /// <summary>
        /// button thống kê bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimBS_Click(object sender, EventArgs e)
        {
            List<DSbenhnhan> listdanhsach = context.DSbenhnhans.ToList();
            var listTim = listdanhsach.Where(p => p.HoTen.ToLower().Contains(txtTim.Text.ToLower()) || p.DiaChi.ToLower().Contains(txtTim.Text.ToLower()) || p.DoiTuong.ToLower().Contains(txtTim.Text.ToLower())).ToList();
            if (listTim.Count > 0)
            {
                BindGrid(listTim);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            List<DSbenhnhan> listdanhsach = context.DSbenhnhans.ToList();
            var listTim = listdanhsach.Where(p => p.DoiTuong.ToLower().Contains(comboBoxbn.Text.ToLower())).ToList();
            if (listTim.Count > 0)
            {

                BindGrid(listTim);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblTong.Text = $"Số Bệnh Nhân: { dgvbenhnhan.RowCount }";
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmReportBN BN = new FrmReportBN();
            BN.Show();
            this.Hide();
        }
        /// <summary>
        /// hàm tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            List<DSbenhnhan> listdanhsach = context.DSbenhnhans.ToList();
            if (txtTim.TextLength > 0)
            {
                var listTim = listdanhsach.Where(p => p.HoTen.ToLower().Contains(txtTim.Text.ToLower()) || p.DoiTuong.ToLower().Contains(txtTim.Text.ToLower()) || p.DiaChi.ToLower().Contains(txtTim.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {

                    BindGrid(listTim);
                }
            }
            else
            {

                BindGrid(listdanhsach); //LOAD LẠI BẢNG KHI KHÔNG TÌM KIẾM
            }
            lblTong.Text = $"Số Bệnh Nhân: { dgvbenhnhan.RowCount }";
        }
        /// <summary>
        /// hàm sự kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxbn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxbn.Checked == true)
            {
                comboBoxbn.Enabled = true;
                btnthongke.Enabled = true;
                btnIn.Enabled = true;
            }
            else
            {
                comboBoxbn.Enabled = false;
                btnthongke.Enabled = false;
                btnIn.Enabled = false;
            }
        }
    }
}
