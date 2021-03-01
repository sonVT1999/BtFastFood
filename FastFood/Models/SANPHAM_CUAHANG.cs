namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SANPHAM_CUAHANG
    {
        [Key]
        public int MaSPCH { get; set; }

        public int SoLuong { get; set; }

        public int? MaSanPham { get; set; }

        public int? MaCuaHang { get; set; }

        public virtual CUAHANG CUAHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
