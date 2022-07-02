namespace benhvien.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Benh")]
    public partial class Benh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBenh { get; set; }

        [Required]
        [StringLength(300)]
        public string TenBenh { get; set; }
    }
}
