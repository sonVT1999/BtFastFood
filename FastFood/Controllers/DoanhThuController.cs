using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class DoanhThuController : Controller
    {
        // GET: DoanhThu
        FastFooddb db = new FastFooddb();
        public ActionResult Index()
        {
            var model = db.DONHANGs.Where(x => x.MaDonHang != 0);
            return View(model);
        }

        [HttpPost]
        public ActionResult ThongKeDoanhThu(DateTime? ngay1, DateTime? ngay2)
        {

            List<DONHANG> model = new List<DONHANG>();
            if (ngay1.ToString() == "" && ngay2.ToString() == "")
            {
                model = db.DONHANGs.ToList();
            }
            else
            {
                model = db.DONHANGs.Where(x => x.NgayDat >= ngay1 && x.NgayDat <= ngay2).ToList();
            }
            return View("Index", model);
        }
    }
}