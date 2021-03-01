using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminPhieuXuatController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminPhieuXuat
        public ActionResult Index()
        {
            var model = db.PHIEUXUATs.Where(x => x.MaPhieuXuat != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(PHIEUXUAT model)
        {
            var PhieuXuat = db.PHIEUXUATs.Find(model.MaPhieuXuat);
            db.PHIEUXUATs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.PHIEUXUATs.Find(id);
            db.PHIEUXUATs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(int mand)
        {
            List<PHIEUXUAT> model = new List<PHIEUXUAT>();
            if (mand != 0)
            {
                model = db.PHIEUXUATs.Where(x => x.MaNguoiDung == mand).ToList();
            }
            return View("Index", model);
        }
    }
}