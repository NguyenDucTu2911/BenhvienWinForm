namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dboctxetnghiem")]
    public partial class dboctxetnghiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dboctxetnghiem()
        {
            BenhAns = new HashSet<BenhAn>();
        }

        [Key]
        [StringLength(10)]
        public string MaXN { get; set; }

        public int MaDK { get; set; }

        public int SoDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhAn> BenhAns { get; set; }

        public virtual xetnghiem xetnghiem { get; set; }
    }
}
