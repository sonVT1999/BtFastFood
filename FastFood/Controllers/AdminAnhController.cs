using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminAnhController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminAnh
        public ActionResult Index()
        {
            var model = db.ANHs.Where(x => x.MaAnh != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Edit(int? MaAnh)
        {
            var model = db.ANHs.Find(MaAnh);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ANH model)
        {
            var obj = db.ANHs.Find(model.MaAnh);
            obj.MaAnh = model.MaAnh;
            obj.MaSanPham = model.MaSanPham;
            obj.LinkAnh = model.LinkAnh;
            db.SaveChanges();
            return RedirectToAction("AdminAnh", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.ANHs.Find(id);
            db.ANHs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}