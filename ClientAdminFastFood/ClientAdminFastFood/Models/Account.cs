using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAdminFastFood.Models
{
    class Account
    {
        public int Ma { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        [Browsable(false)]
        public int? MaNguoiDung { get; set; }
        [ForeignKey(nameof(MaNguoiDung))]
        [Browsable(false)]
        public virtual NguoiDung NguoiDung { get; set; }
        public string TenNguoiDung { get => NguoiDung.Ten; }


        [Browsable(false)]
        public int? MaKhachHang { get; set; }
        [ForeignKey(nameof(MaKhachHang))]
        [Browsable(false)]
        public virtual KhachHang KhachHang { get; set; }
        public string tenkhachhang { get => KhachHang.Ten; }

        [Browsable(false)]
        public int? MaNhomNguoiDung { get; set; }
        [ForeignKey(nameof(MaNhomNguoiDung))]
        [Browsable(false)]
        public virtual NhomNguoiDung NhomNguoiDung { get; set; }
        public string TenNhomNguoiDung { get => NhomNguoiDung.Ten; }
    }
}
