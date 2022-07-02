namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("xetnghiem")]
    public partial class xetnghiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public xetnghiem()
        {
            dboctxetnghiems = new HashSet<dboctxetnghiem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoDangKy { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBS { get; set; }

        [StringLength(150)]
        public string HoTenBS { get; set; }

        [Required]
        [StringLength(200)]
        public string YeuCauXetNghiem { get; set; }

        [Required]
        [StringLength(200)]
        public string ChuanDoan { get; set; }

        [StringLength(200)]
        public string YeuCau { get; set; }

        [StringLength(10)]
        public string Maxn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dboctxetnghiem> dboctxetnghiems { get; set; }
    }
}
