namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToaThuoc")]
    public partial class ToaThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToaThuoc()
        {
            BenhAns = new HashSet<BenhAn>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBS { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKeDonThuoc { get; set; }

        public TimeSpan GioTao { get; set; }

        [Required]
        [StringLength(200)]
        public string LoiDan { get; set; }

        [Required]
        [StringLength(150)]
        public string TenBN { get; set; }

        [Required]
        [StringLength(150)]
        public string TenBS { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhAn> BenhAns { get; set; }
    }
}
