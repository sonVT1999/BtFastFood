namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHSUTHAYDOI")]
    public partial class LICHSUTHAYDOI
    {
        [Key]
        public int MaLichSuThayDoi { get; set; }

        [StringLength(100)]
        public string DiaDiem { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ngayThayDoi { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public int MaKhachHang { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
