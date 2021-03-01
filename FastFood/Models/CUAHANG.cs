namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUAHANG")]
    public partial class CUAHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUAHANG()
        {
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
            SANPHAM_CUAHANG = new HashSet<SANPHAM_CUAHANG>();
        }

        [Key]
        public int MaCuaHang { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public bool TrangThai { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        public int? MaXa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM_CUAHANG> SANPHAM_CUAHANG { get; set; }
    }
}
