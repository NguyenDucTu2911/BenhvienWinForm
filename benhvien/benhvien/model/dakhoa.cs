namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dakhoa")]
    public partial class dakhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dakhoa()
        {
            BenhAns = new HashSet<BenhAn>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDK { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        [StringLength(50)]
        public string HoTenBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBS { get; set; }

        [StringLength(50)]
        public string HoTenBS { get; set; }

        [Required]
        [StringLength(500)]
        public string ThongTinBenh { get; set; }

        [StringLength(500)]
        public string KhamTongThe { get; set; }

        [StringLength(500)]
        public string KhamTungBoPhan { get; set; }

        [StringLength(500)]
        public string TomTatLamSan { get; set; }

        [StringLength(500)]
        public string ChuanDoanNhapVien { get; set; }

        [StringLength(500)]
        public string Thuoc { get; set; }

        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhAn> BenhAns { get; set; }
    }
}
