namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DsXetNghiem")]
    public partial class DsXetNghiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DsXetNghiem()
        {
            dboctxetnghiems = new HashSet<dboctxetnghiem>();
        }

        [Key]
        [StringLength(10)]
        public string MaXN { get; set; }

        [Required]
        [StringLength(150)]
        public string TenXn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dboctxetnghiem> dboctxetnghiems { get; set; }
    }
}
