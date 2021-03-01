namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            ANHs = new HashSet<ANH>();
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            SANPHAM_CUAHANG = new HashSet<SANPHAM_CUAHANG>();
        }

        [Key]
        public int MaSanPham { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public decimal DonGia { get; set; }

        [Required]
        [StringLength(200)]
        public string MoTa { get; set; }

        public int? MaDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANH> ANHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        public virtual DANHMUCSANPHAM DANHMUCSANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM_CUAHANG> SANPHAM_CUAHANG { get; set; }
    }
}
