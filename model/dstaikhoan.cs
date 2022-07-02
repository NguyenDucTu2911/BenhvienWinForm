namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dstaikhoan")]
    public partial class dstaikhoan
    {
        [Key]
        [StringLength(50)]
        public string Taikhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string Matkhau { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhom { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string ChucVu { get; set; }

        public virtual nhomnguoidung nhomnguoidung { get; set; }
    }
}
