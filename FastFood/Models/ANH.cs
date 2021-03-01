namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANH")]
    public partial class ANH
    {
        [Key]
        public int MaAnh { get; set; }

        [Required]
        [StringLength(200)]
        public string LinkAnh { get; set; }

        public int? MaSanPham { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
