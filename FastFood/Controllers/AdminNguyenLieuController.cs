using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminNguyenLieuController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminNguyenLieu
        public ActionResult Index()
        {
            var model = db.NGUYENLIEUx.Where(x => x.TenNguyenLieu != null);
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(NGUYENLIEU model)
        {
            var NguyenLieu = db.NGUYENLIEUx.Find(model.MaNL);
            db.NGUYENLIEUx.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Edit(int? id)
        {
            var model = db.NGUYENLIEUx.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(NGUYENLIEU model)
        {
            var obj = db.NGUYENLIEUx.Find(model.MaNL);
            obj.MaNL = model.MaNL;
            obj.TenNguyenLieu = model.TenNguyenLieu;
            obj.DonViTinh = model.DonViTinh;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.NGUYENLIEUx.Find(id);
            db.NGUYENLIEUx.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<NGUYENLIEU> model = new List<NGUYENLIEU>();
            if (Ten != "")
            {
                model = db.NGUYENLIEUx.Where(x => x.TenNguyenLieu == Ten).ToList();
            }
            else
            {
                model = db.NGUYENLIEUx.Where(x => x.TenNguyenLieu != null).ToList();
            }
            return View("Index", model);
        }
    }
}