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
    public partial class FrmReportBN : Form
    {
        public FrmReportBN()
        {
            InitializeComponent();
        }
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportBN_Load(object sender, EventArgs e)
        {
            benhvien1 context = new benhvien1();
            List<DSbenhnhan> lisbacsi = context.DSbenhnhans.ToList();

            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportThongKeBenhNhan.rdlc";
            var reportDataSource = new ReportDataSource("DataSetBenhNhan", lisbacsi);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DisplayName = "Thống Kê Bệnh Nhân";
            this.reportViewer1.RefreshReport();
        }
    }
}
