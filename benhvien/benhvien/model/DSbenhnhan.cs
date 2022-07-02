namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSbenhnhan")]
    public partial class DSbenhnhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSbenhnhan()
        {
            BenhAns = new HashSet<BenhAn>();
            HoaDons = new HashSet<HoaDon>();
            LePhis = new HashSet<LePhi>();
            VienPhis = new HashSet<VienPhi>();
        }

        [Key]
        [StringLength(20)]
        public string MaBN { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string DanToc { get; set; }

        [Required]
        [StringLength(20)]
        public string QuocTich { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(50)]
        public string NgheNghiep { get; set; }

        [Required]
        [StringLength(20)]
        public string DoiTuong { get; set; }

        [Required]
        [StringLength(20)]
        public string SoBHYT { get; set; }

        [Column(TypeName = "date")]
        public DateTime GiaTriBHYT { get; set; }

        [Required]
        [StringLength(50)]
        public string PhongKham { get; set; }

        public string GhiChu { get; set; }

        [StringLength(10)]
        public string MaXN { get; set; }

        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhAn> BenhAns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LePhi> LePhis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VienPhi> VienPhis { get; set; }
    }
}
