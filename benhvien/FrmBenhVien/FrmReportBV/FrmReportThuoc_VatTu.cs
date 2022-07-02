using benhvien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benhvien
{
    public partial class FrmReportThuoc_VatTu : Form
    {
        benhvien1 context = new benhvien1();
        public FrmReportThuoc_VatTu()
        {
            InitializeComponent();
        }

        private void FrmReportThuoc_VatTu_Load(object sender, EventArgs e)
        {
            List<VatTu> listvattu = context.VatTus.ToList();
            List<Thuoc> listthuoc = context.Thuocs.ToList();
            reportViewer1.Visible = false;
            rdointhuoc.Checked = true;
            rdovattu.Checked = false;
            cbbvattu.Enabled = false;

        }

        private void rdovattu_CheckedChanged(object sender, EventArgs e)
        {
            cbbthuoc.Enabled = false;
            cbbvattu.Enabled = true;
            List<VatTu> listvattu = context.VatTus.OrderBy(p => p.MaVT).ToList();
            this.cbbvattu.DataSource = listvattu;
            this.cbbvattu.DisplayMember = "TenVT";
            this.cbbvattu.ValueMember = "MaVT";
            cbbvattu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbvattu.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void rdointhuoc_CheckedChanged(object sender, EventArgs e)
        {
            cbbvattu.Enabled = false;
            cbbthuoc.Enabled = true;
            List<Thuoc> listTHUOC = context.Thuocs.OrderBy(p => p.MaThuoc).ToList();
            this.cbbthuoc.DataSource = listTHUOC;
            this.cbbthuoc.DisplayMember = "TenThuoc";
            this.cbbthuoc.ValueMember = "MaThuoc";
            cbbthuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbthuoc.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnINBS_Click(object sender, EventArgs e)
        {

        }
    }
}
