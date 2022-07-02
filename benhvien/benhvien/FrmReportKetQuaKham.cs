using benhvien.model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace benhvien
{
    public partial class FrmReportKetQuaKham : Form
    {
        benhvien1 context = new benhvien1();
        public FrmReportKetQuaKham()
        {
            InitializeComponent();
        }


        public void LayMaDK(LocalReport MaDK)
        {
            reportViewer1.Text = MaDK.ToString();
        }
        public void LayHoTenBenhNhan(LocalReport TenBenhNhan)
        {
            reportViewer1.Text = TenBenhNhan.ToString();
        }
        public void LayNgaySinhBenhNhan(LocalReport NgaySinhBenhNhan)
        {
            reportViewer1.Text = NgaySinhBenhNhan.ToString();
        }
        public void LayGioiTinhhBenhNhan(LocalReport GioiTinhBenhNhan)
        {
            reportViewer1.Text = GioiTinhBenhNhan.ToString();
        }
        public void LayTenBacSi(LocalReport TenBacSi)
        {
            reportViewer1.Text = TenBacSi.ToString();
        }
        public void LayThongTinBenh(LocalReport ThongTinBenh)
        {
            reportViewer1.Text = ThongTinBenh.ToString();
        }
        public void LayKhamTongThe(LocalReport KhamTongThe)
        {
            reportViewer1.Text = KhamTongThe.ToString();
        }
        public void LayKhamTungBoPhan(LocalReport KhamTungBoPhan)
        {
            reportViewer1.Text = KhamTungBoPhan.ToString();
        }
        public void LayTomTatLamSan(LocalReport TomTatLamSan)
        {
            reportViewer1.Text = TomTatLamSan.ToString();
        }
        public void LayChuanDoanNhapVien(LocalReport ChuanDoanNhapVien)
        {
            reportViewer1.Text = ChuanDoanNhapVien.ToString();
        }

        private void FrmReportKetQuaKham_Load(object sender, EventArgs e)
        {
            


        }

        
    }
}
