using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace benhvien.model
{
    public partial class benhvien1 : DbContext
    {
        public benhvien1()
            : base("name=benhvien")
        {
        }

        public virtual DbSet<Benh> Benhs { get; set; }
        public virtual DbSet<BenhAn> BenhAns { get; set; }
        public virtual DbSet<CT_DonThuoc> CT_DonThuoc { get; set; }
        public virtual DbSet<dakhoa> dakhoas { get; set; }
        public virtual DbSet<dboctxetnghiem> dboctxetnghiems { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DSbacsi> DSbacsis { get; set; }
        public virtual DbSet<DSbenhnhan> DSbenhnhans { get; set; }
        public virtual DbSet<dstaikhoan> dstaikhoans { get; set; }
        public virtual DbSet<DsXetNghiem> DsXetNghiems { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LePhi> LePhis { get; set; }
        public virtual DbSet<nhomnguoidung> nhomnguoidungs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<ToaThuoc> ToaThuocs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }
        public virtual DbSet<VienPhi> VienPhis { get; set; }
        public virtual DbSet<xetnghiem> xetnghiems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhAn>()
                .Property(e => e.MaPK)
                .IsFixedLength();

            modelBuilder.Entity<BenhAn>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<BenhAn>()
                .Property(e => e.MaXN)
                .IsFixedLength();

            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<CT_DonThuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<dakhoa>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<dboctxetnghiem>()
                .Property(e => e.MaXN)
                .IsFixedLength();

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DSbacsi>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<DSbacsi>()
                .HasMany(e => e.dakhoas)
                .WithRequired(e => e.DSbacsi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DSbenhnhan>()
                .Property(e => e.SoBHYT)
                .IsFixedLength();

            modelBuilder.Entity<DSbenhnhan>()
                .Property(e => e.MaXN)
                .IsFixedLength();

            modelBuilder.Entity<DSbenhnhan>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSbenhnhan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.DSbenhnhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DSbenhnhan>()
                .HasMany(e => e.LePhis)
                .WithRequired(e => e.DSbenhnhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DSbenhnhan>()
                .HasMany(e => e.VienPhis)
                .WithRequired(e => e.DSbenhnhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DSbenhnhan>()
                .HasMany(e => e.xetnghiems)
                .WithRequired(e => e.DSbenhnhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dstaikhoan>()
                .Property(e => e.MaNhom)
                .IsFixedLength();

            modelBuilder.Entity<DsXetNghiem>()
                .Property(e => e.MaXN)
                .IsFixedLength();

            modelBuilder.Entity<DsXetNghiem>()
                .HasMany(e => e.dboctxetnghiems)
                .WithRequired(e => e.DsXetNghiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.DSbacsis)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LePhi>()
                .Property(e => e.SoTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<nhomnguoidung>()
                .Property(e => e.MaNhom)
                .IsFixedLength();

            modelBuilder.Entity<nhomnguoidung>()
                .HasMany(e => e.dstaikhoans)
                .WithRequired(e => e.nhomnguoidung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.CT_DonThuoc)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ToaThuoc>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<ToaThuoc>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<VatTu>()
                .Property(e => e.MaVT)
                .IsFixedLength();

            modelBuilder.Entity<VienPhi>()
                .Property(e => e.SoTienVP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<xetnghiem>()
                .Property(e => e.Maxn)
                .IsFixedLength();

            modelBuilder.Entity<xetnghiem>()
                .HasMany(e => e.dboctxetnghiems)
                .WithRequired(e => e.xetnghiem)
                .WillCascadeOnDelete(false);
        }
    }
}
