namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANNER")]
    public partial class BANNER
    {
        [Key]
        public int MaBanner { get; set; }

        [Required]
        [StringLength(200)]
        public string LinkAnh { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
