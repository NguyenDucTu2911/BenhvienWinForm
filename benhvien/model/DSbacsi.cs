namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSbacsi")]
    public partial class DSbacsi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSbacsi()
        {
            dakhoas = new HashSet<dakhoa>();
        }

        [Key]
        [StringLength(20)]
        public string MaBS { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTenBS { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(500)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        public int KhoaID { get; set; }

        [Required]
        [StringLength(100)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dakhoa> dakhoas { get; set; }

        public virtual Khoa Khoa { get; set; }
    }
}
