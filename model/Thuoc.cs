namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            CT_DonThuoc = new HashSet<CT_DonThuoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [StringLength(100)]
        public string TenThuoc { get; set; }

        [StringLength(200)]
        public string NhomThuoc { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        [StringLength(100)]
        public string HangSanXuat { get; set; }

        public int? SoLuong { get; set; }

        public int? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DonThuoc> CT_DonThuoc { get; set; }
    }
}
