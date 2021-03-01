namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HUYEN")]
    public partial class HUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HUYEN()
        {
            XAs = new HashSet<XA>();
        }

        [Key]
        public int MaHuyen { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten { get; set; }

        public int? MaTinh { get; set; }

        public virtual TINH TINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XA> XAs { get; set; }
    }
}
