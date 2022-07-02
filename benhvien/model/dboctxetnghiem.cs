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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDK { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXN { get; set; }

        public int SoDangKy { get; set; }

        public virtual DsXetNghiem DsXetNghiem { get; set; }

        public virtual xetnghiem xetnghiem { get; set; }
    }
}
