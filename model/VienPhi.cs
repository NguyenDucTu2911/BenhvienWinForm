namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VienPhi")]
    public partial class VienPhi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaVienPhi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDong { get; set; }

        [Column(TypeName = "money")]
        public decimal SoTienVP { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        public virtual DSbenhnhan DSbenhnhan { get; set; }
    }
}
