namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_DonThuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(50)]
        public string Ngay { get; set; }

        [Required]
        [StringLength(50)]
        public string Lieu { get; set; }

        [Required]
        [StringLength(50)]
        public string ThoiDiemSuDung { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
