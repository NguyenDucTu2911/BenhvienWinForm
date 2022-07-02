namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VatTu")]
    public partial class VatTu
    {
        [Key]
        [StringLength(10)]
        public string MaVT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenVT { get; set; }

        [Required]
        [StringLength(50)]
        public string Hang { get; set; }

        public int SL { get; set; }
    }
}
