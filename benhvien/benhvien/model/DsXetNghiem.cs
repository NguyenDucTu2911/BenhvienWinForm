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
        [Key]
        [StringLength(10)]
        public string Maxn { get; set; }

        [Required]
        [StringLength(150)]
        public string TenXn { get; set; }
    }
}
