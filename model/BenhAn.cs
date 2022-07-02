namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhAn")]
    public partial class BenhAn
    {
        [Key]
        [StringLength(20)]
        public string MaBenhan { get; set; }

        [StringLength(20)]
        public string MaBN { get; set; }

        [StringLength(10)]
        public string MaPK { get; set; }

        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [StringLength(10)]
        public string MaXN { get; set; }

        public int? MaDK { get; set; }

        public int? MaBenh { get; set; }

        public virtual Benh Benh { get; set; }

        public virtual dakhoa dakhoa { get; set; }

        public virtual DSbenhnhan DSbenhnhan { get; set; }

        public virtual ToaThuoc ToaThuoc { get; set; }
    }
}
