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
    public partial class FrmReportInPhieuXN : Form
    {
        benhvien1 context = new benhvien1();
        public FrmReportInPhieuXN()
        {
            InitializeComponent();
        }

        private void FrmReportInPhieuXN_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            rdotatca.Checked = true;
            rdokhoa.Checked = false;
            txtmaBN.Enabled = false;


        }


        private void btnINBS_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            if (rdotatca.Checked == true)
            {
                List<xetnghiem> listxn = context.xetnghiems.ToList();
                List<InPhieuXN> listPXN = new List<InPhieuXN>();
                foreach (xetnghiem i in listxn)
                {
                    InPhieuXN temp = new InPhieuXN();
                    temp.SoDangKy = i.SoDangKy;
                    temp.MaBN = i.MaBN;
                    temp.MaBS = i.MaBS;
                    temp.HoTen = i.HoTen;
                    temp.YeuCauXetNghiem = i.YeuCauXetNghiem;
                    temp.ChuanDoan = i.ChuanDoan;
                    temp.YeuCau = i.YeuCau;
                    listPXN.Add(temp);
                }
                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportInPhieuXN.rdlc";
                var reportDataSource = new ReportDataSource("InPhieuXN", listPXN);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.LocalReport.DisplayName = "Phiếu Xét Nghiệm";
                
            }
            else
            {
                String idXN = (txtmaBN.Text);

                 xetnghiem IPxn = context.xetnghiems.FirstOrDefault(p => p.MaBN == idXN);
                 List<xetnghiem> listXN = context.xetnghiems.Where(p => p.MaBN == idXN).ToList();

                if (IPxn == null || listXN.Count() == 0)
                 {
                     MessageBox.Show("Không Tìm Thầy Phiếu Xét Nghiệm");
                    return;
                 }
                List<xetnghiem> listxn = context.xetnghiems.ToList();
                List<InPhieuXN> listPXN = new List<InPhieuXN>();
                foreach (xetnghiem i in listxn)
                {
                    if (i.MaBN == IPxn.MaBN)
                    {
                        InPhieuXN temp = new InPhieuXN();
                        temp.SoDangKy = i.SoDangKy;
                        temp.MaBN = i.MaBN;
                        temp.MaBS = i.MaBS;
                        temp.HoTen = i.HoTen;
                        temp.YeuCauXetNghiem = i.YeuCauXetNghiem;
                        temp.ChuanDoan = i.ChuanDoan;
                        temp.YeuCau = i.YeuCau;
                        listPXN.Add(temp);
                    }

                }
                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportInPhieuXN.rdlc";
                var reportDataSource = new ReportDataSource("InPhieuXN", listPXN);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //this.reportViewer1.LocalReport.DisplayName = "Phiếu Xét Nghiệm";
            }
            this.reportViewer1.RefreshReport();
        }

        private void rdotatca_CheckedChanged(object sender, EventArgs e)
        {
            txtmaBN.Enabled = false;
        }

        private void rdokhoa_CheckedChanged(object sender, EventArgs e)
        {
            txtmaBN.Enabled = true;
        }
    }
}
