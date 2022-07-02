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
using Microsoft.Reporting.WinForms;

namespace benhvien
{
    public partial class FrmReportBS : Form
    {
        benhvien1 context = new benhvien1();
        public FrmReportBS()
        {
            InitializeComponent();
        }
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportBS_Load(object sender, EventArgs e)
        {
            List<Khoa> listkhoa = context.Khoas.ToList();
            reportViewer1.Visible = false;
            rdotatca.Checked = true;
            rdokhoa.Checked = false;
            comboBox1.Enabled = false;
        }
        /// <summary>
        /// các radio check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdotatca_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }
        private void rdokhoa_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            List<Khoa> listkhoa = context.Khoas.OrderBy(p => p.TenKhoa).ToList();
            this.comboBox1.DataSource = listkhoa;
            this.comboBox1.DisplayMember = "TenKhoa";
            this.comboBox1.ValueMember = "KhoaID";
        }
        /// <summary>
        /// button thống kê bác sĩ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnINBS_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            if (rdotatca.Checked == true)
            {
                List<DSbacsi> lisbacsi = context.DSbacsis.ToList();
                List<Khoa> listkhoa = context.Khoas.ToList();
                List<khoarreport> listkhoane = new List<khoarreport>();
                foreach (DSbacsi i in lisbacsi)
                {
                    khoarreport temp = new khoarreport();
                    temp.MaBS = i.MaBS;
                    temp.HoTen = i.HoTenBS;
                    temp.GioiTinh = i.GioiTinh;
                    temp.NgaySinh = i.NgaySinh;
                    temp.SDT = i.SDT.ToString();
                    temp.TenKhoa = i.Khoa.TenKhoa;
                    temp.ChucVu = i.ChucVu;
                    listkhoane.Add(temp);
                }

                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBacSi.rdlc";
                var reportDataSource = new ReportDataSource("DataSet1", listkhoane);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Thống Kê Bác Sĩ";

            }
            else
            {
                int idKhoa = Convert.ToInt32(comboBox1.SelectedValue);

                Khoa khoabs = context.Khoas.FirstOrDefault(p => p.KhoaID == idKhoa);
                List<Khoa> listkhoa = context.Khoas.Where(p => p.KhoaID == idKhoa).ToList();

                if (khoabs == null || listkhoa.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy Khoa");
                    return;
                }
                List<DSbacsi> lisbacsi = context.DSbacsis.ToList();
                List<khoarreport> listkhoane = new List<khoarreport>();
                foreach (DSbacsi i in lisbacsi)
                {
                    if (i.KhoaID == khoabs.KhoaID)
                    {
                        khoarreport temp = new khoarreport();
                        temp.MaBS = i.MaBS;
                        temp.HoTen = i.HoTenBS;
                        temp.GioiTinh = i.GioiTinh;
                        temp.NgaySinh = i.NgaySinh;
                        temp.SDT = i.SDT.ToString();
                        temp.TenKhoa = i.Khoa.TenKhoa;
                        temp.ChucVu = i.ChucVu;
                        listkhoane.Add(temp);
                    }

                }
                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBacSiTheoKhoa.rdlc";
                var reportDataSource = new ReportDataSource("bacsi", listkhoane);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
