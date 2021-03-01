using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAdminFastFood.Models
{
    class SanPham
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public int DonGia { get; set; }
        public string MoTa { get; set; }

        public int MaDanhMucSanPham { get; set; }
        [ForeignKey(nameof(MaDanhMucSanPham))]
        [Browsable(false)]
        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
        public string TenDanhMucSanPham { get => DanhMucSanPham.Ten;}
    }
}
