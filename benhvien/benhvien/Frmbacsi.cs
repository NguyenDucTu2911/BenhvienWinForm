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
    public partial class Frmbacsi : Form
    {

        benhvien1 context = new benhvien1();
        public Frmbacsi()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hàm load form
        /// </summary>
        /// <param name="listbacsi"></param>
        private void Frmbacsi_Load(object sender, EventArgs e)
        {
            comboBoxthomhke.Enabled = false;
            btnthongke.Enabled = false;
            btnIn.Enabled = false;
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
            lblTong.Text = $"Số Bác Sĩ:{ dgvbacsi.RowCount }";
        }
        /// <summary>
        /// Hàm cbb
        /// </summary>
        /// <param name="listbacsi"></param>
        private void FillFalcultyComboboxKhoa(List<Khoa> listbacsi)
        {
            this.comboBoxthomhke.DataSource = listbacsi;
            this.comboBoxthomhke.DisplayMember = "TenKhoa";
            this.comboBoxthomhke.ValueMember = "KhoaID";
        }
        
        /// <summary>
        /// button thống kê bác sĩ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimBS_Click(object sender, EventArgs e)
        {
            List<DSbacsi> listdanhsach = context.DSbacsis.ToList();
            var listTim = listdanhsach.Where(p => p.HoTenBS.ToLower().Contains(txtTim.Text.ToLower()) || p.Khoa.TenKhoa.ToLower().Contains(txtTim.Text.ToLower())).ToList();
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
            List<DSbacsi> listdanhsach = context.DSbacsis.ToList();
            var listTim = listdanhsach.Where(p => p.Khoa.TenKhoa.ToLower().Contains(comboBoxthomhke.Text.ToLower())).ToList();
            if (listTim.Count > 0)
            {

                BindGrid(listTim);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblTong.Text = $"Số Bác Sĩ:{ dgvbacsi.RowCount }";
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmReportBS BN = new FrmReportBS();
            BN.Show();
            this.Hide();
        }
        /// <summary>
        /// Hàm Tìm Kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            List<DSbacsi> listdanhsach = context.DSbacsis.ToList();
            if (txtTim.TextLength > 0)
            {

                var listTim = listdanhsach.Where(p => p.HoTenBS.ToLower().Contains(txtTim.Text.ToLower()) || p.Khoa.TenKhoa.ToLower().Contains(txtTim.Text.ToLower())).ToList();
                if (listTim.Count > 0)
                {
                    BindGrid(listTim);
                }
                //else
                //{
                //    MessageBox.Show("Không Tìm Thấy, Mời Nhập Lại Thông Tin Cần Tìm Kiếm !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }
            else
            {

                BindGrid(listdanhsach);
            }
            lblTong.Text = $"Số Bác Sĩ:{ dgvbacsi.RowCount }";
        }
        /// <summary>
        /// Sự Kiện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxbs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxbs.Checked == true)
            {
                comboBoxthomhke.Enabled = true;
                btnthongke.Enabled = true;
                btnIn.Enabled = true;
            }
            else
            {
                comboBoxthomhke.Enabled = false;
                btnthongke.Enabled = false;
                btnIn.Enabled = false;
            }
        }
        
    }
}