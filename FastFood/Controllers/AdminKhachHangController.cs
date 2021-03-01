using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminKhachHangController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminKhachHang
        public ActionResult Index()
        {
            var model = db.KHACHHANGs.Where(x => x.MaKhachHang != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(KHACHHANG model)
        {
            var KhachHang  = db.KHACHHANGs.Find(model.MaKhachHang);
            db.KHACHHANGs.Add(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.KHACHHANGs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(KHACHHANG model)
        {
            var obj = db.KHACHHANGs.Find(model.MaKhachHang);
            obj.MaKhachHang = model.MaKhachHang;
            obj.Ten = model.Ten;
            obj.TaiKhoan = model.TaiKhoan;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.KHACHHANGs.Find(id);
            db.KHACHHANGs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<KHACHHANG> model = new List<KHACHHANG>();
            if (Ten != "")
            {
                model = db.KHACHHANGs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.KHACHHANGs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}