namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBS { get; set; }

        [Required]
        [StringLength(20)]
        public string MaBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        public int ThanhTien { get; set; }

        public int MaDichVu { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual DSbenhnhan DSbenhnhan { get; set; }
    }
}
