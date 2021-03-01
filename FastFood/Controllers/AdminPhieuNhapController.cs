using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminPhieuNhapController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminPhieuNhap
        public ActionResult Index()
        {
            var model = db.PHIEUNHAPs.Where(x => x.MaPhieuNhap != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(PHIEUNHAP model)
        {
            var PhieuNhap = db.PHIEUNHAPs.Find(model.MaPhieuNhap);
            db.PHIEUNHAPs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.PHIEUNHAPs.Find(id);
            db.PHIEUNHAPs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(int mand)
        {
            List<PHIEUNHAP> model = new List<PHIEUNHAP>();
            if (mand != 0)
            {
                model = db.PHIEUNHAPs.Where(x => x.MaNguoiDung == mand).ToList();
            }
            else
            {
                model = db.PHIEUNHAPs.Where(x => x.MaNguoiDung != null).ToList();
            }
            return View("Index", model);
        }
    }
}