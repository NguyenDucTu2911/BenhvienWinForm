namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LePhi")]
    public partial class LePhi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLePhi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDong { get; set; }

        [Column(TypeName = "money")]
        public decimal SoTien { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        public virtual DSbenhnhan DSbenhnhan { get; set; }
    }
}
