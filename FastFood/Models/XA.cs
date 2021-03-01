namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XA")]
    public partial class XA
    {
        [Key]
        public int MaXa { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public int? MaHuyen { get; set; }

        public virtual HUYEN HUYEN { get; set; }
    }
}
