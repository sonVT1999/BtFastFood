using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminSanPhamController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminSanPham
        public ActionResult Index()
        {
            var model = db.SANPHAMs.Where(x => x.MaSanPham != 0);
            return View(model);
        }
        public ActionResult Add(ANH model)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(SANPHAM model)
        {
            var SanPham = db.SANPHAMs.Find(model.MaSanPham);
            db.SANPHAMs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.SANPHAMs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(SANPHAM model)
        {
            var obj = db.SANPHAMs.Find(model.MaSanPham);
            obj.MaSanPham = model.MaSanPham;
            obj.Ten = model.Ten;
            obj.DonGia = model.DonGia;
            obj.MoTa = model.MoTa;
            obj.MaDM = model.MaDM;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }

        public ActionResult Delete(int id)
        {
            var model = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<SANPHAM> model = new List<SANPHAM>();
            if (Ten != "")
            {
                model = db.SANPHAMs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.SANPHAMs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}