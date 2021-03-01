using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientAdminFastFood.Models
{
    class DonHang
    {
        public int Ma { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public double? ThanhTien { get; set; }
        public int? TrangThai { get; set; }
        [Browsable(false)]
        public string tenKH { get; set; }

        [Browsable(false)]
        public int? MaNguoiDung { get; set; }
        [ForeignKey(nameof(MaNguoiDung))]
        [Browsable(false)]
        public virtual NguoiDung NguoiDung { get; set; }
        public string tenNhanVien { get => NguoiDung.Ten; }

        [Browsable(false)]
        public int? MaKhachHang { get; set; }
        [ForeignKey(nameof(MaKhachHang))]
        [Browsable(false)]
        public virtual KhachHang KhachHang { get; set; }
        public string tenkhachhang { get => KhachHang.Ten; }

    }
}
